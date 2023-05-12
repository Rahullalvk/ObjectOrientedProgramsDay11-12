using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockExchange
{
    public class Stock
    {
        public string name;
        public int numShares;
        public double pricePerShare;
        public double value;

        public Stock(string name, int numShares, double pricePerShare)
        {
            this.name = name;
            this.numShares = numShares;
            this.pricePerShare = pricePerShare;
            this.value = numShares * pricePerShare;
        }
    }
   
}
