using System.Collections.Generic;
using System.Text;
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
            ResponseControl = ResponseControl.Full
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

        public async Task<IEnumerable<Competition>> GetCompetitions(int? season)
            => await GetAsync<IEnumerable<Competition>>(_builder.BuildCompetition(season));

        public async Task<FixtureHead2Head> GetFixture(int fixtureId, int? head2head)
            => await GetAsync<FixtureHead2Head>(_builder.BuildFixture(fixtureId, head2head));

        public async Task<Fixtures> GetFixtures(TimeFrame timeFrame, params LeagueCode[] leagueCodes)
        {
            var leagueCode = string.Empty;
            if (leagueCodes != null && leagueCodes.Length > 0)
            {
                var builder = new StringBuilder();
                for (int index = 0; index < leagueCodes.Length; index++)
                {
                    builder.Append(leagueCodes[index].ToString());
                    if (index < leagueCodes.Length - 1)
                        builder.Append(",");
                }
                leagueCode = builder.ToString();
            }

            return await GetAsync<Fixtures>(_builder.BuildFixtures(timeFrame.ToString(), leagueCode));
        }

        public async Task<LeagueTable> GetLeagueTable(int competitionId, int? matchDay)
            => await GetAsync<LeagueTable>(_builder.BuildLeagueTable(competitionId, matchDay));

        public async Task<Players> GetPlayers(int teamId)
            => await GetAsync<Players>(_builder.BuildPlayers(teamId));

        public async Task<Team> GetTeam(int teamId)
            => await GetAsync<Team>(_builder.BuildTeam(teamId));

        public async Task<Teams> GetTeams(int competitionId)
            => await GetAsync<Teams>(_builder.BuildTeams(competitionId));

        public async Task<Fixtures> GetFixturesForTeam(int teamId, int? season, TimeFrame timeFrame, Venue? venue)
            => await GetAsync<Fixtures>(_builder.BuildFixturesForTeam(teamId, season, timeFrame.ToString(), venue));

        public async Task<Fixtures> GetFixturesForCompetition(int competitionId, int? matchDay)
            => await GetAsync<Fixtures>(_builder.BuildFixturesForCompetition(competitionId, matchDay));

        public async Task<Fixtures> GetFixturesForCompetition(int competitionId, TimeFrame timeFrame)
            => await GetAsync<Fixtures>(_builder.BuildFixturesForCompetition(competitionId, timeFrame.ToString()));

        private async Task<T> GetAsync<T>(string relativeUrl)
        {
            var response = await _client.GetAsync(relativeUrl);
            response.EnsureSuccessStatusCode();
            var responseString = await response.Content.ReadAsStringAsync();
            return string.IsNullOrEmpty(responseString) ? default(T) : JsonConvert.DeserializeObject<T>(responseString);
        }
    }
}
