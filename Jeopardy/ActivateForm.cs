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
    public partial class ActivateForm : Form
    {
        private int _cat;
        private int _val;
        public int Category
        {
            get
            {
                return _cat;
            }
        }
        public int Value
        {
            get
            {
                return _val;
            }
        }

        public ActivateForm()
        {
            InitializeComponent();
            catComboBox.Items.Add("Kategorie");
            valComboBox.Items.Add("Wert");
            for (int i = 1; i < 6; i++)
            {
                catComboBox.Items.Add(i.ToString());
                valComboBox.Items.Add((i * 100).ToString());
            }
            catComboBox.SelectedIndex = 0;
            valComboBox.SelectedIndex = 0;
            catComboBox.AutoCompleteMode = AutoCompleteMode.Append;
            valComboBox.AutoCompleteMode = AutoCompleteMode.Append;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            _cat = catComboBox.SelectedIndex;
            _val = (valComboBox.SelectedIndex) * 100;
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
