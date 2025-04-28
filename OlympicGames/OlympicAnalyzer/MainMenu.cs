using Group_Project_Gui;
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

namespace OlympicAnalyzer
{
    public partial class mainMenuFrm : Form
    {
        //loads data into lists from csv's as soon as user logs in and main menu is initialized
        public mainMenuFrm()
        {
            InitializeComponent();
            DataLoader.LoadOlympicsFromCSV("Olympic_Games_Summary.csv");
            DataLoader.LoadEventMedalsFromCSV("Olympic_Medals.csv");
            DataLoader.LoadRecordFromCSV("World_Records.csv");
            DataLoader.LoadCountryFromCSV("Olympic_Country_Profiles.csv");
        }


        //button to open olympics form
        private void olympicsBtn_Click(object sender, EventArgs e)
        {
            olympicsFrm newOlympicsFrm = new olympicsFrm(this);
            this.Hide();
            newOlympicsFrm.Show();
        }


        //button to open total medals form
        private void medalsBtn_Click(object sender, EventArgs e)
        {
            medalsFrm newMedalsFrm = new medalsFrm(this);
            this.Hide();
            newMedalsFrm.Show();
        }


        //button to open world records form
        private void worldRecordBtn_Click(object sender, EventArgs e)
        {
            worldRecordsFrm newWorldRecordsFrm = new worldRecordsFrm(this);
            this.Hide();
            newWorldRecordsFrm.Show();
        }


        //button to open compare form
        private void compareBtn_Click(object sender, EventArgs e)
        {
            compareFrm newCompareFrm = new compareFrm(this);
            this.Hide();
            newCompareFrm.Show();
        }


        //button to end program
        private void exitBtn_Click(object sender, EventArgs e)
        {
            EndProgram.Exit();
        }

        private void mainMenuFrm_Load(object sender, EventArgs e)
        {
            // on load. add main menu flair
            ShadowLabel lblMain = new ShadowLabel // create the text box dynamically
            {
                Text = "Main Menu",
                Font = new Font("Arial", 34, FontStyle.Bold),
                ForeColor = Color.Black, // text color
                ShadowColor = Color.FromArgb(80, 0, 0, 0), // transparency,,,
                ShadowOffset = 5, // distance from text
                AutoSize = true,
                Location = new Point(70, 50) // where it is positioned
            };
            this.Controls.Add(lblMain); // add to form
            lblMain.BackColor = Color.Transparent; // make it transparent

            // and round off the button panel
            pnlMain.SetRoundedRegion(20);
        }
    }
}
