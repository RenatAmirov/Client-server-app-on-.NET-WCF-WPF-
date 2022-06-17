using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfOrderApplication
{
    /// <summary>
    /// Get orders
    /// </summary>
    public class OrderService : IOrderService
    {
        public List<Order> GetOrders()
        {
            // TODO get orders from db
            return new List<Order> { new Order { OrderDate = DateTime.Now, OrderNum = "12345", LastModifiedDate = DateTime.Now } };
        }
    }
}
