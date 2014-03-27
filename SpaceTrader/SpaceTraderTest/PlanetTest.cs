using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SpaceTrader;

namespace SpaceTraderTest
{
    [TestClass]
    public class PlanetTest
    {
        [TestMethod]
        public void Planet_Constructs_Ok()
        {
            Planet planet = new Planet();
        }
    }
}
