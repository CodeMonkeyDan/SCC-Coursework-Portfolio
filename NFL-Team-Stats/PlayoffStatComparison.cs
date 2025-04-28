//Daniel Schiefer
//CPT-244-A80H-2024FA
//Final Project: NFL Stat Analyzer


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
using static D_Schiefer_CPT244_Final_Project_NFL_Team_Stats.StatData;

namespace D_Schiefer_CPT244_Final_Project_NFL_Team_Stats
{
    public partial class playoffStatComparisonFrm : Form
    {
        //declare variable to hold the reference of mainMenuFrm
        private mainMenuFrm _mainMenuFrm;

        //constructor that takes the mainMenuFrm as a parameter
        public playoffStatComparisonFrm(mainMenuFrm existingMainMenuFrm)
        {
            InitializeComponent();
            _mainMenuFrm = existingMainMenuFrm;
        }


        //populate list box with items when form loads
        private void playoffStatComparisonFrm_Load(object sender, EventArgs e)
        {
            //populate year list boxes
            for (int i = 2003; i <= 2019; i++)
            {
                yearLstBx.Items.Add(i.ToString());
            }
        }


        //display comparison of selected years
        private void displayBtn_Click(object sender, EventArgs e)
        {
            //verifies that user selected a year and a stat to display
            if (yearLstBx.SelectedIndex != -1)
            {
                //clear the list view items and columns
                playoffStatCompLstVw.Items.Clear();
                playoffStatCompLstVw.Columns.Clear();

                //add columns to list view
                playoffStatCompLstVw.Columns.Add("Year", 80);
                playoffStatCompLstVw.Columns.Add("City", 120);
                playoffStatCompLstVw.Columns.Add("Name", 100);
                playoffStatCompLstVw.Columns.Add("Wins", 80);
                playoffStatCompLstVw.Columns.Add("Losses", 80);
                playoffStatCompLstVw.Columns.Add("Ties", 80);
                playoffStatCompLstVw.Columns.Add("Win %", 80);
                playoffStatCompLstVw.Columns.Add("Points For", 100);
                playoffStatCompLstVw.Columns.Add("Points Against", 120);
                playoffStatCompLstVw.Columns.Add("Point Differential", 120);
                playoffStatCompLstVw.Columns.Add("Total Yards", 120);
                playoffStatCompLstVw.Columns.Add("Yards/Play", 100);
                playoffStatCompLstVw.Columns.Add("Passing Yards", 120);
                playoffStatCompLstVw.Columns.Add("Passing TDs", 120);
                playoffStatCompLstVw.Columns.Add("Passing Ints", 120);
                playoffStatCompLstVw.Columns.Add("Rushing Yards", 120);
                playoffStatCompLstVw.Columns.Add("Yards/Rush", 100);
                playoffStatCompLstVw.Columns.Add("Rushing TDs", 120);
                playoffStatCompLstVw.Columns.Add("Fumbles", 80);
                playoffStatCompLstVw.Columns.Add("Playoffs", 120);
                playoffStatCompLstVw.Columns.Add("Super Bowl", 160);
                playoffStatCompLstVw.Columns.Add("Home Attendance", 140);

                try
                {
                    //create a list to store team data for all playoff teams
                    List<StatData.TeamData> playoffDataList = new List<StatData.TeamData>();

                    //loop through yearTeamStandings
                    foreach(var team in StatData.yearTeamStandings)
                    {
                        //verifies if the year matches and if the team made the playoffs
                        if (team.teamYear.ToString() == yearLstBx.Text && team.teamPlayoffs)
                        {
                            //creates a unique key for each playoff team in the selected year
                            string uniqueKey = team.teamYear.ToString() + team.teamName;
                            //uses the unique key to retrieve TeamData for that key
                            if (StatData.teamDataDictionary.TryGetValue(uniqueKey, out
                                StatData.TeamData teamData))
                            {
                                //adds teamData to playoffDataList
                                playoffDataList.Add(teamData);
                            }
                        }
                    }

                    //loop through playoffDataList
                    foreach (var teamData in playoffDataList)
                    {
                        //calculate ties
                        int ties = (16 - (teamData.Standings.teamWins +
                            teamData.Standings.teamLoses));
                        //calculate win percentage
                        double winPer = (teamData.Standings.teamWins +
                            ((double)ties / 2)) / 16;
                        //calculate point differential
                        int ptDiff = teamData.Stats.teamPointsFor -
                            teamData.Stats.teamPointsAgainst;
                        //calculate yards per play
                        double yardsPerPlay = (double)teamData.Stats.teamTotalYards /
                            teamData.Stats.teamTotalPlays;
                        //calculate yards per rush
                        double yardsPerRush = (double)teamData.Stats.teamRushingYards /
                            teamData.Stats.teamRushingAttempts;
                        //calculate if team made playoffs
                        string playoffs = "";
                        if (teamData.Standings.teamPlayoffs)
                        {
                            playoffs = "Made Playoffs";
                        }
                        else
                        {
                            playoffs = "Missed Playoffs";
                        }
                        //calculate if team won the superbowl
                        string superbowlWinner = "";
                        if (teamData.Standings.teamSuperbowlWinner)
                        {
                            superbowlWinner = "Won the Superbowl";

                            //display superbowl winning team
                            sbwLbl.Visible = true;
                            //loop through teamlogos to find match and display logo for superbowl winner
                            foreach (string teamName in StatData.teamLogos.Keys)
                            {
                                if (teamName == teamData.Standings.teamName)
                                {
                                    sbwPicBx.Image = StatData.teamLogos[teamName];
                                }
                            }
                        }

                        //create an array for playoff team stats
                        string[] teamStats = new string[]
                        {
                            yearLstBx.Text,                                         // year
                            teamData.Standings.teamCity,                            // city
                            teamData.Standings.teamName,                            // name
                            teamData.Standings.teamWins.ToString(),                 // wins
                            teamData.Standings.teamLoses.ToString(),                // loses
                            ties.ToString(),                                        // ties
                            winPer.ToString("F3"),                                  // win percentage
                            teamData.Stats.teamPointsFor.ToString(),                // points for
                            teamData.Stats.teamPointsAgainst.ToString(),            // points against
                            ptDiff.ToString(),                                      // point differential
                            teamData.Stats.teamTotalYards.ToString(),               // total yards
                            yardsPerPlay.ToString("F1"),                            // yards per play
                            teamData.Stats.teamPassingYards.ToString(),             // passing yards
                            teamData.Stats.teamPassingTDs.ToString(),               // passing TDs
                            teamData.Stats.teamPassingInts.ToString(),              // passing Ints
                            teamData.Stats.teamRushingYards.ToString(),             // rushing yards
                            yardsPerRush.ToString("F1"),                            // yards per rush
                            teamData.Stats.teamRushingTDs.ToString(),               // rushing TDs
                            teamData.Stats.teamFumbles.ToString(),                  // fumbles
                            playoffs,                                               // made playoffs?
                            superbowlWinner,                                        // won superbowl?
                            teamData.Attendance.teamHomeAttendance.ToString("N0"),  //home game attendance
                        };

                        //add playoff team data to list view
                        ListViewItem playoffTeamItem = new ListViewItem(teamStats);
                        playoffStatCompLstVw.Items.Add(playoffTeamItem);
                    }
                }
                //display message box is data fails to load
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to load data.\n\n" + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            //display message box if user does not select a year and stat to display
            else
            {
                MessageBox.Show("Please make sure to select a Year to display.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //save comparison to a file
        private void saveTeamComparisonBtn_Click(object sender, EventArgs e)
        {
            //verifies there is data in the list view to be saved
            if (playoffStatCompLstVw.Items.Count != 0)
            {
                //generate recommended file name
                string fileName = yearLstBx.Text + "-Playoff-Team-Comp";

                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    FileName = fileName,
                    Filter = "Text Files (.txt)|*.txt"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (StreamWriter playoffStatCompSaveFileObject = new StreamWriter
                            (saveFileDialog.FileName))
                        {
                            //loops through the playoffStatCompLstVw columns
                            for (int i = 0; i < playoffStatCompLstVw.Columns.Count; i++)
                            {
                                //write column header and tabs afterward
                                playoffStatCompSaveFileObject.Write(playoffStatCompLstVw.Columns[i].Text + "\t");

                                //loops through the playoffStatCompLstVw items
                                foreach (ListViewItem item in playoffStatCompLstVw.Items)
                                {
                                    //write the line data for each team and tabs afterward
                                    playoffStatCompSaveFileObject.Write(item.SubItems[i].Text + "\t");
                                }
                                //move to the next line
                                playoffStatCompSaveFileObject.WriteLine();
                            }
                        }
                        //display message telling user the data saved successfully
                        MessageBox.Show("Data saved successfully.", "Data Saved",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    //displays message telling the user the date failed to save
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed to save data.\n\n" + ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            //displays message telling the user they must display data before saving
            else
            {
                MessageBox.Show("Please make sure to display data before exporting.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //close playoffStatComparisonFrm and show mainMenuFrm
        private void mainMenuBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            _mainMenuFrm.Show();
        }


        //calls Exit Class
        private void exitBtn_Click(object sender, EventArgs e)
        {
            Exit.ExitApplication();
        }
    }
}
