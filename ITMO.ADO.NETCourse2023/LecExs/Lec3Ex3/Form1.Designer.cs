﻿namespace Lesson3Ex1
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
            this.btnTran = new System.Windows.Forms.Button();
            this.cnNorthwindt = new System.Data.SqlClient.SqlConnection();
            this.SuspendLayout();
            // 
            // btnTran
            // 
            this.btnTran.Location = new System.Drawing.Point(122, 76);
            this.btnTran.Name = "btnTran";
            this.btnTran.Size = new System.Drawing.Size(112, 23);
            this.btnTran.TabIndex = 0;
            this.btnTran.Text = "Run Transaction";
            this.btnTran.UseVisualStyleBackColor = true;
            this.btnTran.Click += new System.EventHandler(this.btnTran_Click);
            // 
            // cnNorthwindt
            // 
            this.cnNorthwindt.ConnectionString = "Data Source=DESKTOP-ILCCTBA\\SQLEXPRESS;Initial Catalog=northwnd;Integrated Securi" +
    "ty=True";
            this.cnNorthwindt.FireInfoMessageEventOnUserErrors = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTran);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTran;
        private System.Data.SqlClient.SqlConnection cnNorthwindt;
    }
}

