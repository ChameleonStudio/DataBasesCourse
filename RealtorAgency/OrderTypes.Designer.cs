namespace RealtorAgency
{
    partial class OrderTypes
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
            this.realtoragencyDataSet = new RealtorAgency.realtoragencyDataSet();
            this.ordertypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordertypeTableAdapter = new RealtorAgency.realtoragencyDataSetTableAdapters.ordertypeTableAdapter();
            this.tableAdapterManager = new RealtorAgency.realtoragencyDataSetTableAdapters.TableAdapterManager();
            this.ordertypeDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.realtoragencyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordertypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordertypeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // realtoragencyDataSet
            // 
            this.realtoragencyDataSet.DataSetName = "realtoragencyDataSet";
            this.realtoragencyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordertypeBindingSource
            // 
            this.ordertypeBindingSource.DataMember = "ordertype";
            this.ordertypeBindingSource.DataSource = this.realtoragencyDataSet;
            // 
            // ordertypeTableAdapter
            // 
            this.ordertypeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clientTableAdapter = null;
            this.tableAdapterManager.dealTableAdapter = null;
            this.tableAdapterManager.orderTableAdapter = null;
            this.tableAdapterManager.ordertypeTableAdapter = this.ordertypeTableAdapter;
            this.tableAdapterManager.realtorTableAdapter = null;
            this.tableAdapterManager.realtyTableAdapter = null;
            this.tableAdapterManager.realtytypeTableAdapter = null;
            this.tableAdapterManager.regionTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = RealtorAgency.realtoragencyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // ordertypeDataGridView
            // 
            this.ordertypeDataGridView.AutoGenerateColumns = false;
            this.ordertypeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordertypeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2});
            this.ordertypeDataGridView.DataSource = this.ordertypeBindingSource;
            this.ordertypeDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ordertypeDataGridView.Location = new System.Drawing.Point(0, 0);
            this.ordertypeDataGridView.Name = "ordertypeDataGridView";
            this.ordertypeDataGridView.Size = new System.Drawing.Size(336, 255);
            this.ordertypeDataGridView.TabIndex = 1;
            this.ordertypeDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.ordertypeDataGridView_DataError);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn2.HeaderText = "name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // OrderTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 255);
            this.Controls.Add(this.ordertypeDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "OrderTypes";
            this.Text = "Типы объявлений";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OrderTypes_FormClosing);
            this.Load += new System.EventHandler(this.OrderTypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.realtoragencyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordertypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordertypeDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private realtoragencyDataSet realtoragencyDataSet;
        private System.Windows.Forms.BindingSource ordertypeBindingSource;
        private realtoragencyDataSetTableAdapters.ordertypeTableAdapter ordertypeTableAdapter;
        private realtoragencyDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView ordertypeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}