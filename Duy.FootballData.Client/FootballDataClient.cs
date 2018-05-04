using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Duy.FootballData.Models;
using Newtonsoft.Json;

namespace Duy.FootballData.Client
{
    public class FootballDataClient : IFootballDataClient
    {
        private readonly FootballHttpClient _client;

        public FootballDataClient(FootballDataOption footballDataOption)
        {
            _client = new FootballHttpClient(footballDataOption);
        }

        public async Task<IEnumerable<Competition>> GetCompetitions(int season)
        {
            return await GetAsync<IEnumerable<Competition>>($"competitions/?season={season}");
        }

        public async Task<Fixture> GetFixtureById(int fixtureId)
        {
            return await GetAsync<Fixture>($"fixtures/{fixtureId}");
        }

        public async Task<Fixtures> GetFixtures(int competitionId)
        {
            return await GetAsync<Fixtures>("fixtures");
        }

        public async Task<Players> GetPlayers(int teamId)
        {
            return await GetAsync<Players>($"teams/{teamId}/players");
        }

        public async Task<Team> GetTeamById(int teamId)
        {
            return await GetAsync<Team>($"teams/{teamId}");
        }

        public async Task<Teams> GetTeams(int competitionId)
        {
            return await GetAsync<Teams>($"competitions/{competitionId}/teams");
        }

        private async Task<T> GetAsync<T>(string relativeUrl)
        {
            var response = await _client.GetAsync(relativeUrl);
            var responseString = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(responseString);
        }
    }
}
