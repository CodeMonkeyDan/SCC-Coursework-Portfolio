//Daniel Schiefer aka CodeMonkeyDan
//CPT206-A80S-2025SP
//Lab #5: Web App


namespace DSchiefer_Lab_5_WebApp.Models
{
    public class GameResults
    {
        public int Year { get; set; }
        public string Week { get; set; }
        public string HomeTeam { get; set; }
        public string AwayTeam { get; set; }
        public string Winner { get; set; }
        public string Day { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public int PtsWin { get; set; }
        public int PtsLoss { get; set; }
        public int YdsWin { get; set; }
        public int TurnoversWin { get; set; }
        public int YdsLoss { get; set; }
        public int TurnoversLoss { get; set; }
    }
}
