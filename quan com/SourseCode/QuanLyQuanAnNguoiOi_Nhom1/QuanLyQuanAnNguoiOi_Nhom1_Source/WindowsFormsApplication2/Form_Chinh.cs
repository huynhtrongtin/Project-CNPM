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
    public partial class Form_Chinh : Form
    {
        public Form_Chinh()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login s = new Login();
            s.Show();
        }

        private void hệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thốngKêToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TraCuu_thuchi s11 = new TraCuu_thuchi();
            s11.Show();
        }

        private void tiếpNhậnNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemNV_ s2 = new ThemNV_();
            s2.Show();
        }

        private void chấmCôngNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChamCong s3 = new ChamCong();
            s3.Show();
        }

        private void traCứuNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TraCuuNV s4 = new TraCuuNV();
            s4.Show();
        }

        private void tínhLươngNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TinhLuong s5 = new TinhLuong();
            s5.Show();
        }

        private void hóaĐơnBánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HoaDonBanHang s6 = new HoaDonBanHang();
            s6.Show();
        }

        private void nhậnĐặtCơmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DatCom s7 = new DatCom();
            s7.Show();
        }

        private void hóaĐơnNhậpKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HDonNhapKho s8 = new HDonNhapKho();
            s8.Show();
        }

        private void traCứuKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TraCuuKhachHang s9 = new TraCuuKhachHang();
            s9.Show();
        }

        private void thốngKêThuChiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TK_thu_chi s10 = new TK_thu_chi();
            s10.Show();
        }

        private void quảnLýMónĂnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QL_MonAn s12 = new QL_MonAn();
            s12.Show();
        }

        private void traCứuMónĂnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TraCuu_MonAn s13 = new TraCuu_MonAn();
            s13.Show();
        }

        private void thựcPhẩmTồnKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TonKho s14 = new TonKho();
            s14.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }

    }
}
