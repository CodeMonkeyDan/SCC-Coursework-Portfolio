//Daniel Schiefer
//CPT-185-A80H-2024FA
//Final Project: Fantasy Fighters: Mystic Dice Battle


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D_Schiefer_Final_Project_Fantasy_Fighters_Mystic_Dice_Battle
{
    public partial class mainMenuFrm : Form
    {
        public mainMenuFrm()
        {
            InitializeComponent();
        }


        //hide & pass main menu form and start new game
        private void newGameBtn_Click(object sender, EventArgs e)
        {
            userNameFrm newUserNameFrm = new userNameFrm(this);
            newUserNameFrm.Show();
        }


        //hide & pass main menu form and open instructions form
        private void instructionsBtn_Click(object sender, EventArgs e)
        {
            instructionsFrm newInstructionsFrm = new instructionsFrm(this);
            this.Hide();
            newInstructionsFrm.Show();
        }


        //hide & pass main menu form and open high scores form
        private void highScoresBtn_Click(object sender, EventArgs e)
        {
            highScoresFrm newHighScoresFrm = new highScoresFrm(this);
            this.Hide();
            newHighScoresFrm.Show();
        }


        //call Exit Class to exit the game
        private void exitBtn_Click(object sender, EventArgs e)
        {
            Exit.ExitApplication();
        }
    }
}
