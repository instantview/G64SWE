using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq; 
using SpaceTrader;

namespace SpaceTraderTest
{
    [TestClass]
    public class CargoHoldTest
    {
        CargoHold ch;

        [TestInitialize]
        public void init()
        {
            ch = new CargoHold(); 
        }

        [TestMethod]
        public void CargoHold_Constructs_Ok()
        {
            Assert.IsNotNull(ch); 
        }

        [TestMethod]
        public void GetItems_ReturnsAListofItems()
        {
            Type type = ch.GetItems().GetType(); 
            Assert.IsTrue(type.GetGenericTypeDefinition() == typeof(List<>));
        }

        [TestMethod]
        public void AddItems_Add3Items_ShouldSaveItemsToCargoHold()
        {
            List<Item> items = new List<Item>{ 
                new Item("A", 1, 1.00m), 
                new Item("B", 2, 10.00m), 
                new Item("C", 3, 20.00m)};
            ch.AddItems(items);

            CollectionAssert.AreEqual(ch.GetItems(), items);
        }

        [TestMethod]
        public void AddItems_Add3Items_ShouldIncreaseItemCountBy3()
        {
            List<Item> items = new List<Item>{ 
                new Item("A", 1, 1.00m), 
                new Item("B", 2, 10.00m), 
                new Item("C", 3, 20.00m)};
            ch.AddItems(items);

            Assert.IsTrue(ch.GetItemCount() == 3); 
        }

        [TestMethod]
        public void RemoveItem_Remove1Item_ShouldReturnTrue()
        {
            Item item = new Item("C", 3, 20.00m); 

            List<Item> items = new List<Item>{ 
                new Item("A", 1, 1.00m), 
                new Item("B", 2, 10.00m), 
                item };
            ch.AddItems(items);

            Assert.IsTrue(ch.RemoveItem(item));
        }

        [TestMethod]
        public void RemoveItem_RemoveSpecificItem_ShouldRemoveItemFromCargoHold()
        {
            Item item = new Item("C", 3, 20.00m);

            List<Item> items = new List<Item>{ 
                new Item("A", 1, 1.00m), 
                new Item("B", 2, 10.00m), 
                item };
            ch.AddItems(items);
            ch.RemoveItem(item);
            
            Boolean itemExists = ch.GetItems().Exists(x => x.Name == "C"); 
            Assert.IsFalse(itemExists);
        }

        [TestMethod]
        public void RemoveItem_Remove1Item_ShouldDecreaseItemCountBy1()
        {
            Item item = new Item("C", 3, 20.00m);

            List<Item> items = new List<Item>{ 
                new Item("A", 1, 1.00m), 
                new Item("B", 2, 10.00m), 
                item };
            ch.AddItems(items);
            ch.RemoveItem(item);

            Assert.IsTrue(ch.GetItemCount() == 2);
        }

        [TestMethod]
        public void RemoveItem_WhenItemDoesNotExist_ShouldReturnFalse()
        {
            Item item = new Item("C", 3, 20.00m);

            Assert.IsFalse(ch.RemoveItem(item));
        }
    }
}
