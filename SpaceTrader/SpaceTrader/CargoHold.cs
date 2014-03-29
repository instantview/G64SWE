using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceTrader
{
    public class CargoHold
    {
        private int _maxSize;
        private List<Item> _items;

        public int MaxSize
        {
            get { return _maxSize; }
            set { _maxSize = value; }
        }
        
        public List<Item> ItemList
        {
            get { return _items; }
            set { _items = value; }
        }

        public CargoHold(int size)
        {
            _items = new List<Item>();
            _maxSize = size;

            AddItems(); 
        }

        public string Status()
        {
            return string.Format("{0}/{1}", GetItemQuantity(), MaxSize);
        }

        public int GetItemCount()
        {
            return _items.Count;
        }

        public List<Item> GetItems()
        {
            if (_items == null)
                return new List<Item>();
            else
                return _items;
        }

        public void AddItems()
        {   
            _items.Add(new Item("Gold", 0, 0, true));
            _items.Add(new Item("Silver", 0, 0, true));
            _items.Add(new Item("Copper", 0, 0, true));
        }

        public int GetItemQuantity()
        {
            int total = 0; 
            foreach (Item item in _items)
            {
                total += (int) item.Quantities[0]; 
            }
            return total; 
        }
    }
}
