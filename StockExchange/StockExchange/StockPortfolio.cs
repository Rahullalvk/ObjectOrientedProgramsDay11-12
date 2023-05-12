using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockExchange
{
    class StockPortfolio
    {
        public List<Stock> stocks;

        public StockPortfolio()
        {
            stocks = new List<Stock>();
        }

        public void addStock(string name, int numShares, double pricePerShare)
        {
            stocks.Add(new Stock(name, numShares, pricePerShare));
        }

        public double calculateTotalValue()
        {
            double totalValue = 0;
            foreach (Stock stock in stocks)
            {
                totalValue += stock.value;
            }
            return totalValue;
        }

        public void printStockReport()
        {
            Console.WriteLine("Stock Report:");
            Console.WriteLine("{0,-10} {1,-10} {2,-15} {3,-15}", "Name", "Num Shares", "Price Per Share", "Value");
            foreach (Stock stock in stocks)
            {
                Console.WriteLine("{0,-10} {1,-10} {2,-15:C2} {3,-15:C2}", stock.name, stock.numShares, stock.pricePerShare, stock.value);
            }
            Console.WriteLine("{0,-35} {1,-15:C2}", "Total Value:", calculateTotalValue());
        }
    }
}

   