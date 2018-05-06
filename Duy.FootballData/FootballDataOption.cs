using Duy.FootballData.Models;

namespace Duy.FootballData.Client
{
    public class FootballDataOption
    {
        public string Token { get; set; }
        public ResponseControl ResponseControl { get; set; }
        public string BaseUrl { get; set; }
    }
}