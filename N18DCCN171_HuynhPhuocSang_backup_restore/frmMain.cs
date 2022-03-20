using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N18DCCN171_HuynhPhuocSang_backup_restore
{
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {
        public frmMain()
        {
            InitializeComponent();
           
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.databases' table. You can move, or remove it, as needed.
            this.databasesTableAdapter.Fill(this.dataSet1.databases);

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            
            if(XtraMessageBox.Show("Bạn có muốn đăng xuất không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
                Program.frmLogin.Visible = true;
            }
            
        }
    }
}