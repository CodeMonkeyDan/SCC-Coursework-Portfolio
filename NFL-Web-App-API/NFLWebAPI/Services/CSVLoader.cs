//Daniel Schiefer aka CodeMonkeyDan
//CPT206-A80S-2025SP
//Lab #5: Web API


using DSchiefer_Lab_5_WebAPI.Models;


namespace DSchiefer_Lab_5_WebAPI.Services
{
    public static class CSVLoader
    {
        //store the file path as a variable
        private static readonly string FilePath = "Data/NFLGames2000-2019.csv";

        public static async Task<List<GameResults>> LoadGamesAsync()
        {
            //create a list of the game results
            var games = new List<GameResults>();

            //try catch when loading csv data
            try
            {
                //use stream reader to read the file asynchonously
                using (var reader = new StreamReader(FilePath))
                {
                    //skip header line
                    await reader.ReadLineAsync();

                    while (!reader.EndOfStream)
                    {
                        var line = await reader.ReadLineAsync();
                        var parts = line.Split(',');

                        //ensure the line has the correct number of parts
                        if (parts.Length < 14)
                        {
                            //log the error for the line that was missing data
                            Console.WriteLine($"Skipping line due to insufficient data: {line}");
                            continue;
                        }

                        //tryparse values to handle potential errors
                        if (int.TryParse(parts[0], out int year) &&
                            int.TryParse(parts[8], out int ptsWin) &&
                            int.TryParse(parts[9], out int ptsLoss) &&
                            int.TryParse(parts[10], out int ydsWin) &&
                            int.TryParse(parts[11], out int turnoversWin) &&
                            int.TryParse(parts[12], out int ydsLoss) &&
                            int.TryParse(parts[13], out int turnoversLoss))
                        {
                            //adds the valid game result to the list
                            games.Add(new GameResults
                            {
                                Year = year,
                                Week = parts[1],
                                HomeTeam = parts[2],
                                AwayTeam = parts[3],
                                Winner = parts[4],
                                Day = parts[5],
                                Date = parts[6],
                                Time = parts[7],
                                PtsWin = ptsWin,
                                PtsLoss = ptsLoss,
                                YdsWin = ydsWin,
                                TurnoversWin = turnoversWin,
                                YdsLoss = ydsLoss,
                                TurnoversLoss = turnoversLoss
                            });
                        }
                        else
                        {
                            //log the error for the line where parsing failed
                            Console.WriteLine($"Failed to parse line: {line}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading file: {ex.Message}");
            }

            //returns the list of game results
            return games;
        }
    }
}
