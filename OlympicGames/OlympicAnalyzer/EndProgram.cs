using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OlympicAnalyzer
{
    public static class EndProgram
    {
        public static void Exit()
        {
            //verify if user really wants to exit the game
            DialogResult exit = MessageBox.Show("Are you sure you want to exit the program?",
                "End Program", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //if yes, thank user and exit the game
            if (exit == DialogResult.Yes)
            {
                MessageBox.Show("Thank you for using the Olympic Analyzer" +
                    "\n\ncreated by: The Function Tribe of Recursion Glory");
                Application.Exit();
            }
        }
    }
}
