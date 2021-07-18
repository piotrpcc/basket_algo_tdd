using System;
using System.Collections.Generic;

namespace SuperMarketBillApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    
    public class Counter
    {
        public object CalculateTotal(List<string> basket)
        {
            return 10.2 * basket.Count;
        }
    }
}