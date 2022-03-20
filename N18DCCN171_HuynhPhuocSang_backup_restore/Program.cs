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
        public static SqlDataReader reader;

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

        public static SqlDataReader ExecSqlDataReader(String cmd)
        {
            conn.Close();
            SqlCommand sqlcmd = new SqlCommand(cmd, Program.conn);
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.CommandTimeout = 300;
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            try
            {
                reader = sqlcmd.ExecuteReader();
                return reader;
            }
            catch (SqlException ex)
            {
                Program.conn.Close();
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public static int ExecSqlNonQuery(String cmd, String connectionstring, string errstr)
        {
            conn = new SqlConnection(connectionstring);
            SqlCommand Sqlcmd = new SqlCommand(cmd, conn);
            Sqlcmd.CommandType = CommandType.Text;
            Sqlcmd.CommandTimeout = 600;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                int loi = Sqlcmd.ExecuteNonQuery();
                conn.Close();
                return 0;
            }
            catch (SqlException ex)
            {
                if (ex.Message.Contains("Error converting data type varchar to int"))
                    MessageBox.Show("Bạn format lại các cột kiểu char qua int");
                else
                    MessageBox.Show(errstr + "\n" + ex.Message);
                conn.Close();
                return (ex.State);// trạng thái lỗi gửi từ RAISERROR trong sql server qua
            }
        }
    }
}
