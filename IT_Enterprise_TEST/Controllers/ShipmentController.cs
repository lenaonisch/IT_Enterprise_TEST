using IT_Enterprise_TEST.Models;
using IT_Enterprise_TEST.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_Enterprise_TEST.Controllers
{
    class ShipmentController : IController
    {
        IView _view;
        IModel _model;

        public ShipmentController(IView view, IModel model)
        {
            _view = view;
            _model = model;
            _view.SetController(this);
            _model.Attach(_view);
        }

        public void GroupBy(params string[] props)
        {
            _model.ChangeGrouping(props);
        }
    }
}
