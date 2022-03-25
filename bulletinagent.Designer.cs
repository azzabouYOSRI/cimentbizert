namespace cimentbizert
{
    partial class bulletinagent
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
            this.dataGridView1.Location = new System.Drawing.Point(47, 279);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(859, 247);
            this.dataGridView1.TabIndex = 104;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(315, 125);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(45, 13);
            this.label15.TabIndex = 103;
            this.label15.Text = "agent id";
            // 
            // getmat
            // 
            this.getmat.Location = new System.Drawing.Point(400, 122);
            this.getmat.Name = "getmat";
            this.getmat.Size = new System.Drawing.Size(100, 20);
            this.getmat.TabIndex = 102;
            // 
            // getbtn
            // 
            this.getbtn.Location = new System.Drawing.Point(510, 117);
            this.getbtn.Name = "getbtn";
            this.getbtn.Size = new System.Drawing.Size(75, 24);
            this.getbtn.TabIndex = 101;
            this.getbtn.Text = "get";
            this.getbtn.UseVisualStyleBackColor = true;
            this.getbtn.Click += new System.EventHandler(this.getbtn_Click);
            // 
            // bb
            // 
            this.bb.AutoSize = true;
            this.bb.Location = new System.Drawing.Point(398, 44);
            this.bb.Name = "bb";
            this.bb.Size = new System.Drawing.Size(132, 13);
            this.bb.TabIndex = 95;
            this.bb.Text = "consulter les bulletin agent";
            // 
            // bulletinagent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 591);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.getmat);
            this.Controls.Add(this.getbtn);
            this.Controls.Add(this.bb);
            this.Name = "bulletinagent";
            this.Text = "bulletinagent";
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