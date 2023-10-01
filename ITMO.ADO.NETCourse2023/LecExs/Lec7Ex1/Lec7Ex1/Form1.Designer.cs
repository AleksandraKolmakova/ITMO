namespace Lec7Ex1
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
            this.btnLoadCards = new System.Windows.Forms.Button();
            this.lvCards = new System.Windows.Forms.ListView();
            this.lblCard = new System.Windows.Forms.Label();
            this.btnLINQ = new System.Windows.Forms.Button();
            this.lvNewCustomer = new System.Windows.Forms.ListView();
            this.cnNorthwind = new System.Data.SqlClient.SqlConnection();
            this.SuspendLayout();
            // 
            // btnLoadCards
            // 
            this.btnLoadCards.Location = new System.Drawing.Point(12, 328);
            this.btnLoadCards.Name = "btnLoadCards";
            this.btnLoadCards.Size = new System.Drawing.Size(75, 23);
            this.btnLoadCards.TabIndex = 0;
            this.btnLoadCards.Text = "Load Cards";
            this.btnLoadCards.UseVisualStyleBackColor = true;
            this.btnLoadCards.Click += new System.EventHandler(this.btnLoadCards_Click);
            // 
            // lvCards
            // 
            this.lvCards.HideSelection = false;
            this.lvCards.Location = new System.Drawing.Point(12, 12);
            this.lvCards.Name = "lvCards";
            this.lvCards.Size = new System.Drawing.Size(541, 295);
            this.lvCards.TabIndex = 1;
            this.lvCards.UseCompatibleStateImageBehavior = false;
            this.lvCards.View = System.Windows.Forms.View.List;
            // 
            // lblCard
            // 
            this.lblCard.AutoSize = true;
            this.lblCard.Location = new System.Drawing.Point(12, 371);
            this.lblCard.Name = "lblCard";
            this.lblCard.Size = new System.Drawing.Size(29, 13);
            this.lblCard.TabIndex = 2;
            this.lblCard.Text = "Card";
            // 
            // btnLINQ
            // 
            this.btnLINQ.Location = new System.Drawing.Point(573, 328);
            this.btnLINQ.Name = "btnLINQ";
            this.btnLINQ.Size = new System.Drawing.Size(75, 23);
            this.btnLINQ.TabIndex = 3;
            this.btnLINQ.Text = "LINQ Query";
            this.btnLINQ.UseVisualStyleBackColor = true;
            this.btnLINQ.Click += new System.EventHandler(this.btnLINQ_Click);
            // 
            // lvNewCustomer
            // 
            this.lvNewCustomer.HideSelection = false;
            this.lvNewCustomer.Location = new System.Drawing.Point(573, 12);
            this.lvNewCustomer.Name = "lvNewCustomer";
            this.lvNewCustomer.Size = new System.Drawing.Size(199, 295);
            this.lvNewCustomer.TabIndex = 4;
            this.lvNewCustomer.UseCompatibleStateImageBehavior = false;
            this.lvNewCustomer.View = System.Windows.Forms.View.List;
            // 
            // cnNorthwind
            // 
            this.cnNorthwind.ConnectionString = "Data Source=DESKTOP-ILCCTBA\\SQLEXPRESS;Initial Catalog=northwnd;Integrated Securi" +
    "ty=True";
            this.cnNorthwind.FireInfoMessageEventOnUserErrors = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 401);
            this.Controls.Add(this.lvNewCustomer);
            this.Controls.Add(this.btnLINQ);
            this.Controls.Add(this.lblCard);
            this.Controls.Add(this.lvCards);
            this.Controls.Add(this.btnLoadCards);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoadCards;
        private System.Windows.Forms.ListView lvCards;
        private System.Windows.Forms.Label lblCard;
        private System.Windows.Forms.Button btnLINQ;
        private System.Windows.Forms.ListView lvNewCustomer;
        private System.Data.SqlClient.SqlConnection cnNorthwind;
    }
}

