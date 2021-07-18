using System.Collections.Generic;
using NUnit.Framework;

namespace SuperMarketBillTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        // przykład: { nazwa: string, kodKreskowy: string, wartoscProduktu: number
        //cele: - niepusta lista, jak pusta to błąd
        // - 
        [Test]
        public void Test1()
        {

            Counter counter = new Counter();
            
            var basket = new List<string>
            {
                "236565"
            };

            var result = counter.CalculateTotal(basket);

            Assert.AreEqual(10.2, result);
            
        }
    }

    public class Counter
    {
        public object CalculateTotal(List<string> basket)
        {
            return 10.2;
        }
    }
    
    
}