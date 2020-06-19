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
            string[] parameters = new string[] { };
            if (checkBox1.Checked)
            {
                parameters = new string[] { "Organization" }; 
            }
            _controller.GroupBy(parameters);
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
