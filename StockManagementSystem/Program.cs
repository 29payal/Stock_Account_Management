using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "C:\\Users\\DELL\\Desktop\\RFP\\Stock_Account_Management\\StockManagementSystem\\StockData.json";

            FetchForJsonStockData fetchForJsonStockData = new FetchForJsonStockData();

            Stocks data = fetchForJsonStockData.Read(filePath);
            Console.WriteLine("Data for Stock Market : ");

            for (int i =0; i<data.stockMarket.Count; i++)
            {
                Console.WriteLine(data.stockMarket[i].StockName);
                Console.WriteLine(data.stockMarket[i].NumberOfShares);
                Console.WriteLine(data.stockMarket[i].SharePrice);
                Console.WriteLine("############################################");
                Console.WriteLine("Calculate the total stock value :");
                int value = data.stockMarket[i].NumberOfShares * data.stockMarket[i].SharePrice;
                Console.WriteLine(value);
                Console.WriteLine("_______________________________");
               
            }
            Console.ReadLine();
        }
    }
}
