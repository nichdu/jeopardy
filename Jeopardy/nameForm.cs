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
    public partial class nameForm : Form
    {
        public string player1Name {get;set;}
        public string player2Name {get;set;}
        public string player3Name { get; set; }

        public nameForm()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.player1Name = tPlayer1Name.Text;
            this.player2Name = tPlayer2Name.Text;
            this.player3Name = tPlayer3Name.Text;
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
