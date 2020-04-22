namespace WindowsFormsApplication2
{
    partial class TraCuuNV
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
            this.grid_KetQua = new System.Windows.Forms.DataGridView();
            this.txt_TheoTen = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_TuoiTu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_TuoiDen = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_LoaiNV = new System.Windows.Forms.ComboBox();
            this.bt_Tim = new System.Windows.Forms.Button();
            this.bt_In = new System.Windows.Forms.Button();
            this.bt_Thoat = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QueQuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLoaiNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grid_KetQua)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grid_KetQua
            // 
            this.grid_KetQua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_KetQua.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNV,
            this.TenNV,
            this.NgaySinh,
            this.QueQuan,
            this.MaLoaiNV,
            this.DiaChi,
            this.SoDT});
            this.grid_KetQua.Location = new System.Drawing.Point(60, 129);
            this.grid_KetQua.Name = "grid_KetQua";
            this.grid_KetQua.Size = new System.Drawing.Size(864, 150);
            this.grid_KetQua.TabIndex = 19;
            // 
            // txt_TheoTen
            // 
            this.txt_TheoTen.Location = new System.Drawing.Point(102, 29);
            this.txt_TheoTen.Name = "txt_TheoTen";
            this.txt_TheoTen.Size = new System.Drawing.Size(129, 20);
            this.txt_TheoTen.TabIndex = 27;
            this.txt_TheoTen.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Tìm Theo Tên:";
            // 
            // txt_TuoiTu
            // 
            this.txt_TuoiTu.Location = new System.Drawing.Point(366, 29);
            this.txt_TuoiTu.Name = "txt_TuoiTu";
            this.txt_TuoiTu.Size = new System.Drawing.Size(64, 20);
            this.txt_TuoiTu.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(241, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Tìm Theo Tuổi:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.txt_TuoiDen);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cb_LoaiNV);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_TuoiTu);
            this.groupBox1.Controls.Add(this.txt_TheoTen);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(218, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(548, 111);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Loại Tìm Kiếm";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txt_TuoiDen
            // 
            this.txt_TuoiDen.Location = new System.Drawing.Point(472, 29);
            this.txt_TuoiDen.Name = "txt_TuoiDen";
            this.txt_TuoiDen.Size = new System.Drawing.Size(64, 20);
            this.txt_TuoiDen.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(436, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Đến:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(337, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Từ:";
            // 
            // cb_LoaiNV
            // 
            this.cb_LoaiNV.Enabled = false;
            this.cb_LoaiNV.FormattingEnabled = true;
            this.cb_LoaiNV.Items.AddRange(new object[] {
            ""});
            this.cb_LoaiNV.Location = new System.Drawing.Point(167, 64);
            this.cb_LoaiNV.Name = "cb_LoaiNV";
            this.cb_LoaiNV.Size = new System.Drawing.Size(156, 21);
            this.cb_LoaiNV.TabIndex = 31;
            // 
            // bt_Tim
            // 
            this.bt_Tim.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Tim.Location = new System.Drawing.Point(226, 290);
            this.bt_Tim.Name = "bt_Tim";
            this.bt_Tim.Size = new System.Drawing.Size(108, 32);
            this.bt_Tim.TabIndex = 33;
            this.bt_Tim.Text = "Tìm";
            this.bt_Tim.UseVisualStyleBackColor = true;
            this.bt_Tim.Click += new System.EventHandler(this.bt_Tim_Click);
            // 
            // bt_In
            // 
            this.bt_In.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_In.Location = new System.Drawing.Point(382, 290);
            this.bt_In.Name = "bt_In";
            this.bt_In.Size = new System.Drawing.Size(108, 32);
            this.bt_In.TabIndex = 34;
            this.bt_In.Text = "In Ra";
            this.bt_In.UseVisualStyleBackColor = true;
            // 
            // bt_Thoat
            // 
            this.bt_Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Thoat.Location = new System.Drawing.Point(544, 290);
            this.bt_Thoat.Name = "bt_Thoat";
            this.bt_Thoat.Size = new System.Drawing.Size(108, 32);
            this.bt_Thoat.TabIndex = 35;
            this.bt_Thoat.Text = "Thoát";
            this.bt_Thoat.UseVisualStyleBackColor = true;
            this.bt_Thoat.Click += new System.EventHandler(this.bt_Thoat_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(11, 66);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(150, 17);
            this.checkBox1.TabIndex = 36;
            this.checkBox1.Text = "Tìm Theo Loại Nhân Viên:";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // MaNV
            // 
            this.MaNV.HeaderText = "Mã NV";
            this.MaNV.Name = "MaNV";
            // 
            // TenNV
            // 
            this.TenNV.HeaderText = "Tên NV";
            this.TenNV.Name = "TenNV";
            // 
            // NgaySinh
            // 
            this.NgaySinh.HeaderText = "Ngày Sinh";
            this.NgaySinh.Name = "NgaySinh";
            // 
            // QueQuan
            // 
            this.QueQuan.HeaderText = "Quê Quán";
            this.QueQuan.Name = "QueQuan";
            // 
            // MaLoaiNV
            // 
            this.MaLoaiNV.HeaderText = "Mã Loại NV";
            this.MaLoaiNV.Name = "MaLoaiNV";
            // 
            // DiaChi
            // 
            this.DiaChi.HeaderText = "Địa Chỉ";
            this.DiaChi.Name = "DiaChi";
            // 
            // SoDT
            // 
            this.SoDT.HeaderText = "Số ĐT";
            this.SoDT.Name = "SoDT";
            // 
            // TraCuuNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 352);
            this.Controls.Add(this.bt_Thoat);
            this.Controls.Add(this.bt_In);
            this.Controls.Add(this.bt_Tim);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grid_KetQua);
            this.Name = "TraCuuNV";
            this.Text = "TraCuuNV";
            this.Load += new System.EventHandler(this.TraCuuNV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_KetQua)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_KetQua;
        private System.Windows.Forms.TextBox txt_TheoTen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_TuoiTu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cb_LoaiNV;
        private System.Windows.Forms.Button bt_Tim;
        private System.Windows.Forms.Button bt_In;
        private System.Windows.Forms.Button bt_Thoat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_TuoiDen;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn QueQuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLoaiNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDT;
    }
}