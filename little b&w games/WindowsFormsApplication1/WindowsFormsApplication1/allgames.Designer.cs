namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.hangmanButton = new System.Windows.Forms.Button();
            this.brickbreakerButton = new System.Windows.Forms.Button();
            this.movingSkyTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // hangmanButton
            // 
            this.hangmanButton.BackColor = System.Drawing.Color.White;
            this.hangmanButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.hangmanButton.Font = new System.Drawing.Font("Andy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hangmanButton.ForeColor = System.Drawing.Color.Black;
            this.hangmanButton.Location = new System.Drawing.Point(257, 12);
            this.hangmanButton.Name = "hangmanButton";
            this.hangmanButton.Size = new System.Drawing.Size(97, 26);
            this.hangmanButton.TabIndex = 0;
            this.hangmanButton.Text = "hangman";
            this.hangmanButton.UseVisualStyleBackColor = false;
            this.hangmanButton.Click += new System.EventHandler(this.hangmanButton_Click);
            // 
            // brickbreakerButton
            // 
            this.brickbreakerButton.BackColor = System.Drawing.Color.White;
            this.brickbreakerButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.brickbreakerButton.Font = new System.Drawing.Font("Andy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brickbreakerButton.ForeColor = System.Drawing.Color.Black;
            this.brickbreakerButton.Location = new System.Drawing.Point(257, 44);
            this.brickbreakerButton.Name = "brickbreakerButton";
            this.brickbreakerButton.Size = new System.Drawing.Size(97, 26);
            this.brickbreakerButton.TabIndex = 1;
            this.brickbreakerButton.Text = "brick breaker";
            this.brickbreakerButton.UseVisualStyleBackColor = false;
            this.brickbreakerButton.Click += new System.EventHandler(this.brickbreakerButton_Click);
            // 
            // movingSkyTimer
            // 
            this.movingSkyTimer.Enabled = true;
            this.movingSkyTimer.Interval = 50;
            this.movingSkyTimer.Tick += new System.EventHandler(this.movingSkyTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(657, 328);
            this.Controls.Add(this.brickbreakerButton);
            this.Controls.Add(this.hangmanButton);
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button hangmanButton;
        private System.Windows.Forms.Button brickbreakerButton;
        private System.Windows.Forms.Timer movingSkyTimer;
    }
}

