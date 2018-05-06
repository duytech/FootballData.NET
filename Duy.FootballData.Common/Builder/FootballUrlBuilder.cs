using System;

namespace Duy.FootballData.Common.Builder
{
    public class FootballUrlBuilder
    {
        public string BuildCompetition() => "competitions";

        public string BuildCompetition(int season) => $"competitions/?season={season}";

        public string BuildFixture(int fixtureId) => $"fixtures/{fixtureId}";

        public string BuildFixtures() => "fixtures";

        public string BuildLeagueTable(int competitionId) => $"competitions/{competitionId}/leagueTable";

        public string BuildLeagueTable(int competitionId, int matchDay) => $"competitions/{competitionId}/leagueTable/?matchDay={matchDay}";

        public string BuildPlayers(int teamId) => $"teams/{teamId}/players";

        public string BuildTeamById(int teamId) => $"teams/{teamId}";

        public string BuildTeams(int competitionId) => $"competitions/{competitionId}/teams";
    }
}
