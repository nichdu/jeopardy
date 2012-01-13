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
    public partial class QuestionWindow : Form
    {
        private System.Media.SoundPlayer player;
        private Enums.AnswerType _atype;
        private string _content;
        private bool _keyAlreadyPressed;
        private MainForm _par;
        private int _curPlayer;
        private int _value;
        private int _cat;
        private System.Media.SoundPlayer _bgplayer;

        public QuestionWindow(Enums.AnswerType atype, string content, string question, int value, int cat)
        {
            InitializeComponent();
            Console.WriteLine("Frage: " + question);
            _atype = atype;
            _content = content;
            _value = value;
            _cat = cat;
            _curPlayer = -1;
            if (_atype == Enums.AnswerType.Text)
            {
                answerLabel.Text = _content;
                answerLabel.Show();
                bgMusic();
            }
            else if (_atype == Enums.AnswerType.Image)
            {
                answerImage.Load(_content);
                if (answerImage.Image.Size.Width > answerImage.Size.Width
                    || answerImage.Image.Size.Height > answerImage.Size.Height)
                {
                    answerImage.SizeMode = PictureBoxSizeMode.Zoom;
                }
                else
                {
                    answerImage.SizeMode = PictureBoxSizeMode.CenterImage;
                }
                answerImage.Show();
                bgMusic();
            }
            else if (_atype == Enums.AnswerType.Audio)
            {
                playSound(_content);
                answerLabel.Text = "Zuhören!";
                answerLabel.Show();
            }
        }

        private void bgMusic()
        {
            _bgplayer = new System.Media.SoundPlayer(@"C:\Users\Tjark\Dropbox\Bezirksjugendtreffen 2012\Abendprogramm\bgmusic-loop.wav");
            Random rnd = new Random();
            if (rnd.Next(2) == 1)
            {
                _bgplayer.PlayLooping();
            }
        }

        private void playSound(string path)
        {
            player = new System.Media.SoundPlayer();
            player.SoundLocation = path;
            player.Load();
            player.Play();
        }

        private void QuestionWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (player != null)
            {
                player.Stop();
            }
            if (_bgplayer != null)
            {
                _bgplayer.Stop();
            }
        }

        private void QuestionWindow_KeyDown(object sender, KeyEventArgs e)
        {;
            if (!_keyAlreadyPressed)
            {
                if (e.KeyCode == Keys.H)
                {
                    // Spieler 1
                    playerAlert(0);
                }
                else if (e.KeyCode == Keys.L)
                {
                    // Spieler 2
                    playerAlert(1);
                }
                else if (e.KeyCode == Keys.Oem7)
                {
                    // Spieler 3
                    playerAlert(2);
                }
            }
            else
            {
                if (e.KeyCode == Keys.C)
                {
                    _par.updateScore(_curPlayer, _value);
                    _par.questionAnswered(_cat, _value, _curPlayer);
                    Console.WriteLine("Correct answer: " + _par.GetPlayerName(_curPlayer) + ": " + _value + "");
                    this.Close();
                }
                else if (e.KeyCode == Keys.V)
                {
                    _par.updateScore(_curPlayer, -_value);
                    _keyAlreadyPressed = false;
                    alertLabel.Hide();
                    Console.WriteLine("Wrong answer: " + _par.GetPlayerName(_curPlayer) + ": -" + _value + "");
                    _curPlayer = -1;
                    if (player != null)
                    {
                        player.Play();
                    }
                }
            }
            if (e.KeyCode == Keys.X)
            {
                _par.questionAnswered(_cat, _value, -1);
                Console.WriteLine("No correct answer.");
                this.Close();
            }
        }

        private void playerAlert(int p)
        {
            switch (p)
            {
                case 0:
                    alertLabel.BackColor = Color.Red;
                    break;
                case 1:
                    alertLabel.BackColor = Color.Lime;
                    break;
                case 2:
                    alertLabel.BackColor = Color.DeepSkyBlue;
                    break;
            }
            if (player != null)
            {
                player.Stop();
            }
            alertLabel.Text = _par.GetPlayerName(p);
            Console.WriteLine("Player Alert: " + _par.GetPlayerName(p) + "");
            _curPlayer = p;
            alertLabel.Show();
            _keyAlreadyPressed = true;
        }

        private void QuestionWindow_Shown(object sender, EventArgs e)
        {
            _par = this.Owner as MainForm;
        }
    }
}
