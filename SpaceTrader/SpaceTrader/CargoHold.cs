using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceTrader
{
    public class CargoHold
    {
        private List<Item> _items = new List<Item>();
        

        //public int GetItemCount()
        //{
        //    return _items.Count;    
        //}

        //public List<Item> GetItems()
        //{
        //    if (_items == null)
        //        return new List<Item>();
        //    else
        //        return _items;
        //}

        ///* Add an item to the cargo hold. */
        //public void AddItems(List<Item> items)
        //{
        //    _items = new List<Item>();
 
        //    for (int i = 0; i < items.Count; i++)
        //    {
        //        _items.Add(items[i]); 
        //    }
        //}

        ///* Remove an item from the cargo hold. Returns true if successful */
        //public bool RemoveItem(Item item)
        //{
        //    if (_items.Exists(x => x.Name == item.Name))
        //    {   _items.Remove(item);
        //        return true; 
        //    }
        //    else
        //        return false; 
        //}
    }
}
