namespace Lesson3Ex3
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
            this.txtMaxPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGetCheapest = new System.Windows.Forms.Button();
            this.cnNorthwind = new System.Data.SqlClient.SqlConnection();
            this.cmdCheapProducts = new System.Data.SqlClient.SqlCommand();
            this.cmdProductCount = new System.Data.SqlClient.SqlCommand();
            this.txtproductCnt = new System.Windows.Forms.TextBox();
            this.txtExpensiveProduct = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtMaxPrice
            // 
            this.txtMaxPrice.Location = new System.Drawing.Point(63, 80);
            this.txtMaxPrice.Name = "txtMaxPrice";
            this.txtMaxPrice.Size = new System.Drawing.Size(100, 20);
            this.txtMaxPrice.TabIndex = 0;
            this.txtMaxPrice.TextChanged += new System.EventHandler(this.txtMaxPrice_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter max unit price:";
            // 
            // btnGetCheapest
            // 
            this.btnGetCheapest.Location = new System.Drawing.Point(274, 48);
            this.btnGetCheapest.Name = "btnGetCheapest";
            this.btnGetCheapest.Size = new System.Drawing.Size(134, 52);
            this.btnGetCheapest.TabIndex = 2;
            this.btnGetCheapest.Text = "Get product count";
            this.btnGetCheapest.UseVisualStyleBackColor = true;
            this.btnGetCheapest.Click += new System.EventHandler(this.btnGetCheapest_Click);
            // 
            // cnNorthwind
            // 
            this.cnNorthwind.ConnectionString = "Data Source=DESKTOP-ILCCTBA\\SQLEXPRESS;Initial Catalog=northwnd;Integrated Securi" +
    "ty=True";
            this.cnNorthwind.FireInfoMessageEventOnUserErrors = false;
            // 
            // cmdCheapProducts
            // 
            this.cmdCheapProducts.CommandText = "SELECT        ProductName, UnitPrice\r\nFROM            Products\r\nWHERE        (Uni" +
    "tPrice < @price)\r\nORDER BY UnitPrice DESC";
            this.cmdCheapProducts.Connection = this.cnNorthwind;
            this.cmdCheapProducts.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@price", System.Data.SqlDbType.Money, 8, "UnitPrice")});
            // 
            // cmdProductCount
            // 
            this.cmdProductCount.CommandText = "SELECT        COUNT(*) AS ProductCount\r\nFROM            Products";
            this.cmdProductCount.Connection = this.cnNorthwind;
            // 
            // txtproductCnt
            // 
            this.txtproductCnt.Location = new System.Drawing.Point(292, 106);
            this.txtproductCnt.Name = "txtproductCnt";
            this.txtproductCnt.Size = new System.Drawing.Size(100, 20);
            this.txtproductCnt.TabIndex = 3;
            // 
            // txtExpensiveProduct
            // 
            this.txtExpensiveProduct.Location = new System.Drawing.Point(63, 106);
            this.txtExpensiveProduct.Multiline = true;
            this.txtExpensiveProduct.Name = "txtExpensiveProduct";
            this.txtExpensiveProduct.Size = new System.Drawing.Size(100, 20);
            this.txtExpensiveProduct.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 181);
            this.Controls.Add(this.txtExpensiveProduct);
            this.Controls.Add(this.txtproductCnt);
            this.Controls.Add(this.btnGetCheapest);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMaxPrice);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMaxPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGetCheapest;
        private System.Data.SqlClient.SqlConnection cnNorthwind;
        private System.Data.SqlClient.SqlCommand cmdCheapProducts;
        private System.Data.SqlClient.SqlCommand cmdProductCount;
        private System.Windows.Forms.TextBox txtproductCnt;
        private System.Windows.Forms.TextBox txtExpensiveProduct;
    }
}

