using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Duy.FootballData.Common.Builder;
using Duy.FootballData.Models;
using Newtonsoft.Json;

namespace Duy.FootballData.Client
{
    public class FootballDataClient : IFootballDataClient
    {
        private readonly FootballHttpClient _client;
        private readonly FootballUrlBuilder _builder;
        private static readonly FootballDataOption _defaultOption = new FootballDataOption
        {
            Token = string.Empty,
            ResponseControl = ResponseControl.full,
            BaseUrl = "http://api.football-data.org/v1/"
        };

        /// <summary>
        /// Default constructor with no api key, full response control and http://api.football-data.org/v1/ as url.
        /// </summary>
        public FootballDataClient() : this(_defaultOption) { }

        /// <summary>
        /// Use this constructor to specify custom option.
        /// </summary>
        /// <param name="footballDataOption"></param>
        public FootballDataClient(FootballDataOption footballDataOption)
        {
            _client = new FootballHttpClient(footballDataOption);
            _builder = new FootballUrlBuilder();
        }

        public async Task<IEnumerable<Competition>> GetCompetitions(int season) 
            => await GetAsync<IEnumerable<Competition>>(_builder.BuildCompetition(season));

        public async Task<Fixture> GetFixtureById(int fixtureId) 
            => await GetAsync<Fixture>(_builder.BuildFixture(fixtureId));

        public async Task<Fixtures> GetFixtures() 
            => await GetAsync<Fixtures>(_builder.BuildFixtures());

        public async Task<LeagueTable> GetLeagueTable(int competitionId) 
            => await GetAsync<LeagueTable>(_builder.BuildLeagueTable(competitionId));

        public async Task<LeagueTable> GetLeagueTable(int competitionId, int matchDay) 
            => await GetAsync<LeagueTable>(_builder.BuildLeagueTable(competitionId, matchDay));

        public async Task<Players> GetPlayers(int teamId) 
            => await GetAsync<Players>(_builder.BuildPlayers(teamId));

        public async Task<Team> GetTeamById(int teamId) 
            => await GetAsync<Team>(_builder.BuildTeamById(teamId));

        public async Task<Teams> GetTeams(int competitionId) 
            => await GetAsync<Teams>(_builder.BuildTeams(competitionId));

        private async Task<T> GetAsync<T>(string relativeUrl)
        {
            var response = await _client.GetAsync(relativeUrl);
            response.EnsureSuccessStatusCode();
            var responseString = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(responseString);
        }
    }
}
