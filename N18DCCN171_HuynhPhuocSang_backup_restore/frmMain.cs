using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N18DCCN171_HuynhPhuocSang_backup_restore
{
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {
        String deviceName=""; 
        String prefixBackupDevice = "DEVICE_DB";
        public frmMain()
        {
            InitializeComponent();
           
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.backupDevicesTableAdapter.Connection.ConnectionString = Program.connstr;
            this.backupDevicesTableAdapter.Fill(this.dataSet1.BackupDevices);
            

            this.databasesTableAdapter.Connection.ConnectionString = Program.connstr;
            this.databasesTableAdapter.Fill(this.dataSet1.databases);

            databasesGridControl_Click(sender,e);


        }

        private void LoadBackupSets()
        {

            if (txtDbName.Text.Trim() == "") return;
            try
            {
                this.backupSetTableAdapter.Connection.ConnectionString = Program.connstr;
                this.backupSetTableAdapter.Fill(this.dataSet1.BackupSet, txtDbName.Text);

                this.backupDevicesTableAdapter.Connection.ConnectionString = Program.connstr;
                this.backupDevicesTableAdapter.Fill(this.dataSet1.BackupDevices);

                CheckDeviceExist();
                if (backupSetBindingSource.Count > 0)
                {
                    btnRestore.Enabled = true;
                    btnDeleteBackupDevice.Enabled = true;
                    btnDeleteBackupSet.Enabled = true;

                    //lưu số lượng bản sao lưu hiện có: chưa biết làm gì !
                    //bansaoluu = int.Parse(((DataRowView)bdsST_STT_BACKUP[0])["position"].ToString());

                }
                else
                {
                    btnRestore.Enabled = false;
                    btnDeleteBackupDevice.Enabled = false;
                    btnDeleteBackupSet.Enabled = false;

                    //lưu lại số bản backup, chưa biết để làm gì!
                    //bansaoluu = 0;
                }
                //txtbansaoluu.Text = bansaoluu.ToString();

            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            
            if(XtraMessageBox.Show("Bạn có muốn đăng xuất không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
                Program.frmLogin.Visible = true;
            }
            
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.backupSetTableAdapter.Fill(this.dataSet1.BackupSet, txtDbName.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
        
        private void databasesGridControl_Click(object sender, EventArgs e)
        {
            try
            {
                if (databasesBindingSource.Position == -1 || databasesBindingSource.Count == 0 || databasesBindingSource.DataSource == null)
                    txtDbName.Text = "";
                else txtDbName.Text = ((DataRowView)databasesBindingSource[databasesBindingSource.Position])["name"].ToString();
                LoadBackupSets();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "", MessageBoxButtons.OK);
            }
        }
        private void CheckDeviceExist()
        {
            String StrTendevice = "SELECT  COUNT(name)  FROM  sys.backup_devices  WHERE  name  =  N'"+prefixBackupDevice +
                txtDbName.Text.Trim() + "'";
            Program.reader = Program.ExecSqlDataReader(StrTendevice);
            if (Program.reader == null) return;
            Program.reader.Read();

            
            if (Program.reader.GetInt32(0) > 0)
            {
                IsDeviceExist();//có device thì hiện ra những chức năng có thể thực hiện
                deviceName = prefixBackupDevice + txtDbName.Text.Trim();

            }
            // chưa có device: chỉ hiện newdevice vs logout
            else IsDeviceNotExist();
            Program.reader.Close();

        }

        private void IsDeviceExist()
        {
            btnBackup.Enabled = ckRestoreWithTime.Enabled= btnDeleteBackupDevice.Enabled = true;
            btnCreateBackupDevice.Enabled = false; 
        }
        private void IsDeviceNotExist()
        {
            btnBackup.Enabled = ckRestoreWithTime.Enabled = btnDeleteBackupDevice.Enabled = false;
            btnCreateBackupDevice.Enabled = true;
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            String StrBackup;
            if (txtDbName.Text.Trim() == "" || deviceName == "") return;

            StrBackup = "BACKUP DATABASE " + txtDbName.Text.Trim() + " TO " + deviceName;
            if (ckDelOldBackups.Checked == true)
                if (XtraMessageBox.Show("Bạn chắc chắn muốn xóa tất cả các bản sao lưu trước đó?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.OK)
                    StrBackup = StrBackup + " WITH INIT";
                else
                    return;

            int err = Program.ExecSqlNonQuery(StrBackup, Program.connstr, "");
            if (err != 0)
            {
                XtraMessageBox.Show("Backup " + txtDbName.Text + " thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            XtraMessageBox.Show("Backup " + txtDbName.Text + " thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadBackupSets();
        }

        private void btnCreateBackupDevice_Click(object sender, EventArgs e)
        {
            deviceName = prefixBackupDevice + txtDbName.Text;
            String strFullPathDevice = Program.strDefaultPath + "/" + deviceName;

            String query = "USE master\n EXEC sp_addumpdevice '" + Program.device_type + "', '" + deviceName + "','" + strFullPathDevice + "'";
            try
            {

                Program.reader = Program.ExecSqlDataReader(query);
                if (Program.reader != null)
                {
                    XtraMessageBox.Show("Tạo backup device thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.backupDevicesTableAdapter.Fill(this.dataSet1.BackupDevices);

                    IsDeviceExist();

                }
                else XtraMessageBox.Show("Tạo backup device thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex, "!", MessageBoxButtons.OK);
                return;
            }

            Program.conn.Close();

        }

        private void btnDeleteBackupDevice_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn muốn xóa backup device?", "Cảnh báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                return;
            try
            {
                deviceName = prefixBackupDevice + txtDbName.Text;
                DeleteByName(deviceName); //delete backup device and file.
                DeleteHistory(txtDbName.Text);//delete history backup also.

                LoadBackupSets();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex, "Question", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        public int DeleteByName(String name)
        {
            using (SqlConnection connetion = new SqlConnection(Program.connstr))
            {
                using (SqlCommand command = new SqlCommand("EXEC sp_dropdevice @name, 'delfile' ; ", connetion))
                {
                    command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
                    connetion.Open();
                    return command.ExecuteNonQuery();
                }
            }
        }
        public int DeleteHistory(String name)
        {
            using (SqlConnection connetion = new SqlConnection(Program.connstr))
            {
                using (SqlCommand command = new SqlCommand("EXEC msdb.dbo.sp_delete_database_backuphistory @database_name = @name", connetion))
                {
                    command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
                    connetion.Open();
                    return command.ExecuteNonQuery();
                }
            }
        }
    }
}