namespace cimentbizert
{
    partial class bulletinemp
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label15 = new System.Windows.Forms.Label();
            this.getmat = new System.Windows.Forms.TextBox();
            this.getbtn = new System.Windows.Forms.Button();
            this.bb = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(65, 285);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(859, 247);
            this.dataGridView1.TabIndex = 109;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(303, 127);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(91, 13);
            this.label15.TabIndex = 108;
            this.label15.Text = "matricule employe";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // getmat
            // 
            this.getmat.Location = new System.Drawing.Point(418, 124);
            this.getmat.Name = "getmat";
            this.getmat.Size = new System.Drawing.Size(100, 20);
            this.getmat.TabIndex = 107;
            // 
            // getbtn
            // 
            this.getbtn.Location = new System.Drawing.Point(528, 123);
            this.getbtn.Name = "getbtn";
            this.getbtn.Size = new System.Drawing.Size(75, 24);
            this.getbtn.TabIndex = 106;
            this.getbtn.Text = "get";
            this.getbtn.UseVisualStyleBackColor = true;
            this.getbtn.Click += new System.EventHandler(this.getbtn_Click);
            // 
            // bb
            // 
            this.bb.AutoSize = true;
            this.bb.Location = new System.Drawing.Point(416, 50);
            this.bb.Name = "bb";
            this.bb.Size = new System.Drawing.Size(173, 13);
            this.bb.TabIndex = 105;
            this.bb.Text = "consulter les bulletin d\'un employee";
            // 
            // bulletinemp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 550);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.getmat);
            this.Controls.Add(this.getbtn);
            this.Controls.Add(this.bb);
            this.Name = "bulletinemp";
            this.Text = "bulletinemp";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox getmat;
        private System.Windows.Forms.Button getbtn;
        private System.Windows.Forms.Label bb;
    }
}