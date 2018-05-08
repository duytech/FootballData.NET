using Duy.FootballData.App.Tools;
using System;

namespace Duy.FootballData.Tools
{
    class Program
    {
        static void Main(string[] args)
        {
            var converter = new LeagueCodeConverter();
            var codes = converter.ReadLeagueCodeTable("LeagueCodeTable.xml");
            Console.WriteLine(codes);
            Console.ReadLine();
        }
    }
}
