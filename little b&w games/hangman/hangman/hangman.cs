using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hangman
{
    public partial class hangmanGame : Form
    {
        Graphics graphics;
        string word;
        List<char> guesses = new List<char>();
        int numberWrong = 0;
        bool restart = false;

        public hangmanGame()
        {
            InitializeComponent();
            this.BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            graphics = this.CreateGraphics();

            FormClosing += HangmanGame_FormClosing;
        }

        private void HangmanGame_FormClosing(object sender, FormClosingEventArgs e)
        {
            for (int i = 0; i < this.MdiParent.Controls.Count; i++)
            {
                this.MdiParent.Controls[i].Visible = true;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //the stick
            graphics.DrawLine(new Pen(Color.White, 2), 400, 160, 400, 20);
            graphics.DrawLine(new Pen(Color.White, 2), 330, 20, 400, 20);

            //the body
           // graphics.DrawLine(new Pen(Color.White, 2), 330, 65, 330, 20);
            //graphics.DrawLine(new Pen(Color.White, 2), 330, 65, 310, 27);
           // graphics.DrawLine(new Pen(Color.White, 2), 330, 65, 330, 120);
            //graphics.DrawLine(new Pen(Color.White, 2), 330, 90, 310, 105);
           // graphics.DrawLine(new Pen(Color.White, 2), 330, 90, 350, 105);
            //graphics.DrawEllipse(new Pen(Color.White,2), 314, 120, 30, 30);
        }
        

        private void wordToGuess_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter )
            {
                if (restart)
                {
                    guesses = new List<char>();
                    if (wordToGuess.Text == "yes")
                    {
                        graphics.Clear(Color.Black);
                        graphics.DrawLine(new Pen(Color.White, 2), 400, 160, 400, 20);
                        graphics.DrawLine(new Pen(Color.White, 2), 330, 20, 400, 20);

                        wordToGuess.Text = "";
                        restart = false;
                        numberWrong = 0;
                        wrongLabel.Text = numberWrong.ToString();
                        againQuestion.Visible = false;
                        wordBlanks.Text = "";
                        question.Visible = true;
                        word = "";
                    }
                    else
                    {
                        againQuestion.Visible = false;
                        wordToGuess.Visible = false;
                        worddd.Visible = false;
                        wordBlanks.Visible = true;
                        wordToGuess.Text = "";
                        wordBlanks.Text = "okay byeee";
                        closeTimer.Start();
                    }
                }
                else if (numberWrong >= 6)
                {
                    wordToGuess.Visible = false;
                    worddd.Visible = false;
                    wordBlanks.Visible = true;

                    if (wordToGuess.Text == "yes")
                    {
                        wordToGuess.Text = "";
                        wordBlanks.Text = word;
                        restartTimer.Start();
                    }
                    else
                    {
                        wordToGuess.Text = "";
                        wordBlanks.Text = "okay byeee";
                        closeTimer.Start();
                    }
                }
                else
                {
                    question.Visible = false;
                    wordToGuess.Visible = false;
                    word = wordToGuess.Text;
                    wordBlanks.Text = "";
                    for (int i = 0; i < word.Length; i++)
                    {
                        wordBlanks.Text += "_ ";
                    }

                    foreach (Button button in Controls.OfType<Button>())
                    {
                        button.Visible = true;
                    }
                }
            }
        }

        private void letterClick(object sender, EventArgs e)
        {
            Button buttonClicked = sender as Button;

            char guessLetter = buttonClicked.Name[0];

            guesses.Add(guessLetter);
            
            if (!word.Contains(guessLetter))
            {
                numberWrong++;
                wrongLabel.Text = numberWrong.ToString();
            }

            //drawing the body
            if (numberWrong >= 1)
            {
                graphics.DrawLine(new Pen(Color.White, 2), 330, 65, 330, 20);
            }
            if (numberWrong >= 2)
            {
                graphics.DrawLine(new Pen(Color.White, 2), 330, 65, 310, 27);
            }
            if (numberWrong >= 3)
            {
                graphics.DrawLine(new Pen(Color.White, 2), 330, 65, 330, 120);
            }
            if (numberWrong >= 4)
            {
                graphics.DrawLine(new Pen(Color.White, 2), 330, 90, 310, 105);
            }
            if (numberWrong >= 5)
            {
                graphics.DrawLine(new Pen(Color.White, 2), 330, 90, 350, 105);
            }
            if (numberWrong >= 6)
            {
                graphics.DrawEllipse(new Pen(Color.White, 2), 314, 120, 30, 30);
                wordToGuess.Text = "";
                worddd.Visible = true;
                wordToGuess.Visible = true;
                wordBlanks.Visible = false;

                foreach (Button button in Controls.OfType<Button>())
                {
                    button.Visible = false;
                }
            }


            buttonClicked.Visible = false;
            
            wordBlanks.Text = "";

            int missingletters = 0;

            for (int i = 0; i < word.Length; i++)
            {
                if (!guesses.Contains(word[i]))
                {
                    wordBlanks.Text += "_ ";
                    missingletters++;
                }
                else
                {
                    wordBlanks.Text += word[i] + " ";
                }
            }

            if (missingletters == 0)
            {
                wordToGuess.Text = "";
                winLabel.Visible = true;
                restartTimer.Start();

                foreach(Button button in Controls.OfType<Button>())
                {
                    button.Visible = false;
                }
            }
        }

        private void closeTimer_Tick(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void restartTimer_Tick(object sender, EventArgs e)
        {
            restart = true;
            winLabel.Visible = false;
            againQuestion.Visible = true;
            wordBlanks.Text = "";
            wordToGuess.Visible = true;
            restartTimer.Stop();
        }
    }
}
