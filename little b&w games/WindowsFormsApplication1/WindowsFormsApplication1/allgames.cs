using alyssabrickbreaker;
using hangman;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            menu menuu = new menu();
            menuu.MdiParent = this;
            menuu.Show();
            
        }

        private void hangmanButton_Click(object sender, EventArgs e)
        {
            hangmanGame hangmann = new hangmanGame();            
            hangmann.MdiParent = this;
            
            hangmanButton.Hide();            
            brickbreakerButton.Hide();    
            hangmann.Show();

        }

        private void brickbreakerButton_Click(object sender, EventArgs e)
        {
            brickbreaker brickbreakerr = new brickbreaker();
            brickbreakerr.MdiParent = this;

            brickbreakerButton.Hide();
            hangmanButton.Hide();
            brickbreakerr.Show();
        }

        private void movingSkyTimer_Tick(object sender, EventArgs e)
        {

        }
    }
}
