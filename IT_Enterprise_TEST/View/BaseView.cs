using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT_Enterprise_TEST.View
{
    class BaseView : Form
    {
        public BaseView()
        {
            ViewStartPage();
        }
        ShipmentsForm shipmentsForm { get; set; }
        void ViewStartPage()
        {
            shipmentsForm = new ShipmentsForm();
            shipmentsForm.Show();
        }
    }
}
