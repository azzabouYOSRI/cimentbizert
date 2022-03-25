namespace cimentbizert
{
    partial class somme
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
            System.Windows.Forms.TextBox result;
            this.years = new System.Windows.Forms.TextBox();
            this.supp = new System.Windows.Forms.Button();
            this.months = new System.Windows.Forms.TextBox();
            this.bb = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // result
            // 
            result.Location = new System.Drawing.Point(559, 142);
            result.Name = "result";
            result.Size = new System.Drawing.Size(51, 20);
            result.TabIndex = 5;
            // 
            // years
            // 
            this.years.Location = new System.Drawing.Point(207, 100);
            this.years.Name = "years";
            this.years.Size = new System.Drawing.Size(72, 20);
            this.years.TabIndex = 3;
            this.years.TextChanged += new System.EventHandler(this.SU1_TextChanged);
            // 
            // supp
            // 
            this.supp.Location = new System.Drawing.Point(545, 100);
            this.supp.Name = "supp";
            this.supp.Size = new System.Drawing.Size(75, 23);
            this.supp.TabIndex = 2;
            this.supp.Text = "calculer";
            this.supp.UseVisualStyleBackColor = true;
            this.supp.Click += new System.EventHandler(this.supp_Click);
            // 
            // months
            // 
            this.months.Location = new System.Drawing.Point(207, 142);
            this.months.Name = "months";
            this.months.Size = new System.Drawing.Size(51, 20);
            this.months.TabIndex = 4;
            // 
            // bb
            // 
            this.bb.AutoSize = true;
            this.bb.Location = new System.Drawing.Point(304, 29);
            this.bb.Name = "bb";
            this.bb.Size = new System.Drawing.Size(130, 13);
            this.bb.TabIndex = 29;
            this.bb.Text = "somme de remboursement";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(401, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "resultat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "month (optinal)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(121, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "the year";
            // 
            // somme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bb);
            this.Controls.Add(result);
            this.Controls.Add(this.months);
            this.Controls.Add(this.years);
            this.Controls.Add(this.supp);
            this.Name = "somme";
            this.Text = "somme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox years;
        private System.Windows.Forms.Button supp;
        private System.Windows.Forms.TextBox months;
        private System.Windows.Forms.Label bb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}