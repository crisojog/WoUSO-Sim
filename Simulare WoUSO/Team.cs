using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulare_WoUSO
{
    class Team
    {
        public int score;
        public int id;
        public List<Player> players;

        public Team()
        {
            score = 0;
            id = currentId++;
            players = new List<Player>();
        }

        public void Add(Player p)
        {
            players.Add(p);
        }

        private static int currentId = 0;
    }
}
