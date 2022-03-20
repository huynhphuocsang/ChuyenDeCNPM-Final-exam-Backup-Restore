using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;


using DevExpress.XtraEditors;
namespace N18DCCN171_HuynhPhuocSang_backup_restore
{
    static class Program
    {

        public static SqlConnection conn = new SqlConnection();
        public static string connstr;
        public static SqlDataAdapter da;

        public static string servername = "DESKTOP-MAA5MC1";
        public static string username = "sa";
        public static string password = "123";
        public static string database = "";
        public static string mlogin = "";

        public static int nambatdau = 2016;//để cho cmbNK tự động tính dựa vào năm này
        public static int flagRestore = 0;// check whether user restored db? 
        public static string strDefaultPath = "D:/Study/LearnPTIT/ChuyenDeCongNghePhanMem/Recovery";
        public static String device_type = "Disk";
        public static frmLogin frmLogin;


        public static int KetNoi()
        {
            if (Program.conn != null && Program.conn.State == ConnectionState.Open) Program.conn.Close();
            try
            {
                Program.connstr = "Data source=" + Program.servername + ";User Id = " + Program.username + "; Password = " + Program.password;
                Program.conn.ConnectionString = Program.connstr;
                Program.conn.Open();
                return 1;
            }
            catch (Exception e)
            {
                XtraMessageBox.Show("Kết nối thất bại! \nBạn vui lòng kiểm tra lại thông tin đăng nhập", "Thông báo!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return 0;
            }
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmLogin = new frmLogin();
            Application.Run(frmLogin);
        }
    }
}
