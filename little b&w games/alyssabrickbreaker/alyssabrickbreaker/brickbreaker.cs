using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace alyssabrickbreaker
{
    public partial class brickbreaker : Form
    {
        Graphics gfx;
        Bitmap bitmap;

        Ball bubble;
        Paddle paddle;
        List<Brick> bricks;

        int lives = 3;

        public brickbreaker()
        {
           
            InitializeComponent();
            this.BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bitmap = new Bitmap(ClientRectangle.Width, ClientRectangle.Height);
            gfx = Graphics.FromImage(bitmap);

            bubble = new Ball(100, 100, 10, 10, 6, 6);
            paddle = new Paddle((ClientSize.Width / 2) - 25, ClientSize.Height - 20, 50, 10, 10);
            
            CreateBricks();
        }



        private void CreateBricks()
        {
            int x = 10;
            int y = 10;
            int width = 20;
            int height = 10;
            bricks = new List<Brick>();
            for (int j = 0; j < 13; j++)
            {
                for (int i = 0; i < 4; i++)
                {
                    bricks.Add(new Brick(x + (25 * j), y + (15 * i), width, height));
                }
            }
        }

        private void gametime_Tick(object sender, EventArgs e)
        {
            gfx.Clear(BackColor);
            if (lives > -1)
            {

                bubble.Update(ClientSize);
                paddle.Update(ClientSize);

                if (bubble.rectangle.IntersectsWith(paddle.rectangle))
                {
                    bubble._speedy *= -1;

                    if (paddle.movingleft)
                    {
                        bubble._speedx--;
                    }

                    if (paddle.movingright)
                    {
                        bubble._speedx++;
                    }
                }
                if (bubble.rectangle.Y > ClientSize.Height)
                {
                    bubble.rectangle.Y = ClientSize.Height / 2;
                    bubble.rectangle.X = ClientSize.Width / 2;

                    lives--;
                    bubble._speedx = 6;
                }

                for (int a = 0; a < bricks.Count; a++)
                {
                    if (bubble.rectangle.IntersectsWith(bricks[a].rectangle))
                    {
                        bricks[a].isHit = true;
                        bubble._speedy *= -1;// Math.Abs(_speedy);

                    }
                }

                for (int i = 0; i < bricks.Count; i++)
                {
                    if (bricks[i].isHit == true)
                    {
                        bricks.RemoveAt(i);
                        i--;
                    }
                    else
                    {
                        bricks[i].Render(gfx, BackColor, ClientSize.Width, ClientSize.Height);
                    }
                }

                paddle.Render(gfx);
                bubble.Render(gfx);


                for (int i = 0; i < lives; i++)
                {
                    gfx.FillEllipse(Brushes.WhiteSmoke, 4, 100 + i * 15, 10, 10);

                }
            }

            gameScreen.Image = bitmap;

            if (lives == -1)
            {
                lostLabel.Visible = true;
                bricks.Clear();
                againTimer.Start();
                gametime.Stop();
            }

            else if (bricks.Count == 0)
            {
                winLabel.Visible = true;
                againTimer.Start();
                gametime.Stop();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                paddle.movingleft = true;
            }

            if (e.KeyCode == Keys.Right)
            {
                paddle.movingright = true;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                paddle.movingleft = false;
            }

            if (e.KeyCode == Keys.Right)
            {
                paddle.movingright = false;
            }
        }

        private void againTimer_Tick(object sender, EventArgs e)
        {
            lostLabel.Visible = false;
            winLabel.Visible = false;
            textBox.Visible = true;
            againQuestion.Visible = true;
            againTimer.Stop();
        }

        private void closeTimer_Tick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox.Text == "yes")
                {
                    textBox.Text = "";
                    textBox.Visible = false;
                    againQuestion.Visible = false;
                    lives = 3;
                    CreateBricks();
                    gametime.Start();
                }
                else
                {
                    byeLabel.Visible = true;
                    againQuestion.Visible = false;
                    textBox.Visible = false;
                    closeTimer.Start();
                }
            }
        }

        private void brickbreaker_FormClosing(object sender, FormClosingEventArgs e)
        {
            for (int i = 0; i < this.MdiParent.Controls.Count; i++)
            {
                this.MdiParent.Controls[i].Visible = true;
            }
        }
    }
}
