namespace Jeopardy
{
    partial class nameForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.okButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tPlayer1Name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tPlayer2Name = new System.Windows.Forms.TextBox();
            this.tPlayer3Name = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(214, 89);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 4;
            this.okButton.Text = "OK\r\n";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Spieler 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Spieler 2";
            // 
            // tPlayer1Name
            // 
            this.tPlayer1Name.Location = new System.Drawing.Point(66, 6);
            this.tPlayer1Name.Name = "tPlayer1Name";
            this.tPlayer1Name.Size = new System.Drawing.Size(223, 20);
            this.tPlayer1Name.TabIndex = 1;
            this.tPlayer1Name.Text = "Foo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Spieler 3";
            // 
            // tPlayer2Name
            // 
            this.tPlayer2Name.Location = new System.Drawing.Point(66, 32);
            this.tPlayer2Name.Name = "tPlayer2Name";
            this.tPlayer2Name.Size = new System.Drawing.Size(223, 20);
            this.tPlayer2Name.TabIndex = 2;
            this.tPlayer2Name.Text = "Bar";
            // 
            // tPlayer3Name
            // 
            this.tPlayer3Name.Location = new System.Drawing.Point(66, 58);
            this.tPlayer3Name.Name = "tPlayer3Name";
            this.tPlayer3Name.Size = new System.Drawing.Size(223, 20);
            this.tPlayer3Name.TabIndex = 3;
            this.tPlayer3Name.Text = "Baz";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(133, 89);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 20;
            this.cancelButton.Text = "Abbrechen";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // nameForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(301, 124);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.tPlayer3Name);
            this.Controls.Add(this.tPlayer2Name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tPlayer1Name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.okButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "nameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Namen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox tPlayer1Name;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox tPlayer2Name;
        public System.Windows.Forms.TextBox tPlayer3Name;
        private System.Windows.Forms.Button cancelButton;
    }
}