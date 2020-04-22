namespace WindowsFormsApplication2
{
    partial class TraCuu_MonAn
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
            this.label3 = new System.Windows.Forms.Label();
            this.Grid_KQ = new System.Windows.Forms.DataGridView();
            this.tb_giaTu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_giaDen = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bt_Tim = new System.Windows.Forms.Button();
            this.cb_MonAn = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_KQ)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Giá từ:";
            // 
            // Grid_KQ
            // 
            this.Grid_KQ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_KQ.Location = new System.Drawing.Point(12, 74);
            this.Grid_KQ.Name = "Grid_KQ";
            this.Grid_KQ.Size = new System.Drawing.Size(445, 233);
            this.Grid_KQ.TabIndex = 5;
            this.Grid_KQ.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_KQ_CellContentClick);
            // 
            // tb_giaTu
            // 
            this.tb_giaTu.Location = new System.Drawing.Point(76, 39);
            this.tb_giaTu.Name = "tb_giaTu";
            this.tb_giaTu.Size = new System.Drawing.Size(86, 20);
            this.tb_giaTu.TabIndex = 6;
            this.tb_giaTu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_giaTu_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(168, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Đến:";
            // 
            // tb_giaDen
            // 
            this.tb_giaDen.Location = new System.Drawing.Point(208, 39);
            this.tb_giaDen.Name = "tb_giaDen";
            this.tb_giaDen.Size = new System.Drawing.Size(86, 20);
            this.tb_giaDen.TabIndex = 8;
            this.tb_giaDen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_giaDen_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tên Món:";
            // 
            // bt_Tim
            // 
            this.bt_Tim.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Tim.Location = new System.Drawing.Point(327, 15);
            this.bt_Tim.Name = "bt_Tim";
            this.bt_Tim.Size = new System.Drawing.Size(75, 41);
            this.bt_Tim.TabIndex = 11;
            this.bt_Tim.Text = "Tìm";
            this.bt_Tim.UseVisualStyleBackColor = true;
            this.bt_Tim.Click += new System.EventHandler(this.bt_Tim_Click);
            // 
            // cb_MonAn
            // 
            this.cb_MonAn.FormattingEnabled = true;
            this.cb_MonAn.Location = new System.Drawing.Point(76, 12);
            this.cb_MonAn.Name = "cb_MonAn";
            this.cb_MonAn.Size = new System.Drawing.Size(218, 21);
            this.cb_MonAn.TabIndex = 12;
            // 
            // TraCuu_MonAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 319);
            this.Controls.Add(this.cb_MonAn);
            this.Controls.Add(this.bt_Tim);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_giaDen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_giaTu);
            this.Controls.Add(this.Grid_KQ);
            this.Controls.Add(this.label3);
            this.Name = "TraCuu_MonAn";
            this.Text = "Tra Cứu Món Ăn";
            this.Load += new System.EventHandler(this.TraCuu_MonAn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_KQ)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView Grid_KQ;
        private System.Windows.Forms.TextBox tb_giaTu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_giaDen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bt_Tim;
        private System.Windows.Forms.ComboBox cb_MonAn;

    }
}