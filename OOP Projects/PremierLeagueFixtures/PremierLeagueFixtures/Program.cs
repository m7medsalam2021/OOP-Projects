using PremierLeagueFixtures;

Console.WriteLine("Welcome to Premier League Fixtures Generator!\n");

int teamCount;
do
{
    Console.Write("Enter number of teams (min 2): ");
} while (!int.TryParse(Console.ReadLine(), out teamCount) || teamCount < 2);

List<Team> teams = LeagueManager.AddTeam(teamCount);

LeagueManager manager = new LeagueManager(teams, new List<Match>());

manager.GenerateFixtures();

DateTime start = new DateTime(2025, 8, 1);
manager.ScheduleMatchDates(start);

Console.WriteLine("\nFixtures generated successfully!\n");
foreach (var team in manager.Teams)
{
    Console.WriteLine($"--- Matches for {team.Name} ---");

    foreach (var match in team.MatcheList)
    {
        string home = match.HomeTeam.Name;
        string away = match.AwayTeam.Name;
        string place = match.MatchPlace.ToString();
        string date = match.MatchDate.ToString("dd/MM/yyyy");

        Console.WriteLine($"Round {match.RoundNumber}: {home} vs {away} ({place}) on {date}");
    }

    Console.WriteLine();
}


Console.WriteLine("Press any key to exit...");
Console.ReadKey();