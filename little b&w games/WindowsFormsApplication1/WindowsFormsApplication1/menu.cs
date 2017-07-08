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
    public partial class menu : Form
    {
        private int movingSkyImageID = 0;
        private Bitmap bitmap;

        

        public menu()
        {
            InitializeComponent();
            bitmap = new Bitmap(ClientRectangle.Width, ClientRectangle.Height);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            bitmap = (Bitmap)Properties.Resources.ResourceManager.GetObject($"movingSky{movingSkyImageID}");

            movingSkyImageID++;
            movingSkyImageID %= 23;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.BackgroundImage = bitmap;

        }
    }
}
