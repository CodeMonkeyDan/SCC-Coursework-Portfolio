//Daniel Schiefer
//CPT-244-A80H-2024FA
//Final Project: NFL Stat Analyzer


using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D_Schiefer_CPT244_Final_Project_NFL_Team_Stats
{
    public static class YearTeamStandingsLoader
    {
        public static void LoadYearTeamStanding()
        {
            //load and populate YearTeamStandings list
            try
            {
                //locate file path for YearTeamStandings.cvs
                string filePath = Path.Combine(Directory.GetCurrentDirectory(), "YearTeamStandings.CSV");
                //create an object to upload data to
                using (StreamReader uploadTeamStandingsFileObject = new StreamReader(filePath))
                {
                    //removes the header
                    uploadTeamStandingsFileObject.ReadLine();
                    //loop through object until the end of the file is reached
                    while (!uploadTeamStandingsFileObject.EndOfStream)
                    {
                        //take data one line at a time to populate each new object in YearTeamStandings list
                        string teamStandings = uploadTeamStandingsFileObject.ReadLine();
                        string[] teamStandingsSplit = teamStandings.Split(',');
                        bool playoffs = false;
                        bool superbowlWin = false;

                        if (teamStandingsSplit[13].ToLower() == "playoffs")
                        {
                            playoffs = true;
                        }
                        if (teamStandingsSplit[14].ToLower() == "won superbowl")
                        {
                            superbowlWin = true;
                        }

                        StatData.yearTeamStandings.Add(new StatData.YearTeamStandings
                        (
                            teamStandingsSplit[0],              // teamCity
                            teamStandingsSplit[1],              // teamName
                            int.Parse(teamStandingsSplit[2]),   // teamYear
                            int.Parse(teamStandingsSplit[3]),   // teamWins
                            int.Parse(teamStandingsSplit[4]),   // teamLosses
                            playoffs,                           // teamPlayoffs
                            superbowlWin)                       // teamSuperBowlWinner
                        );
                    }
                }
            }
            //if file fails to load, message box pops up and shows exception error
            catch (Exception ex)
            {
                MessageBox.Show("Team standings file failed to load.\n\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
