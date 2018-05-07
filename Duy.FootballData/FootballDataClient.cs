using System.Collections.Generic;
using System.Threading.Tasks;
using Duy.FootballData.Common;
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
            ApiKey = string.Empty,
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

        /// <summary>
        /// Get competition in a year.
        /// </summary>
        /// <param name="season">Year of competition</param>
        /// <returns></returns>
        public async Task<IEnumerable<Competition>> GetCompetitions(int? season)
            => await GetAsync<IEnumerable<Competition>>(_builder.BuildCompetition(season));

        public async Task<FixtureHead2Head> GetFixture(int fixtureId, int? head2head)
            => await GetAsync<FixtureHead2Head>(_builder.BuildFixture(fixtureId, head2head));

        public async Task<Fixtures> GetFixtures(int? timeFrame, string leagueCode)
            => await GetAsync<Fixtures>(_builder.BuildFixtures(timeFrame, leagueCode));

        /// <summary>
        /// Get League table for a competition and a matchday.
        /// </summary>
        /// <param name="competitionId"></param>
        /// <param name="matchDay">Match on that day</param>
        /// <returns></returns>
        public async Task<LeagueTable> GetLeagueTable(int competitionId, int? matchDay)
            => await GetAsync<LeagueTable>(_builder.BuildLeagueTable(competitionId, matchDay));

        public async Task<Players> GetPlayers(int teamId)
            => await GetAsync<Players>(_builder.BuildPlayers(teamId));

        public async Task<Team> GetTeam(int teamId)
            => await GetAsync<Team>(_builder.BuildTeam(teamId));

        public async Task<Teams> GetTeams(int competitionId)
            => await GetAsync<Teams>(_builder.BuildTeams(competitionId));

        /// <summary>
        /// <see cref="IFootballDataClient.GetFixturesForTeam(int, int?, string, Venue?)"/>
        /// </summary>
        public async Task<Fixtures> GetFixturesForTeam(int teamId, int? season, string timeFrame, Venue? venue)
            => await GetAsync<Fixtures>(_builder.BuildFixturesForTeam(teamId, season, timeFrame, venue));

        public async Task<Fixtures> GetFixturesForCompetition(int competitionId, int? matchDay)
            => await GetAsync<Fixtures>(_builder.BuildFixturesForCompetition(competitionId, matchDay));

        public async Task<Fixtures> GetFixturesForCompetition(int competitionId, string timeFrame)
            => await GetAsync<Fixtures>(_builder.BuildFixturesForCompetition(competitionId, timeFrame));

        private async Task<T> GetAsync<T>(string relativeUrl)
        {
            var response = await _client.GetAsync(relativeUrl);
            response.EnsureSuccessStatusCode();
            var responseString = await response.Content.ReadAsStringAsync();
            return string.IsNullOrEmpty(responseString) ? default(T) : JsonConvert.DeserializeObject<T>(responseString);
        }
    }
}
