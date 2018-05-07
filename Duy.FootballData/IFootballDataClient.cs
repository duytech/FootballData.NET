using Duy.FootballData.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Duy.FootballData.Client
{
    public interface IFootballDataClient
    {
        Task<IEnumerable<Competition>> GetCompetitions(int? season);

        Task<Teams> GetTeams(int competitionId);

        Task<Team> GetTeam(int teamId);

        Task<Fixtures> GetFixtures(int? timeFrame, string leagueCode);

        /// <summary>
        /// Show one fixture.
        /// </summary>
        /// <param name="fixtureId"></param>
        /// <param name="head2head"></param>
        /// <returns></returns>
        Task<FixtureHead2Head> GetFixture(int fixtureId, int? head2head);

        /// <summary>
        /// Show all fixtures for a certain team.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="season"></param>
        /// <param name="timeFrame"></param>
        /// <param name="venue"></param>
        /// <returns></returns>
        Task<Fixtures> GetFixturesForTeam(int teamId, int? season, string timeFrame, Venue? venue);

        Task<Fixtures> GetFixturesForCompetition(int competitionId, int? matchDay);

        Task<Fixtures> GetFixturesForCompetition(int competitionId, string timeFrame);

        Task<Players> GetPlayers(int teamId);

        Task<LeagueTable> GetLeagueTable(int competitionId, int? matchDay);
    }
}
