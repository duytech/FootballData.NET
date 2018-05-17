using System;
using System.Collections.Generic;
using System.Text;

namespace Duy.FootballData.App
{
    class Class1
    {

        public class Rootobject
        {
            public _Links _links { get; set; }
            public string leagueCaption { get; set; }
            public int matchday { get; set; }
            public Standing[] standing { get; set; }
        }

        public class _Links
        {
            public Self self { get; set; }
            public Competition competition { get; set; }
        }

        public class Self
        {
            public string href { get; set; }
        }

        public class Competition
        {
            public string href { get; set; }
        }

        public class Standing
        {
            public _Links1 _links { get; set; }
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
            public Home home { get; set; }
            public Away away { get; set; }
        }

        public class _Links1
        {
            public Team team { get; set; }
        }

        public class Team
        {
            public string href { get; set; }
        }

        public class Home
        {
            public int goals { get; set; }
            public int goalsAgainst { get; set; }
            public int wins { get; set; }
            public int draws { get; set; }
            public int losses { get; set; }
        }

        public class Away
        {
            public int goals { get; set; }
            public int goalsAgainst { get; set; }
            public int wins { get; set; }
            public int draws { get; set; }
            public int losses { get; set; }
        }

    }
}
