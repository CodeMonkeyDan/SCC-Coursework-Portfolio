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
    public static class YearTeamStatsLoader
    {
        public static void LoadYearTeamStats()
        {
            //load and populate YearTeamStats list
            try
            {
                //locate file path for YearTeamStats.cvs
                string filePath = Path.Combine(Directory.GetCurrentDirectory(), "YearTeamStats.CSV");
                //create an object to upload data to
                using (StreamReader uploadTeamStatsFileObject = new StreamReader(filePath))
                {
                    //removes the header
                    uploadTeamStatsFileObject.ReadLine();
                    //loop through object until the end of the file is reached
                    while (!uploadTeamStatsFileObject.EndOfStream)
                    {
                        //take data one line at a time to populate each new object in YearTeamStats list
                        string teamStats = uploadTeamStatsFileObject.ReadLine();
                        string[] teamStatsSplit = teamStats.Split(',');

                        //splits the team into city and name
                        string[] cityNameSplit = teamStatsSplit[1].Split(' ');
                        string teamName = cityNameSplit[cityNameSplit.Length - 1];
                        string teamCity = string.Join(",", cityNameSplit, 0, cityNameSplit.Length - 1);

                        StatData.yearTeamStats.Add(new StatData.YearTeamStats
                        (
                            int.Parse(teamStatsSplit[0]),   // teamYear
                            teamCity,                       // teamCity
                            teamName,                       // teamName
                            int.Parse(teamStatsSplit[6]),   // teamPointsFor
                            int.Parse(teamStatsSplit[7]),   // teamPointsAgainst
                            int.Parse(teamStatsSplit[11]),  // teamTotalYards
                            int.Parse(teamStatsSplit[12]),  // teamTotalPlays
                            int.Parse(teamStatsSplit[15]),  // teamFumbles
                            int.Parse(teamStatsSplit[19]),  // teamPassingYards
                            int.Parse(teamStatsSplit[20]),  // teamPassingTDs
                            int.Parse(teamStatsSplit[21]),  // teamPassingInts
                            int.Parse(teamStatsSplit[24]),  // teamRushingAttempts
                            int.Parse(teamStatsSplit[25]),  // teamRushingYards
                            int.Parse(teamStatsSplit[26])   // teamRushingTDs
                        ));
                    }
                }
            }
            //if file fails to load, message box pops up and shows exception error
            catch (Exception ex)
            {
                MessageBox.Show("Team stats file failed to load.\n\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
