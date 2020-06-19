using IT_Enterprise_TEST.Controllers;
using IT_Enterprise_TEST.Models;
using IT_Enterprise_TEST.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT_Enterprise_TEST
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ShipmentsForm view = new ShipmentsForm();
            IModel model = new ShipmentModel();
            IController controller = new ShipmentController(view, model);

            Application.Run(view);
        }
    }
}
