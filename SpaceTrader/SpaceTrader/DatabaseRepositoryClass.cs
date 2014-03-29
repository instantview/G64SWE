using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceTrader
{
    public class DatabaseRepositoryClass
    {
        IDatabaseAccess da;

        public DatabaseRepositoryClass(IDatabaseAccess da_in)
        {
            da = da_in;
        }

        public int getPrice(string iteName)
        {

            string query = "SELECT price FROM setting WHERE name='" + iteName + "'";
            int price = da.Query_GetPriceForName(query);
            return price;

        }
    }

    public interface IDatabaseAccess
    {
        int Query_GetPriceForName(string query);
    }

}


