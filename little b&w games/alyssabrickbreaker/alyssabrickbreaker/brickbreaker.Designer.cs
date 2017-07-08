namespace alyssabrickbreaker
{
    partial class brickbreaker
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
            this.components = new System.ComponentModel.Container();
            this.gametime = new System.Windows.Forms.Timer(this.components);
            this.gameScreen = new System.Windows.Forms.PictureBox();
            this.lostLabel = new System.Windows.Forms.Label();
            this.againTimer = new System.Windows.Forms.Timer(this.components);
            this.againQuestion = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            this.byeLabel = new System.Windows.Forms.Label();
            this.closeTimer = new System.Windows.Forms.Timer(this.components);
            this.winLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gameScreen)).BeginInit();
            this.SuspendLayout();
            // 
            // gametime
            // 
            this.gametime.Enabled = true;
            this.gametime.Interval = 64;
            this.gametime.Tick += new System.EventHandler(this.gametime_Tick);
            // 
            // gameScreen
            // 
            this.gameScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameScreen.Location = new System.Drawing.Point(0, 0);
            this.gameScreen.Name = "gameScreen";
            this.gameScreen.Size = new System.Drawing.Size(343, 217);
            this.gameScreen.TabIndex = 0;
            this.gameScreen.TabStop = false;
            // 
            // lostLabel
            // 
            this.lostLabel.AutoSize = true;
            this.lostLabel.Font = new System.Drawing.Font("Andy", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lostLabel.ForeColor = System.Drawing.Color.White;
            this.lostLabel.Location = new System.Drawing.Point(87, 74);
            this.lostLabel.Name = "lostLabel";
            this.lostLabel.Size = new System.Drawing.Size(148, 21);
            this.lostLabel.TabIndex = 2;
            this.lostLabel.Text = "you ran out of lives";
            this.lostLabel.Visible = false;
            // 
            // againTimer
            // 
            this.againTimer.Interval = 2000;
            this.againTimer.Tick += new System.EventHandler(this.againTimer_Tick);
            // 
            // againQuestion
            // 
            this.againQuestion.AutoSize = true;
            this.againQuestion.Font = new System.Drawing.Font("Andy", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.againQuestion.ForeColor = System.Drawing.Color.White;
            this.againQuestion.Location = new System.Drawing.Point(62, 74);
            this.againQuestion.Name = "againQuestion";
            this.againQuestion.Size = new System.Drawing.Size(214, 21);
            this.againQuestion.TabIndex = 3;
            this.againQuestion.Text = "would you like to play again?";
            this.againQuestion.Visible = false;
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("Andy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.Location = new System.Drawing.Point(91, 102);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(138, 25);
            this.textBox.TabIndex = 4;
            this.textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox.Visible = false;
            this.textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            // 
            // byeLabel
            // 
            this.byeLabel.AutoSize = true;
            this.byeLabel.Font = new System.Drawing.Font("Andy", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.byeLabel.ForeColor = System.Drawing.Color.White;
            this.byeLabel.Location = new System.Drawing.Point(119, 90);
            this.byeLabel.Name = "byeLabel";
            this.byeLabel.Size = new System.Drawing.Size(84, 21);
            this.byeLabel.TabIndex = 5;
            this.byeLabel.Text = "okay byeee";
            this.byeLabel.Visible = false;
            // 
            // closeTimer
            // 
            this.closeTimer.Interval = 1000;
            this.closeTimer.Tick += new System.EventHandler(this.closeTimer_Tick);
            // 
            // winLabel
            // 
            this.winLabel.AutoSize = true;
            this.winLabel.Font = new System.Drawing.Font("Andy", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winLabel.ForeColor = System.Drawing.Color.White;
            this.winLabel.Location = new System.Drawing.Point(124, 89);
            this.winLabel.Name = "winLabel";
            this.winLabel.Size = new System.Drawing.Size(71, 21);
            this.winLabel.TabIndex = 6;
            this.winLabel.Text = "you won!";
            this.winLabel.Visible = false;
            // 
            // brickbreaker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(343, 217);
            this.Controls.Add(this.winLabel);
            this.Controls.Add(this.byeLabel);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.againQuestion);
            this.Controls.Add(this.lostLabel);
            this.Controls.Add(this.gameScreen);
            this.KeyPreview = true;
            this.Name = "brickbreaker";
            this.Text = "brick breaker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.brickbreaker_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.gameScreen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer gametime;
        private System.Windows.Forms.PictureBox gameScreen;
        private System.Windows.Forms.Label lostLabel;
        private System.Windows.Forms.Timer againTimer;
        private System.Windows.Forms.Label againQuestion;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label byeLabel;
        private System.Windows.Forms.Timer closeTimer;
        private System.Windows.Forms.Label winLabel;
    }
}

