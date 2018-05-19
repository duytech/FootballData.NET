using System.Collections.Generic;

namespace Duy.FootballData.Models
{
    public class Players
    {
        public TeamLinks _links { get; set; }
        public int count { get; set; }
        public IList<Player> players { get; set; }
    }
}
