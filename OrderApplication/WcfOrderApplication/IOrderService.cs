using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfOrderApplication
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IOrderService" in both code and config file together.
    [ServiceContract]
    public interface IOrderService
    {
        [OperationContract]
        List<Order> GetOrders();
    }

    /// <summary>
    /// Заказ
    /// </summary>
    [DataContract]
    public class Order
    {
        DateTime orderDate;
        string orderNum;
        DateTime lastModifiedDate;

        [DataMember]
        public DateTime OrderDate
        {
            get { return orderDate; }
            set { orderDate = value; }
        }

        [DataMember]
        public string OrderNum
        {
            get { return orderNum; }
            set { orderNum = value; }
        }

        [DataMember]
        public DateTime LastModifiedDate
        {
            get { return lastModifiedDate; }
            set { lastModifiedDate = value; }
        }

    }

}
