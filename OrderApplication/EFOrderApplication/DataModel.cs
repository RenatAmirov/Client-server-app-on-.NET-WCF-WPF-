using EFOrderApplication.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFOrderApplication
{
    public class DataModel : DbContext
    {
        public DbSet<Order> Orders { get; set; }
    }
}
