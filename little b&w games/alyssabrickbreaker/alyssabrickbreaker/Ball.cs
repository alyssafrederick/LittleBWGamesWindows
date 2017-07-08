using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace alyssabrickbreaker
{
    public class Ball
    {
        public Rectangle rectangle;
        public int _speedx;
        public int _speedy;

        public Ball(int x, int y, int width, int height, int speedx, int speedy)
        {
            rectangle = new Rectangle(x, y, width, height);
            _speedx = speedy;
            _speedy = speedy;
        }

        public void Update(Size ClientSize)
        {
            if (rectangle.X + rectangle.Width >= ClientSize.Width)
            {
                _speedx = -Math.Abs(_speedx);
            }

            if (rectangle.X <= 0)
            {
                _speedx = Math.Abs(_speedx);
            }

            if (rectangle.Y <= 0)
            {
                _speedy = Math.Abs(_speedy);
            }

            rectangle.X += _speedx;
            rectangle.Y += _speedy;
        }

        public void Render(Graphics gfx)
        {
            gfx.FillEllipse(Brushes.WhiteSmoke, rectangle);
        }
    }
}
