using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SpaceTrader;
using System.Collections;

namespace SpaceTraderTest
{
    [TestClass]
    public class ItemTest
    {
        [TestMethod]
        public void Item_Created_ItemIsNotNull()
        {
            Item sys = new Item("pen", 50, 30);
            Assert.IsNotNull(sys);
        }
        [TestMethod]
        public void Item_CreatedPlantItemsName_IsNotNull()
        {
            Item sys = new Item("pen", 50, 30);
            String name = sys.name;
            Assert.IsNotNull(name);
        }
        [TestMethod]
        public void Item_CreatedPlantItemsPrice_IsNotNull()
        {
            Item sys = new Item("pen", 50, 30);
            ArrayList price = sys.Prices;
            Assert.IsNotNull(price);
        }
        [TestMethod]
        public void Item_CreatedPlantItemsAmount_IsNotNull()
        {
            Item sys = new Item("pen", 50, 30);
            ArrayList plantamount = sys.Quantities;
            Assert.IsNotNull(plantamount);
        }
        [TestMethod]
        public void Item_Buy5FromIt_PlantAmount0Decrease5()
        {
            Item sys = new Item("pen", 50, 30);
            ArrayList plantamount = sys.Quantities;
            int pasttstock = (int)plantamount[0];
            sys.reduceStock(5);
            int currentstock = (int)plantamount[0];
            Assert.IsTrue(pasttstock - currentstock == 5);
        }
        public void Item_Sell5ToIt_PlantAmount0Increase5()
        {
            Item sys = new Item("pen", 50, 30);
            ArrayList plantamount = sys.Quantities;
            int pasttstock = (int)plantamount[0];
            sys.increaseStock(5);
            int currentstock = (int)plantamount[0];
            Assert.IsTrue(currentstock - pasttstock == 5);
        }
        [TestMethod]
        public void Item_MinPrice_MoreThanZero()
        {
            Item sys = new Item("pen", 50, 30);
            int minprice = sys.MinPrice;
            Assert.IsTrue(minprice >= 0);
        }
        [TestMethod]
        public void Item_MaxPrice_MaxPriceMoreThanZero()
        {
            Item sys = new Item("pen", 50, 30);
            int maxprice = sys.MaxPrice;
            Assert.IsTrue(maxprice >= 0);
        }
        [TestMethod]
        public void Item_setMinPrice_ChangeTheValueOfMinPrice()
        {
            Item sys = new Item("pen", 50, 30);
            sys.SetMinPrice(20);
            int minprice = sys.MinPrice;
            Assert.IsTrue(minprice == 20);
        }
        [TestMethod]
        public void Item_setMaxPrice_ChangeTheValueOfMaxPrice()
        {
            Item sys = new Item("pen", 50, 30);
            sys.SetMaxPrice(40);
            int maxprice = sys.MaxPrice;
            Assert.IsTrue(maxprice == 40);
        }
    }
}
