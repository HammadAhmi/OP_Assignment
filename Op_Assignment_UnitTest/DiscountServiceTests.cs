using Microsoft.VisualStudio.TestTools.UnitTesting;
using OP_Assignment.Services;
using System;

namespace Op_Assignment_UnitTest
{
    [TestClass]
    public class DiscountServiceTests
    {
        [TestMethod]
        public void Loyal_Customer_Over_100_Gets_10_Percent_Discount()
        {
            var service = new DiscountService();
            var discount = service.CalculateDiscount(200, "Loyal");
            Assert.AreEqual(20, discount);
        }

        [TestMethod]
        public void New_Customer_No_Discount()
        {
            var service = new DiscountService();
            var discount = service.CalculateDiscount(200, "New");
            Assert.AreEqual(0, discount);
        }
    }
}
