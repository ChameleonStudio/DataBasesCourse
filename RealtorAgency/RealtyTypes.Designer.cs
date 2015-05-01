namespace RealtorAgency
{
    partial class RealtyTypes
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
            this.realtytypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.realtytypeTableAdapter = new RealtorAgency.realtoragencyDataSetTableAdapters.realtytypeTableAdapter();
            this.tableAdapterManager = new RealtorAgency.realtoragencyDataSetTableAdapters.TableAdapterManager();
            this.realtytypeDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.realtoragencyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.realtytypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.realtytypeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // realtoragencyDataSet
            // 
            this.realtoragencyDataSet.DataSetName = "realtoragencyDataSet";
            this.realtoragencyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // realtytypeBindingSource
            // 
            this.realtytypeBindingSource.DataMember = "realtytype";
            this.realtytypeBindingSource.DataSource = this.realtoragencyDataSet;
            // 
            // realtytypeTableAdapter
            // 
            this.realtytypeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clientTableAdapter = null;
            this.tableAdapterManager.dealTableAdapter = null;
            this.tableAdapterManager.orderTableAdapter = null;
            this.tableAdapterManager.ordertypeTableAdapter = null;
            this.tableAdapterManager.realtorTableAdapter = null;
            this.tableAdapterManager.realtyTableAdapter = null;
            this.tableAdapterManager.realtytypeTableAdapter = this.realtytypeTableAdapter;
            this.tableAdapterManager.regionTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = RealtorAgency.realtoragencyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // realtytypeDataGridView
            // 
            this.realtytypeDataGridView.AutoGenerateColumns = false;
            this.realtytypeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.realtytypeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2});
            this.realtytypeDataGridView.DataSource = this.realtytypeBindingSource;
            this.realtytypeDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.realtytypeDataGridView.Location = new System.Drawing.Point(0, 0);
            this.realtytypeDataGridView.Name = "realtytypeDataGridView";
            this.realtytypeDataGridView.Size = new System.Drawing.Size(309, 210);
            this.realtytypeDataGridView.TabIndex = 1;
            this.realtytypeDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.realtytypeDataGridView_DataError);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn2.HeaderText = "name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // RealtyType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 210);
            this.Controls.Add(this.realtytypeDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "RealtyType";
            this.Text = "Тип недвижимости";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RealtyType_FormClosing);
            this.Load += new System.EventHandler(this.RealtyType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.realtoragencyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.realtytypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.realtytypeDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private realtoragencyDataSet realtoragencyDataSet;
        private System.Windows.Forms.BindingSource realtytypeBindingSource;
        private realtoragencyDataSetTableAdapters.realtytypeTableAdapter realtytypeTableAdapter;
        private realtoragencyDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView realtytypeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}