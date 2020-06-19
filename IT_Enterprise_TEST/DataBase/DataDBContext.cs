using System;
using System.Data.Entity;
using IT_Enterprise_TEST.Entities;

namespace IT_Enterprise_TEST.DataBase
{
    public class DataDBContext : DbContext, IDisposable
    {
        public DbSet<Shipment> Shipments { get; set; }

        public DataDBContext() : base()
        {
            Database.SetInitializer<DataDBContext>(null);
        }
    }
}
