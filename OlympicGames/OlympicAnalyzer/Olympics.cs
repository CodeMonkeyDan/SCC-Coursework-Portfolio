using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OlympicDataLibrary;


namespace OlympicAnalyzer
{
    public partial class olympicsFrm : Form
    {
        //declare variable to hold reference of mainMenuFrm
        private mainMenuFrm _mainMenuFrm;

        //constructor that takes mainMenuFrm as a parameter
        public olympicsFrm(mainMenuFrm existingMainMenuFrm)
        {
            InitializeComponent();
            _mainMenuFrm = existingMainMenuFrm;
        }

        //automatically loads combo box items when form loads
        private void olympicsFrm_Load(object sender, EventArgs e)
        {
            populateYearSelectorComboBox(); //clear, sort, and populate year combo box

            // on load. add title flair
            ShadowLabel lblData = new ShadowLabel // create the text box dynamically
            {
                Text = "Olympics",
                Font = new Font("Arial", 34, FontStyle.Bold),
                ForeColor = Color.Black, // text color
                ShadowColor = Color.FromArgb(80, 0, 0, 0), // transparency,,,
                ShadowOffset = 5, // distance from text
                AutoSize = true,
                Location = new Point(171, 20) // where it is positioned
            };
            this.Controls.Add(lblData); // add to form
            lblData.BackColor = Color.Transparent; // make it transparent
        }
        //button to display olympic data based on year-season combo selected
        private void selectYearBtn_Click(object sender, EventArgs e)
        {
            if (yearSelectorCmbBx.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a Year to view data for.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //declare variable for what user selected
                string selectedYearSeason = yearSelectorCmbBx.Text;
                //declare variables to hold info needed later in method
                int selectedYear = 0;
                string selectedSeason = "";
                string selectedCity = "";

                //traverse olympicsList to find data and and set labels
                foreach (var record in DataLoader.olympicsList)
                {
                    if (selectedYearSeason == record.Year + " - " + record.Season)
                    {
                        selectedYear = record.Year;
                        selectedSeason = record.Season.ToString();
                        selectedCity = record.HostCity;
                        yearSeasonLbl.Text = record.Year + " " + record.Season + " Olympics";
                        hostLbl.Text = record.HostCity + ", " + record.HostCountry;
                    }
                }

                //clears and adds columns to list view
                initializeListView();

                //create dictionary to store individual country medal data
                Dictionary<string, (int gold, int silver, int bronze)> medalCounts = new Dictionary<string, (int, int, int)>();

                //declare dataFound flag for those year-seasons where no medal data is present
                bool dataFound = false;

                //traverse eventMedalsList to gather medal data for each country based on the year-season selected
                foreach (var record in DataLoader.eventMedalsList)
                {
                    //check each record if it matches the selected year-season
                    //normalize method is to fix differences in city format between two different lists
                    if (selectedYear == record.EventYear && normalizeCity(selectedCity) == normalizeCity(record.EventCity))
                    {
                        //check if the country is already in the dictionary and adds/initializes country if not
                        if (!medalCounts.ContainsKey(record.WinningCountry))
                        {
                            medalCounts[record.WinningCountry] = (0, 0, 0);
                        }

                        //update medal count based on MedalType
                        var counts = medalCounts[record.WinningCountry];
                        switch (record.MedalType)
                        {
                            case Place.Gold:
                                counts.gold++;
                                break;
                            case Place.Silver:
                                counts.silver++;
                                break;
                            case Place.Bronze:
                                counts.bronze++;
                                break;
                        }

                        //store the updated counts back in the dictionary
                        medalCounts[record.WinningCountry] = counts;

                        //updates flag if data was found
                        dataFound = true;
                    }
                }

                //message box pops up if no data was found
                if (!dataFound)
                {
                    MessageBox.Show("No medal data was available for the " + selectedYear + " " + selectedSeason + " Olympics.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                //sort by total medals in descending order
                var sortedMedalCounts = medalCounts.Select(kvp => new
                {
                    Country = kvp.Key,
                    Gold = kvp.Value.gold,
                    Silver = kvp.Value.silver,
                    Bronze = kvp.Value.bronze,
                    Total = kvp.Value.gold + kvp.Value.silver + kvp.Value.bronze
                }).OrderByDescending(m => m.Total).ToList();

                //adds each medal count record to the list view
                foreach (var item in sortedMedalCounts)
                {
                    ListViewItem listViewItem = new ListViewItem(item.Country);
                    listViewItem.SubItems.Add(item.Gold.ToString());
                    listViewItem.SubItems.Add(item.Silver.ToString());
                    listViewItem.SubItems.Add(item.Bronze.ToString());
                    listViewItem.SubItems.Add(item.Total.ToString());

                    olympicDataLstVw.Items.Add(listViewItem);
                }
            }
        }


        //button to clear and reset the form
        private void resetBtn_Click(object sender, EventArgs e)
        {
            yearSeasonLbl.Text = string.Empty;
            hostLbl.Text = string.Empty;
            olympicDataLstVw.Columns.Clear();
            olympicDataLstVw.Items.Clear();
            yearSelectorCmbBx.SelectedItem = null;
        }


        //button to return to main menu
        private void mainMenuBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            _mainMenuFrm.Show();
        }


        //button to end program
        private void exitBtn_Click(object sender, EventArgs e)
        {
            EndProgram.Exit();
        }


        //method to clear, sort, and populate the year selector combo box
        private void populateYearSelectorComboBox()
        {
            //clear combo box items
            yearSelectorCmbBx.Items.Clear();

            //sort and populate combo box items, makes sure only distinct year-season combinations area added
            foreach (var record in DataLoader.olympicsList.OrderBy(r => r.Year)
                .ThenBy(r => r.Season)
                .Select(r => new { r.Year, r.Season } )
                .Distinct())
            {
                yearSelectorCmbBx.Items.Add(record.Year + " - " + record.Season);
            }
        }


        //method to initialize list view
        public void initializeListView()
        {
            //clear list view
            olympicDataLstVw.Columns.Clear();
            olympicDataLstVw.Items.Clear();

            //add constant columns
            olympicDataLstVw.Columns.Add("Country", 150);
            olympicDataLstVw.Columns.Add("Gold", 100);
            olympicDataLstVw.Columns.Add("Slver", 100);
            olympicDataLstVw.Columns.Add("Bronze", 100);
            olympicDataLstVw.Columns.Add("Total", 100);
        }


        //helper method to normalize city names
        private string normalizeCity(string city)
        {
            return city.ToLower().Replace("-", " ").Trim();
        }
    }
}
