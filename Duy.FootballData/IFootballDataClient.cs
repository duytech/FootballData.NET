using Duy.FootballData.Common;
using Duy.FootballData.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Duy.FootballData.Client
{
    public interface IFootballDataClient
    {
        /// <summary>
        /// Get all available competitions. Default is current year.
        /// </summary>
        /// <param name="season">Year of competition</param>
        /// <returns></returns>
        Task<IEnumerable<Competition>> GetCompetitions(int? season);

        /// <summary>
        /// Get all teams for a certain competition.
        /// </summary>
        /// <param name="competitionId"></param>
        /// <returns></returns>
        Task<Teams> GetTeams(int competitionId);

        /// <summary>
        /// Get one team.
        /// </summary>
        /// <param name="teamId"></param>
        /// <returns></returns>
        Task<Team> GetTeam(int teamId);

        /// <summary>
        /// Get fixtures across a set of competitions.
        /// </summary>
        /// <param name="timeFrame"></param>
        /// <param name="leagueCode"></param>
        /// <returns></returns>
        Task<Fixtures> GetFixtures(string timeFrame, params LeagueCode[] leagueCode);

        /// <summary>
        /// Get one fixture.
        /// </summary>
        /// <param name="fixtureId"></param>
        /// <param name="head2head"></param>
        /// <returns></returns>
        Task<FixtureHead2Head> GetFixture(int fixtureId, int? head2head);

        /// <summary>
        /// Get all fixtures for a certain team.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="season"></param>
        /// <param name="timeFrame"></param>
        /// <param name="venue"></param>
        /// <returns></returns>
        Task<Fixtures> GetFixturesForTeam(int teamId, int? season, string timeFrame, Venue? venue);

        /// <summary>
        /// Get all fixtures for a certain competition with matchday filter.
        /// </summary>
        /// <param name="competitionId"></param>
        /// <param name="matchDay">Match on that day</param>
        /// <returns></returns>
        Task<Fixtures> GetFixturesForCompetition(int competitionId, int? matchDay);

        /// <summary>
        /// Get all fixture for a competion with time frame filter. Default is next seven days.
        /// </summary>
        /// <param name="competitionId"></param>
        /// <param name="timeFrame"></param>
        /// <returns></returns>
        Task<Fixtures> GetFixturesForCompetition(int competitionId, string timeFrame);

        /// <summary>
        /// Get all players for a certain team.
        /// </summary>
        /// <param name="teamId"></param>
        /// <returns></returns>
        Task<Players> GetPlayers(int teamId);

        /// <summary>
        /// Get League table / current standing.
        /// </summary>
        /// <param name="competitionId"></param>
        /// <param name="matchDay">Match on that day</param>
        /// <returns></returns>
        Task<LeagueTable> GetLeagueTable(int competitionId, int? matchDay);
    }
}
