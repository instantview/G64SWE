using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceTrader
{
    public class CargoHold
    {
        private int _maxSize;

        public int MaxSize
        {
            get { return _maxSize; }
            set { _maxSize = value; }
        }
        
        private List<Item> _items;

        public List<Item> ItemList
        {
            get { return _items; }
            set { _items = value; }
        }

        public CargoHold(int size)
        {
            _items = new List<Item>();
            _maxSize = size;

            addItems(); 
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

        /* Add an item to the cargo hold. */
        //public void AddItems(List<Item> items)
        //{
        //    _items = new List<Item>();

        //    for (int i = 0; i < items.Count; i++)
        //    {
        //        _items.Add(items[i]);
        //    }
        //}

      /*  public void AddItems(string name, int quantity)
        {
            Item item = _items.Find(x => x.Name == name);
            item.Quantity += quantity; 
        } /*


        /* Remove an item from the cargo hold. Returns true if successful */
      /*  public bool RemoveItem(Item item)
        {
            if (_items.Exists(x => x.Name == item.Name))
            {
                _items.Remove(item);
                return true;
            }
            else
                return false;
        }
        */
        public void addItems()
        {   
      
            _items.Add(new Item("Gold", 0, 0));
            _items.Add(new Item("Silver", 0, 0));
            _items.Add(new Item("Copper", 0, 0));
       

        }

        public int GetCapacity()
        {
            int total = 0; 
            for (int i = 0; i < _items.Count; i++)
            {
                total += _items[i].Quantity; 
            }
            return total; 
        }
    }
}
