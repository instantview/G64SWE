using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections; 

namespace SpaceTrader
{
    public class Item
    {
        private ArrayList PlantPrice = new ArrayList();

        public ArrayList PlantPrice1
        {
            get { return PlantPrice; }
            set { PlantPrice = value; }
        }
        private ArrayList PlantAmount = new ArrayList();

        public ArrayList PlantAmount1
        {
            get { return PlantAmount; }
            set { PlantAmount = value; }
        }
        public int MinPrice { get; set; }
        public int MaxPrice { get; set; }
        public string name { get; set; }

        public Item(string vname, int vmax, int vmin)
        {
            name = vname;
            SetMaxPrice(vmax);
            SetMinPrice(vmin);
            SetPrice();


        }

        public void Buy(int p1, int p2)
        {
            if (p2 < (int)PlantAmount[p1])
            {
                int a = (int)PlantAmount[p1] - p2;
                PlantAmount.RemoveAt(p1);
                PlantAmount.Insert(p1, a);
            }
        }
        public void SetMaxPrice(int p)
        {
            MaxPrice = p;
        }
        public void SetMinPrice(int p)
        {
            MinPrice = p;
        }

        public void SetPrice()
        {
            Random ro = new Random();
            for (int i = 0; i < 5; i++)
            {

                PlantPrice.Add(ro.Next(MinPrice, MaxPrice));
                PlantAmount.Add(ro.Next(10, 40));
                System.Threading.Thread.Sleep(100);
            }
        }

        private String _name;
        private int _quantity;
        private Decimal _price;


        public Item(String name, int quantity, Decimal price)
        {
            this._name = name;
            this._price = price;
            this._quantity = quantity;
        }

        /* CHristian*/
        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }


        public Decimal Price
        {
            get { return _price; }
            set { _price = value; }
        }

    }
    /* Represents an item that can be traded */
    //public class Item
    //{
    //    private String _name;
    //    private int _quantity;
    //    private Decimal _price;


    //    public Item(String name, int quantity, Decimal price)
    //    {
    //        this._name = name;
    //        this._price = price;
    //        this._quantity = quantity; 
    //    }


    //    public String Name
    //    {
    //        get { return _name; }
    //        set { _name = value; }
    //    }
        
    //    public int Quantity
    //    {
    //        get { return _quantity; }
    //        set { _quantity = value; }
    //    }

        
    //    public Decimal Price
    //    {
    //        get { return _price; }
    //        set { _price = value; }
    //    }
    //}
}
