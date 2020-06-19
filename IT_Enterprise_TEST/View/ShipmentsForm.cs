using System;
using System.Windows.Forms;
using IT_Enterprise_TEST.Models;
using IT_Enterprise_TEST.View;

namespace IT_Enterprise_TEST
{
    public partial class ShipmentsForm : Form, IView
    {
        IController _controller;
        public ShipmentsForm()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            _controller.GroupBy("Office");
        }

        public void ModelChanged(IModel sender, ModelEventArgs args)
        {
            BindingSource bindingSource1 = new BindingSource();
            bindingSource1.DataSource = args.Shipments;

            dataGridView1.DataSource = bindingSource1;
        }

        public void SetController(IController controller)
        {
            _controller = controller;
        }
    }
}
