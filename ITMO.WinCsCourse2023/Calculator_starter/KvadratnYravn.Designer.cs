namespace Calculator
{
    partial class KvadratnYravn
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Koefa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Koefb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Koefc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ax² + bx + c = 0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Решение квадратных уравнений";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "a =";
            // 
            // Koefa
            // 
            this.Koefa.Location = new System.Drawing.Point(40, 80);
            this.Koefa.Name = "Koefa";
            this.Koefa.Size = new System.Drawing.Size(30, 20);
            this.Koefa.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "b =";
            // 
            // Koefb
            // 
            this.Koefb.Location = new System.Drawing.Point(100, 80);
            this.Koefb.Name = "Koefb";
            this.Koefb.Size = new System.Drawing.Size(30, 20);
            this.Koefb.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(140, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "c =";
            // 
            // Koefc
            // 
            this.Koefc.Location = new System.Drawing.Point(165, 80);
            this.Koefc.Name = "Koefc";
            this.Koefc.Size = new System.Drawing.Size(30, 20);
            this.Koefc.TabIndex = 7;
            // 
            // KvadratnYravn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 161);
            this.Controls.Add(this.Koefc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Koefb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Koefa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "KvadratnYravn";
            this.Text = "KvadratnYravn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Koefa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Koefb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Koefc;
    }
}