namespace WindowsFormsApplication2
{
    partial class TinhLuong
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
            this.label7 = new System.Windows.Forms.Label();
            this.grid_Luong = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.bt_Thoat = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_Thang = new System.Windows.Forms.ComboBox();
            this.txt_Ten = new System.Windows.Forms.TextBox();
            this.bt_Tim = new System.Windows.Forms.Button();
            this.cb_Nam = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Luong)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(189, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "Tên Nhân Viên:";
            // 
            // grid_Luong
            // 
            this.grid_Luong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Luong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column7,
            this.Column8});
            this.grid_Luong.Location = new System.Drawing.Point(7, 84);
            this.grid_Luong.Name = "grid_Luong";
            this.grid_Luong.Size = new System.Drawing.Size(592, 150);
            this.grid_Luong.TabIndex = 39;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Tên NV";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Số Ngày Nghỉ";
            this.Column4.Name = "Column4";
            this.Column4.Width = 120;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Số Ngày Đi Trễ";
            this.Column5.Name = "Column5";
            this.Column5.Width = 120;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Lương Cơ Bản";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Tổng Lương";
            this.Column8.Name = "Column8";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(192, 250);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 35);
            this.button2.TabIndex = 42;
            this.button2.Text = "In Ra";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // bt_Thoat
            // 
            this.bt_Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Thoat.Location = new System.Drawing.Point(325, 250);
            this.bt_Thoat.Name = "bt_Thoat";
            this.bt_Thoat.Size = new System.Drawing.Size(87, 35);
            this.bt_Thoat.TabIndex = 43;
            this.bt_Thoat.Text = "Thoát";
            this.bt_Thoat.UseVisualStyleBackColor = true;
            this.bt_Thoat.Click += new System.EventHandler(this.bt_Thoat_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(187, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "Tháng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(189, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "Năm:";
            // 
            // cb_Thang
            // 
            this.cb_Thang.FormattingEnabled = true;
            this.cb_Thang.Location = new System.Drawing.Point(291, 60);
            this.cb_Thang.Name = "cb_Thang";
            this.cb_Thang.Size = new System.Drawing.Size(87, 21);
            this.cb_Thang.TabIndex = 48;
            // 
            // txt_Ten
            // 
            this.txt_Ten.Location = new System.Drawing.Point(291, 8);
            this.txt_Ten.Name = "txt_Ten";
            this.txt_Ten.Size = new System.Drawing.Size(150, 20);
            this.txt_Ten.TabIndex = 49;
            // 
            // bt_Tim
            // 
            this.bt_Tim.Location = new System.Drawing.Point(458, 6);
            this.bt_Tim.Name = "bt_Tim";
            this.bt_Tim.Size = new System.Drawing.Size(75, 23);
            this.bt_Tim.TabIndex = 50;
            this.bt_Tim.Text = "Tìm";
            this.bt_Tim.UseVisualStyleBackColor = true;
            this.bt_Tim.Click += new System.EventHandler(this.bt_Tim_Click);
            // 
            // cb_Nam
            // 
            this.cb_Nam.FormattingEnabled = true;
            this.cb_Nam.Location = new System.Drawing.Point(291, 34);
            this.cb_Nam.Name = "cb_Nam";
            this.cb_Nam.Size = new System.Drawing.Size(87, 21);
            this.cb_Nam.TabIndex = 51;
            this.cb_Nam.SelectedIndexChanged += new System.EventHandler(this.cb_Nam_SelectedIndexChanged);
            // 
            // TinhLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 297);
            this.Controls.Add(this.cb_Nam);
            this.Controls.Add(this.bt_Tim);
            this.Controls.Add(this.txt_Ten);
            this.Controls.Add(this.cb_Thang);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bt_Thoat);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.grid_Luong);
            this.Controls.Add(this.label7);
            this.Name = "TinhLuong";
            this.Text = "Tính Lương";
            this.Load += new System.EventHandler(this.TinhLuong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_Luong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView grid_Luong;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button bt_Thoat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_Thang;
        private System.Windows.Forms.TextBox txt_Ten;
        private System.Windows.Forms.Button bt_Tim;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.ComboBox cb_Nam;
    }
}