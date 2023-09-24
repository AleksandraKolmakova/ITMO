namespace LoadDataSetXml
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
            this.gdvCustomers = new System.Windows.Forms.DataGridView();
            this.gdvOrders = new System.Windows.Forms.DataGridView();
            this.lblCustomersTable = new System.Windows.Forms.Label();
            this.lblOrdersTable = new System.Windows.Forms.Label();
            this.btnLoadSchema = new System.Windows.Forms.Button();
            this.btnLoadData = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gdvCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // gdvCustomers
            // 
            this.gdvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvCustomers.Location = new System.Drawing.Point(26, 44);
            this.gdvCustomers.Name = "gdvCustomers";
            this.gdvCustomers.Size = new System.Drawing.Size(740, 120);
            this.gdvCustomers.TabIndex = 0;
            // 
            // gdvOrders
            // 
            this.gdvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvOrders.Location = new System.Drawing.Point(26, 227);
            this.gdvOrders.Name = "gdvOrders";
            this.gdvOrders.Size = new System.Drawing.Size(740, 120);
            this.gdvOrders.TabIndex = 1;
            // 
            // lblCustomersTable
            // 
            this.lblCustomersTable.AutoSize = true;
            this.lblCustomersTable.Location = new System.Drawing.Point(23, 18);
            this.lblCustomersTable.Name = "lblCustomersTable";
            this.lblCustomersTable.Size = new System.Drawing.Size(86, 13);
            this.lblCustomersTable.TabIndex = 2;
            this.lblCustomersTable.Text = "Customers Table";
            // 
            // lblOrdersTable
            // 
            this.lblOrdersTable.AutoSize = true;
            this.lblOrdersTable.Location = new System.Drawing.Point(23, 195);
            this.lblOrdersTable.Name = "lblOrdersTable";
            this.lblOrdersTable.Size = new System.Drawing.Size(65, 13);
            this.lblOrdersTable.TabIndex = 3;
            this.lblOrdersTable.Text = "OrdersTable";
            // 
            // btnLoadSchema
            // 
            this.btnLoadSchema.Location = new System.Drawing.Point(34, 372);
            this.btnLoadSchema.Name = "btnLoadSchema";
            this.btnLoadSchema.Size = new System.Drawing.Size(150, 50);
            this.btnLoadSchema.TabIndex = 4;
            this.btnLoadSchema.Text = "Load Schema";
            this.btnLoadSchema.UseVisualStyleBackColor = true;
            this.btnLoadSchema.Click += new System.EventHandler(this.btnLoadSchema_Click);
            // 
            // btnLoadData
            // 
            this.btnLoadData.Location = new System.Drawing.Point(211, 372);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(150, 50);
            this.btnLoadData.TabIndex = 5;
            this.btnLoadData.Text = "Load Data";
            this.btnLoadData.UseVisualStyleBackColor = true;
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLoadData);
            this.Controls.Add(this.btnLoadSchema);
            this.Controls.Add(this.lblOrdersTable);
            this.Controls.Add(this.lblCustomersTable);
            this.Controls.Add(this.gdvOrders);
            this.Controls.Add(this.gdvCustomers);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gdvCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gdvCustomers;
        private System.Windows.Forms.DataGridView gdvOrders;
        private System.Windows.Forms.Label lblCustomersTable;
        private System.Windows.Forms.Label lblOrdersTable;
        private System.Windows.Forms.Button btnLoadSchema;
        private System.Windows.Forms.Button btnLoadData;
    }
}

