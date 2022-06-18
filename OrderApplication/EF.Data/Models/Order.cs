using System;
using System.Collections.Generic;
using System.Text;

namespace EF.Data.Models
{
    public class Order
    {
        DateTime orderDate;
        string orderNum;
        DateTime lastModifiedDate;

        public DateTime OrderDate
        {
            get { return orderDate; }
            set { orderDate = value; }
        }

        public string OrderNum
        {
            get { return orderNum; }
            set { orderNum = value; }
        }

        public DateTime LastModifiedDate
        {
            get { return lastModifiedDate; }
            set { lastModifiedDate = value; }
        }

    }

}
