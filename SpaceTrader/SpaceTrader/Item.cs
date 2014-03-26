using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceTrader
{
    /* Represents an item that can be traded */
    public class Item
    {
        private String _name;
        private int _quantity;
        private Decimal _price;


        public Item(String name, int quantity, Decimal price)
        {
            this._name = name;
            this._price = price;
            this._quantity = quantity; 
        }


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
}
