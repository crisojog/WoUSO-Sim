using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulare_WoUSO
{
    public partial class Form1 : Form
    {
        Game game;
        List<String> infoTexts = new List<String>();

        public Form1()
        {
            InitializeComponent();
            playerList.Height = this.Height - 80;

            game = new Game();

            UpdatePlayerList();

            this.InitInfoTexts();

            infoLabel.Text = infoTexts[0];          
        }

        void simDay_Click(object sender, System.EventArgs e)
        {
            game.SimulateDay();
            UpdatePlayerList();
            dayWeekLabel.Text = "Day: " + game.turn + "     Week: " + game.turn / 7;
        }

        void Form1_Resize(object sender, System.EventArgs e)
        {
            playerList.Height = this.Height - 80;
        }

        private void UpdatePlayerList()
        {
            playerList.Text = "";
            String classings = "";
            for (int i = game.players.Count - 1; i >= 0; i--)
            {
                Player p = game.players[i];
                classings = p.id + "\t" + p.score + "\t" + p.strategy + "\t" + p.form + "\n";
                playerList.Text += classings;
            }
            playerList.Refresh();
        }

        private void simWeek_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 7; i++)
            {
                game.SimulateDay();
                UpdatePlayerList();
                dayWeekLabel.Text = "Day: " + game.turn + "     Week: " + game.turn / 7;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void InitInfoTexts()
        {
            infoTexts.Add("Hover over each label for more info");
            infoTexts.Add("Each student is identified by an unique ID");
            infoTexts.Add("This bit is pretty self explanatory");
            infoTexts.Add("Strategy used: \n0 - chooses players from the bottom of the table; \n1 - chooses equally matched players; \n2 - chooses randomly");
            infoTexts.Add("Form: the greater it is, the more chances the player has of winning. \nIncreases after win, decreases after loss");
        }

        void label_MouseLeave(object sender, System.EventArgs e)
        {
            infoLabel.Text = infoTexts[0];
        }

        void idLabel_MouseHover(object sender, System.EventArgs e)
        {
            infoLabel.Text = infoTexts[1];
        }

        void scoreLabel_MouseHover(object sender, System.EventArgs e)
        {
            infoLabel.Text = infoTexts[2];
        }

        private void strategyLabel_MouseHover(object sender, System.EventArgs e)
        {
            infoLabel.Text = infoTexts[3];
        }

        private void formLabel_MouseHover(object sender, System.EventArgs e)
        {
            infoLabel.Text = infoTexts[4];
        }
    }
}
