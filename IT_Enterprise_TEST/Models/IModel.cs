using IT_Enterprise_TEST.Entities;
using IT_Enterprise_TEST.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_Enterprise_TEST.Models
{
    public class ModelEventArgs
    {
        public List<Shipment> Shipments { get; set; }

        public ModelEventArgs(List<Shipment> shipments)
        {
            Shipments = shipments;
        }
    }
    public interface IModel
    {
        void ChangeGrouping(params string[] parameters);
        void Attach(IView view);
    }
}
