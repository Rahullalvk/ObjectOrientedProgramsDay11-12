namespace StockExchange
{
    class Program
    {
        static void Main(string[] args)
        {
            StockPortfolio portfolio = new StockPortfolio();
            Console.Write("Enter number of stocks: ");
            int numStocks = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < numStocks; i++)
            {
                Console.WriteLine("\nStock {0}:", i + 1);
                Console.Write("Enter stock name: ");
                string name = Console.ReadLine();
                Console.Write("Enter number of shares: ");
                int numShares = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter price per share: ");
                double pricePerShare = Convert.ToDouble(Console.ReadLine());
                portfolio.addStock(name, numShares, pricePerShare);
            }

            Console.WriteLine();
            portfolio.printStockReport();
        }
    }
}