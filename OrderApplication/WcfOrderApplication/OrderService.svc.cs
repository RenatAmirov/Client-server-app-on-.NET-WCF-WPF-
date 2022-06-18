using EFOrderApplication;
using System;
using System.Collections.Generic;

namespace WcfOrderApplication
{
    /// <summary>
    /// Get orders
    /// </summary>
    public class OrderService : IOrderService
    {
        DataModel db = new DataModel();

        public List<Order> GetOrders()
        {


            var dbOrders = db.Orders;
            var orders = new List<Order>();
            foreach(var dbOrder in dbOrders)
            {
                orders.Add(new Order {
                    OrderDate = dbOrder.OrderDate, 
                    OrderNum = dbOrder.OrderNum, 
                    LastModifiedDate = dbOrder.LastModifiedDate });
            }
            return orders;
        }
    }
}
