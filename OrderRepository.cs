using System;
using System.Collections.Generic;
using System.Text;

namespace ACME.BL
{
    public class OrderRepository
    {
        public Order Retrieve(int orderId)
        {
            Order order = new Order(orderId);

            // temp hard coded
            if (orderId == 10)

            // use current year in hard coded data
            {
                order.OrderDate = new DateTimeOffset(DateTime.Now.Year, 10, 22, 10, 00, 00, new TimeSpan(7, 0, 0));
            }

            return order;
        }

        // Saves the current order
        public bool Save()
        {
            return true;
        }

    }
}
