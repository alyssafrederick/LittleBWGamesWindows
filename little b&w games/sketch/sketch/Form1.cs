using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sketch
{
    public partial class etchisketch : Form
    {
        Graphics gfx;
        int x = 20;
        int y = 20;      

        int xr;
        int yr;

        public etchisketch()
        {
            InitializeComponent();
            x = ClientRectangle.Width / 2;
            y = ClientRectangle.Height / 2;

            xr = ClientRectangle.Width / 2;
            yr = ClientRectangle.Height / 2;
        }

        private void etchisketch_Load(object sender, EventArgs e)
        {
            gfx = CreateGraphics();
            gfx.FillRectangle(new SolidBrush(Color.White), x, y, 2, 2);
        }

        private void etchisketch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.X)
            {
                gfx.Clear(Color.Black);
            }

            if (e.KeyData == Keys.Left)
            {
                xr += 2;
                x -= 2;
                gfx.FillRectangle(new SolidBrush(Color.White), x, y, 2, 2);
                gfx.FillRectangle(new SolidBrush(Color.White), xr, yr, 2, 2);
            }

            if (e.KeyData == Keys.Right)
            {
                xr -= 2;
                x += 2;
                gfx.FillRectangle(new SolidBrush(Color.White), x, y, 2, 2);
                gfx.FillRectangle(new SolidBrush(Color.White), xr, yr, 2, 2);
            }

            if (e.KeyData == Keys.Up)
            {
                yr += 2;
                y -= 2;
                gfx.FillRectangle(new SolidBrush(Color.White), x, y, 2, 2);
                gfx.FillRectangle(new SolidBrush(Color.White), xr, yr, 2, 2);
            }

            if (e.KeyData == Keys.Down)
            {
                yr -= 2;
                y += 2;
                gfx.FillRectangle(new SolidBrush(Color.White), x, y, 2, 2);
                gfx.FillRectangle(new SolidBrush(Color.White), xr, yr, 2, 2);
            }
        }

        private void etchisketch_Click(object sender, EventArgs e)
        {

        }
    }
}
