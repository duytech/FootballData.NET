﻿using System;
using System.Collections.Generic;

namespace Duy.FootballData.Models
{
    public class Head2Head
    {
        public int count { get; set; }
        public DateTime timeFrameStart { get; set; }
        public DateTime timeFrameEnd { get; set; }
        public int homeTeamWins { get; set; }
        public int awayTeamWins { get; set; }
        public int draws { get; set; }
        public Fixture lastHomeWinHomeTeam { get; set; }
        public Fixture lastWinHomeTeam { get; set; }
        public Fixture lastAwayWinAwayTeam { get; set; }
        public Fixture lastWinAwayTeam { get; set; }
        public IList<Fixture> fixtures { get; set; }
    }
}
