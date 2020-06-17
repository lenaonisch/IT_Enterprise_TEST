namespace IT_Enterprise_TEST
{
    partial class Shipments
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ShipmentsDataSet = new System.Data.DataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.spipmentsDBDataSet = new IT_Enterprise_TEST.DataBase.SpipmentsDBDataSet();
            this.spipmentsDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ShipmentsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spipmentsDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spipmentsDBDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ShipmentsDataSet
            // 
            this.ShipmentsDataSet.DataSetName = "NewDataSet";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.spipmentsDBDataSetBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // spipmentsDBDataSet
            // 
            this.spipmentsDBDataSet.DataSetName = "SpipmentsDBDataSet";
            this.spipmentsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spipmentsDBDataSetBindingSource
            // 
            this.spipmentsDBDataSetBindingSource.DataSource = this.spipmentsDBDataSet;
            this.spipmentsDBDataSetBindingSource.Position = 0;
            // 
            // Shipments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Shipments";
            this.Text = "Shipments";
            ((System.ComponentModel.ISupportInitialize)(this.ShipmentsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spipmentsDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spipmentsDBDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Data.DataSet ShipmentsDataSet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource spipmentsDBDataSetBindingSource;
        private DataBase.SpipmentsDBDataSet spipmentsDBDataSet;
    }
}

