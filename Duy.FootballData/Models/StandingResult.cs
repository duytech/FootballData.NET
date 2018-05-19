using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duy.FootballData.Models
{
    public class StandingResult
    {
        public int goals { get; set; }
        public int goalsAgainst { get; set; }
        public int wins { get; set; }
        public int draws { get; set; }
        public int losses { get; set; }
    }
}
