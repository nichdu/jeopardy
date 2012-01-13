namespace Jeopardy
{
    partial class FinishForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinishForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lWinnerName = new System.Windows.Forms.Label();
            this.lWinnerScore = new System.Windows.Forms.Label();
            this.l2ndName = new System.Windows.Forms.Label();
            this.l3rdName = new System.Windows.Forms.Label();
            this.l2ndScore = new System.Windows.Forms.Label();
            this.l3rdScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 267);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lWinnerName
            // 
            this.lWinnerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lWinnerName.Location = new System.Drawing.Point(12, 290);
            this.lWinnerName.Name = "lWinnerName";
            this.lWinnerName.Size = new System.Drawing.Size(400, 41);
            this.lWinnerName.TabIndex = 1;
            this.lWinnerName.Text = "Winner";
            this.lWinnerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lWinnerScore
            // 
            this.lWinnerScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lWinnerScore.Location = new System.Drawing.Point(12, 331);
            this.lWinnerScore.Name = "lWinnerScore";
            this.lWinnerScore.Size = new System.Drawing.Size(400, 41);
            this.lWinnerScore.TabIndex = 2;
            this.lWinnerScore.Text = "1337";
            this.lWinnerScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // l2ndName
            // 
            this.l2ndName.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l2ndName.Location = new System.Drawing.Point(12, 382);
            this.l2ndName.Name = "l2ndName";
            this.l2ndName.Size = new System.Drawing.Size(300, 41);
            this.l2ndName.TabIndex = 3;
            this.l2ndName.Text = "2nd";
            this.l2ndName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // l3rdName
            // 
            this.l3rdName.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l3rdName.Location = new System.Drawing.Point(12, 433);
            this.l3rdName.Name = "l3rdName";
            this.l3rdName.Size = new System.Drawing.Size(300, 41);
            this.l3rdName.TabIndex = 4;
            this.l3rdName.Text = "3rd";
            this.l3rdName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // l2ndScore
            // 
            this.l2ndScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l2ndScore.Location = new System.Drawing.Point(312, 382);
            this.l2ndScore.Name = "l2ndScore";
            this.l2ndScore.Size = new System.Drawing.Size(100, 41);
            this.l2ndScore.TabIndex = 5;
            this.l2ndScore.Text = "1336";
            this.l2ndScore.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // l3rdScore
            // 
            this.l3rdScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l3rdScore.Location = new System.Drawing.Point(312, 433);
            this.l3rdScore.Name = "l3rdScore";
            this.l3rdScore.Size = new System.Drawing.Size(100, 41);
            this.l3rdScore.TabIndex = 6;
            this.l3rdScore.Text = "1335";
            this.l3rdScore.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FinishForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 490);
            this.ControlBox = false;
            this.Controls.Add(this.l3rdScore);
            this.Controls.Add(this.l2ndScore);
            this.Controls.Add(this.l3rdName);
            this.Controls.Add(this.l2ndName);
            this.Controls.Add(this.lWinnerScore);
            this.Controls.Add(this.lWinnerName);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FinishForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ende";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FinishForm_FormClosed);
            this.Shown += new System.EventHandler(this.FinishForm_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FinishForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lWinnerName;
        private System.Windows.Forms.Label lWinnerScore;
        private System.Windows.Forms.Label l2ndName;
        private System.Windows.Forms.Label l3rdName;
        private System.Windows.Forms.Label l2ndScore;
        private System.Windows.Forms.Label l3rdScore;
    }
}