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
        //CargoHold ch;
        //List<Item> items;
        //Item sampleItem; 

        //[TestInitialize]
        //public void init()
        //{
        //    ch = new CargoHold();
        //    sampleItem = new Item("C", 3, 20.00m);
        //    items = new List<Item>{ new Item("A", 1, 1.00m), 
        //                            new Item("B", 2, 10.00m), 
        //                            sampleItem };
        //}

        //[TestMethod]
        //public void CargoHold_Constructs_Ok()
        //{
        //    Assert.IsNotNull(ch); 
        //}

        //[TestMethod]
        //public void GetItems_ReturnsAListofItems()
        //{
        //    Type type = ch.GetItems().GetType(); 
        //    Assert.IsTrue(type.GetGenericTypeDefinition() == typeof(List<>));
        //}

        //[TestMethod]
        //public void AddItems_Add3Items_ShouldSaveItemsToCargoHold()
        //{
        //    //List<Item> items = new List<Item>{ 
        //    //    new Item("A", 1, 1.00m), 
        //    //    new Item("B", 2, 10.00m), 
        //    //    new Item("C", 3, 20.00m)};
        //    ch.AddItems(items);

        //    CollectionAssert.AreEqual(ch.GetItems(), items);
        //}

        //[TestMethod]
        //public void AddItems_Add3Items_ShouldIncreaseItemCountBy3()
        //{
        //    //List<Item> items = new List<Item>{ 
        //    //    new Item("A", 1, 1.00m), 
        //    //    new Item("B", 2, 10.00m), 
        //    //    new Item("C", 3, 20.00m)};
        //    ch.AddItems(items);

        //    Assert.IsTrue(ch.GetItemCount() == 3); 
        //}

        //[TestMethod]
        //public void RemoveItem_Remove1Item_ShouldReturnTrue()
        //{
        //    ch.AddItems(items);
        //    Assert.IsTrue(ch.RemoveItem(sampleItem));
        //}

        //[TestMethod]
        //public void RemoveItem_RemoveSpecificItem_ShouldRemoveItemFromCargoHold()
        //{
        //    ch.AddItems(items);
        //    ch.RemoveItem(sampleItem);
            
        //    Boolean itemExists = ch.GetItems().Exists(x => x.Name == sampleItem.Name); 
        //    Assert.IsFalse(itemExists);
        //}

        //[TestMethod]
        //public void RemoveItem_Remove1Item_ShouldDecreaseItemCountBy1()
        //{
        //    ch.AddItems(items);
        //    ch.RemoveItem(sampleItem);

        //    Assert.IsTrue(ch.GetItemCount() == 2);
        //}

        //[TestMethod]
        //public void RemoveItem_WhenItemDoesNotExist_ShouldReturnFalse()
        //{
        //    Assert.IsFalse(ch.RemoveItem(sampleItem));
        //}

        //[TestMethod]
        //public void GetItemQuantity_WhenItemsWithQuantityArePresent_ReturnsTotalQuantityOfItemsInCargoHold()
        //{

        //}
    }
}
