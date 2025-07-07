using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremierLeagueFixtures
{
    public enum MatchPlace
    {
        Home = 1,
        Away
    }
    public class Match
    {

        private int matchId;
        private int roundNumber;
        public Team homeTeam { get; set; }
        public Team awayTeam { get; set; }
        public MatchPlace MatchPlace { get; set; }

        public int RoundNumber { get => roundNumber; set => roundNumber = value; }
        public int MatchId { get => matchId; set => matchId = value; }
        public Team HomeTeam { get => homeTeam; set => homeTeam = value; }
        public Team AwayTeam { get => awayTeam; set => awayTeam = value; }
        public DateTime MatchDate { get; set; }

        public Match(int _matchId, int _roundNumber)
        {
            MatchId = _matchId;
            RoundNumber = _roundNumber;
        }
        public Match()
        {
            
        }
    }
}
