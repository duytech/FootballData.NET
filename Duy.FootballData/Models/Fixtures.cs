using System;
using System.Collections.Generic;
using System.Text;

namespace Duy.FootballData.Models
{
    public class Fixtures
    {
        public TeamLinks _links { get; set; }
        public DateTime? timeFrameStart { get; set; }
        public DateTime? timeFrameEnd { get; set; }
        public int season { get; set; }
        public int count { get; set; }
        public IList<Fixture> fixtures { get; set; }
    }
}
