namespace WindowsFormsApplication2
{
    partial class QL_MonAn
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
            this.txt_Them = new System.Windows.Forms.Button();
            this.bt_Thoat = new System.Windows.Forms.Button();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MonAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grid_MonAn = new System.Windows.Forms.DataGridView();
            this.bt_Luu = new System.Windows.Forms.Button();
            this.bt_Huy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_MonAn)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Them
            // 
            this.txt_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Them.Location = new System.Drawing.Point(12, 282);
            this.txt_Them.Name = "txt_Them";
            this.txt_Them.Size = new System.Drawing.Size(75, 37);
            this.txt_Them.TabIndex = 1;
            this.txt_Them.Text = "Thêm Mới";
            this.txt_Them.UseVisualStyleBackColor = true;
            this.txt_Them.Click += new System.EventHandler(this.txt_Them_Click);
            // 
            // bt_Thoat
            // 
            this.bt_Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Thoat.Location = new System.Drawing.Point(387, 282);
            this.bt_Thoat.Name = "bt_Thoat";
            this.bt_Thoat.Size = new System.Drawing.Size(75, 37);
            this.bt_Thoat.TabIndex = 4;
            this.bt_Thoat.Text = "Thoát";
            this.bt_Thoat.UseVisualStyleBackColor = true;
            this.bt_Thoat.Click += new System.EventHandler(this.bt_Thoat_Click);
            // 
            // DonGia
            // 
            this.DonGia.HeaderText = "Đơn Giá";
            this.DonGia.Name = "DonGia";
            this.DonGia.Width = 200;
            // 
            // MonAn
            // 
            this.MonAn.HeaderText = "Món Ăn";
            this.MonAn.Name = "MonAn";
            this.MonAn.Width = 200;
            // 
            // Grid_MonAn
            // 
            this.Grid_MonAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_MonAn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MonAn,
            this.DonGia});
            this.Grid_MonAn.Enabled = false;
            this.Grid_MonAn.Location = new System.Drawing.Point(12, 12);
            this.Grid_MonAn.Name = "Grid_MonAn";
            this.Grid_MonAn.Size = new System.Drawing.Size(450, 264);
            this.Grid_MonAn.TabIndex = 0;
            // 
            // bt_Luu
            // 
            this.bt_Luu.Enabled = false;
            this.bt_Luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Luu.Location = new System.Drawing.Point(127, 282);
            this.bt_Luu.Name = "bt_Luu";
            this.bt_Luu.Size = new System.Drawing.Size(75, 37);
            this.bt_Luu.TabIndex = 5;
            this.bt_Luu.TabStop = false;
            this.bt_Luu.Text = "Lưu";
            this.bt_Luu.UseVisualStyleBackColor = true;
            this.bt_Luu.Click += new System.EventHandler(this.bt_Luu_Click);
            // 
            // bt_Huy
            // 
            this.bt_Huy.Enabled = false;
            this.bt_Huy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Huy.Location = new System.Drawing.Point(261, 282);
            this.bt_Huy.Name = "bt_Huy";
            this.bt_Huy.Size = new System.Drawing.Size(75, 37);
            this.bt_Huy.TabIndex = 6;
            this.bt_Huy.TabStop = false;
            this.bt_Huy.Text = "Hủy";
            this.bt_Huy.UseVisualStyleBackColor = true;
            this.bt_Huy.Click += new System.EventHandler(this.bt_Huy_Click);
            // 
            // QL_MonAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 328);
            this.Controls.Add(this.bt_Huy);
            this.Controls.Add(this.bt_Luu);
            this.Controls.Add(this.bt_Thoat);
            this.Controls.Add(this.txt_Them);
            this.Controls.Add(this.Grid_MonAn);
            this.Name = "QL_MonAn";
            this.Text = "Quản Lý Món Ăn";
            ((System.ComponentModel.ISupportInitialize)(this.Grid_MonAn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button txt_Them;
        private System.Windows.Forms.Button bt_Thoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn MonAn;
        private System.Windows.Forms.DataGridView Grid_MonAn;
        private System.Windows.Forms.Button bt_Luu;
        private System.Windows.Forms.Button bt_Huy;
    }
}