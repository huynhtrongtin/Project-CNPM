using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
            //Application.Run(new Form_Chinh());
            //Application.Run(new DatCom());
            //Application.Run(new ChamCong());            
            //Application.Run(new TinhLuong());
            //Application.Run(new TraCuuKhachHang());
            //Application.Run(new TraCuu_MonAn());
        }
    }
}
