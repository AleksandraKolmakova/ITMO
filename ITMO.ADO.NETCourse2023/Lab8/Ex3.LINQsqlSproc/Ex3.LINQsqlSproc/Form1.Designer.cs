namespace Ex3.LINQsqlSproc
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
            this.btnOrderDetails = new System.Windows.Forms.Button();
            this.btnOrderStory = new System.Windows.Forms.Button();
            this.lblEnterOrderID = new System.Windows.Forms.Label();
            this.lblEnterClientID = new System.Windows.Forms.Label();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.txtClientID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnOrderDetails
            // 
            this.btnOrderDetails.Location = new System.Drawing.Point(44, 96);
            this.btnOrderDetails.Name = "btnOrderDetails";
            this.btnOrderDetails.Size = new System.Drawing.Size(100, 37);
            this.btnOrderDetails.TabIndex = 0;
            this.btnOrderDetails.Text = "Order Details";
            this.btnOrderDetails.UseVisualStyleBackColor = true;
            this.btnOrderDetails.Click += new System.EventHandler(this.btnOrderDetails_Click);
            // 
            // btnOrderStory
            // 
            this.btnOrderStory.Location = new System.Drawing.Point(231, 96);
            this.btnOrderStory.Name = "btnOrderStory";
            this.btnOrderStory.Size = new System.Drawing.Size(100, 37);
            this.btnOrderStory.TabIndex = 1;
            this.btnOrderStory.Text = "Order Story";
            this.btnOrderStory.UseVisualStyleBackColor = true;
            this.btnOrderStory.Click += new System.EventHandler(this.btnOrderStory_Click);
            // 
            // lblEnterOrderID
            // 
            this.lblEnterOrderID.AutoSize = true;
            this.lblEnterOrderID.Location = new System.Drawing.Point(41, 25);
            this.lblEnterOrderID.Name = "lblEnterOrderID";
            this.lblEnterOrderID.Size = new System.Drawing.Size(73, 13);
            this.lblEnterOrderID.TabIndex = 2;
            this.lblEnterOrderID.Text = "Enter order ID";
            // 
            // lblEnterClientID
            // 
            this.lblEnterClientID.AutoSize = true;
            this.lblEnterClientID.Location = new System.Drawing.Point(228, 25);
            this.lblEnterClientID.Name = "lblEnterClientID";
            this.lblEnterClientID.Size = new System.Drawing.Size(74, 13);
            this.lblEnterClientID.TabIndex = 3;
            this.lblEnterClientID.Text = "Enter client ID";
            // 
            // txtOrderID
            // 
            this.txtOrderID.Location = new System.Drawing.Point(44, 51);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(100, 20);
            this.txtOrderID.TabIndex = 4;
            // 
            // txtClientID
            // 
            this.txtClientID.Location = new System.Drawing.Point(231, 51);
            this.txtClientID.Name = "txtClientID";
            this.txtClientID.Size = new System.Drawing.Size(100, 20);
            this.txtClientID.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 194);
            this.Controls.Add(this.txtClientID);
            this.Controls.Add(this.txtOrderID);
            this.Controls.Add(this.lblEnterClientID);
            this.Controls.Add(this.lblEnterOrderID);
            this.Controls.Add(this.btnOrderStory);
            this.Controls.Add(this.btnOrderDetails);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOrderDetails;
        private System.Windows.Forms.Button btnOrderStory;
        private System.Windows.Forms.Label lblEnterOrderID;
        private System.Windows.Forms.Label lblEnterClientID;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.TextBox txtClientID;
    }
}

