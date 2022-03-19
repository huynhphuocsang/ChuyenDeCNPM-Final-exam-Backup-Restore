using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace N18DCCN171_HuynhPhuocSang_backup_restore
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textEdit2_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void ckShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (ckShowPassword.Checked) txtPassword.Properties.UseSystemPasswordChar = false;
            else txtPassword.Properties.UseSystemPasswordChar = true; 
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
