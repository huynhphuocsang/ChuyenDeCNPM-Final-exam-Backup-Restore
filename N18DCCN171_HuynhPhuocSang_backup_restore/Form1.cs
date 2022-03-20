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
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        public frmLogin()
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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Trim() == "" || txtPassword.Text.Trim() == "" || txtServername.Text.Trim() == "")
            {
                MessageBox.Show("Tên server, tên đăng nhập và mật mã không được trống", "", MessageBoxButtons.OK);
                return;
            }
            Program.servername = txtServername.Text.Trim();
            Program.username = txtUsername.Text.Trim();
            Program.password = txtPassword.Text.Trim();
            if (Program.KetNoi() == 0)
            {
                return;
            }
            this.Visible = false;
            Program.conn.Close();
            
            try
            {
                
                frmMain form = new frmMain();
                form.Activate();
                form.ShowDialog();

                //Program.form.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message, "", MessageBoxButtons.OK);
            }
        }

       
    }
}
