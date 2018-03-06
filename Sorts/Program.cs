using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorts
{
    class Program
    {
        static void Main(string[] args)
        {
            //bubbleSort();
            //binarySearch();
            StockSaleMaxProfit();

        }

        static public void StockSaleMaxProfit()
        {

            int[] stockPricesYesterday = { 10, 7, 5, 8, 11, 9, 13, 44, 3, 5 };
            int profit = 0;
            int buyPeriod = 0;
            int sellPeriod = 0;

            for (int i = 0; i < stockPricesYesterday.Length; i++)
            {
                for (int j = i; j < stockPricesYesterday.Length - 1; j++)
                {

                    Console.WriteLine(stockPricesYesterday[j + 1]);
                    Console.WriteLine(stockPricesYesterday[i]);
                    Console.WriteLine(stockPricesYesterday[j + 1] - stockPricesYesterday[i]);

                    if (stockPricesYesterday[j + 1] - stockPricesYesterday[i] > profit)
                    {
                        profit =  stockPricesYesterday[j + 1] - stockPricesYesterday[i];
                        buyPeriod = i;
                        sellPeriod = j + 1;
                    }
                    Console.WriteLine(profit);
                    Console.WriteLine();
                }

            }

            Console.WriteLine(String.Format("Buy period: {0} - Buy Price: {1}", buyPeriod + 1, stockPricesYesterday[buyPeriod] ));
            Console.WriteLine(String.Format("Sell period: {0} - Sell Price: {1}", sellPeriod + 1, stockPricesYesterday[sellPeriod]));
            Console.Write("Per share profit: ");
            Console.WriteLine(profit);


            Console.WriteLine("Press any key to continue...");
            Console.Read();

            // Returns 6 (buying for $5 and selling for $11)

        }
        static public void bubbleSort()
        {
            int[] intArray = new int[] { 3, 5, 1, 4, 2, 7, 6, 9, 8 };


            for (int i = 1; i < intArray.Length; i++)
            {
                for (int j = 0; j < intArray.Length - 1 ; j++)
                {
                    
                    if (intArray[j] > intArray[j + 1])
                    {
                        int tempItem = intArray[j];
                        intArray[j] = intArray[j + 1];
                        intArray[j + 1] = tempItem;
                    }

                }

            }

            Console.WriteLine();
           
            foreach(int i in intArray)
            {
                Console.Write(@"{0} ", i);
            }

            Console.Write("Press any key to conitnue....");

            Console.ReadKey();
        }

        static public int binarySearch()
        {

            int[] intArray = new int[] { 1, 3, 5, 7, 9 };
            int intTarget = 2;

            int min = 0;
            int n = intArray.Length;
            int max = n - 1;
            int result = -1;
            
            do
            {
                int mid = (min + max) / 2;

                if (intTarget > intArray[mid])
                    min = mid + 1;
                else
                    max = mid - 1;
                if (intArray[mid] == intTarget)
                {
                    result = mid;
                    break;
                }
            }

            while (min <= max);

            Console.WriteLine(@"Index of target in array: {0}", result);
            Console.WriteLine("Pres any key....");
            Console.ReadKey();
            return result;

        }
    }
}
