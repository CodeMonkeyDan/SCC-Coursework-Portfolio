using OlympicDataLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static OlympicAnalyzer.medalsFrm;

namespace OlympicAnalyzer
{
    public partial class medalsFrm : Form
    {
        //declare variable to hold reference of mainMenuFrm
        private mainMenuFrm _mainMenuFrm;

        //dictionary to store medal counts
        private Dictionary<string, (int gold, int silver, int bronze)> medalCounts;

        //constructor that takes mainMenuFrm as a parameter
        public medalsFrm(mainMenuFrm existingMainMenuFrm)
        {
            InitializeComponent();
            _mainMenuFrm = existingMainMenuFrm;
            medalCounts = new Dictionary<string, (int, int, int)>();
        }


        //populate list view as soon as form loads
        private void medalsFrm_Load(object sender, EventArgs e)
        {
            //clear and add columns to list view
            initializeListView();

            //traverse eventMedalsList to gather medal data for each country
            foreach (var record in DataLoader.eventMedalsList)
            {
                //check if the country is already in the dictionary and add/initialize country if not
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
            }

            //sort by total medals in descending order and store sorted list
            var sortedMedalCounts = SortMedalData("total");

            //add each medal count record to the list view
            foreach (var item in sortedMedalCounts)
            {
                ListViewItem listViewItem = new ListViewItem(item.Country);
                listViewItem.SubItems.Add(item.Gold.ToString());
                listViewItem.SubItems.Add(item.Silver.ToString());
                listViewItem.SubItems.Add(item.Bronze.ToString());
                listViewItem.SubItems.Add(item.Total.ToString());

                olympicDataLstVw.Items.Add(listViewItem);
            }

            // dynamic shadow of title text
            ShadowLabel lblTitle = new ShadowLabel // create the text box dynamically bc it CAN'T READ
            {
                Text = "Total Medals",
                Font = new Font("Arial", 24, FontStyle.Bold),
                ForeColor = Color.Black, // text color
                ShadowColor = Color.FromArgb(80, 0, 0, 0), // transparency,,,
                ShadowOffset = 5, // distance from text
                AutoSize = true,
                Location = new Point(149, 30) // where it is positioned
            };
            this.Controls.Add(lblTitle); // add to form
            lblTitle.BackColor = Color.Transparent; // make it transparent
        }


        //button to sort list view
        private void sortBtn_Click(object sender, EventArgs e)
        {
            //verifies that the user selected a field
            if (sortMedalsCmbBx.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a Field to sort by.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //get the selected sort option from the combo box
                string selectedSortBy = sortMedalsCmbBx.SelectedItem.ToString();

                //sort the medal counts based on the selected option
                var sortedMedalCounts = SortMedalData(selectedSortBy);

                //clear and add items to list view
                initializeListView();

                //add the sorted medal count data to the ListView
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


        //method to initialize list view
        public void initializeListView()
        {
            olympicDataLstVw.Columns.Clear();
            olympicDataLstVw.Items.Clear();

            olympicDataLstVw.Columns.Add("Country", 150);
            olympicDataLstVw.Columns.Add("Gold", 100);
            olympicDataLstVw.Columns.Add("Silver", 100);
            olympicDataLstVw.Columns.Add("Bronze", 100);
            olympicDataLstVw.Columns.Add("Total", 100);
        }


        //method to sort data based on the selected field
        public List<MedalCount> SortMedalData(string sortBy)
        {
            //create a medal count list for sorting
            var medalCountsList = medalCounts.Select(kvp => new MedalCount
            {
                Country = kvp.Key,
                Gold = kvp.Value.gold,
                Silver = kvp.Value.silver,
                Bronze = kvp.Value.bronze,
                Total = kvp.Value.gold + kvp.Value.silver + kvp.Value.bronze
            }).ToList();

            //determine sorting based on user selected field
            switch (sortBy.ToLower())
            {
                case "country":
                    return medalCountsList.OrderBy(m => m.Country).ToList();
                case "gold":
                    return medalCountsList.OrderByDescending(m => m.Gold).ToList();
                case "silver":
                    return medalCountsList.OrderByDescending(m => m.Silver).ToList();
                case "bronze":
                    return medalCountsList.OrderByDescending(m => m.Bronze).ToList();
                case "total":
                    return medalCountsList.OrderByDescending(m => m.Total).ToList();
                default:
                    return medalCountsList;
            }
        }


        //MedalCount class to represent the country and its medal counts
        public class MedalCount
        {
            public string Country { get; set; }
            public int Gold { get; set; }
            public int Silver { get; set; }
            public int Bronze { get; set; }
            public int Total { get; set; }
        }
    }
}
