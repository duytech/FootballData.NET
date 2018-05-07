# FootballData.NET
A client for football-data.org

## Install
NuGet Package
```
PM> Install-Package Duy.FootballData.Client -Version 1.1.0
```
https://www.nuget.org/packages/Duy.FootballData.Client/

## Usage
Football API documentation
http://api.football-data.org/documentation

## Example
```
var option = new FootballDataOption
{
	ApiKey = string.Empty,
	ResponseControl = ResponseControl.full,
	BaseUrl = "http://api.football-data.org/v1/"
};
IFootballDataClient client = new FootballDataClient(option);

var competition = await client.GetCompetitions(2017);
Console.WriteLine(JsonConvert.SerializeObject(competition, Formatting.Indented));

var fixture = await client.GetFixture(146773, 5);
Console.WriteLine(JsonConvert.SerializeObject(fixture, Formatting.Indented));

var leagueTable = await client.GetLeagueTable(445, 1);
Console.WriteLine(JsonConvert.SerializeObject(leagueTable, Formatting.Indented));

var fixtureTeam = await client.GetFixturesForTeam(66, 2017, "n10", Venue.home);
Console.WriteLine(JsonConvert.SerializeObject(fixtureTeam, Formatting.Indented));

var liverpoolPlayers = await client.GetPlayers(64);
Console.WriteLine(JsonConvert.SerializeObject(liverpoolPlayers, Formatting.Indented));
```