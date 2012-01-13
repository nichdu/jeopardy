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
    public partial class FinishForm : Form
    {
        private string[] _names;
        private int[] _scores;
        private MainForm _ownr;
        private Color[] _clrs;

        public FinishForm()
        {
            InitializeComponent();
            pictureBox1.Load(@"C:\Users\Tjark\Dropbox\Bezirksjugendtreffen 2012\Abendprogramm\feuerwerk.jpg");
        }

        private void FinishForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Application.Exit();
            }
        }

        private void FinishForm_Shown(object sender, EventArgs e)
        {
            _ownr = this.Owner as MainForm;
            _names = _ownr.getNames();
            _scores = _ownr.getScores();
            _clrs = _ownr.getColors();
            this.updateDisplay();
        }

        private void updateDisplay()
        {
            lWinnerName.Text = _names[0];
            lWinnerName.BackColor = _clrs[0];
            lWinnerScore.Text = _scores[0].ToString();
            lWinnerScore.BackColor = _clrs[0];
            Console.WriteLine("1. " + _names[0] + " Punkte: " + _scores[0].ToString());

            l2ndName.Text = _names[1];
            l2ndName.BackColor = _clrs[1];
            l2ndScore.Text = _scores[1].ToString();
            l2ndScore.BackColor = _clrs[1];
            Console.WriteLine("2. " + _names[1] + " Punkte: " + _scores[1].ToString());

            l3rdName.Text = _names[2];
            l3rdName.BackColor = _clrs[2];
            l3rdScore.Text = _scores[2].ToString();
            l3rdScore.BackColor = _clrs[2];
            Console.WriteLine("3. " + _names[2] + " Punkte: " + _scores[2].ToString());
        }

        private void FinishForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
