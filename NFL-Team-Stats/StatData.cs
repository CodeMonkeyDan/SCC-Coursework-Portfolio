//Daniel Schiefer
//CPT-244-A80H-2024FA
//Final Project: NFL Stat Analyzer


using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace D_Schiefer_CPT244_Final_Project_NFL_Team_Stats
{
    public static class StatData
    {
        //create lists for each csv file
        public static readonly List<YearTeamStats> yearTeamStats = new List<YearTeamStats>();

        public static readonly List<YearTeamStandings> yearTeamStandings =
            new List<YearTeamStandings>();

        public static readonly List<YearTeamAttendance> yearTeamAttendance =
            new List<YearTeamAttendance>();

        //centralized dictionary for team data
        public static readonly Dictionary<string, TeamData> teamDataDictionary =
            new Dictionary<string, TeamData>();

        //create library for team logos
        public static readonly Dictionary<string, Image> teamLogos = new Dictionary<string, Image>
        {
            { "Cardinals", Properties.Resources.Arizona_Cardinals },
            { "Falcons", Properties.Resources.Atlanta_Falcons },
            { "Ravens", Properties.Resources.Baltimore_Ravens },
            { "Bills", Properties.Resources.Buffalo_Bills },
            { "Panthers", Properties.Resources.Carolina_Panthers },
            { "Bears", Properties.Resources.Chicago_Bears },
            { "Bengals", Properties.Resources.Cincinnati_Bengals },
            { "Browns", Properties.Resources.Cleveland_Browns },
            { "Cowboys", Properties.Resources.Dallas_Cowboys },
            { "Broncos", Properties.Resources.Denver_Broncos },
            { "Lions", Properties.Resources.Detroit_Lions },
            { "Packers", Properties.Resources.GreenBay_Packers },
            { "Texans", Properties.Resources.Houston_Texans },
            { "Colts", Properties.Resources.Indianapolis_Colts },
            { "Jaguars", Properties.Resources.Jacksonville_Jaguars },
            { "Chiefs", Properties.Resources.KansasCity_Chiefs },
            { "Raiders", Properties.Resources.LasVegas_Raiders },
            { "Chargers", Properties.Resources.LosAngeles_Chargers },
            { "Rams", Properties.Resources.LosAngeles_Rams },
            { "Dolphins", Properties.Resources.Miami_Dolphins },
            { "Vikings", Properties.Resources.Minnesota_Vikings },
            { "Patriots", Properties.Resources.NewEngland_Patriots },
            { "Saints", Properties.Resources.NewOrleans_Saints },
            { "Giants", Properties.Resources.NewYork_Giants },
            { "Jets", Properties.Resources.NewYork_Jets },
            { "Eagles", Properties.Resources.Philadelphia_Eagles },
            { "Steelers", Properties.Resources.Pittsburgh_Steelers },
            { "49ers", Properties.Resources.SanFrancisco_49ers },
            { "Seahawks", Properties.Resources.Seattle_Seahawks },
            { "Buccaneers", Properties.Resources.TampaBay_Buccaneers },
            { "Titans", Properties.Resources.Tennessee_Titans },
            { "Redskins", Properties.Resources.Washington_Redskins }
        };


        //method to load data into the dictionary
        public static void LoadTeamData()
        {
            //loops through yearTeamStats to create a unique key for each team
            foreach (var stats in yearTeamStats)
            {
                //create a unique key based on teamYear and teamName
                string uniqueKey = stats.teamYear.ToString() + stats.teamName;

                //find the corresponding data in yearTeamStandings and yearTeamAttendance
                var standings = yearTeamStandings
                    .FirstOrDefault(s => s.teamYear == stats.teamYear && s.teamName == stats.teamName);
                var attendance = yearTeamAttendance
                    .FirstOrDefault(a => a.teamYear == stats.teamYear && a.teamName == stats.teamName);

                // If data exists for the team, add it to the dictionary
                if (standings != null && attendance != null)
                {
                    teamDataDictionary[uniqueKey] = new TeamData(stats, standings, attendance);
                }
            }
        }


        //team data holder class for combining stats, standings, and attendance
        public class TeamData
        {
            public YearTeamStats Stats { get; set; }
            public YearTeamStandings Standings { get; set; }
            public YearTeamAttendance Attendance { get; set; }

            public TeamData(YearTeamStats stats, YearTeamStandings standings, YearTeamAttendance attendance)
            {
                Stats = stats;
                Standings = standings;
                Attendance = attendance;
            }
        }



        //Team Stats Data
        public class YearTeamStats
        {
            //team stats fields
            public int teamYear { get; }
            public string teamCity { get; }
            public string teamName { get; }
            public int teamPointsFor {  get; }
            public int teamPointsAgainst { get; }
            public int teamTotalYards { get; }
            public int teamTotalPlays { get; }
            public int teamFumbles { get; }
            public int teamPassingYards { get; }
            public int teamPassingTDs { get; }
            public int teamPassingInts { get; }
            public int teamRushingAttempts { get; }
            public int teamRushingYards { get; }
            public int teamRushingTDs { get; }

            //team stats constructor
            public YearTeamStats(int year, string city, string name, int pointsFor, int pointsAgainst,
                int totalYards, int totalPlays, int fumbles, int passingYards, int passingTDs,
                int passingInts, int rushingAttempts, int rushingYards, int rushingTDs)
            {
                teamYear = year;
                teamCity = city;
                teamName = name;
                teamPointsFor = pointsFor;
                teamPointsAgainst = pointsAgainst;
                teamTotalYards = totalYards;
                teamTotalPlays = totalPlays;
                teamFumbles = fumbles;
                teamPassingYards = passingYards;
                teamPassingTDs = passingTDs;
                teamPassingInts = passingInts;
                teamRushingAttempts = rushingAttempts;
                teamRushingYards = rushingYards;
                teamRushingTDs = rushingTDs;
            }
        }


        //Team Standings Data
        public class YearTeamStandings
        {
            //team standings fields
            public string teamCity { get; }
            public string teamName { get; }
            public int teamYear { get; }
            public int teamWins { get; }
            public int teamLoses { get; }
            public bool teamPlayoffs { get; }
            public bool teamSuperbowlWinner { get; }

            //team standings constructor
            public YearTeamStandings(string city, string name, int year, int wins, int loses,
                bool playoffs, bool superbowlWinner)
            {
                teamCity = city;
                teamName = name;
                teamYear = year;
                teamWins = wins;
                teamLoses = loses;
                teamPlayoffs = playoffs;
                teamSuperbowlWinner = superbowlWinner;
            }
        }


        //Team Attendance Data
        public class YearTeamAttendance
        {
            //team attendance fields
            public string teamCity { get; }
            public string teamName { get; }
            public int teamYear { get; }
            public int teamHomeAttendance { get; }

            //team attendance constructor
            public YearTeamAttendance(string city, string name, int year, int attendance)
            {
                teamCity = city;
                teamName = name;
                teamYear = year;
                teamHomeAttendance = attendance;
            }
        }
    }
}
