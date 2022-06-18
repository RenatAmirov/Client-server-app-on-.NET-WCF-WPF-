using EF.Data.Models;
using System;
using System.Data.Entity;

namespace EF.Data
{
    public class DataModel: DbContext
    {
        public DbSet<Order> Orders { get; set; }
    }
}
