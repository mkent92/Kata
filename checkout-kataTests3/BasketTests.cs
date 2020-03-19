using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace checkout_kata.Tests
{
    [TestClass()]
    public class BasketTests
    {
        [TestMethod]
        public void ShouldCalculateTotals_WhenSimilarItemsAreScanned()
        {
            Dictionary<string, int> saleRules = new Dictionary<string, int>();
            PricingRules pricingRules = new PricingRules(saleRules);
            Basket basket = new Basket(pricingRules);
            Item itemA = new Item { Sku = "A", Price = 50 };
            basket.Scan(itemA);
            basket.Scan(itemA);
            basket.Scan(itemA);
            basket.GetTotal().Equals(150);
        }

        [TestMethod]
        public void ShouldCalculateTotals_WhenDifferentItemsNotOnSaleAreScanned()
        {
            Dictionary<string, int> saleRules = new Dictionary<string, int>();
            PricingRules pricingRules = new PricingRules(saleRules);
            Basket basket = new Basket(pricingRules);
            Item itemA = new Item { Sku = "A", Price = 50 };
            Item itemB = new Item { Sku = "B", Price = 30 };
            basket.Scan(itemA);
            basket.Scan(itemB);
            basket.Scan(itemA);
            basket.GetTotal().Equals(130);
        }

        public void ShouldUseSpecialPrice_WhenItemScannedIsOnSale()
        {

        }

        [TestMethod]
        public void ShouldNotProvdeAnySpecialPrice_WhenItemIsNotOnSale()
        {
            Dictionary<string, int> saleRules = new Dictionary<string, int>();
            PricingRules pricingRules = new PricingRules(saleRules);
            pricingRules.LookupPrice("A", 1).Equals(null);
        }

        [TestMethod]
        public void ShouldNotProvideSpecialPrice_WhenItemIsOnSale_AndNumberOfUnitsDoNotMatchSpecialPriceRule()
        {
            Dictionary<string, int> saleRules = new Dictionary<string, int>();
            saleRules.Add("A:3", 130);
            PricingRules pricingRules = new PricingRules(saleRules);

            pricingRules.LookupPrice("A", 1).Equals(null);
        }

        [TestMethod]
        public void ShouldProvideSpecialPrice_WhenItemIsOnSale_AndNumberOfUnitsMatchSpecialPriceRule(string sku, int units, int specialPrice)
        {
            Dictionary<string, int> saleRules = new Dictionary<string, int>();
            saleRules.Add(String.Format("{0}:{1}", sku, units), specialPrice);
            PricingRules pricingRules = new PricingRules(saleRules);

            pricingRules.LookupPrice(sku, units).Equals(specialPrice);
        }
    }
}