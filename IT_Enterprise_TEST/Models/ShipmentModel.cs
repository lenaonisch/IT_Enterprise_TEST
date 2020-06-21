using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Dynamic;
using System.Text;
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
                // .Select("new ( Sum(Sum) as TotalSum, Sum(Quantity) as Quantity, Key.City as City)")
                StringBuilder selectClauseOtherParams = 
                    new StringBuilder("new ( Sum(Sum) as TotalSum, Sum(Quantity) as Quantity");
                foreach (string parameter in parameters)
                {
                    selectClauseOtherParams
                        .Append(", Key.")
                        .Append(parameter)
                        .Append(" as ")
                        .Append(parameter);
                }
                selectClauseOtherParams.Append(")");

                t = await Context.Shipments.GroupBy($"new({String.Join(",", parameters)})", "it")
                .Select(selectClauseOtherParams.ToString())
                .ToListAsync();
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
    }
}
