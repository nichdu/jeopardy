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
    public partial class MainForm : Form
    {
        /* Real programmers don't document. If it was hard to write, it should be hard to understand. */

        // Players
        private Player[] _players;

        // Jeopardy Game
        private JeopardyGame game;

        private Button[] _btns;

        private Color[] _clrs;

        private Color _defaultButtonColor;

        public MainForm(string jgPath, string player0Name, string player1Name, string player2Name)
        {
            constr(jgPath, player0Name, player1Name, player2Name);
        }

        public MainForm(string jgPath)
        {
            using (var form = new nameForm())
            {
                form.ShowDialog();
                constr(jgPath, form.player1Name, form.player2Name, form.player3Name);
            }
        }

        private void constr(string jgPath, string player0Name, string player1Name, string player2Name)
        {
            InitializeComponent();
            game = JeopardyGame.GetInstance(jgPath);
            this.updateCategories();
            _players = new Player[3];
            _players[0] = new Player(player0Name, Color.Red);
            _players[1] = new Player(player1Name, Color.Lime);
            _players[2] = new Player(player2Name, Color.DeepSkyBlue);
            this.updatePlayerNames();
            this.resetScore();
            iterateButtons();
            _defaultButtonColor = cat1_100.BackColor;
        }

        private void iterateButtons()
        {
            _btns = new Button[25];
            ushort i = 0;
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl.Name.Substring(0, 3) == "cat" && ctrl.Name.Substring(3, 1) != "e")
                {
                    _btns[i] = ctrl as Button;
                    i++;
                }
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
            this.lPlayer1Name.Text = _players[0].GetName();
            this.lPlayer2Name.Text = _players[1].GetName();
            this.lPlayer3Name.Text = _players[2].GetName();
        }

        private void resetScore()
        {
            this.setPlayerScore(0, 0);
            this.setPlayerScore(1, 0);
            this.setPlayerScore(2, 0);
        }

        private void setPlayerScore(int player, int score)
        {
            _players[player].setScore(score);
            this.updatePlayerScores();
        }

        private void addPlayerScore(int player, int score)
        {
            _players[player].addScore(score);
            this.updatePlayerScores();
        }

        private void updatePlayerScores()
        {
            this.lPlayer1Score.Text = _players[0].GetScore().ToString("G");
            this.lPlayer2Score.Text = _players[1].GetScore().ToString();
            this.lPlayer3Score.Text = _players[2].GetScore().ToString();
        }

        private bool checkGameCompleted()
        {
            foreach (Button btn in _btns)
            {
                if (btn.Enabled)
                {
                    return false;
                }
            }
            return true;
        }

        private void doFinishingStuff()
        {
            _clrs = null;
            if (checkGameCompleted())
            {
                using (var form = new FinishForm())
                {
                    form.ShowDialog(this);
                }
            }
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int category = Convert.ToInt32(btn.Name.Substring(3, 1)) - 1;
            int question = Convert.ToInt32(btn.Name.Substring(5, 1)) - 1;
            Question q = game.getQuestion(category, question);
            using (var form = new QuestionWindow(q.AnswerType(), q.GetContent(), q.GetQuestion(), (question+1)*100, category))
            {
                form.ShowDialog(this);
            }
            doFinishingStuff();
        }

        public void questionAnswered(int cat, int q, int player)
        {
            cat = ++cat;
            foreach (Control child in this.Controls)
            {
                if (child.Name == "cat" + cat + "_" + q)
                {
                    child.Enabled = false;
                    if (player >= 0)
                    {
                        child.BackColor = _players[player].GetColor();
                    }
                    else
                    {
                        child.BackColor = Color.Gray;
                    }
                }
            }
        }

        public void updateScore(int player, int score)
        {
            this.addPlayerScore(player, score);
        }

        public string GetPlayerName(int p)
        {
            return _players[p].GetName();
        }

        public string[] getNames()
        {
            _clrs = new Color[3];
            string[] names = new string[3];
            if (_players[0].GetScore() > _players[1].GetScore())
            {
                // Spieler 0 hat mehr Punkte als Spieler 1
                if (_players[2].GetScore() > _players[0].GetScore())
                {
                    // Spieler 2 hat die meisten Punkte, die anderen beiden ergeben sich aus dem ersten if
                    names[0] = _players[2].GetName();
                    names[1] = _players[0].GetName();
                    names[2] = _players[1].GetName();

                    _clrs[0] = _players[2].GetColor();
                    _clrs[1] = _players[0].GetColor();
                    _clrs[2] = _players[1].GetColor();
                }
                else
                {
                    // Spieler 0 hat die meisten Punkte
                    names[0] = _players[0].GetName();
                    _clrs[0] = _players[0].GetColor();
                    if (_players[1].GetScore() > _players[2].GetScore())
                    {
                        // Spieler 1 ist 2., Spieler 2 3.
                        names[1] = _players[1].GetName();
                        names[2] = _players[2].GetName();

                        _clrs[1] = _players[1].GetColor();
                        _clrs[2] = _players[2].GetColor();
                    }
                    else
                    {
                        // Spieler 2 ist 2., Spieler 1 3.
                        names[1] = _players[2].GetName();
                        names[2] = _players[1].GetName();

                        _clrs[1] = _players[2].GetColor();
                        _clrs[2] = _players[1].GetColor();
                    }
                }
            }
            else
            {
                // Spieler 1 hat mehr Punkte als Spieler 0
                if (_players[2].GetScore() > _players[1].GetScore())
                {
                    // Spieler 2 hat die meisten Punkte, die anderen beiden ergeben sich aus dem ersten if
                    names[0] = _players[2].GetName();
                    names[1] = _players[1].GetName();
                    names[2] = _players[0].GetName();

                    _clrs[0] = _players[2].GetColor();
                    _clrs[1] = _players[1].GetColor();
                    _clrs[2] = _players[0].GetColor();
                }
                else
                {
                    // Spieler 1 hat die meisten Punkte
                    names[0] = _players[1].GetName();
                    _clrs[0] = _players[1].GetColor();
                    if (_players[0].GetScore() > _players[2].GetScore())
                    {
                        // Spieler 0 ist 2., Spieler 2 3.
                        names[1] = _players[0].GetName();
                        names[2] = _players[2].GetName();

                        _clrs[1] = _players[0].GetColor();
                        _clrs[2] = _players[2].GetColor();
                    }
                    else
                    {
                        // Spieler 2 ist 2., Spieler 0 3.
                        names[1] = _players[2].GetName();
                        names[2] = _players[0].GetName();

                        _clrs[1] = _players[2].GetColor();
                        _clrs[2] = _players[0].GetColor();
                    }
                }
            }
            return names;
        }

        public Color[] getColors()
        {
            if (_clrs == null)
            {
                throw new Exception("Es muss zuerst GetNames() aufgerufen werden.");
            }
            return _clrs;
        }

        public int[] getScores()
        {
            int[] scores = new int[3];
            for (int i = 0; i < 4; ++i)
            {
                try
                {
                    scores[i] = _players[i].GetScore();
                }
                catch
                {

                }
            }
            Array.Sort(scores);
            Array.Reverse(scores);
            return scores;
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            Screen[] screens = Screen.AllScreens;

            if (screens.Length != 1)
            {
                // There are multiple monitors.
                foreach (Screen scr in screens)
                {
                    if (!scr.Primary)
                    {
                        // This is not the primary monitor.
                        this.Location = scr.Bounds.Location;
                        break;
                    }
                }
            }
        }

        private void MainForm_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
              //  Application.Exit();
                contextMenu.Show();
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Wirklich beenden?", "Jeopardy", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                e.Cancel = true;
            }
            Console.WriteLine("Bye!");
        }

        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void spielerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = sender as ToolStripMenuItem;
            int plyr = Convert.ToInt32(item.Name.Substring(7, 1));
            if (plyr < 0 && plyr > 2)
            {
                return;
            }

            using (HowMuchForm hmf = new HowMuchForm())
            {
                hmf.ShowDialog();
                if (hmf.Result)
                {
                    this.updateScore(plyr, hmf.Score);
                }
            }
        }

        private void aktivierenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ActivateForm af = new ActivateForm())
            {
                af.ShowDialog();
                int cat = af.Category;
                int val = af.Value;
                foreach (Control child in this.Controls)
                {
                    if (child.Name == "cat" + cat + "_" + val)
                    {
                        child.Enabled = true;
                        Button btn = child as Button;
                        btn.UseVisualStyleBackColor = true;
                    }
                }
            }
        }

        private void spielBeendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var form = new FinishForm())
            {
                form.ShowDialog(this);
            }
        }
    }
}
