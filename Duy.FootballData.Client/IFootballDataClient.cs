using Duy.FootballData.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Duy.FootballData.Client
{
    public interface IFootballDataClient
    {
        Task<IEnumerable<Competition>> GetCompetitions(int season);

        Task<Teams> GetTeams(int competitionId);

        Task<Team> GetTeamById(int teamId);

        Task<Fixtures> GetFixtures(int competitionId);

        Task<Fixture> GetFixtureById(int fixtureId);

        Task<Players> GetPlayers(int teamId);
    }
}
