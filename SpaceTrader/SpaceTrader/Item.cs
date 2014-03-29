using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections; 

namespace SpaceTrader
{
    public class Item
    {
        private ArrayList _prices = new ArrayList();
        private ArrayList _quantities = new ArrayList();
        private String _name;

        
        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public ArrayList Prices
        {
            get { return _prices; }
            set { _prices = value; }
        }
        
        public ArrayList Quantities
        {
            get { return _quantities; }
            set { _quantities = value; }
        }

        public int MinPrice { get; set; }
        
        public int MaxPrice { get; set; }
        
        public string name { get; set; }

        public Item(string vname, int vmax, int vmin, bool initialPrice=false)
        {
            name = vname;
            SetMaxPrice(vmax);
            SetMinPrice(vmin);
            SetPrice(initialPrice);
        }

        public void reduceStock( int p2)
        {
            int a = ((int)_quantities[0]) - p2;
            _quantities[0] = a;
            //  _quantities.RemoveAt(0);   
            _quantities.Insert(0, a);
        }

        public void increaseStock(int p2)
        {
            int a = ((int)_quantities[0]) + p2;
            _quantities[0] = a;
            //  _quantities.RemoveAt(0);
            _quantities.Insert(0, a);
        }

        public void SetMaxPrice(int p)
        {
            MaxPrice = p;
        }
        public void SetMinPrice(int p)
        {
            MinPrice = p;
        }

        public void SetPrice(bool initialPrice=false)
        {
            if (initialPrice)
            {
                for (int i = 1; i < 6; i++)
                {
                    _prices.Add(0);
                    _quantities.Add(0);
                }
            }
            else
            {
                Random ro = new Random();
                for (int i = 1; i < 6; i++)
                {
                    _prices.Add(ro.Next(MinPrice, MaxPrice));
                    _quantities.Add(ro.Next(10 * i, 40 * i));
                    //System.Threading.Thread.Sleep(1);
                }
            }

            
        }
    }
}
