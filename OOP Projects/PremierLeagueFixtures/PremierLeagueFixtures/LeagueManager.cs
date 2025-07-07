using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PremierLeagueFixtures
{
    public class LeagueManager
    {
        private List<Team> teams;
        private List<Match> matches;

        public List<Team> Teams { get => teams; set => teams = value; }
        public List<Match> Match { get => matches; set => matches = value; }
        public LeagueManager(List<Team> _teams, List<Match> _matches)
        {
            teams = _teams ?? new List<Team>();
            matches = _matches ?? new List<Match>();
        }
        public static List<Team> AddTeam(int size)
        {
            List<Team> teams = new List<Team>();
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Please Enter Name Of Team {i + 1}");
                string teamName = Console.ReadLine();

                Console.WriteLine($"Please Enter Stadium Name For {teamName}");
                string stadiumName = Console.ReadLine();

                Team team = new Team()
                {
                    Id = i + 1,
                    Name = teamName,
                    StadiumName = stadiumName,
                    MatcheList = new Match[0]
                };
                teams.Add(team);
            }
            return teams;
        }

        public void GenerateFixtures()
        {
            int matchId = 1;
            int roundNumber = 1;

            for (int i = 0; i < teams.Count; i++)
            {
                for (int j = i + 1; j < teams.Count; j++)
                {
                    Team homeTeam = teams[i];
                    Team awayTeam = teams[j];

                    // Match 1: homeTeam vs awayTeam (Home match)
                    Match firstMatch = new Match(matchId++, roundNumber++)
                    {
                        HomeTeam = homeTeam,
                        AwayTeam = awayTeam,
                        MatchPlace = MatchPlace.Home
                    };

                    // Match 2: awayTeam vs homeTeam (Return match)
                    Match secondMatch = new Match(matchId++, roundNumber++)
                    {
                        HomeTeam = awayTeam,
                        AwayTeam = homeTeam,
                        MatchPlace = MatchPlace.Away
                    };

                    // Add to global match list
                    matches.Add(firstMatch);
                    matches.Add(secondMatch);

                    // Add to each team
                    AddMatchToTeam(homeTeam, firstMatch);
                    AddMatchToTeam(awayTeam, secondMatch);
                }
            }
        }
        private void AddMatchToTeam(Team team, Match match)
        {
            var list = team.MatcheList?.ToList() ?? new List<Match>();
            list.Add(match);
            team.MatcheList = list.ToArray();
        }
        public void ScheduleMatchDates(DateTime startDate)
        {
            DateTime currentDate = startDate;

            foreach (var match in matches.OrderBy(m => m.RoundNumber))
            {
                while (currentDate.DayOfWeek != DayOfWeek.Friday && currentDate.DayOfWeek != DayOfWeek.Saturday)
                {
                    currentDate = currentDate.AddDays(1);
                }
                match.MatchDate = currentDate;
                currentDate = currentDate.AddDays(1);
            }
        }




    }
}
