using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulare_WoUSO
{
    class Player
    {
        public int id;
        public int score;
        public int teamId;
        public int groupId;
        public int seriesId;
        public double form;
        public int strategy;
        public List<KeyValuePair<Player, int>> blocked;
        public static Random rnd = new Random();

        public Player(int _teamId, int _groupId, int _seriesId)
        {
            id = currentId++;
            teamId = _teamId;
            groupId = _groupId;
            seriesId = _seriesId;
            score = Constants.initialScore;
            form = 0.5;

            strategy = rnd.Next(3);
            blocked = new List<KeyValuePair<Player, int>>();
        }

        private static int currentId = 0;

        public bool CanChallenge(Player player)
        {
            for (int i = 0; i < blocked.Count; i++)
            {
                if (player.id == blocked[i].Key.id)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
