using System;
using System.Collections.Generic;
using System.Text;

namespace Duy.FootballData.Models
{
    public class LeagueTable
    {
        public LeagueTableLinks _links { get; set; }
        public string leagueCaption { get; set; }
        public int matchday { get; set; }
        public IList<StandingTeam> standing { get; set; }
    }
}
