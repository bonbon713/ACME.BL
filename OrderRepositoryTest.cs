using System;
using ACME.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACME.BLTest
{
    [TestClass]
    public class OrderRepositoryTest
    {
        [TestMethod]
        public void RetrieveOrderDisplayTest()
        {
            // Arrange
            var orderRepository = new OrderRepository();
            var expected = new Order(10)
            {
                OrderDate = new DateTimeOffset(DateTime.Now.Year, 10, 22, 14, 00, 00, new TimeSpan(7, 0, 0)),
            };

            // Act
            var actual = orderRepository.Retrieve(10);

            // Assert
            Assert.AreEqual(expected.OrderDate, actual.OrderDate);
        }
    }
}
