using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace alyssabrickbreaker
{
    public class Brick
    {
        public Rectangle rectangle;
        public bool isHit = false;

        public Brick(int x, int y, int width, int height)
        {
            rectangle = new Rectangle(x, y, width, height);
        }

        public void Render(Graphics gfx, Color backcolor, int clientWidth, int clientHieght)
        {
            gfx.FillRectangle(Brushes.WhiteSmoke, rectangle);
        }
    }
}
