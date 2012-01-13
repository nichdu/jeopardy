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
    public partial class HowMuchForm : Form
    {
        private int _score;
        private bool _res;
        public int Score
        {
            get
            {
                return _score;
            }
        }
        public bool Result
        {
            get
            {
                return _res;
            }
        }

        public HowMuchForm()
        {
            InitializeComponent();
        }
        
        private void okButton_Click(object sender, EventArgs e)
        {
            try
            {
                _score = Convert.ToInt32(pointInput.Text);
                _res = true;
                this.Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("Bitte eine Zahl eingeben!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            _res = false;
            this.Close();
        }
    }
}
