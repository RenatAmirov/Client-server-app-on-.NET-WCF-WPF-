using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFOrderApplication.Models
{
    /// <summary>
    /// Order entity
    /// </summary>
    [Table("Order")]
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
