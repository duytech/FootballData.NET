﻿namespace Duy.FootballData.Models
{
    public class StandingTeam
    {
        public StandingLinks _links { get; set; }
        public int position { get; set; }
        public string teamName { get; set; }
        public string crestURI { get; set; }
        public int playedGames { get; set; }
        public int points { get; set; }
        public int goals { get; set; }
        public int goalsAgainst { get; set; }
        public int goalDifference { get; set; }
        public int wins { get; set; }
        public int draws { get; set; }
        public int losses { get; set; }
        public StandingResult home { get; set; }
        public StandingResult away { get; set; }
    }
}
