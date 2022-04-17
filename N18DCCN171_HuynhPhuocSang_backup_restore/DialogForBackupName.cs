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
    public partial class DialogForBackupName : DevExpress.XtraEditors.XtraForm
    {
        public string backupName = ""; 

        public DialogForBackupName()
        {
            InitializeComponent();
        }

        private void btnVerifyname_Click(object sender, EventArgs e)
        {
            if (txtBackupName.Text.Trim().Length > 128)
            {
                XtraMessageBox.Show("Độ dài tối đa là 128 ký tự", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                backupName = txtBackupName.Text;
                this.Close(); 
            }
        }
    }
}