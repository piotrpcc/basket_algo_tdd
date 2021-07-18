using System.Collections.Generic;
using NUnit.Framework;
using SuperMarketBillApp;

namespace SuperMarketBillTests
{
    public class Tests
    {
        private Counter counter = new Counter();

        [SetUp]
        public void Setup()
        {
        }
        // przykład: { nazwa: string, kodKreskowy: string, wartoscProduktu: number
        //cele: - niepusta lista, jak pusta to błąd
        // - 
        [Test]
        public void ShouldCalculateTotal()
        {

            
            var basket = new List<string>
            {
                "236565"
            };

            var result = counter.CalculateTotal(basket);

            Assert.AreEqual(10.2, result);
            
        }
        
        [Test]
        public void ShouldCalculateTotalWithManyProducts()
        {
            var newOffer = new Dictionary<string, double>();
            
            counter.SetNewOffer(newOffer);
            var basket = new List<string>
            {
                "236565",
                "111111"
            };

            var result = counter.CalculateTotal(basket);

            Assert.AreEqual(20.4, result);
        }
    }
    
    
    
}