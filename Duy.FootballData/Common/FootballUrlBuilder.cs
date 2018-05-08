using System.Text;

namespace Duy.FootballData.Common
{
    internal class FootballUrlBuilder
    {
        public string BuildCompetition(int? season)
        {
            var builder = new StringBuilder("competitions/?");
            if(season.HasValue)
            {
                builder.Append($"season={season}");
            }

            return builder.ToString();
        }

        public string BuildFixture(int fixtureId, int? head2head)
        {
            var builder = new StringBuilder($"fixtures/{fixtureId}");
            if (head2head.HasValue)
            {
                builder.Append($"/?head2head={head2head}");
            }

            return builder.ToString();
        }

        public string BuildFixtures(string timeFrame, string leagueCode)
        {
            var builder = new StringBuilder("fixtures/?");
            if (!string.IsNullOrEmpty(timeFrame))
            {
                builder.Append($"timeFrame={timeFrame}");
            }

            if (!string.IsNullOrEmpty(leagueCode))
            {
                builder.Append($"&league={leagueCode}");
            }

            return builder.ToString();
        }

        public string BuildFixturesForCompetition(int competitionId, int? matchDay)
        {
            var builder = new StringBuilder($"competitions/{competitionId}/fixtures");
            if (matchDay.HasValue)
            {
                builder.Append($"/?matchday={matchDay}");
            }

            return builder.ToString();
        }

        public string BuildFixturesForCompetition(int competitionId, string timeFrame)
        {
            var builder = new StringBuilder($"competitions/{competitionId}/fixtures");
            if (!string.IsNullOrEmpty(timeFrame))
            {
                builder.Append($"/?timeFrame={timeFrame}");
            }

            return builder.ToString();
        }

        public string BuildFixturesForTeam(int teamId, int? season, string timeFrame, Venue? venue)
        {
            var builder = new StringBuilder($"teams/{teamId}/fixtures/?");
            if (season.HasValue)
            {
                builder.Append($"season={season}");
            }

            if (!string.IsNullOrEmpty(timeFrame))
            {
                builder.Append($"&timeFrame={timeFrame}");
            }

            if (venue.HasValue)
            {
                builder.Append($"&venue={venue.ToString().ToLower()}");
            }

            return builder.ToString();
        }

        public string BuildLeagueTable(int competitionId, int? matchDay)
        {
            var builder = new StringBuilder($"competitions/{competitionId}/leagueTable/?");
            if(matchDay.HasValue)
            {
                builder.Append($"matchday={matchDay}");
            }

            return builder.ToString();
        }

        public string BuildPlayers(int teamId) => $"teams/{teamId}/players";

        public string BuildTeam(int teamId) => $"teams/{teamId}";

        public string BuildTeams(int competitionId) => $"competitions/{competitionId}/teams";
    }
}
