using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem
{
    public class Stocks
    {
        public List<StockMarket>stockMarket;
    }
    public class StockMarket
    {
        public string StockName { get; set; }
        public int NumberOfShares { get; set; }
        public int SharePrice { get; set; }
    }
}
