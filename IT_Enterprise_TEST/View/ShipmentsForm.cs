using System;
using System.Collections.Generic;
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
            List<string> parameters = new List<string>();
            foreach(var item in lbGroupingParameters.SelectedItems)
            {
                parameters.Add(item.ToString());
            }
            _controller.GroupBy(parameters.ToArray());
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

        private void button1_Click(object sender, EventArgs e)
        {
            _controller.AddSomething();
        }
    }
}
