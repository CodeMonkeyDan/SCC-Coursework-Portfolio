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
    public partial class mainMenuFrm : Form
    {
        public mainMenuFrm()
        {
            InitializeComponent();
        }


        //reads csv files into lists when app starts
        private void mainMenuFrm_Load(object sender, EventArgs e)
        {
            YearTeamStatsLoader.LoadYearTeamStats();
            YearTeamStandingsLoader.LoadYearTeamStanding();
            YearTeamAttendanceLoader.LoadYearTeamAttendance();
            StatData.LoadTeamData();
        }


        //hide mainMenuFrm and creates/shows team2TeamComparisonFrm
        private void teamStatsBtn_Click(object sender, EventArgs e)
        {
            team2TeamComparisonFrm newTeam2TeamComparisonFrm = new team2TeamComparisonFrm(this);
            this.Hide();
            newTeam2TeamComparisonFrm.Show();
        }


        //hide mainMenuFrm and creates/shows yearStatComparisonFrm
        private void nflStatsBtn_Click(object sender, EventArgs e)
        {
            yearStatComparisonFrm newYearStatComparisonFrm = new yearStatComparisonFrm(this);
            this.Hide();
            newYearStatComparisonFrm.Show();
        }


        //hides mainMenuFrm and creates/shows playoffStatComparisonFrm
        private void playoffStatsBtn_Click(object sender, EventArgs e)
        {
            playoffStatComparisonFrm newPlayoffStatComparisonFrm = new playoffStatComparisonFrm(this);
            this.Hide();
            newPlayoffStatComparisonFrm.Show();
        }


        //calls Exit Class
        private void button4_Click(object sender, EventArgs e)
        {
            Exit.ExitApplication();
        }
    }
}
