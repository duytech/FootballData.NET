using Duy.FootballData.Client;
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
                    Token = string.Empty,
                    ResponseControl = ResponseControl.full,
                    BaseUrl = "http://api.football-data.org/v1/"
                };
                var client = new FootballDataClient(option);
                var competition = await client.GetCompetitions(2017);
                Console.WriteLine(JsonConvert.SerializeObject(competition, Formatting.Indented));

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
