using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Jeopardy
{
    public partial class Form1 : Form
    {
        // Player names
        private string player1Name;
        private string player2Name;
        private string player3Name;

        // Player scores
        private int[] Scores;

        // Jeopardy Game
        private JeopardyGame game;


        public Form1(string jgPath)
        {
            InitializeComponent();
            if (Screen.AllScreens.Length >= 2)
            {
                MessageBox.Show("Es sind mindestens 2 Bildschirme angeschlossen.");
            }
            game = new JeopardyGame(jgPath);
            this.updateCategories();
            using (var form = new nameForm())
            {
                form.ShowDialog();
                player1Name = form.player1Name;
                player2Name = form.player2Name;
                player3Name = form.player3Name;
                this.Scores = new int[4];
                this.updatePlayerNames();
                this.resetScore();
            }
        }

        private void updateCategories()
        {
            this.category1Label.Text = game.GetCategoryName(0);
            this.category2Label.Text = game.GetCategoryName(1);
            this.category3Label.Text = game.GetCategoryName(2);
            this.category4Label.Text = game.GetCategoryName(3);
            this.category5Label.Text = game.GetCategoryName(4);
        }

        private void updatePlayerNames()
        {
            this.lPlayer1Name.Text = this.player1Name;
            this.lPlayer2Name.Text = this.player2Name;
            this.lPlayer3Name.Text = this.player3Name;
        }

        private void resetScore()
        {
            this.setPlayerScore(1, 0);
            this.setPlayerScore(2, 0);
            this.setPlayerScore(3, 0);
        }

        private void setPlayerScore(int player, int score)
        {
            Scores[player] = score;
            this.updatePlayerScores();
        }

        private void updatePlayerScores()
        {
            this.lPlayer1Score.Text = Scores[1].ToString();
            this.lPlayer2Score.Text = Scores[2].ToString();
            this.lPlayer3Score.Text = Scores[3].ToString();
        }

        private void playerAddScore(int player, int score)
        {
            this.Scores[player] += score;
            this.updatePlayerScores();
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
