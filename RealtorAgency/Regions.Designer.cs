namespace RealtorAgency
{
    partial class Regions
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
            this.regionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.regionTableAdapter = new RealtorAgency.realtoragencyDataSetTableAdapters.regionTableAdapter();
            this.tableAdapterManager = new RealtorAgency.realtoragencyDataSetTableAdapters.TableAdapterManager();
            this.regionDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.realtoragencyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regionDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // realtoragencyDataSet
            // 
            this.realtoragencyDataSet.DataSetName = "realtoragencyDataSet";
            this.realtoragencyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // regionBindingSource
            // 
            this.regionBindingSource.DataMember = "region";
            this.regionBindingSource.DataSource = this.realtoragencyDataSet;
            // 
            // regionTableAdapter
            // 
            this.regionTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.realtytypeTableAdapter = null;
            this.tableAdapterManager.regionTableAdapter = this.regionTableAdapter;
            this.tableAdapterManager.UpdateOrder = RealtorAgency.realtoragencyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // regionDataGridView
            // 
            this.regionDataGridView.AutoGenerateColumns = false;
            this.regionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.regionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2});
            this.regionDataGridView.DataSource = this.regionBindingSource;
            this.regionDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.regionDataGridView.Location = new System.Drawing.Point(0, 0);
            this.regionDataGridView.Name = "regionDataGridView";
            this.regionDataGridView.Size = new System.Drawing.Size(327, 289);
            this.regionDataGridView.TabIndex = 1;
            this.regionDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.regionDataGridView_DataError);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn2.HeaderText = "name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // Regions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 289);
            this.Controls.Add(this.regionDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Regions";
            this.Text = "Районы";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Regions_FormClosing);
            this.Load += new System.EventHandler(this.Regions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.realtoragencyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regionDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private realtoragencyDataSet realtoragencyDataSet;
        private System.Windows.Forms.BindingSource regionBindingSource;
        private realtoragencyDataSetTableAdapters.regionTableAdapter regionTableAdapter;
        private realtoragencyDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView regionDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}