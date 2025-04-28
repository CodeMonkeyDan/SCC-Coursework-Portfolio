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
    public static class YearTeamAttendanceLoader
    {
        public static void LoadYearTeamAttendance()
        {
            //hashset to keep track of unique team-year combinations
            HashSet<string> teamYearTracker = new HashSet<string>();

            //load and populate YearTeamAttendance list
            try
            {
                //locate file path for YearTeamAttendance.cvs
                string filePath = Path.Combine(Directory.GetCurrentDirectory(), "YearTeamAttendance.CSV");
                //create an object to upload data to
                using (StreamReader uploadTeamAttendanceFileObject = new StreamReader(filePath))
                {
                    //removes the header
                    uploadTeamAttendanceFileObject.ReadLine();
                    //loop through object until the end of the file is reached
                    while (!uploadTeamAttendanceFileObject.EndOfStream)
                    {
                        //take data one line at a time to populate each new object in YearTeamAttendance list
                        string teamAttendance = uploadTeamAttendanceFileObject.ReadLine();
                        string[] teamAttendanceSplit = teamAttendance.Split(',');

                        //parse fields into seperate variables
                        string teamCity = teamAttendanceSplit[0];
                        string teamName = teamAttendanceSplit[1];
                        int teamYear = int.Parse(teamAttendanceSplit[2]);
                        int teamAttend = int.Parse(teamAttendanceSplit[4]);

                        //create a unique key for each team-year
                        string teamYearKey = teamCity + teamName + teamYear;

                        //checks to see if unique team-year already exists
                        if (!teamYearTracker.Contains(teamYearKey))
                        {
                            //add data to YearTeamAttendance list
                            StatData.yearTeamAttendance.Add(new StatData.YearTeamAttendance
                            (
                                teamCity,       // teamCity
                                teamName,       // teamName
                                teamYear,       // teamYear
                                teamAttend      // teamAttendance
                            ));
                            teamYearTracker.Add(teamYearKey);
                        }
                    }
                }
            }
            //if file fails to load, message box pops up and shows exception error
            catch (Exception ex)
            {
                MessageBox.Show("Team attendance file failed to load.\n\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
