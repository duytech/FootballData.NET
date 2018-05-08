using Duy.FootballData.Client;
using Duy.FootballData.Common;
using Duy.FootballData.Models;
using Newtonsoft.Json;
using System;
using System.Threading.Tasks;

namespace Duy.FootballData.App
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            try
            {
                var option = new FootballDataOption
                {
                    ApiKey = string.Empty,
                    ResponseControl = ResponseControl.Full
                };
                IFootballDataClient client = new FootballDataClient(option);

                var competition = await client.GetCompetitions(2017);
                Console.WriteLine(JsonConvert.SerializeObject(competition, Formatting.Indented));

                var fixture = await client.GetFixture(146773, 5);
                Console.WriteLine(JsonConvert.SerializeObject(fixture, Formatting.Indented));

                var leagueTable = await client.GetLeagueTable(445, 1);
                Console.WriteLine(JsonConvert.SerializeObject(leagueTable, Formatting.Indented));

                var fixtureTeam = await client.GetFixturesForTeam(66, 2017, "n10", Venue.Home);
                Console.WriteLine(JsonConvert.SerializeObject(fixtureTeam, Formatting.Indented));

                var fixtureCompetition = await client.GetFixtures("n99", LeagueCode.PL, LeagueCode.CL, LeagueCode.SA);
                Console.WriteLine(JsonConvert.SerializeObject(fixtureCompetition, Formatting.Indented));

                var liverpoolPlayers = await client.GetPlayers(64);
                Console.WriteLine(JsonConvert.SerializeObject(liverpoolPlayers, Formatting.Indented));

                Console.ReadLine();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.ReadLine();
            }
        }
    }
}
