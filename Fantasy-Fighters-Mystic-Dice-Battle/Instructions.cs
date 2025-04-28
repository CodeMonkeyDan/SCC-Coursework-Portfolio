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
    public partial class instructionsFrm : Form
    {
        //declare variable to hold the reference of mainMenuFrm
        private mainMenuFrm _mainMenuFrm;

        //constructor that takes mainMenuFrm as a parameter
        public instructionsFrm(mainMenuFrm existingMainMenuFrm)
        {
            InitializeComponent();
            //store the reference mainMenuFrm
            _mainMenuFrm = existingMainMenuFrm;
        }


        //write instruction text box when form loads
        private void instructionsFrm_Load(object sender, EventArgs e)
        {
            instrctionsTxtBx.Text = "Welcome to a dice-rolling strategy game that combines a little " +
                "luck, with a touch of tactics, and a combat dynamic where each unit has a strength " +
                "and weakness against others. Your mission is to battle through four areas, each " +
                "with two stages, defeating three enemies per stage. At the end of your journey, " +
                "you will face a single, formidable boss." +
                "\r\n\r\nGetting Started" +
                "\r\n\t1. Starting a New Game: Enter your name to begin." +
                "\r\n\t2. Select Your Combatants:" +
                "\r\n\t\t* Choose the here you wish to attack with by clicking their radio button." +
                "\r\n\t\t* Choose the enemy you wish to attack by clicking their radio button." +
                "\r\n\t3. Roll the Dice: Click Roll Dice to initiate the battle. Damage is determined" +
                "by the\r\n\t    roll of the dice, along with other factors." +
                "\r\n\r\nTurn-Based Combat" +
                "\r\n\t* After your turn, the computer will take its turn by selecting one of its " +
                "enemies\r\n\t   to attack one of your heroes." +
                "\r\n\r\nGame Mechanics" +
                "\r\n\t* Strengths and Weaknesses: Each enemy has a strength and a weakness against " +
                "\r\n\t   one of the heroes." +
                "\r\n\t\t* If the enemy is strong against the hero, the hero loses 1 from their" +
                "\r\n\t\t   dice total, and the enemy gains 1." +
                "\r\n\t\t* If the enemy is weak against the hero, the reverse applies." +
                "\r\n\t* Attack Limits:" +
                "\r\n\t\t* A unit's base attack (before buffs) cannot exceed its remaining hit" +
                "\r\n\t\t   points." +
                "\r\n\t\t* The minimum attack any unit will deal is 1." +
                "\r\n\t* Hero Artifacts:" +
                "\r\n\t\t* Each hero can acquire a special artifact that boosts their dice rolls by" +
                "\r\n\t\t   2." +
                "\r\n\t\t* These artifacts are not always easy to find, but they're worth the effort!" +
                "\r\n\t*Final Boss:" +
                "\r\n\t\t* The boss is doubly strong against all hereos, making it yoru toughest" +
                "\r\n\t\t   challenge." +
                "\r\n\t\t* There is a way to weaken the boss before the battle begins - if you can" +
                "\r\n\t\t   find it!" +
                "\r\n\r\nTips for Success:" +
                "\r\nExploration and keen observation can lead to surprising advantages. While not " +
                "every stage holds a secret, those you uncover may turn the tide in your favor. " +
                "Strategize wisely, roll boldly, and prepare to save the world!";
        }


        //close instructions form and start new game
        private void newGameBtn_Click(object sender, EventArgs e)
        {
            userNameFrm newUserNameFrm = new userNameFrm(_mainMenuFrm);
            this.Close();
            newUserNameFrm.Show();
        }


        //close instructions form and recall open main menu form
        private void mainMenuBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            _mainMenuFrm.Show();
        }


        //close instructions form, pass the open main menu form, and open high scores form
        private void highScoresBtn_Click(object sender, EventArgs e)
        {
            highScoresFrm newHighScoresFrm = new highScoresFrm(_mainMenuFrm);
            this.Close();
            newHighScoresFrm.Show();
        }


        //call Exit Class to exit the game
        private void exitBtn_Click(object sender, EventArgs e)
        {
            Exit.ExitApplication();
        }
    }
}
