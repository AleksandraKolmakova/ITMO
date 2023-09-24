namespace DataViewExample
{
    partial class Form1
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
            this.dgvCustomerGrid = new System.Windows.Forms.DataGridView();
            this.txtSort = new System.Windows.Forms.TextBox();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.lblFilter = new System.Windows.Forms.Label();
            this.btnSetDataViewProperties = new System.Windows.Forms.Button();
            this.btnAddRow = new System.Windows.Forms.Button();
            this.customersTableAdapter1 = new DataViewExample.dsNorthwindTableAdapters.CustomersTableAdapter();
            this.ordersTableAdapter1 = new DataViewExample.dsNorthwindTableAdapters.OrdersTableAdapter();
            this.dsNorthwind1 = new DataViewExample.dsNorthwind();
            this.btnGetOrders = new System.Windows.Forms.Button();
            this.dgvDataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNorthwind1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCustomerGrid
            // 
            this.dgvCustomerGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomerGrid.Location = new System.Drawing.Point(12, 12);
            this.dgvCustomerGrid.Name = "dgvCustomerGrid";
            this.dgvCustomerGrid.Size = new System.Drawing.Size(345, 425);
            this.dgvCustomerGrid.TabIndex = 0;
            // 
            // txtSort
            // 
            this.txtSort.Location = new System.Drawing.Point(411, 31);
            this.txtSort.Multiline = true;
            this.txtSort.Name = "txtSort";
            this.txtSort.Size = new System.Drawing.Size(100, 20);
            this.txtSort.TabIndex = 1;
            this.txtSort.Text = "CustomerID";
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(411, 90);
            this.txtFilter.Multiline = true;
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(100, 20);
            this.txtFilter.TabIndex = 2;
            this.txtFilter.Text = "City = \'London\'";
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Location = new System.Drawing.Point(411, 12);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(26, 13);
            this.lblCustomerID.TabIndex = 3;
            this.lblCustomerID.Text = "Sort";
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Location = new System.Drawing.Point(411, 71);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(29, 13);
            this.lblFilter.TabIndex = 4;
            this.lblFilter.Text = "Filter";
            // 
            // btnSetDataViewProperties
            // 
            this.btnSetDataViewProperties.Location = new System.Drawing.Point(411, 134);
            this.btnSetDataViewProperties.Name = "btnSetDataViewProperties";
            this.btnSetDataViewProperties.Size = new System.Drawing.Size(100, 45);
            this.btnSetDataViewProperties.TabIndex = 5;
            this.btnSetDataViewProperties.Text = "Set Data View Properties";
            this.btnSetDataViewProperties.UseVisualStyleBackColor = true;
            this.btnSetDataViewProperties.Click += new System.EventHandler(this.btnSetDataViewProperties_Click);
            // 
            // btnAddRow
            // 
            this.btnAddRow.Location = new System.Drawing.Point(414, 263);
            this.btnAddRow.Name = "btnAddRow";
            this.btnAddRow.Size = new System.Drawing.Size(100, 45);
            this.btnAddRow.TabIndex = 6;
            this.btnAddRow.Text = "AddRow";
            this.btnAddRow.UseVisualStyleBackColor = true;
            this.btnAddRow.Click += new System.EventHandler(this.btnAddRow_Click);
            // 
            // customersTableAdapter1
            // 
            this.customersTableAdapter1.ClearBeforeFill = true;
            // 
            // ordersTableAdapter1
            // 
            this.ordersTableAdapter1.ClearBeforeFill = true;
            // 
            // dsNorthwind1
            // 
            this.dsNorthwind1.DataSetName = "dsNorthwind";
            this.dsNorthwind1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnGetOrders
            // 
            this.btnGetOrders.Location = new System.Drawing.Point(414, 212);
            this.btnGetOrders.Name = "btnGetOrders";
            this.btnGetOrders.Size = new System.Drawing.Size(100, 45);
            this.btnGetOrders.TabIndex = 7;
            this.btnGetOrders.Text = "Get Orders";
            this.btnGetOrders.UseVisualStyleBackColor = true;
            this.btnGetOrders.Click += new System.EventHandler(this.btnGetOrders_Click);
            // 
            // dgvDataGrid
            // 
            this.dgvDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataGrid.Location = new System.Drawing.Point(548, 12);
            this.dgvDataGrid.Name = "dgvDataGrid";
            this.dgvDataGrid.Size = new System.Drawing.Size(345, 425);
            this.dgvDataGrid.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 450);
            this.Controls.Add(this.dgvDataGrid);
            this.Controls.Add(this.btnGetOrders);
            this.Controls.Add(this.btnAddRow);
            this.Controls.Add(this.btnSetDataViewProperties);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.lblCustomerID);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.txtSort);
            this.Controls.Add(this.dgvCustomerGrid);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNorthwind1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCustomerGrid;
        private System.Windows.Forms.TextBox txtSort;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.Button btnSetDataViewProperties;
        private System.Windows.Forms.Button btnAddRow;
        private dsNorthwindTableAdapters.CustomersTableAdapter customersTableAdapter1;
        private dsNorthwindTableAdapters.OrdersTableAdapter ordersTableAdapter1;
        private dsNorthwind dsNorthwind1;
        private System.Windows.Forms.Button btnGetOrders;
        private System.Windows.Forms.DataGridView dgvDataGrid;
    }
}

