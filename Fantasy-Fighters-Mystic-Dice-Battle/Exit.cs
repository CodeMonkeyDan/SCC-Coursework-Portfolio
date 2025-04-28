//Daniel Schiefer
//CPT-185-A80H-2024FA
//Final Project: Fantasy Fighters: Mystic Dice Battle


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D_Schiefer_Final_Project_Fantasy_Fighters_Mystic_Dice_Battle
{
    public static class Exit
    {
        public static void ExitApplication()
        {
            //verify if user really wants to exit the game
            DialogResult exit = MessageBox.Show("Are you sure you want to exit?",
                "Exit Program", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //if yes, thank user and exit the game
            if (exit == DialogResult.Yes)
            {
                MessageBox.Show("Thank you for playing Fantasy Fighter: Mystic Dice Battle", "Good Bye");
                Application.Exit();
            }
        }
    }
}
