using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceTrader
{
    public class DatabaseAccessMock : IDatabaseAccess
    {
        public int Query_GetPriceForName(string query)
        {
            int result = 0;
            // lets stub a response. We could create a whole in memory database if we //wanted more complex behaviour
            if (query.Equals("SELECT price FROM setting WHERE name='Gold'"))
                result = 100;
            return result;
        }
    }
}
