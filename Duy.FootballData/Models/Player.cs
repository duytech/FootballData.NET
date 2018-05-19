using System;

namespace Duy.FootballData.Models
{
    public class Player
    {
        public string name { get; set; }
        public string position { get; set; }
        public int? jerseyNumber { get; set; }
        public DateTime dateOfBirth { get; set; }
        public string nationality { get; set; }
        public DateTime? contractUntil { get; set; }
        public string marketValue { get; set; }
    }
}
