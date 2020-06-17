using System.Data.Entity;
using IT_Enterprise_TEST.Models;

namespace IT_Enterprise_TEST.DataBase
{
    public class DataDBContext : DbContext
    {
        public DbSet<Shipment> Shipments { get; set; }
    }
}
