using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            NhanVienXL nv = new NhanVienXL();
            bool kq = nv.KiemTraDangNhap(txt_TenDangNhap.Text, txt_MatKhau.Text);
            if(kq==true)
            {
                Form_Chinh frm_Chinh = new Form_Chinh();
                frm_Chinh.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!");
            }

        }
    }
}
