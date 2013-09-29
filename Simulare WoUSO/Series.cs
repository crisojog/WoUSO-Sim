using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulare_WoUSO
{
    class Series
    {   
        public int id;
        public List<Group> groups;
        public List<Team> teams;
        public List<Player> players;
        public int score;

        public Series()
        {
            score = 0;
            id = currentId++;
            groups = new List<Group>();
            teams = new List<Team>();
            players = new List<Player>();
        }

        public void Add(Group g)
        {
            groups.Add(g);
            foreach (Team t in g.teams)
            {
                teams.Add(t);
                foreach (Player p in t.players)
                {
                    players.Add(p);
                }
            }
        }

        private static int currentId = 0;
    }
}
