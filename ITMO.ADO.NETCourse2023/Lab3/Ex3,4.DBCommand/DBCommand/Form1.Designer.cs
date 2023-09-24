namespace DBCommand
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
            this.cmdDtQuery = new System.Data.SqlClient.SqlCommand();
            this.btnDtQuery = new System.Windows.Forms.Button();
            this.lstCust = new System.Windows.Forms.ListBox();
            this.ResultsTextBox = new System.Windows.Forms.TextBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.cmdTenMostExpProd = new System.Data.SqlClient.SqlCommand();
            this.txtMostExpProd = new System.Windows.Forms.TextBox();
            this.btnMostExpProd = new System.Windows.Forms.Button();
            this.cmdCreateTable = new System.Data.SqlClient.SqlCommand();
            this.btnCreateTb = new System.Windows.Forms.Button();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.btnParReq = new System.Windows.Forms.Button();
            this.cmdParametrRequest = new System.Data.SqlClient.SqlCommand();
            this.txtResultsCity = new System.Windows.Forms.TextBox();
            this.btnParamStorProc = new System.Windows.Forms.Button();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.txtOrdYear = new System.Windows.Forms.TextBox();
            this.txtResultsParStProc = new System.Windows.Forms.TextBox();
            this.cmdParamStorProc = new System.Data.SqlClient.SqlCommand();
            this.SuspendLayout();
            // 
            // cnNorthwind
            // 
            this.cnNorthwind.ConnectionString = "Data Source=DESKTOP-ILCCTBA\\SQLEXPRESS;Initial Catalog=northwnd;Integrated Securi" +
    "ty=True;Pooling=False";
            this.cnNorthwind.FireInfoMessageEventOnUserErrors = false;
            // 
            // cmdDtQuery
            // 
            this.cmdDtQuery.CommandText = "SELECT        CustomerID, CompanyName\r\nFROM            Customers";
            this.cmdDtQuery.Connection = this.cnNorthwind;
            // 
            // btnDtQuery
            // 
            this.btnDtQuery.Location = new System.Drawing.Point(7, 208);
            this.btnDtQuery.Name = "btnDtQuery";
            this.btnDtQuery.Size = new System.Drawing.Size(111, 45);
            this.btnDtQuery.TabIndex = 0;
            this.btnDtQuery.Text = "Data Request";
            this.btnDtQuery.UseVisualStyleBackColor = true;
            this.btnDtQuery.Click += new System.EventHandler(this.btnDtQuery_Click);
            // 
            // lstCust
            // 
            this.lstCust.FormattingEnabled = true;
            this.lstCust.Location = new System.Drawing.Point(12, 44);
            this.lstCust.Name = "lstCust";
            this.lstCust.Size = new System.Drawing.Size(279, 95);
            this.lstCust.TabIndex = 1;
            // 
            // ResultsTextBox
            // 
            this.ResultsTextBox.Location = new System.Drawing.Point(7, 259);
            this.ResultsTextBox.Multiline = true;
            this.ResultsTextBox.Name = "ResultsTextBox";
            this.ResultsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ResultsTextBox.Size = new System.Drawing.Size(729, 20);
            this.ResultsTextBox.TabIndex = 2;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(12, 12);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(120, 26);
            this.btnLoad.TabIndex = 3;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // cmdTenMostExpProd
            // 
            this.cmdTenMostExpProd.CommandText = "Ten Most Expensive Products";
            this.cmdTenMostExpProd.CommandType = System.Data.CommandType.StoredProcedure;
            this.cmdTenMostExpProd.Connection = this.cnNorthwind;
            this.cmdTenMostExpProd.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // txtMostExpProd
            // 
            this.txtMostExpProd.Location = new System.Drawing.Point(8, 355);
            this.txtMostExpProd.Multiline = true;
            this.txtMostExpProd.Name = "txtMostExpProd";
            this.txtMostExpProd.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMostExpProd.Size = new System.Drawing.Size(729, 20);
            this.txtMostExpProd.TabIndex = 4;
            // 
            // btnMostExpProd
            // 
            this.btnMostExpProd.Location = new System.Drawing.Point(7, 305);
            this.btnMostExpProd.Name = "btnMostExpProd";
            this.btnMostExpProd.Size = new System.Drawing.Size(116, 44);
            this.btnMostExpProd.TabIndex = 5;
            this.btnMostExpProd.Text = "Ten Most Expensive Products";
            this.btnMostExpProd.UseVisualStyleBackColor = true;
            this.btnMostExpProd.Click += new System.EventHandler(this.btnMostExpProd_Click);
            // 
            // cmdCreateTable
            // 
            this.cmdCreateTable.Connection = this.cnNorthwind;
            // 
            // btnCreateTb
            // 
            this.btnCreateTb.Location = new System.Drawing.Point(8, 396);
            this.btnCreateTb.Name = "btnCreateTb";
            this.btnCreateTb.Size = new System.Drawing.Size(115, 42);
            this.btnCreateTb.TabIndex = 6;
            this.btnCreateTb.Text = "Create New Table";
            this.btnCreateTb.UseVisualStyleBackColor = true;
            this.btnCreateTb.Click += new System.EventHandler(this.btnCreateTb_Click);
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(362, 55);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(100, 20);
            this.txtCity.TabIndex = 7;
            this.txtCity.Text = "London";
            // 
            // btnParReq
            // 
            this.btnParReq.Location = new System.Drawing.Point(362, 15);
            this.btnParReq.Name = "btnParReq";
            this.btnParReq.Size = new System.Drawing.Size(161, 34);
            this.btnParReq.TabIndex = 8;
            this.btnParReq.Text = "Parameter Request";
            this.btnParReq.UseVisualStyleBackColor = true;
            this.btnParReq.Click += new System.EventHandler(this.btnParReq_Click);
            // 
            // cmdParametrRequest
            // 
            this.cmdParametrRequest.CommandText = "SELECT        CustomerID, CompanyName, City\r\nFROM            Customers\r\nWHERE    " +
    "    (City = @City)";
            this.cmdParametrRequest.Connection = this.cnNorthwind;
            this.cmdParametrRequest.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@City", System.Data.SqlDbType.NVarChar, 15, "City")});
            // 
            // txtResultsCity
            // 
            this.txtResultsCity.Location = new System.Drawing.Point(362, 81);
            this.txtResultsCity.Name = "txtResultsCity";
            this.txtResultsCity.Size = new System.Drawing.Size(340, 20);
            this.txtResultsCity.TabIndex = 9;
            this.txtResultsCity.Text = "Results";
            // 
            // btnParamStorProc
            // 
            this.btnParamStorProc.Location = new System.Drawing.Point(362, 115);
            this.btnParamStorProc.Name = "btnParamStorProc";
            this.btnParamStorProc.Size = new System.Drawing.Size(161, 37);
            this.btnParamStorProc.TabIndex = 10;
            this.btnParamStorProc.Text = "Parameter Stored Procedure";
            this.btnParamStorProc.UseVisualStyleBackColor = true;
            this.btnParamStorProc.Click += new System.EventHandler(this.btnParamStorProc_Click);
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Location = new System.Drawing.Point(362, 159);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(84, 20);
            this.txtCategoryName.TabIndex = 11;
            this.txtCategoryName.Text = "Beverages";
            // 
            // txtOrdYear
            // 
            this.txtOrdYear.Location = new System.Drawing.Point(469, 159);
            this.txtOrdYear.Name = "txtOrdYear";
            this.txtOrdYear.Size = new System.Drawing.Size(54, 20);
            this.txtOrdYear.TabIndex = 12;
            this.txtOrdYear.Text = "1997";
            // 
            // txtResultsParStProc
            // 
            this.txtResultsParStProc.Location = new System.Drawing.Point(362, 186);
            this.txtResultsParStProc.Name = "txtResultsParStProc";
            this.txtResultsParStProc.Size = new System.Drawing.Size(161, 20);
            this.txtResultsParStProc.TabIndex = 13;
            this.txtResultsParStProc.Text = "Results";
            // 
            // cmdParamStorProc
            // 
            this.cmdParamStorProc.CommandText = "SalesByCategory";
            this.cmdParamStorProc.CommandType = System.Data.CommandType.StoredProcedure;
            this.cmdParamStorProc.Connection = this.cnNorthwind;
            this.cmdParamStorProc.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@CategoryName", System.Data.SqlDbType.NVarChar, 15),
            new System.Data.SqlClient.SqlParameter("@OrdYear", System.Data.SqlDbType.NVarChar, 4)});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtResultsParStProc);
            this.Controls.Add(this.txtOrdYear);
            this.Controls.Add(this.txtCategoryName);
            this.Controls.Add(this.btnParamStorProc);
            this.Controls.Add(this.txtResultsCity);
            this.Controls.Add(this.btnParReq);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.btnCreateTb);
            this.Controls.Add(this.btnMostExpProd);
            this.Controls.Add(this.txtMostExpProd);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.ResultsTextBox);
            this.Controls.Add(this.lstCust);
            this.Controls.Add(this.btnDtQuery);
            this.Name = "Form1";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Data.SqlClient.SqlConnection cnNorthwind;
        private System.Data.SqlClient.SqlCommand cmdDtQuery;
        private System.Windows.Forms.Button btnDtQuery;
        private System.Windows.Forms.ListBox lstCust;
        private System.Windows.Forms.TextBox ResultsTextBox;
        private System.Windows.Forms.Button btnLoad;
        private System.Data.SqlClient.SqlCommand cmdTenMostExpProd;
        private System.Windows.Forms.TextBox txtMostExpProd;
        private System.Windows.Forms.Button btnMostExpProd;
        private System.Data.SqlClient.SqlCommand cmdCreateTable;
        private System.Windows.Forms.Button btnCreateTb;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Button btnParReq;
        private System.Data.SqlClient.SqlCommand cmdParametrRequest;
        private System.Windows.Forms.TextBox txtResultsCity;
        private System.Windows.Forms.Button btnParamStorProc;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.TextBox txtOrdYear;
        private System.Windows.Forms.TextBox txtResultsParStProc;
        private System.Data.SqlClient.SqlCommand cmdParamStorProc;
    }
}

