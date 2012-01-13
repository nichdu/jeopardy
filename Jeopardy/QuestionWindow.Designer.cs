namespace Jeopardy
{
    partial class QuestionWindow
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
            this.answerLabel = new System.Windows.Forms.Label();
            this.answerImage = new System.Windows.Forms.PictureBox();
            this.alertLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.answerImage)).BeginInit();
            this.SuspendLayout();
            // 
            // answerLabel
            // 
            this.answerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerLabel.Location = new System.Drawing.Point(12, 34);
            this.answerLabel.Name = "answerLabel";
            this.answerLabel.Size = new System.Drawing.Size(1000, 700);
            this.answerLabel.TabIndex = 0;
            this.answerLabel.Text = "label1";
            this.answerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.answerLabel.Visible = false;
            // 
            // answerImage
            // 
            this.answerImage.Location = new System.Drawing.Point(12, 34);
            this.answerImage.Name = "answerImage";
            this.answerImage.Size = new System.Drawing.Size(1000, 700);
            this.answerImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.answerImage.TabIndex = 1;
            this.answerImage.TabStop = false;
            this.answerImage.Visible = false;
            // 
            // alertLabel
            // 
            this.alertLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alertLabel.Location = new System.Drawing.Point(812, 709);
            this.alertLabel.Name = "alertLabel";
            this.alertLabel.Size = new System.Drawing.Size(200, 50);
            this.alertLabel.TabIndex = 2;
            this.alertLabel.Text = "Foo";
            this.alertLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.alertLabel.Visible = false;
            // 
            // QuestionWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.alertLabel);
            this.Controls.Add(this.answerImage);
            this.Controls.Add(this.answerLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "QuestionWindow";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuestionWindow";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QuestionWindow_FormClosing);
            this.Shown += new System.EventHandler(this.QuestionWindow_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.QuestionWindow_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.answerImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label answerLabel;
        private System.Windows.Forms.PictureBox answerImage;
        private System.Windows.Forms.Label alertLabel;
    }
}