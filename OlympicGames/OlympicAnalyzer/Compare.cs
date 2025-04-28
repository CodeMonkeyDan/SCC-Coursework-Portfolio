using OlympicDataLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static OlympicAnalyzer.medalsFrm;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OlympicAnalyzer
{
    public partial class compareFrm : Form
    {
        //declare variable to hold reference of mainMenuFrm
        private mainMenuFrm _mainMenuFrm;

        //constructor that takes mainMenuFrm as a parameter
        public compareFrm(mainMenuFrm existingMainMenuFrm)
        {
            InitializeComponent();
            _mainMenuFrm = existingMainMenuFrm;
        }


        //populate country combo boxes when form loads
        private void compareFrm_Load(object sender, EventArgs e)
        {
            //clear form design
            clearForm();

            //clear combo box items
            selectCountry1CmbBx.Items.Clear();
            selectCountry2CmbBx.Items.Clear();

            foreach (var record in DataLoader.countryList.OrderBy(r => r.CountryName))
            {
                selectCountry1CmbBx.Items.Add(record.CountryName);
                selectCountry2CmbBx.Items.Add(record.CountryName);
            }

            // dynamic shadow of title text
            ShadowLabel lblCompare = new ShadowLabel // create the text box dynamically bc it CAN'T READ
            {
                Text = "Compare Countries",
                Font = new Font("Arial", 24, FontStyle.Bold),
                ForeColor = Color.Black, // text color
                ShadowColor = Color.FromArgb(80, 0, 0, 0), // transparency,,,
                ShadowOffset = 5, // distance from text
                AutoSize = true,
                Location = new Point(349, 30) // where it is positioned
            };
            this.Controls.Add(lblCompare); // add to form
            lblCompare.BackColor = Color.Transparent; // make it transparent
        }

        //button to compare two countries
        private void compareBtn_Click(object sender, EventArgs e)
        {
            //verifies that the user selected a country in each combo box
            if (selectCountry1CmbBx.SelectedIndex == -1 ||  selectCountry2CmbBx.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a Country from each list to compare data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //declare variable to store user selected countries
                string country1 = selectCountry1CmbBx.Text;
                string country2 = selectCountry2CmbBx.Text;

                //display user selected countries in header
                country1Lbl.Text = country1;
                country2Lbl.Text = country2;

                //dictionary to store total medals for all countries
                Dictionary<string, (int gold, int silver, int bronze)> totalMedals = new Dictionary<string, (int gold, int silver, int bronze)>();

                //declare variables to hold the country codes for looking up data
                string countryCode1 = null;
                string countryCode2 = null;

                //loop through countryList to find the coresponding country codes
                foreach (var country in DataLoader.countryList)
                {
                    if (country.CountryName == country1)
                    {
                        countryCode1 = country.CountryAbbreviation;
                    }
                    if (country.CountryName == country2)
                    {
                        countryCode2 = country.CountryAbbreviation;
                    }
                }

                //loop through all olympic records to count total medals for each country
                foreach (var record in DataLoader.eventMedalsList)
                {
                    //check if the country is already in the dictionary and add/initialize country if not
                    if (!totalMedals.ContainsKey(record.CountryCode))
                    {
                        totalMedals[record.CountryCode] = (0, 0, 0);
                    }

                    //update medal count
                    var counts = totalMedals[record.CountryCode];
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
                    totalMedals[record.CountryCode] = counts;
                }
                // Get medal counts for the selected countries
                var country1Medals = totalMedals.ContainsKey(countryCode1) ? totalMedals[countryCode1] : (gold: 0, silver: 0, bronze: 0);
                var country2Medals = totalMedals.ContainsKey(countryCode2) ? totalMedals[countryCode2] : (gold: 0, silver: 0, bronze: 0);

                // Display results in labels
                c1GoldLbl.Text = "Gold: " + country1Medals.gold.ToString();
                c1SilverLbl.Text = "Silver: " + country1Medals.silver.ToString();
                c1BronzeLbl.Text = "Bronze: " + country1Medals.bronze.ToString();
                c1TotalLbl.Text = "Total: " + (country1Medals.gold + country1Medals.silver + country1Medals.bronze).ToString();

                c2GoldLbl.Text = "Gold: " + country2Medals.gold.ToString();
                c2SilverLbl.Text = "Silver: " + country2Medals.silver.ToString();
                c2BronzeLbl.Text = "Bronze: " + country2Medals.bronze.ToString();
                c2TotalLbl.Text = "Total: " + (country2Medals.gold + country2Medals.silver + country2Medals.bronze).ToString();


                //loading data into list view
                initializeListView();

                //loading header for country 1
                ListViewItem header1 = new ListViewItem(country1);
                header1.ForeColor = Color.White;
                header1.BackColor = Color.DarkGray;
                header1.Font = new Font(compareCountriesLstVw.Font, FontStyle.Bold);
                compareCountriesLstVw.Items.Add(header1);

                //load data for country 1
                int country1RecordCounter = 0;
                foreach (var record in DataLoader.recordList)
                {
                    if (countryCode1 == record.RecordHolderCountry)
                    {
                        ListViewItem item = CreateListViewItemFromRecord(record);
                        compareCountriesLstVw.Items.Add(item);
                        country1RecordCounter++;
                    }
                }
                c1RecordsLbl.Text = "Records: " + country1RecordCounter.ToString();

                //loading header for country 2
                ListViewItem header2 = new ListViewItem(country2);
                header2.ForeColor = Color.White;
                header2.BackColor = Color.DarkGray;
                header2.Font = new Font(compareCountriesLstVw.Font, FontStyle.Bold);
                compareCountriesLstVw.Items.Add(header2);

                //load data for country 2
                int country2RecordCounter = 0;
                foreach (var record in DataLoader.recordList)
                {
                    if (countryCode2 == record.RecordHolderCountry)
                    {
                        ListViewItem item = CreateListViewItemFromRecord(record);
                        compareCountriesLstVw.Items.Add(item);
                        country2RecordCounter++;
                    }
                }
                c2RecordsLbl.Text = "Records: " + country2RecordCounter.ToString();
            }
        }


        //button to reset form
        private void resetBtn_Click(object sender, EventArgs e)
        {
            clearForm();
        }


        //method to clear form
        private void clearForm()
        {
            selectCountry1CmbBx.SelectedItem = null;
            selectCountry2CmbBx.SelectedItem = null;
            compareCountriesLstVw.Columns.Clear();
            compareCountriesLstVw.Items.Clear();
            country1Lbl.Text = null;
            c1GoldLbl.Text = null;
            c1SilverLbl.Text = null;
            c1BronzeLbl.Text = null;
            c1TotalLbl.Text = null;
            c1RecordsLbl.Text = null;
            country2Lbl.Text = null;
            c2GoldLbl.Text = null;
            c2SilverLbl.Text = null;
            c2BronzeLbl.Text = null;
            c2TotalLbl.Text = null;
            c2RecordsLbl.Text = null;
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
            //clear list view
            compareCountriesLstVw.Columns.Clear();
            compareCountriesLstVw.Items.Clear();

            //add constant columns
            compareCountriesLstVw.Columns.Add("Event", 250);
            compareCountriesLstVw.Columns.Add("Category", 200);
            compareCountriesLstVw.Columns.Add("Record", 100);
            compareCountriesLstVw.Columns.Add("Athlete", 235);
            compareCountriesLstVw.Columns.Add("Country", 100);
            compareCountriesLstVw.Columns.Add("Date", 100);
        }


        //method to create a list view item
        private ListViewItem CreateListViewItemFromRecord(Record record)
        {
            ListViewItem item = new ListViewItem(record.EventName);
            item.SubItems.Add(record.EventCategory);
            item.SubItems.Add(record.RecordValue);
            item.SubItems.Add(record.RecordHolderAthlete);
            item.SubItems.Add(record.RecordHolderCountry);
            item.SubItems.Add(record.RecordDate.ToString("MM-dd-yyyy"));

            return item;
        }
    }
}
