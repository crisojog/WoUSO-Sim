using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulare_WoUSO
{
    class Game
    {
        public List<Series> series = new List<Series>();
        public List<Group> groups = new List<Group>();
        public List<Team> teams = new List<Team>();
        public List<Player> players = new List<Player>();
        public Random rnd;
        public int turn = 0;

        public Game()
        {
            int teamId = 0, groupId = 0, seriesId = 0;
            rnd = new Random(Guid.NewGuid().GetHashCode());
            series = new List<Series>();
            Player p;
            Team t = new Team();
            Group g = new Group();
            Series s = new Series();
            //Populate game
            for (int i = 0; i < Constants.playerNo; i++)
            {
                p = new Player(teamId, groupId, seriesId);
                players.Add(p);
                t.Add(p);
                p.teamId = t.id;
                p.groupId = g.id;
                p.seriesId = s.id;
                if (t.players.Count == Constants.playersPerTeam)
                {
                    teams.Add(t);
                    g.Add(t);
                    t = new Team();
                }
                if (g.teams.Count == Constants.teamsPerGroup)
                {
                    s.Add(g);
                    groups.Add(g);
                    g = new Group();
                }
                if (s.groups.Count == Constants.groupsPerSeries)
                {
                    series.Add(s);
                    s = new Series();
                }
            }
        }

        public void SimulateDay()
        {
            for (int i = 0; i < players.Count; i++)
            {
                Player o = ChooseOpponent(players[i], i);
                Challenge(players[i], o);
                DecreaseBlock(players[i]);
            }

            players.Sort(new Comparison<Player>((x, y) => x.score.CompareTo(y.score)));
            turn++;
        }

        private void Challenge(Player p, Player o)
        {
            p.score -= 30; o.score -= 30;
            double winner = rnd.NextDouble() * (p.form + o.form);
            if (winner <= p.form) // a castigat p
            {
                p.score += 80;
                p.form += (1 - p.form) * Constants.formIncrease;
                o.form -= o.form * Constants.formIncrease;
            }
            else
            {
                o.score += 80;
                o.form += (1 - o.form) * Constants.formIncrease;
                p.form -= p.form * Constants.formIncrease;
            }
            BlockPlayers(p, o);
        }

        private void BlockPlayers(Player p, Player o)
        {
            int diff = Math.Abs(p.score - o.score);
            if (10 < diff && diff <= 20)
            {
                p.blocked.Add(new KeyValuePair<Player, int>(o, 2));
                o.blocked.Add(new KeyValuePair<Player, int>(p, 2));
            }
            else if (20 < diff && diff <= 30)
            {
                p.blocked.Add(new KeyValuePair<Player, int>(o, 3));
                o.blocked.Add(new KeyValuePair<Player, int>(p, 3));
            }
            else if (30 < diff && diff <= 40)
            {
                p.blocked.Add(new KeyValuePair<Player, int>(o, 4));
                o.blocked.Add(new KeyValuePair<Player, int>(p, 4));
            }
            else if (40 < diff && diff <= 50)
            {
                p.blocked.Add(new KeyValuePair<Player, int>(o, 5));
                o.blocked.Add(new KeyValuePair<Player, int>(p, 5));
            }
            else if (50 < diff && diff <= 60)
            {
                p.blocked.Add(new KeyValuePair<Player, int>(o, 6));
                o.blocked.Add(new KeyValuePair<Player, int>(p, 6));
            }
            else
            {
                p.blocked.Add(new KeyValuePair<Player, int>(o, 7));
                o.blocked.Add(new KeyValuePair<Player, int>(p, 7));
            }
        }

        private void DecreaseBlock(Player p)
        {
            for (int i = 0; i < p.blocked.Count; i++)
            {
                if (p.blocked[i].Value == 1)
                    p.blocked.Remove(p.blocked[i]);
                else
                    p.blocked[i] = new KeyValuePair<Player,int>(p.blocked[i].Key, p.blocked[i].Value - 1);
            }
        }

        private Player ChooseOpponent(Player p, int index)
        {
            Player opp = null;

            int strat = p.strategy;
            if(turn < 10) strat = 2;
            switch (strat)
            {
                case 0: // caut numai de-aia cat mai slabi;
                    opp = players[players.Count - 1 - rnd.Next(players.Count / 3)];
                    while (opp == p || !p.CanChallenge(opp))
                    {
                        opp = players[players.Count - 1 - rnd.Next(players.Count / 3)];
                    }
                    break;
                case 1: // caut egali cu mine
                    for (int i = index + 1; i < players.Count; i++)
                    {
                        if (players[i] != p && p.CanChallenge(players[i]))
                        {
                            opp = players[i];
                            break;
                        }
                    }
                    if (opp == null)
                    {
                        for (int i = index - 1; i >= 0; i--)
                        {
                            if (players[i] != p && p.CanChallenge(players[i]))
                            {
                                opp = players[i];
                                break;
                            }
                        }
                    }
                    break;
                case 2: // totalmente random
                    opp = players[rnd.Next(players.Count)];
                    while (opp == p || !p.CanChallenge(opp))
                    {
                        opp = players[rnd.Next(players.Count)];
                    }
                    break;
                default:
                    break;
            }
            return opp;
        }
    }
}
