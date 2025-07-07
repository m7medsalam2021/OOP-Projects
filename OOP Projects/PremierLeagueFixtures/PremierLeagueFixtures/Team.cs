using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremierLeagueFixtures
{
    public  class Team
    {
        private int id;
        private string name;
        private string stadiumName;
        Match[] matcheList;

        public int Id 
        {
            get {  return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string StadiumName
        {
            get { return stadiumName; }
            set { stadiumName = value; }
        }
        public Match[] MatcheList
        {
            get { return matcheList; }
            set { matcheList = value; }
        }

        public Match this[int id]
        {
            get
            {
                for(int  i = 0; i < matcheList?.Length; i++)
                {
                    if (matcheList[i].MatchId == id)
                        return matcheList[i];
                }
                return new Match();
            }
        }

        public Match[] ShowAllMatchesOfTeam()
        {

            return matcheList ?? new Match[0];
        }
        public Match GetMatch(int id)
        {
            Match match = new Match();
            for(int i = 0; i < matcheList?.Length; i++)
            {
                if (matcheList[i].RoundNumber == id) 
                    return matcheList[i];

            }
            return new Match();
        }
    }
}
