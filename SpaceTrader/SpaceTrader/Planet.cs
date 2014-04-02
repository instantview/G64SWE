using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing.Drawing2D;
using SpaceTrader; 

namespace SpaceTrader
{
    public class Planet
    {
        private GraphicsPath gp = new GraphicsPath();
        private List<Item> itemsList = new List<Item>();
        private int _status;

        public int Status
        {
            get { return _status; }
            set { _status = value; }
        }

        public List<Item> ItemsList
        {
            get { return itemsList; }
            set { itemsList = value; }
        }

        public GraphicsPath Gp
        {
            get { return gp; }
            set { gp = value; }
        }
        public int x { get; set; }

        public int height { get; set; }

        public int y { get; set; }

        public string name { get; set; }



        public Planet(string vname, int vx, int vy, int vheight, int vwidth)
        {
            name = vname;
            x = vx;
            y = vy;
            _status = 3;
            height = vheight;
            width = vwidth;
            setGraphicsPath();
            AddItems();
        }

        public int width { get; set; }

        public int draw(int x, int y, int height, int width)
        {
            return (x + width);
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
        public void AddItems()
        {
            itemsList.Add(new Item("Gold", 200, 150));
            itemsList.Add(new Item("Silver", 140, 80));
            itemsList.Add(new Item("Copper", 70, 10));

        }


        public System.Drawing.Rectangle getSize()
        {
            return new System.Drawing.Rectangle(x, y, height, width);
        }


    }
}
