using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulare_WoUSO
{
    class Group
    {
        public int id;
        public List<Team> teams;
        public List<Player> players;
        public int score;

        public Group()
        {
            score = 0;
            id = currentId++;
            teams = new List<Team>();
            players = new List<Player>();
        }

        public void Add(Team t)
        {
            teams.Add(t);
            foreach (Player p in t.players)
            {
                players.Add(p);
            }
        }
        private static int currentId = 0;
    }
}
