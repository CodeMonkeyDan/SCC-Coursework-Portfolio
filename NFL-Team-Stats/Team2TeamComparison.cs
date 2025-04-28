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

namespace D_Schiefer_CPT244_Final_Project_NFL_Team_Stats
{
    public partial class team2TeamComparisonFrm : Form
    {
        //declare variable to hold the reference of mainMenuFrm
        private mainMenuFrm _mainMenuFrm;

        //constructor that takes the mainMenuFrm as a parameter
        public team2TeamComparisonFrm(mainMenuFrm existingMainMenuFrm)
        {
            InitializeComponent();
            _mainMenuFrm = existingMainMenuFrm;
        }


        //populate list boxes with items when form loads
        private void team2TeamComparisonFrm_Load(object sender, EventArgs e)
        {
            //populate year list boxes
            for (int i = 2003;  i <= 2019;  i++)
            {
                team1YearLstBx.Items.Add(i.ToString());
                team2YearLstBx.Items.Add(i.ToString());
            }

            //populate team list boxes
            foreach (string teamName in StatData.teamLogos.Keys)
            {
                team1TeamLstBx.Items.Add(teamName);
                team2TeamLstBx.Items.Add(teamName);
            }
        }


        //display comparison of selected teams
        private void displayBtn_Click(object sender, EventArgs e)
        {
            //verifies that user selected a year and a name for each team
            if (team1YearLstBx.SelectedIndex != - 1 && team1TeamLstBx.SelectedIndex != - 1 &&
                team2YearLstBx.SelectedIndex != - 1 && team2TeamLstBx.SelectedIndex != - 1)
            {
                //loop through teamlogos to find matches and display logos for selected teams
                foreach (string teamName in StatData.teamLogos.Keys)
                {
                    if (teamName == team1TeamLstBx.Text)
                    {
                        team1PicBx.Image = StatData.teamLogos[teamName];
                    }
                    if (teamName == team2TeamLstBx.Text)
                    {
                        team2PicBx.Image = StatData.teamLogos[teamName];
                    }
                }

                //clear the list view items and columns
                team2TeamCompLstVw.Items.Clear();
                team2TeamCompLstVw.Columns.Clear();

                //add columns to list view
                team2TeamCompLstVw.Columns.Add("Year", 80);
                team2TeamCompLstVw.Columns.Add("City", 120);
                team2TeamCompLstVw.Columns.Add("Name", 100);
                team2TeamCompLstVw.Columns.Add("Wins", 80);
                team2TeamCompLstVw.Columns.Add("Losses", 80);
                team2TeamCompLstVw.Columns.Add("Ties", 80);
                team2TeamCompLstVw.Columns.Add("Win %", 80);
                team2TeamCompLstVw.Columns.Add("Points For", 100);
                team2TeamCompLstVw.Columns.Add("Points Against", 120);
                team2TeamCompLstVw.Columns.Add("Point Differential", 120);
                team2TeamCompLstVw.Columns.Add("Total Yards", 120);
                team2TeamCompLstVw.Columns.Add("Yards/Play", 100);
                team2TeamCompLstVw.Columns.Add("Passing Yards", 120);
                team2TeamCompLstVw.Columns.Add("Passing TDs", 120);
                team2TeamCompLstVw.Columns.Add("Passing Ints", 120);
                team2TeamCompLstVw.Columns.Add("Rushing Yards", 120);
                team2TeamCompLstVw.Columns.Add("Yards/Rush", 100);
                team2TeamCompLstVw.Columns.Add("Rushing TDs", 120);
                team2TeamCompLstVw.Columns.Add("Fumbles", 80);
                team2TeamCompLstVw.Columns.Add("Playoffs", 120);
                team2TeamCompLstVw.Columns.Add("Super Bowl", 160);
                team2TeamCompLstVw.Columns.Add("Home Attendance", 140);

                try
                {
                    //create a unique key for each team selected by the user
                    string team1Key = team1YearLstBx.Text + team1TeamLstBx.Text;
                    string team2Key = team2YearLstBx.Text + team2TeamLstBx.Text;

                    //retrieve data for each team
                    if (StatData.teamDataDictionary.TryGetValue(team1Key, out StatData.TeamData team1Data) &&
                        StatData.teamDataDictionary.TryGetValue(team2Key, out StatData.TeamData team2Data))
                    {
                        //calculate ties for team 1
                        int team1Ties = (16 - (team1Data.Standings.teamWins +
                            team1Data.Standings.teamLoses));
                        //calculate win percentage for team 1
                        double team1WinPer = (team1Data.Standings.teamWins +
                            ((double)team1Ties / 2)) / 16;
                        //calculate point differential for team 1
                        int team1PtDiff = team1Data.Stats.teamPointsFor -
                            team1Data.Stats.teamPointsAgainst;
                        //calculate yards per play for team 1
                        double team1YardsPerPlay = (double)team1Data.Stats.teamTotalYards /
                            team1Data.Stats.teamTotalPlays;
                        //calculate yards per rush for team 1
                        double team1YardsPerRush = (double)team1Data.Stats.teamRushingYards /
                            team1Data.Stats.teamRushingAttempts;
                        //calculate if team 1 made playoffs
                        string team1Playoffs = "";
                        if (team1Data.Standings.teamPlayoffs)
                        {
                            team1Playoffs = "Made Playoffs";
                        }
                        else
                        {
                            team1Playoffs = "Missed Playoffs";
                        }
                        //calculate if team 1 won the superbowl
                        string team1SuperbowlWinner = "";
                        if (team1Data.Standings.teamSuperbowlWinner)
                        {
                            team1SuperbowlWinner = "Won the Superbowl";
                        }

                        //create an array for team 1 stats
                        string[] team1Stats = new string[]
                        {
                            team1YearLstBx.Text,                                    // year
                            team1Data.Standings.teamCity,                           // city
                            team1TeamLstBx.Text,                                    // name
                            team1Data.Standings.teamWins.ToString(),                // wins
                            team1Data.Standings.teamLoses.ToString(),               // loses
                            team1Ties.ToString(),                                   // ties
                            team1WinPer.ToString("F3"),                             // win percentage
                            team1Data.Stats.teamPointsFor.ToString(),               // points for
                            team1Data.Stats.teamPointsAgainst.ToString(),           // points against
                            team1PtDiff.ToString(),                                 // point differential
                            team1Data.Stats.teamTotalYards.ToString(),              // total yards
                            team1YardsPerPlay.ToString("F1"),                       // yards per play
                            team1Data.Stats.teamPassingYards.ToString(),            // passing yards
                            team1Data.Stats.teamPassingTDs.ToString(),              // passing TDs
                            team1Data.Stats.teamPassingInts.ToString(),             // passing Ints
                            team1Data.Stats.teamRushingYards.ToString(),            // rushing yards
                            team1YardsPerRush.ToString("F1"),                       // yards per rush
                            team1Data.Stats.teamRushingTDs.ToString(),              // rushing TDs
                            team1Data.Stats.teamFumbles.ToString(),                 // fumbles
                            team1Playoffs,                                          // made playoffs?
                            team1SuperbowlWinner,                                   // won superbowl?
                            team1Data.Attendance.teamHomeAttendance.ToString("N0"), //home game attendance
                        };

                        //calculate ties for team 2
                        int team2Ties = (16 - (team2Data.Standings.teamWins +
                            team2Data.Standings.teamLoses));
                        //calculate win percentage for team 2
                        double team2WinPer = (team2Data.Standings.teamWins +
                            ((double)team2Ties / 2)) / 16;
                        //calculate point differential for team 2
                        int team2PtDiff = team2Data.Stats.teamPointsFor -
                            team2Data.Stats.teamPointsAgainst;
                        //calculate yards per play for team 2
                        double team2YardsPerPlay = (double)team2Data.Stats.teamTotalYards /
                            team2Data.Stats.teamTotalPlays;
                        //calculate yards per rush for team 2
                        double team2YardsPerRush = (double)team2Data.Stats.teamRushingYards /
                            team2Data.Stats.teamRushingAttempts;
                        //calculate if team 2 made playoffs
                        string team2Playoffs = "";
                        if (team2Data.Standings.teamPlayoffs)
                        {
                            team2Playoffs = "Made Playoffs";
                        }
                        else
                        {
                            team2Playoffs = "Missed Playoffs";
                        }
                        //calculate if team 2 won the superbowl
                        string team2SuperbowlWinner = "";
                        if (team2Data.Standings.teamSuperbowlWinner)
                        {
                            team2SuperbowlWinner = "Won the Superbowl";
                        }

                        //create an array for team 2 stats
                        string[] team2Stats = new string[]
                        {
                            team2YearLstBx.Text,                                    // year
                            team2Data.Standings.teamCity,                           // city
                            team2TeamLstBx.Text,                                    // name
                            team2Data.Standings.teamWins.ToString(),                // wins
                            team2Data.Standings.teamLoses.ToString(),               // loses
                            team2Ties.ToString(),                                   // ties
                            team2WinPer.ToString("F3"),                             // win percentage
                            team2Data.Stats.teamPointsFor.ToString(),               // points for
                            team2Data.Stats.teamPointsAgainst.ToString(),           // points against
                            team2PtDiff.ToString(),                                 // point differential
                            team2Data.Stats.teamTotalYards.ToString(),              // total yards
                            team2YardsPerPlay.ToString("F1"),                       // yards per play
                            team2Data.Stats.teamPassingYards.ToString(),            // passing yards
                            team2Data.Stats.teamPassingTDs.ToString(),              // passing TDs
                            team2Data.Stats.teamPassingInts.ToString(),             // passing Ints
                            team2Data.Stats.teamRushingYards.ToString(),            // rushing yards
                            team2YardsPerRush.ToString("F1"),                       // yards per rush
                            team2Data.Stats.teamRushingTDs.ToString(),              // rushing TDs
                            team2Data.Stats.teamFumbles.ToString(),                 // fumbles
                            team2Playoffs,                                          // made playoffs?
                            team2SuperbowlWinner,                                   // won superbowl?
                            team2Data.Attendance.teamHomeAttendance.ToString("N0"), // home game attendance
                        };

                        //add team data to list view
                        ListViewItem team1Item = new ListViewItem(team1Stats);
                        team2TeamCompLstVw.Items.Add(team1Item);
                        ListViewItem team2Item = new ListViewItem(team2Stats);
                        team2TeamCompLstVw.Items.Add(team2Item);
                    }
                }
                //display message box is data fails to load
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to load data.\n\n" + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            //display message box if user does not select a year and name for both teams
            else
            {
                MessageBox.Show("Please make sure to select a Year and Team for both Team 1 and " +
                    "Team 2.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //save comparison to file
        private void saveTeamComparisonBtn_Click(object sender, EventArgs e)
        {
            //verifies there is data in the list view to be saved
            if (team2TeamCompLstVw.Items.Count != 0)
            {
                //generate recommended file name
                string team1Year = team2TeamCompLstVw.Items[0].SubItems[0].Text;
                string team1Name = team2TeamCompLstVw.Items[0].SubItems[2].Text;
                string team2Year = team2TeamCompLstVw.Items[1].SubItems[0].Text;
                string team2Name = team2TeamCompLstVw.Items[1].SubItems[2].Text;
                string fileName = team1Year + team1Name + "-" + team2Year + team2Name + "-Comp";

                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    FileName = fileName,
                    Filter = "Text Files (.txt)|*.txt"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (StreamWriter team2TeamCompSaveFileObject = new StreamWriter
                            (saveFileDialog.FileName))
                        {
                            //loops through the team2TeamCompLstVw columns
                            for (int i = 0; i < team2TeamCompLstVw.Columns.Count; i++)
                            {
                                //write column header and tabs afterward
                                team2TeamCompSaveFileObject.Write(team2TeamCompLstVw.Columns[i].Text + "\t");

                                //loops through the team2TeamCompLstVw items
                                foreach (ListViewItem item in team2TeamCompLstVw.Items)
                                {
                                    //write the line data for each team and tabs afterward
                                    team2TeamCompSaveFileObject.Write(item.SubItems[i].Text + "\t");
                                }
                                //move to the next line
                                team2TeamCompSaveFileObject.WriteLine();
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


        //close team2TeamComparisonFrm and show mainMenuFrm
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
