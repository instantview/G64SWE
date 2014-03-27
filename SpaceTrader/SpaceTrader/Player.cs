using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceTrader
{
    public class Player
    {
        private List<Item> itemsList = new List<Item>();
        private Account account;
        private CargoHold cargoHold;

        

        public CargoHold CargoHold
        {
            get { return cargoHold; }
            set { cargoHold = value; }
        }

        public Account Account
        {
            get { return account; }
            set { account = value; }
        }

        public Player()
        {
            // TODO: Complete member initialization
            account = new Account();
            cargoHold = new CargoHold(10); 
        }


    }
}
