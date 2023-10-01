namespace Ex1_3.LINQsql1_1
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
            this.lstCustomersAndCities = new System.Windows.Forms.ListBox();
            this.btnCustomersAndCities = new System.Windows.Forms.Button();
            this.lstCustomersOrders = new System.Windows.Forms.ListView();
            this.chCustomerID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chOrdersCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnCustomersOrders = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstCustomersAndCities
            // 
            this.lstCustomersAndCities.FormattingEnabled = true;
            this.lstCustomersAndCities.HorizontalScrollbar = true;
            this.lstCustomersAndCities.Location = new System.Drawing.Point(34, 25);
            this.lstCustomersAndCities.Name = "lstCustomersAndCities";
            this.lstCustomersAndCities.Size = new System.Drawing.Size(131, 212);
            this.lstCustomersAndCities.TabIndex = 0;
            // 
            // btnCustomersAndCities
            // 
            this.btnCustomersAndCities.Location = new System.Drawing.Point(34, 266);
            this.btnCustomersAndCities.Name = "btnCustomersAndCities";
            this.btnCustomersAndCities.Size = new System.Drawing.Size(131, 65);
            this.btnCustomersAndCities.TabIndex = 1;
            this.btnCustomersAndCities.Text = "Customers in London";
            this.btnCustomersAndCities.UseVisualStyleBackColor = true;
            this.btnCustomersAndCities.Click += new System.EventHandler(this.btnCustomersAndCities_Click);
            // 
            // lstCustomersOrders
            // 
            this.lstCustomersOrders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chCustomerID,
            this.chCity,
            this.chOrdersCount});
            this.lstCustomersOrders.HideSelection = false;
            this.lstCustomersOrders.Location = new System.Drawing.Point(202, 25);
            this.lstCustomersOrders.Name = "lstCustomersOrders";
            this.lstCustomersOrders.Size = new System.Drawing.Size(289, 212);
            this.lstCustomersOrders.TabIndex = 2;
            this.lstCustomersOrders.UseCompatibleStateImageBehavior = false;
            this.lstCustomersOrders.View = System.Windows.Forms.View.Details;
            // 
            // chCustomerID
            // 
            this.chCustomerID.Text = "CustomerID";
            this.chCustomerID.Width = 91;
            // 
            // chCity
            // 
            this.chCity.Text = "City";
            this.chCity.Width = 91;
            // 
            // chOrdersCount
            // 
            this.chOrdersCount.Text = "OrdersCount";
            this.chOrdersCount.Width = 94;
            // 
            // btnCustomersOrders
            // 
            this.btnCustomersOrders.Location = new System.Drawing.Point(265, 266);
            this.btnCustomersOrders.Name = "btnCustomersOrders";
            this.btnCustomersOrders.Size = new System.Drawing.Size(143, 65);
            this.btnCustomersOrders.TabIndex = 3;
            this.btnCustomersOrders.Text = "Customers and Orders";
            this.btnCustomersOrders.UseVisualStyleBackColor = true;
            this.btnCustomersOrders.Click += new System.EventHandler(this.btnCustomersOrders_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCustomersOrders);
            this.Controls.Add(this.lstCustomersOrders);
            this.Controls.Add(this.btnCustomersAndCities);
            this.Controls.Add(this.lstCustomersAndCities);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstCustomersAndCities;
        private System.Windows.Forms.Button btnCustomersAndCities;
        private System.Windows.Forms.ListView lstCustomersOrders;
        private System.Windows.Forms.ColumnHeader chCustomerID;
        private System.Windows.Forms.ColumnHeader chCity;
        private System.Windows.Forms.ColumnHeader chOrdersCount;
        private System.Windows.Forms.Button btnCustomersOrders;
    }
}

