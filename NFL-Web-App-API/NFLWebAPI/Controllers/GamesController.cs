//Daniel Schiefer aka CodeMonkeyDan
//CPT206-A80S-2025SP
//Lab #5: Web API


using Microsoft.AspNetCore.Mvc;
using DSchiefer_Lab_5_WebAPI.Models;
using DSchiefer_Lab_5_WebAPI.Services;


namespace DSchiefer_Lab_5_WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class GamesController : ControllerBase
    {
        //define valid weeks as a constant array to use
        private static readonly string[] ValidWeeks = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "WildCard", "Division", "ConfChamp", "SuperBowl" };


        //GET: api/games/valid-weeks
        [HttpGet("valid-weeks")]
        public ActionResult<IEnumerable<string>> GetValidWeeks()
        {
            //return the list of valid weeks as a JSON response
            return Ok(ValidWeeks);
        }


        //GET: api/games/search?year=2020&week=5&team=Patriots&winner=Home&gameType=home
        [HttpGet("search")]
        public async Task<ActionResult<IEnumerable<GameResults>>> SearchGames(
            [FromQuery] int? year,
            [FromQuery] string? week,
            [FromQuery] string? team,
            [FromQuery] string? winner,
            [FromQuery] string? home_away)
        {
            //validate that the year is between 2000 and 2019
            if (year < 2000 || year > 2019)
            {
                return BadRequest("Year must be between 2000 and 2019.");
            }

            //validate the week input
            if (!string.IsNullOrEmpty(week) &&
                !ValidWeeks.Any(validWeek => validWeek.Equals(week, StringComparison.OrdinalIgnoreCase)))
            {
                return BadRequest("Week must be a number between 1 and 17, or one of the valid week names (WildCard, SuperBowl, Division, ConfChamp).");
            }

            //validate home_away input
            if (!string.IsNullOrEmpty(home_away) && !(home_away == "home" || home_away == "away"))
            {
                return BadRequest("home_away must Home, Away, or left blank.");
            }

            //load the games from the CSV asynchronously
            var games = await CSVLoader.LoadGamesAsync();

            //apply dynamic filtering based on the provided query parameters
            var filteredGames = games.AsQueryable();

            //filter by year
            if (year.HasValue)
            {
                filteredGames = filteredGames.Where(game => game.Year == year.Value);
            }

            //filter by week
            if (!string.IsNullOrEmpty(week))
            {
                filteredGames = filteredGames.Where(game => game.Week.Equals(week, StringComparison.OrdinalIgnoreCase));
            }

            //filter by team (home, away, or either)
            if (!string.IsNullOrEmpty(team))
            {
                //if only home teams has been selected
                if (home_away.Equals("home", StringComparison.OrdinalIgnoreCase))
                {
                    filteredGames = filteredGames.Where(game =>
                        game.HomeTeam.Contains(team, StringComparison.OrdinalIgnoreCase));
                }
                //if only away teams has been selected
                else if (home_away.Equals("away", StringComparison.OrdinalIgnoreCase))
                {
                    filteredGames = filteredGames.Where(game =>
                        game.AwayTeam.Contains(team, StringComparison.OrdinalIgnoreCase));
                }
                //if home/away does not matter
                else
                {
                    filteredGames = filteredGames.Where(game =>
                        game.HomeTeam.Contains(team, StringComparison.OrdinalIgnoreCase) ||
                        game.AwayTeam.Contains(team, StringComparison.OrdinalIgnoreCase));
                }
            }

            //filter by winner
            if (!string.IsNullOrEmpty(winner))
            {
                //if only home teams has been selected
                if (home_away.Equals("home", StringComparison.OrdinalIgnoreCase))
                {
                    filteredGames = filteredGames.Where(game =>
                        game.Winner.Contains(winner, StringComparison.OrdinalIgnoreCase) &&
                        game.HomeTeam.Contains(winner, StringComparison.OrdinalIgnoreCase));
                }
                //if only away teams has been selected
                else if (home_away.Equals("away", StringComparison.OrdinalIgnoreCase))
                {
                    filteredGames = filteredGames.Where(game =>
                        game.Winner.Contains(winner, StringComparison.OrdinalIgnoreCase) &&
                        game.AwayTeam.Contains(winner, StringComparison.OrdinalIgnoreCase));
                }
                //if home/away does not matter
                else
                {
                    filteredGames = filteredGames.Where(game =>
                        game.Winner.Contains(winner, StringComparison.OrdinalIgnoreCase));
                }
            }

            // Return the filtered games as a JSON response
            return Ok(filteredGames.ToList());
        }
    }
}
