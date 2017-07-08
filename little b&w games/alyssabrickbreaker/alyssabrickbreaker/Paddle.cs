using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace alyssabrickbreaker
{
    public class Paddle
    {
        public Rectangle rectangle;
        public Rectangle[] parts;
        public int _speedx;
        public bool movingleft;
        public bool movingright;

        public Paddle(int x, int y, int width, int height, int speedx)
        {
            movingleft = false;
            movingright = false;
            rectangle = new Rectangle(x, y, width, height);
            _speedx = speedx;
        }

        public void Update(Size ClientSize)
        {
            if (movingleft == true && rectangle.X >= 0)
            {
                rectangle.X -= _speedx;
            }

            if (movingright == true && rectangle.X <= ClientSize.Width - rectangle.Width)
            {
                rectangle.X += _speedx;
            }
        }

        public void Render(Graphics gfx)
        {
            gfx.FillRectangle(Brushes.WhiteSmoke, rectangle);
        }
    }
}
