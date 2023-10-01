namespace Ex4.LINQsql_m
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
            this.btnTheBest10Products = new System.Windows.Forms.Button();
            this.lstTheBest10Products = new System.Windows.Forms.ListView();
            this.clmTenMost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmUnitPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnTheBest10Products
            // 
            this.btnTheBest10Products.Location = new System.Drawing.Point(32, 12);
            this.btnTheBest10Products.Name = "btnTheBest10Products";
            this.btnTheBest10Products.Size = new System.Drawing.Size(261, 51);
            this.btnTheBest10Products.TabIndex = 0;
            this.btnTheBest10Products.Text = "The 10 most expensive products";
            this.btnTheBest10Products.UseVisualStyleBackColor = true;
            this.btnTheBest10Products.Click += new System.EventHandler(this.btnTheBest10Products_Click);
            // 
            // lstTheBest10Products
            // 
            this.lstTheBest10Products.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmTenMost,
            this.clmUnitPrice});
            this.lstTheBest10Products.HideSelection = false;
            this.lstTheBest10Products.Location = new System.Drawing.Point(32, 69);
            this.lstTheBest10Products.Name = "lstTheBest10Products";
            this.lstTheBest10Products.Size = new System.Drawing.Size(261, 269);
            this.lstTheBest10Products.TabIndex = 1;
            this.lstTheBest10Products.UseCompatibleStateImageBehavior = false;
            this.lstTheBest10Products.View = System.Windows.Forms.View.Details;
            // 
            // clmTenMost
            // 
            this.clmTenMost.Text = "Ten Most";
            this.clmTenMost.Width = 141;
            // 
            // clmUnitPrice
            // 
            this.clmUnitPrice.Text = "Unit Price";
            this.clmUnitPrice.Width = 114;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 367);
            this.Controls.Add(this.lstTheBest10Products);
            this.Controls.Add(this.btnTheBest10Products);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTheBest10Products;
        private System.Windows.Forms.ListView lstTheBest10Products;
        private System.Windows.Forms.ColumnHeader clmTenMost;
        private System.Windows.Forms.ColumnHeader clmUnitPrice;
    }
}

