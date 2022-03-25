namespace cimentbizert
{
    partial class suprimer
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
            this.supp = new System.Windows.Forms.Button();
            this.SU1 = new System.Windows.Forms.TextBox();
            this.bb = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // supp
            // 
            this.supp.Location = new System.Drawing.Point(434, 113);
            this.supp.Name = "supp";
            this.supp.Size = new System.Drawing.Size(75, 23);
            this.supp.TabIndex = 0;
            this.supp.Text = "supprimer";
            this.supp.UseVisualStyleBackColor = true;
            this.supp.Click += new System.EventHandler(this.supp_Click);
            // 
            // SU1
            // 
            this.SU1.Location = new System.Drawing.Point(316, 113);
            this.SU1.Name = "SU1";
            this.SU1.Size = new System.Drawing.Size(100, 20);
            this.SU1.TabIndex = 1;
            this.SU1.TextChanged += new System.EventHandler(this.SU1_TextChanged);
            // 
            // bb
            // 
            this.bb.AutoSize = true;
            this.bb.Location = new System.Drawing.Point(313, 26);
            this.bb.Name = "bb";
            this.bb.Size = new System.Drawing.Size(106, 13);
            this.bb.TabIndex = 28;
            this.bb.Text = "suprimer un employer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "matricule employee";
            // 
            // suprimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bb);
            this.Controls.Add(this.SU1);
            this.Controls.Add(this.supp);
            this.Name = "suprimer";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button supp;
        private System.Windows.Forms.TextBox SU1;
        private System.Windows.Forms.Label bb;
        private System.Windows.Forms.Label label1;
    }
}