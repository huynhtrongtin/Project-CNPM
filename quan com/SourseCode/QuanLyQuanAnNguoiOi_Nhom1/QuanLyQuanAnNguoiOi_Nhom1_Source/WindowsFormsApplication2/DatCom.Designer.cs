namespace WindowsFormsApplication2
{
    partial class DatCom
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
            this.bt_Thoat = new System.Windows.Forms.Button();
            this.bt_huy = new System.Windows.Forms.Button();
            this.bt_Luu = new System.Windows.Forms.Button();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.txt_DC = new System.Windows.Forms.TextBox();
            this.txt_TenKH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtime_NgayDat = new System.Windows.Forms.DateTimePicker();
            this.dtime_NgayNhan = new System.Windows.Forms.DateTimePicker();
            this.Grid_DatMon = new System.Windows.Forms.DataGridView();
            this.bt_ThemMoi = new System.Windows.Forms.Button();
            this.bt_InRa = new System.Windows.Forms.Button();
            this.cb_MonAn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.txt_SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_DatMon)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_Thoat
            // 
            this.bt_Thoat.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bt_Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Thoat.Location = new System.Drawing.Point(336, 355);
            this.bt_Thoat.Name = "bt_Thoat";
            this.bt_Thoat.Size = new System.Drawing.Size(75, 33);
            this.bt_Thoat.TabIndex = 17;
            this.bt_Thoat.Text = "Thoát";
            this.bt_Thoat.UseVisualStyleBackColor = true;
            this.bt_Thoat.Click += new System.EventHandler(this.bt_Thoat_Click);
            // 
            // bt_huy
            // 
            this.bt_huy.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bt_huy.Enabled = false;
            this.bt_huy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_huy.Location = new System.Drawing.Point(174, 355);
            this.bt_huy.Name = "bt_huy";
            this.bt_huy.Size = new System.Drawing.Size(75, 33);
            this.bt_huy.TabIndex = 16;
            this.bt_huy.Text = "Hủy";
            this.bt_huy.UseVisualStyleBackColor = true;
            this.bt_huy.Click += new System.EventHandler(this.bt_huy_Click);
            // 
            // bt_Luu
            // 
            this.bt_Luu.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bt_Luu.Enabled = false;
            this.bt_Luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Luu.Location = new System.Drawing.Point(93, 355);
            this.bt_Luu.Name = "bt_Luu";
            this.bt_Luu.Size = new System.Drawing.Size(75, 33);
            this.bt_Luu.TabIndex = 15;
            this.bt_Luu.Text = "Lưu";
            this.bt_Luu.UseVisualStyleBackColor = true;
            this.bt_Luu.Click += new System.EventHandler(this.bt_Luu_Click);
            // 
            // txt_SDT
            // 
            this.txt_SDT.Enabled = false;
            this.txt_SDT.Location = new System.Drawing.Point(126, 62);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(208, 20);
            this.txt_SDT.TabIndex = 14;
            // 
            // txt_DC
            // 
            this.txt_DC.Enabled = false;
            this.txt_DC.Location = new System.Drawing.Point(126, 36);
            this.txt_DC.Name = "txt_DC";
            this.txt_DC.Size = new System.Drawing.Size(208, 20);
            this.txt_DC.TabIndex = 13;
            // 
            // txt_TenKH
            // 
            this.txt_TenKH.Enabled = false;
            this.txt_TenKH.Location = new System.Drawing.Point(126, 10);
            this.txt_TenKH.Name = "txt_TenKH";
            this.txt_TenKH.Size = new System.Drawing.Size(208, 20);
            this.txt_TenKH.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Số Điện Thoại:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Địa Chỉ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tên Khách Hàng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Ngày Nhận:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Ngày Đặt:";
            // 
            // dtime_NgayDat
            // 
            this.dtime_NgayDat.CustomFormat = "dd/MM/yyyy";
            this.dtime_NgayDat.Enabled = false;
            this.dtime_NgayDat.Location = new System.Drawing.Point(126, 88);
            this.dtime_NgayDat.Name = "dtime_NgayDat";
            this.dtime_NgayDat.Size = new System.Drawing.Size(209, 20);
            this.dtime_NgayDat.TabIndex = 20;
            this.dtime_NgayDat.Value = new System.DateTime(2011, 11, 15, 20, 44, 51, 0);
            // 
            // dtime_NgayNhan
            // 
            this.dtime_NgayNhan.Enabled = false;
            this.dtime_NgayNhan.Location = new System.Drawing.Point(126, 114);
            this.dtime_NgayNhan.Name = "dtime_NgayNhan";
            this.dtime_NgayNhan.Size = new System.Drawing.Size(209, 20);
            this.dtime_NgayNhan.TabIndex = 21;
            // 
            // Grid_DatMon
            // 
            this.Grid_DatMon.AllowUserToOrderColumns = true;
            this.Grid_DatMon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_DatMon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cb_MonAn,
            this.txt_SoLuong,
            this.txt_DonGia});
            this.Grid_DatMon.Enabled = false;
            this.Grid_DatMon.Location = new System.Drawing.Point(24, 153);
            this.Grid_DatMon.Name = "Grid_DatMon";
            this.Grid_DatMon.Size = new System.Drawing.Size(383, 186);
            this.Grid_DatMon.TabIndex = 22;
            // 
            // bt_ThemMoi
            // 
            this.bt_ThemMoi.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bt_ThemMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ThemMoi.Location = new System.Drawing.Point(12, 355);
            this.bt_ThemMoi.Name = "bt_ThemMoi";
            this.bt_ThemMoi.Size = new System.Drawing.Size(75, 33);
            this.bt_ThemMoi.TabIndex = 23;
            this.bt_ThemMoi.Text = "Thêm Mới";
            this.bt_ThemMoi.UseVisualStyleBackColor = true;
            this.bt_ThemMoi.Click += new System.EventHandler(this.bt_ThemMoi_Click);
            // 
            // bt_InRa
            // 
            this.bt_InRa.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bt_InRa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_InRa.Location = new System.Drawing.Point(255, 355);
            this.bt_InRa.Name = "bt_InRa";
            this.bt_InRa.Size = new System.Drawing.Size(75, 33);
            this.bt_InRa.TabIndex = 24;
            this.bt_InRa.Text = "In Ra";
            this.bt_InRa.UseVisualStyleBackColor = true;
            // 
            // cb_MonAn
            // 
            this.cb_MonAn.HeaderText = "Món Ăn";
            this.cb_MonAn.Name = "cb_MonAn";
            this.cb_MonAn.Width = 150;
            // 
            // txt_SoLuong
            // 
            this.txt_SoLuong.DataPropertyName = "asdas";
            this.txt_SoLuong.HeaderText = "Số Lượng";
            this.txt_SoLuong.Name = "txt_SoLuong";
            this.txt_SoLuong.Width = 90;
            // 
            // txt_DonGia
            // 
            this.txt_DonGia.HeaderText = "Đơn Giá";
            this.txt_DonGia.Name = "txt_DonGia";
            this.txt_DonGia.ReadOnly = true;
            this.txt_DonGia.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.txt_DonGia.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.txt_DonGia.Width = 90;
            // 
            // DatCom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 400);
            this.Controls.Add(this.bt_InRa);
            this.Controls.Add(this.bt_ThemMoi);
            this.Controls.Add(this.Grid_DatMon);
            this.Controls.Add(this.dtime_NgayNhan);
            this.Controls.Add(this.dtime_NgayDat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bt_Thoat);
            this.Controls.Add(this.bt_huy);
            this.Controls.Add(this.bt_Luu);
            this.Controls.Add(this.txt_SDT);
            this.Controls.Add(this.txt_DC);
            this.Controls.Add(this.txt_TenKH);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DatCom";
            this.Text = "Đặt Cơm";
            this.Load += new System.EventHandler(this.DatCom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_DatMon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_Thoat;
        private System.Windows.Forms.Button bt_huy;
        private System.Windows.Forms.Button bt_Luu;
        private System.Windows.Forms.TextBox txt_SDT;
        private System.Windows.Forms.TextBox txt_DC;
        private System.Windows.Forms.TextBox txt_TenKH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtime_NgayDat;
        private System.Windows.Forms.DateTimePicker dtime_NgayNhan;
        private System.Windows.Forms.DataGridView Grid_DatMon;
        private System.Windows.Forms.Button bt_ThemMoi;
        private System.Windows.Forms.Button bt_InRa;
        private System.Windows.Forms.DataGridViewComboBoxColumn cb_MonAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn txt_SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn txt_DonGia;
    }
}