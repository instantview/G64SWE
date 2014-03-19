using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing.Drawing2D;

namespace SpaceTraderApp
{
    public class Planet
    {
        private GraphicsPath gp = new GraphicsPath();

        public GraphicsPath Gp
        {
            get { return gp; }
            set { gp = value; }
        } 
        public int x { get; set; }

        public Planet (string vname, int vx, int vy, int vheight, int vwidth)
        {
            name = vname;
            x = vx;
            y = vy;
            height = vheight;
            width = vwidth;
            setGraphicsPath(); ;

        }

        public int width { get; set; }

        public int draw(int x,int y, int height, int width)
        {
            return(x + width);
        }
        public void setGraphicsPath()
        {
            gp.StartFigure();
            gp.AddLine(x, y, x, y + width);
            gp.AddLine(x, y + width, x + height, y + width);
            gp.AddLine(x + height, y + width, x + height, y + width);
            gp.AddLine(x + height, y + width, x, y);

            gp.CloseFigure();
        }

        public System.Drawing.Rectangle getSize()
        {
            return new System.Drawing.Rectangle(x, y, height, width);
        }

        public int height { get; set; }

        public int y { get; set; }
        public string name { get; set; }
    }
}
