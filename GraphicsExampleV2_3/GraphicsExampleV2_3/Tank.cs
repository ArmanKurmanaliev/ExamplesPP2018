using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GraphicsExampleV2_3
{
    class Tank
    {
        int x, y;
        int w, h;
        public GraphicsPath gp;
        public Tank(int x, int y, int w, int h)
        {
            this.x = x;
            this.y = y;
            this.w = w;
            this.h = h;
            Move();
        }

        public void Move()
        {
            x = x + 1;
            gp = new GraphicsPath();
            gp.AddRectangle(new Rectangle(x, y, w, h));
            gp.AddEllipse(new Rectangle(x, y, w, h));
            gp.AddLine(x + w / 2, y + h / 2, x + w + w / 2, y + h / 2);
        }

    }
}
