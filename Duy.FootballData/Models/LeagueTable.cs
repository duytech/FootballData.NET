﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Duy.FootballData.Models
{
    public class LeagueTable
    {
        public string leagueCaption { get; set; }
        public int matchday { get; set; }
        public IList<StandingTeam> standing { get; set; }
    }
}
