using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Dynamic;
using System.Threading.Tasks;
using IT_Enterprise_TEST.DataBase;
using IT_Enterprise_TEST.Entities;
using IT_Enterprise_TEST.View;

namespace IT_Enterprise_TEST.Models
{
    public delegate void ModelHandler<IModel>(IModel sender, ModelEventArgs e);

    public class ShipmentModel : IModel
    {
        DataDBContext _context = null;

        public event ModelHandler<ShipmentModel> changed;

        private DataDBContext Context
        {
            get
            {
                if (_context == null)
                {
                    return _context = new DataDBContext();
                }
                else
                {
                    return _context;
                }
            }
        }

        public async Task ChangeGrouping(params string[] parameters)
        {
            List<object> t;
            if (parameters.Length != 0)
            {
                t = (from shipment in Context.Shipments
                     group shipment by new {
                         Date = parameters.Contains("Date") ? shipment.Date : null,
                         Organization = parameters.Contains("Organization") ? shipment.Organization : null,
                         City = parameters.Contains("City") ? shipment.City : null,
                         Country = parameters.Contains("Country") ? shipment.Country : null,
                         Manager = parameters.Contains("Manager") ? shipment.Manager : null,
                     } into g
                     select new { Sum = g.Sum(k => k.Sum), Quantity = g.Sum(k => k.Quantity),
                         Date = g.Key.Date != null ? g.Key.Date : null,
                         Organization = g.Key.Organization != null? g.Key.Organization: null,
                         City = g.Key.City != null ? g.Key.City : null,
                         Country = g.Key.Country != null ? g.Key.Country : null,
                         Manager = g.Key.Manager != null ? g.Key.Manager : null
                     })
                        .ToList<object>();
            }
            else
            {
                t = Context.Shipments.Select(s => s).ToList<object>();
            }    
            var args = new ModelEventArgs(t);

            changed?.Invoke(this, args);
        }

        public void Attach(IView view)
        {
            changed += view.ModelChanged;
        }

        public void AddSomething()
        {
            Context.Shipments.Add(
                new Shipment()
                {
                    
                    City = "Dnipro",
                    Country = "Ukraine",
                    Date = DateTime.Now,
                    Manager = "manager",
                    Organization = "org",
                    Quantity = 1,
                    Sum = 100
                });
            Context.SaveChanges();
        }
    }
}
