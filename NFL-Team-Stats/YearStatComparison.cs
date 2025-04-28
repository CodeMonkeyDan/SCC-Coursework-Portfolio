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
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static D_Schiefer_CPT244_Final_Project_NFL_Team_Stats.StatData;

namespace D_Schiefer_CPT244_Final_Project_NFL_Team_Stats
{
    public partial class yearStatComparisonFrm : Form
    {
        //declare variable to hold the reference of mainMenuFrm
        private mainMenuFrm _mainMenuFrm;

        //constructor that takes the mainMenuFrm as a parameter
        public yearStatComparisonFrm(mainMenuFrm existingMainMenuFrm)
        {
            InitializeComponent();
            _mainMenuFrm = existingMainMenuFrm;
        }


        //populate list box with items when form loads
        private void yearStatComparisonFrm_Load(object sender, EventArgs e)
        {
            //populate year list boxes
            for (int i = 2003; i <= 2019; i++)
            {
                yearLstBx.Items.Add(i.ToString());
            }
        }


        //display comparison of selected stats
        private void displayBtn_Click(object sender, EventArgs e)
        {
            //verifies that user selected a year and a stat to display
            if (yearLstBx.SelectedIndex != - 1 && statLstBx.SelectedIndex != - 1)
            {
                //clear the list view items and columns
                yearStatCompLstVw.Items.Clear();
                yearStatCompLstVw.Columns.Clear();

                try
                {
                    //create a list to store TeamData for all 32 teams
                    List<StatData.TeamData> teamDataList = new List<StatData.TeamData>();

                    //loop through the teamLogo dictionary to create a key for each team key
                    foreach (string team in StatData.teamLogos.Keys)
                    {
                        //creates a unique key for each team
                        string teamKey = yearLstBx.Text + team;

                        //use unique key to retrive data for each team
                        if (StatData.teamDataDictionary.TryGetValue(teamKey, out StatData.TeamData teamData))
                        {
                            //adds teamData to teamDataList
                            teamDataList.Add(teamData);
                        }
                    }

                    //add constant columns
                    yearStatCompLstVw.Columns.Add("Year", 80);
                    yearStatCompLstVw.Columns.Add("City", 120);
                    yearStatCompLstVw.Columns.Add("Name", 100);

                    //add appropriate columns based on user selected stats
                    if (statLstBx.Text == "Records")
                    {
                        yearStatCompLstVw.Columns.Add("Wins", 80);
                        yearStatCompLstVw.Columns.Add("Losses", 80);
                        yearStatCompLstVw.Columns.Add("Ties", 80);
                        yearStatCompLstVw.Columns.Add("Win %", 80);
                        yearStatCompLstVw.Columns.Add("Playoffs", 120);
                        yearStatCompLstVw.Columns.Add("Super Bowl", 160);
                    }
                    else if (statLstBx.Text == "Points")
                    {
                        yearStatCompLstVw.Columns.Add("Points For", 100);
                        yearStatCompLstVw.Columns.Add("Points Against", 120);
                        yearStatCompLstVw.Columns.Add("Point Differential", 120);
                    }
                    else if (statLstBx.Text == "Total Offense")
                    {
                        yearStatCompLstVw.Columns.Add("Total Yards", 120);
                        yearStatCompLstVw.Columns.Add("Yards/Play", 100);
                        yearStatCompLstVw.Columns.Add("Total TDs", 100);
                    }
                    else if (statLstBx.Text == "Passing")
                    {
                        yearStatCompLstVw.Columns.Add("Passing Yards", 120);
                        yearStatCompLstVw.Columns.Add("Passing TDs", 120);
                        yearStatCompLstVw.Columns.Add("Passing Ints", 120);
                    }
                    else if (statLstBx.Text == "Rushing")
                    {
                        yearStatCompLstVw.Columns.Add("Rushing Yards", 120);
                        yearStatCompLstVw.Columns.Add("Yards/Rush", 100);
                        yearStatCompLstVw.Columns.Add("Rushing TDs", 120);
                    }
                    else if (statLstBx.Text == "Turnovers")
                    {
                        yearStatCompLstVw.Columns.Add("Ints", 80);
                        yearStatCompLstVw.Columns.Add("Fumbles", 80);
                    }
                    else
                    {
                        yearStatCompLstVw.Columns.Add("Home Attendance", 140);
                    }

                    //loop through each team in the teamDataList and add data
                    foreach (var teamData in teamDataList)
                    {
                        //create a ListViewItem for each team
                        ListViewItem item = new ListViewItem(yearLstBx.Text);
                        item.SubItems.Add(teamData.Standings.teamCity);
                        item.SubItems.Add(teamData.Standings.teamName);

                        //add appropriate data based on user selected stat
                        if (statLstBx.Text == "Records")
                        {
                            //calculate ties
                            int ties = (16 - (teamData.Standings.teamWins +
                                teamData.Standings.teamLoses));
                            //calculate win percentage
                            double winPer = (teamData.Standings.teamWins +
                                ((double)ties / 2)) / 16;
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
                            }
                            item.SubItems.Add(teamData.Standings.teamWins.ToString());
                            item.SubItems.Add(teamData.Standings.teamLoses.ToString());
                            item.SubItems.Add(ties.ToString());
                            item.SubItems.Add(winPer.ToString("F3"));
                            item.SubItems.Add(playoffs);
                            item.SubItems.Add(superbowlWinner);
                        }
                        else if (statLstBx.Text == "Points")
                        {
                            //calculate point differential
                            int pointDiff = teamData.Stats.teamPointsFor -
                                teamData.Stats.teamPointsAgainst;
                            item.SubItems.Add(teamData.Stats.teamPointsFor.ToString());
                            item.SubItems.Add(teamData.Stats.teamPointsAgainst.ToString());
                            item.SubItems.Add(pointDiff.ToString());
                        }
                        else if (statLstBx.Text == "Total Offense")
                        {
                            //calculate yards per play
                            double yardsPerPlay = (double)teamData.Stats.teamTotalYards /
                                teamData.Stats.teamTotalPlays;
                            //calculate total tds
                            int totalTDs = teamData.Stats.teamPassingTDs +
                                teamData.Stats.teamRushingTDs;
                            item.SubItems.Add(teamData.Stats.teamTotalYards.ToString());
                            item.SubItems.Add(yardsPerPlay.ToString("F1"));
                            item.SubItems.Add(totalTDs.ToString());
                        }
                        else if (statLstBx.Text == "Passing")
                        {
                            item.SubItems.Add(teamData.Stats.teamPassingYards.ToString());
                            item.SubItems.Add(teamData.Stats.teamPassingTDs.ToString());
                            item.SubItems.Add(teamData.Stats.teamPassingInts.ToString());
                        }
                        else if (statLstBx.Text == "Rushing")
                        {
                            //calculate yards per rush
                            double yardsPerRush = (double)teamData.Stats.teamRushingYards /
                                teamData.Stats.teamRushingAttempts;
                            item.SubItems.Add(teamData.Stats.teamRushingYards.ToString());
                            item.SubItems.Add(yardsPerRush.ToString("F1"));
                            item.SubItems.Add(teamData.Stats.teamRushingTDs.ToString());
                        }
                        else if (statLstBx.Text == "Turnovers")
                        {
                            item.SubItems.Add(teamData.Stats.teamPassingInts.ToString());
                            item.SubItems.Add(teamData.Stats.teamFumbles.ToString());
                        }
                        else
                        {
                            item.SubItems.Add(teamData.Attendance.teamHomeAttendance.ToString("N0"));
                        }

                        // Add the item to the ListView
                        yearStatCompLstVw.Items.Add(item);
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
                MessageBox.Show("Please make sure to select a Year and a Stat to display.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //save comparison to a file
        private void saveTeamComparisonBtn_Click(object sender, EventArgs e)
        {
            //verifies there is data in the list view to be saved
            if (yearStatCompLstVw.Items.Count != 0)
            {
                //generate recommended file name
                string fileName = yearLstBx.Text + "-" + statLstBx.Text + "-Comp";

                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    FileName = fileName,
                    Filter = "Text Files (.txt)|*.txt"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (StreamWriter yearStatCompSaveFileObject = new StreamWriter
                            (saveFileDialog.FileName))
                        {
                            //loops through the yearStatCompLstVw columns
                            for (int i = 0; i < yearStatCompLstVw.Columns.Count; i++)
                            {
                                //write column header, adding a tab after each except for the last
                                yearStatCompSaveFileObject.Write(yearStatCompLstVw.Columns[i].Text);
                                if (i < yearStatCompLstVw.Columns.Count - 1)
                                    yearStatCompSaveFileObject.Write("\t");
                            }
                            //new line after headers
                            yearStatCompSaveFileObject.WriteLine();

                            //loops through the yearStatCompLstVw items
                            foreach (ListViewItem item in yearStatCompLstVw.Items)
                            {
                                //loop through the yearStatCompLstVx subitems
                                for (int i = 0; i < item.SubItems.Count; i++)
                                {
                                    //write data, adding a tab after each except for the last
                                    yearStatCompSaveFileObject.Write(item.SubItems[i].Text);
                                    if (i < item.SubItems.Count - 1)
                                        yearStatCompSaveFileObject.Write("\t");
                                }
                                //new line after each row
                                yearStatCompSaveFileObject.WriteLine();
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


        //close yearStatComparisonFrm and show mainMenuFrm
        private void mainMenuBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            _mainMenuFrm.Show();
        }


        //call Exit Class
        private void exitBtn_Click(object sender, EventArgs e)
        {
            Exit.ExitApplication();
        }
    }
}
