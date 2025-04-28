//Daniel Schiefer
//CPT-185-A80H-2024FA
//Final Project: Fantasy Fighters: Mystic Dice Battle


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D_Schiefer_Final_Project_Fantasy_Fighters_Mystic_Dice_Battle
{
    public partial class highScoresFrm : Form
    {
        //declare variable to hold the reference of mainMenuFrm
        public mainMenuFrm _mainMenuFrm;

        //constructor that takes mainMenuFrm as a parameter
        public highScoresFrm(mainMenuFrm existingMainMenuFrm)
        {
            InitializeComponent();
            //store the reference mainMenuFrm
            _mainMenuFrm = existingMainMenuFrm;
        }


        //load high score data when form loads
        private void highScoresFrm_Load(object sender, EventArgs e)
        {
            //clear list view
            highScoresLstVw.Columns.Clear();
            highScoresLstVw.Items.Clear();
            try
            {
                //add columns to list view
                highScoresLstVw.Columns.Add("Player", 190);
                highScoresLstVw.Columns.Add("Score", 100);

                //locate file path for highscores.txt
                string filePath = Path.Combine(Directory.GetCurrentDirectory(), "highscores.txt");
                //create an object to upload high score data
                using (StreamReader loadHighScoreFileObject = new StreamReader(filePath))
                {
                    while (!loadHighScoreFileObject.EndOfStream)
                    {
                        //read line and split name and score
                        string line = loadHighScoreFileObject.ReadLine();
                        var parts = line.Split(',');

                        ListViewItem item = new ListViewItem(parts[0]);
                        item.SubItems.Add(parts[1]);
                        highScoresLstVw.Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("High Score file failed to load/save.\n\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //close high scores form and start new game
        private void newGameBtn_Click(object sender, EventArgs e)
        {
            userNameFrm newUserNameFrm = new userNameFrm(_mainMenuFrm);
            this.Close();
            newUserNameFrm.Show();
        }


        //close high scores form and recall open main menu form
        private void mainMenuBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            _mainMenuFrm.Show();
        }


        //close high scores form, pass the open main menu form, and open instructions form
        private void instructionsBtn_Click(object sender, EventArgs e)
        {
            instructionsFrm newInstructionsFrm = new instructionsFrm(_mainMenuFrm);
            this.Close();
            newInstructionsFrm.Show();
        }


        //call Exit Class to exit the game
        private void exitBtn_Click(object sender, EventArgs e)
        {
            Exit.ExitApplication();
        }
    }
}
