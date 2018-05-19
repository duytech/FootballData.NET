namespace Duy.FootballData.Models
{
    public class FixtureResult
    {
        public int? goalsHomeTeam { get; set; }
        public int? goalsAwayTeam { get; set; }
        public Score halfTime { get; set; }
        public Score extraTime { get; set; }
        public Score penaltyShootout { get; set; }
    }
}
