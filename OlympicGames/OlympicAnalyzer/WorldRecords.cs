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
    public partial class worldRecordsFrm : Form
    {
        //declare variable to hold reference of mainMenuFrm
        private mainMenuFrm _mainMenuFrm;

        //constructor that takes mainMenuFrm as a parameter
        public worldRecordsFrm(mainMenuFrm existingMainMenuFrm)
        {
            InitializeComponent();
            _mainMenuFrm = existingMainMenuFrm;
        }


        //automatically loads combo box items & data grid view when form loads
        private void worldRecordsFrm_Load(object sender, EventArgs e)
        {
            populateEventSelectorComboBox(); //clear, sort, and populate event combo box

            populateRecordListView(); //clear and populate record list view view

            // dynamic shadow of title text
            ShadowLabel lblTitle = new ShadowLabel // create the text box dynamically bc it CAN'T READ
            {
                Text = "World Records",
                Font = new Font("Arial", 24, FontStyle.Bold),
                ForeColor = Color.Black, // text color
                ShadowColor = Color.FromArgb(80, 0, 0, 0), // transparency,,,
                ShadowOffset = 5, // distance from text
                AutoSize = true,
                Location = new Point(349, 30) // where it is positioned
            };
            this.Controls.Add(lblTitle); // add to form
            lblTitle.BackColor = Color.Transparent; // make it transparent
        }


        //button to sort world records in list view
        private void sortBtn_Click(object sender, EventArgs e)
        {
            if (sortRecordCmbBx.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a Field to sort by.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //declare variable for what the user selected
                string sortBy = sortRecordCmbBx.Text;

                //declares a variable to hold sorted records
                IEnumerable<Record> sortedRecords = null;

                //switch case to sort data by what the user selected
                switch (sortBy)
                {
                    case "Event":
                        sortedRecords = DataLoader.recordList.OrderBy(r => r.EventName);
                        break;
                    case "Category":
                        sortedRecords = DataLoader.recordList.OrderBy(r => r.EventCategory);
                        break;
                    case "Record":
                        sortedRecords = DataLoader.recordList.OrderBy(r => r.RecordValue);
                        break;
                    case "Athlete":
                        sortedRecords = DataLoader.recordList.OrderBy(r => r.RecordHolderAthlete);
                        break;
                    case "Country":
                        sortedRecords = DataLoader.recordList.OrderBy(r => r.RecordHolderCountry);
                        break;
                    case "Date":
                        sortedRecords = DataLoader.recordList.OrderBy(r => r.RecordDate);
                        break;
                }

                //clears and adds columns to the list view
                initializeListView();

                //populate list view
                foreach (var record in sortedRecords)
                {
                    //only returns the top record for each event
                    if (record.RecordRank == "1")
                    {
                        //adds each record to the list view
                        ListViewItem item = CreateListViewItemFromRecord(record);
                        worldRecordLstVw.Items.Add(item);
                    }
                }
            }
        }


        //method to display top 3 records for a selected event
        private void selectEventBtn_Click(object sender, EventArgs e)
        {
            //verifies the user selected an event
            if (eventSelectorCmbBx.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an Event to view data for.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //declare variable for what the user selected
                string selectedEvent = eventSelectorCmbBx.Text;

                //clears and adds columns to the list view
                initializeListView();

                //populate list view
                foreach (var record in DataLoader.recordList)
                {
                    //verifies the event
                    if (selectedEvent == record.EventName + ": " + record.EventCategory)
                    {
                        //adds each record to the list view
                        ListViewItem item = CreateListViewItemFromRecord(record);
                        worldRecordLstVw.Items.Add(item);
                    }
                }
            }
        }


        //button to clear and reset the form
        private void resetBtn_Click(object sender, EventArgs e)
        {
            eventSelectorCmbBx.SelectedItem = null;
            sortRecordCmbBx.SelectedItem = null;
            populateRecordListView();
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


        //mothod to clear, sort, and populate the event selector combo box
        private void populateEventSelectorComboBox()
        {
            //clear combo box items
            eventSelectorCmbBx.Items.Clear();

            //sort and populate combo box items
            foreach (var record in DataLoader.recordList.OrderBy(r => r.EventName))
            {
                //eliminates duplciate records by only selecting the top record for each event
                if (record.RecordRank == "1")
                {
                    eventSelectorCmbBx.Items.Add(record.EventName + ": " + record.EventCategory);
                }
            }
        }


        //method to clear and populate the record list view
        private void populateRecordListView()
        {
            //clears and adds columns to the list view
            initializeListView();

            foreach (var record in DataLoader.recordList)
            {
                //only adds the top record for each event
                if (record.RecordRank == "1")
                {
                    ListViewItem item = CreateListViewItemFromRecord(record);
                    worldRecordLstVw.Items.Add(item);
                }
            }
        }


        //method to initialize list view
        public void initializeListView()
        {
            //clear list view
            worldRecordLstVw.Columns.Clear();
            worldRecordLstVw.Items.Clear();

            //add constant columns
            worldRecordLstVw.Columns.Add("Event", 250);
            worldRecordLstVw.Columns.Add("Category", 200);
            worldRecordLstVw.Columns.Add("Record", 100);
            worldRecordLstVw.Columns.Add("Athlete", 235);
            worldRecordLstVw.Columns.Add("Country", 100);
            worldRecordLstVw.Columns.Add("Date", 100);
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
