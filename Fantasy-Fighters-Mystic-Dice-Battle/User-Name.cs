//Daniel Schiefer
//CPT-185-A80H-2024FA
//Final Project: Fantasy Fighters: Mystic Dice Battle


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D_Schiefer_Final_Project_Fantasy_Fighters_Mystic_Dice_Battle
{
    public partial class userNameFrm : Form
    {
        //declare variable to hold the reference of mainMenuFrm
        private mainMenuFrm _mainMenuFrm;

        //constructor that takes mainMenuFrm as a parameter
        public userNameFrm(mainMenuFrm existingMainMenuFrm)
        {
            InitializeComponent();
            //store the reference mainMenuFrm
            _mainMenuFrm = existingMainMenuFrm;
        }


        //resets score to 0 when the form loads
        private void userNameFrm_Load(object sender, EventArgs e)
        {
            //GameData.userScore = 0;
        }


        //verifies if the user enetered a name before proceeding
        private void okBtn_Click(object sender, EventArgs e)
        {
            if (userNameTxtBx.Text == "")
            {
                MessageBox.Show("Please enter your name before proceeding.", "Error");
                userNameTxtBx.Focus();
                return;
            }
            else
            {
                GameData.userName = userNameTxtBx.Text;
                GameData.stage = 1;
                storyFrm newStoryFrm = new storyFrm(_mainMenuFrm);
                this.Close();
                _mainMenuFrm.Hide();
                newStoryFrm.Show();
            }
        }


        //cancel and return to main menu
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            _mainMenuFrm.Show();
        }
    }
}
