using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duy.FootballData.Models
{
    public class CompetitionLinks : Links
    {
        public Link teams { get; set; }
        public Link fixtures { get; set; }
        public Link leagueTable { get; set; }
    }
}
