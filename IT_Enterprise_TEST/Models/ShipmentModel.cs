using System.Linq;
using IT_Enterprise_TEST.DataBase;
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

        public void ChangeGrouping(params string[] parameters)
        {
            var t = Context.Shipments.Select(s=>s).ToList();
            var args = new ModelEventArgs(t);

            changed?.Invoke(this, args);
        }

        public void Attach(IView view)
        {
            changed += view.ModelChanged;
        }
    }
}
