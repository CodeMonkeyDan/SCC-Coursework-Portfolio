//Daniel Schiefer
//CPT-244-A80H-2024FA
//Final Project: NFL Stat Analyzer


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D_Schiefer_CPT244_Final_Project_NFL_Team_Stats
{
    public static class Exit
    {
        public static void ExitApplication()
        {
            //verify if user really wants to exit the program
            DialogResult exit = MessageBox.Show("Are you sure you want to exit?",
                "Exit Program", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //if yes, thank user and exit the program
            if (exit == DialogResult.Yes)
            {
                MessageBox.Show("Thank you for using my NFL Stat Analyzer", "Good Bye");
                Application.Exit();
            }
        }
    }
}
