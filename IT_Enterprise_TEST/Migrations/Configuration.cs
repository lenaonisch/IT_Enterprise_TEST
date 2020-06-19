namespace IT_Enterprise_TEST.Migrations
{
    using IT_Enterprise_TEST.Entities;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<IT_Enterprise_TEST.DataBase.DataDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(IT_Enterprise_TEST.DataBase.DataDBContext context)
        {
            Shipment[] shipments = new Shipment[]
            {
                new Shipment()
                {
                    City = "Kyiv",
                    Country = "Ukraine",
                    Date = new DateTime(2020, 06, 17),
                    Manager = "Ivanov",
                    Organization = "Voshod",
                    Quantity = 1,
                    Sum = 100
                },
                new Shipment()
                {
                    City = "Moscow",
                    Country = "Russia",
                    Date = new DateTime(2020, 06, 17),
                    Manager = "Ivanov",
                    Organization = "RiK",
                    Quantity = 2,
                    Sum = 250
                },
                new Shipment()
                {
                    City = "Kyiv",
                    Country= "Ukraine",
                    Date= new DateTime(2020, 06, 17),
                    Manager = "Ivanov",
                    Organization="Voshod",
                    Quantity=1, Sum=100
                },
                new Shipment()
                {
                    City = "Moscow",
                    Country= "Russia",
                    Date= new DateTime(2020, 06, 17),
                    Manager = "Petrov",
                    Organization="RiK",
                    Quantity = 5,
                    Sum = 450
                },
                new Shipment()
                {
                    City = "Kyiv",
                    Country= "Ukraine",
                    Date= new DateTime(2020, 06, 18),
                    Manager = "Petrov",
                    Organization="Voshod",
                    Quantity = 7,
                    Sum = 750
                },
                new Shipment()
                {
                    City = "Kyiv",
                    Country= "Ukraine",
                    Date= new DateTime(2020, 06, 18),
                    Manager = "Sidorov",
                    Organization="Voshod",
                    Quantity = 10,
                    Sum = 1050
                }
            };
            context.Shipments.AddOrUpdate(shipments);
            context.SaveChanges();
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
