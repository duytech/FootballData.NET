using Duy.FootballData.Common;
using System;

namespace Duy.FootballData.Models
{
    public class TimeFrame
    {
        public TimeDirection TimeDirection  { get; set; }
        public int DayRange { get; set; }

        public override string ToString()
        {
            if (DayRange < 1 || DayRange > 99)
                throw new ArgumentOutOfRangeException("DayRange must be between 1 and 99.");

            var timeDirection = TimeDirection == TimeDirection.Next ? "n" : "p";
            
            return $"{timeDirection}{DayRange}";
        }
    }
}
