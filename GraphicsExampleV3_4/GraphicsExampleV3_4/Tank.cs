using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace GraphicsExampleV3_4
{
    class Tank
    {
        int x, y, w, h;
        Pen pen;

        public enum Direction
        {
            UP,
            DOWN,
            LEFT,
            RIGHT
        };

        public Direction d = Direction.RIGHT;

        public Tank(int x, int y, int w, int h, Color color)
        {
            pen = new Pen(color, 3);
            this.x = x;
            this.y = y;
            this.w = w;
            this.h = h;
        }

        public void Draw(Graphics g)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddRectangle(new Rectangle(x, y, w, h));
            path.AddEllipse(new Rectangle(x, y, w, h));
            if (d == Direction.RIGHT)
                path.AddLine(x + w / 2, y + h / 2, x + w + w / 2, y + h / 2);
            if (d == Direction.DOWN)
                path.AddLine(x + w / 2, y + h / 2, x + w / 2, y + h + h / 2);
            g.DrawPath(pen, path);
        }

        public void Move()
        {
            if (d == Direction.RIGHT)
                x++;
            if (d == Direction.DOWN)
                y++;
        }
    }
}
