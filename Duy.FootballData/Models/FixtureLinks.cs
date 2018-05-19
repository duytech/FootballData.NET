using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duy.FootballData.Models
{
    public class FixtureLinks : Links
    {
        public Link competition { get; set; }
        public Link hometeam { get; set; }
        public Link awayteam { get; set; }
    }
}
