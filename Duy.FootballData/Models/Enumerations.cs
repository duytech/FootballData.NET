using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duy.FootballData.Models
{
    public enum ResponseControl
    {
        full,
        minified,
        compressed
    }

    public enum Venue
    {
        home,
        away
    }

    public enum LeagueCode
    {
        /// <summary>
        /// 1. Bundesliga
        /// </summary>
        BL1,
        /// <summary>
        /// 2. Bundesliga
        /// </summary>
        BL2
    }
}
