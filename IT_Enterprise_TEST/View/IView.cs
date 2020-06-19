using IT_Enterprise_TEST.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_Enterprise_TEST.View
{
    public delegate void ViewHandler<IView>(IView sender, ViewEventArgs e);

    public class ViewEventArgs : EventArgs
    {
        public string[] GroupParams;
        public ViewEventArgs(params string[] parameters) { GroupParams = parameters; }
    }
    public interface IView
    {
        void SetController(IController controller);
        void ModelChanged(IModel sender, ModelEventArgs args);
    }
}
