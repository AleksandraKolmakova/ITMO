namespace Lesson3Ex2
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
            this.cnNorthwind = new System.Data.SqlClient.SqlConnection();
            this.cmdSPCntProdInCat = new System.Data.SqlClient.SqlCommand();
            this.btnQueryDB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCategoryID = new System.Windows.Forms.TextBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.lstProducts = new System.Windows.Forms.ListBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lstCurrentProducts = new System.Windows.Forms.ListBox();
            this.lstDiscontunuedProducts = new System.Windows.Forms.ListBox();
            this.btnSumProducts = new System.Windows.Forms.Button();
            this.btnIncreacePrices = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cnNorthwind
            // 
            this.cnNorthwind.ConnectionString = "Data Source=DESKTOP-ILCCTBA\\SQLEXPRESS;Initial Catalog=northwnd;Integrated Securi" +
    "ty=True";
            this.cnNorthwind.FireInfoMessageEventOnUserErrors = false;
            // 
            // cmdSPCntProdInCat
            // 
            this.cmdSPCntProdInCat.CommandText = "CountProductsInCategory";
            this.cmdSPCntProdInCat.CommandType = System.Data.CommandType.StoredProcedure;
            this.cmdSPCntProdInCat.Connection = this.cnNorthwind;
            this.cmdSPCntProdInCat.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@CatID", System.Data.SqlDbType.Int, 4),
            new System.Data.SqlClient.SqlParameter("@CatName", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Output, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // btnQueryDB
            // 
            this.btnQueryDB.Location = new System.Drawing.Point(28, 96);
            this.btnQueryDB.Name = "btnQueryDB";
            this.btnQueryDB.Size = new System.Drawing.Size(75, 23);
            this.btnQueryDB.TabIndex = 0;
            this.btnQueryDB.Text = "QueryDB";
            this.btnQueryDB.UseVisualStyleBackColor = true;
            this.btnQueryDB.Click += new System.EventHandler(this.btnQueryDB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Category ID:";
            // 
            // txtCategoryID
            // 
            this.txtCategoryID.Location = new System.Drawing.Point(28, 58);
            this.txtCategoryID.Multiline = true;
            this.txtCategoryID.Name = "txtCategoryID";
            this.txtCategoryID.Size = new System.Drawing.Size(100, 20);
            this.txtCategoryID.TabIndex = 2;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(224, 26);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 3;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // lstProducts
            // 
            this.lstProducts.FormattingEnabled = true;
            this.lstProducts.Location = new System.Drawing.Point(224, 74);
            this.lstProducts.Name = "lstProducts";
            this.lstProducts.Size = new System.Drawing.Size(194, 160);
            this.lstProducts.TabIndex = 4;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(599, 26);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lstCurrentProducts
            // 
            this.lstCurrentProducts.FormattingEnabled = true;
            this.lstCurrentProducts.Location = new System.Drawing.Point(503, 74);
            this.lstCurrentProducts.Name = "lstCurrentProducts";
            this.lstCurrentProducts.Size = new System.Drawing.Size(120, 95);
            this.lstCurrentProducts.TabIndex = 6;
            // 
            // lstDiscontunuedProducts
            // 
            this.lstDiscontunuedProducts.FormattingEnabled = true;
            this.lstDiscontunuedProducts.Location = new System.Drawing.Point(643, 74);
            this.lstDiscontunuedProducts.Name = "lstDiscontunuedProducts";
            this.lstDiscontunuedProducts.Size = new System.Drawing.Size(131, 95);
            this.lstDiscontunuedProducts.TabIndex = 7;
            // 
            // btnSumProducts
            // 
            this.btnSumProducts.Location = new System.Drawing.Point(28, 287);
            this.btnSumProducts.Name = "btnSumProducts";
            this.btnSumProducts.Size = new System.Drawing.Size(146, 23);
            this.btnSumProducts.TabIndex = 8;
            this.btnSumProducts.Text = "Summarize Products";
            this.btnSumProducts.UseVisualStyleBackColor = true;
            this.btnSumProducts.Click += new System.EventHandler(this.btnSumProducts_Click);
            // 
            // btnIncreacePrices
            // 
            this.btnIncreacePrices.Location = new System.Drawing.Point(28, 346);
            this.btnIncreacePrices.Name = "btnIncreacePrices";
            this.btnIncreacePrices.Size = new System.Drawing.Size(146, 23);
            this.btnIncreacePrices.TabIndex = 9;
            this.btnIncreacePrices.Text = "IncreasePrices";
            this.btnIncreacePrices.UseVisualStyleBackColor = true;
            this.btnIncreacePrices.Click += new System.EventHandler(this.btnIncreacePrices_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(205, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(580, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "4";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 351);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnIncreacePrices);
            this.Controls.Add(this.btnSumProducts);
            this.Controls.Add(this.lstDiscontunuedProducts);
            this.Controls.Add(this.lstCurrentProducts);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lstProducts);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.txtCategoryID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnQueryDB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Data.SqlClient.SqlConnection cnNorthwind;
        private System.Data.SqlClient.SqlCommand cmdSPCntProdInCat;
        private System.Windows.Forms.Button btnQueryDB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCategoryID;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.ListBox lstProducts;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ListBox lstCurrentProducts;
        private System.Windows.Forms.ListBox lstDiscontunuedProducts;
        private System.Windows.Forms.Button btnSumProducts;
        private System.Windows.Forms.Button btnIncreacePrices;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

