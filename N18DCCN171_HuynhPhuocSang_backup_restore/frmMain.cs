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
        int backupSetIndex = 0; 
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
                    //lưu lại vị trí để delete, cụ thể khi vừa load thì vị trí thu được là vị trí đầu tiên><số lượng record hiện có
                    backupSetIndex = int.Parse(((DataRowView)backupSetBindingSource[0])["position"].ToString());

                }
                else
                {
                    btnRestore.Enabled = false;
                    btnDeleteBackupDevice.Enabled = false;
                    btnDeleteBackupSet.Enabled = false;

                    backupSetIndex = 0; 
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
                if (XtraMessageBox.Show("Bạn chắc chắn muốn xóa tất cả các bản sao lưu trước đó?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
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

        private void btnDeleteBackupSet_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có chắc chắn xóa bản backup này không?", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != DialogResult.OK)
                return;
            
            if (backupSetIndex == 1)
            {
                if (XtraMessageBox.Show("Nếu xóa bản backup đầu tiên, sẽ mất các bản backup còn lại?", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != DialogResult.OK)
                    return;
            }
            String sql = GenerateDeleteScriptABackupSet(txtDbName.Text, backupSetIndex);

            try
            {
                int err = Program.ExecSqlNonQuery(sql, Program.connstr, "Lỗi phục hồi");
                if (err == 0)
                {
                    XtraMessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadBackupSets();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex, "Question", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        public string GenerateDeleteScriptABackupSet(string dbname, int vtri)
        {
            string str = "DECLARE @database_name NVARCHAR(100)," +
                " @VTRI INT SET @VTRI = " + vtri + " SET @database_name = '" + dbname + "' " +
                "DECLARE @backup_set_id INT DECLARE @media_set_id INT DECLARE @restore_history_id TABLE (restore_history_id INT) SELECT @backup_set_id = MIN(backup_set_id) FROM msdb.dbo.backupset WHERE database_name = @database_name AND type = 'D' AND backup_set_id >= (SELECT MAX(backup_set_id) FROM msdb.dbo.backupset WHERE media_set_id = (SELECT MAX(media_set_id) FROM msdb.dbo.backupset WHERE database_name = @database_name AND type='D') AND position = @VTRI) SELECT @media_set_id = media_set_id FROM msdb.dbo.backupset WHERE backup_set_id = @backup_set_id INSERT INTO @restore_history_id (restore_history_id) SELECT DISTINCT restore_history_id FROM msdb.dbo.restorehistory WHERE backup_set_id = @backup_set_id SET XACT_ABORT ON BEGIN TRANSACTION BEGIN TRY DELETE FROM msdb.dbo.backupfile WHERE backup_set_id = @backup_set_id DELETE FROM msdb.dbo.backupfilegroup WHERE backup_set_id = @backup_set_id DELETE FROM msdb.dbo.restorefile WHERE restore_history_id IN (SELECT restore_history_id FROM @restore_history_id) DELETE FROM msdb.dbo.restorefilegroup WHERE restore_history_id IN (SELECT restore_history_id FROM @restore_history_id) DELETE FROM msdb.dbo.restorehistory WHERE restore_history_id IN (SELECT restore_history_id FROM @restore_history_id) DELETE FROM msdb.dbo.backupset WHERE backup_set_id = @backup_set_id COMMIT TRANSACTION END TRY BEGIN CATCH ROLLBACK DECLARE @ErrMess VARCHAR(1000) SELECT @ErrMess = 'LOI: ' + ERROR_MESSAGE() RAISERROR(@ErrMess, 16, 1) END CATCH";
            return str;
        }

        private void backupSetGridControl_Click(object sender, EventArgs e)
        {
            if (backupSetBindingSource.Position == -1 || backupSetBindingSource.Count == 0 || backupSetBindingSource.DataSource == null) backupSetIndex = 0;
            else backupSetIndex = int.Parse(((DataRowView)backupSetBindingSource[backupSetBindingSource.Position])["position"].ToString());
            
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            int err;
            if (this.backupSetBindingSource.Count == 0)
            {
                XtraMessageBox.Show("Chưa có bản sao lưu để phục hồi", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            if (backupSetIndex == 0)//trong trường hợp có nhưng chưa chọn trên bảng!
            {
                XtraMessageBox.Show("Vui lòng chọn bản sao lưu cần phục hồi", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            if (Program.conn != null && Program.conn.State == ConnectionState.Open)
                Program.conn.Close();

            if (txtDbName.Text.Trim() == "" || deviceName == "") return;
            if (ckRestoreWithTime.Checked == false)
            {

                String strRestore = " ALTER DATABASE " + txtDbName.Text.Trim()
                    + " SET SINGLE_USER WITH ROLLBACK IMMEDIATE " +
                    " USE tempdb RESTORE DATABASE " + txtDbName.Text.Trim()
                    + " FROM   " + deviceName + " WITH FILE =  " + backupSetIndex + ", REPLACE  "
                    + " ALTER DATABASE  " + txtDbName.Text.Trim() + " SET MULTI_USER";


                if (XtraMessageBox.Show("Bạn chắc chắc muốn phục hồi database ", "", MessageBoxButtons.OKCancel,MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    err = Program.ExecSqlNonQuery(strRestore, Program.connstr, "Lỗi phục hồi");
                    if (err == 0)
                        XtraMessageBox.Show("Phục hồi thành công", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                    return;

            }


            else
            {

                DateTime datetimeOfBackupSetPicked = (DateTime)((DataRowView)backupSetBindingSource[0])["backup_start_date"];
                string strTempDatetimeBk = dateRestore.DateTime.Year + "-" + dateRestore.DateTime.Month + "-" + dateRestore.DateTime.Day + " " +
                    timeRestore.Time.Hour + ":" + (timeRestore.Time.Minute) + ":" + timeRestore.Time.Second;
                
                
                DateTime dateTimePickedToRestore;
                dateTimePickedToRestore = DateTime.Parse(strTempDatetimeBk);
                if ((dateRestore.DateTime.Date < datetimeOfBackupSetPicked.Date) ||
                           (dateRestore.DateTime.Date == datetimeOfBackupSetPicked.Date && dateTimePickedToRestore.TimeOfDay.Ticks < datetimeOfBackupSetPicked.TimeOfDay.Ticks))
                {
                    XtraMessageBox.Show("Thời điểm muốn phục hồi phải sau bản sao lưu đã chọn!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (dateTimePickedToRestore > DateTime.Now)
                {
                    XtraMessageBox.Show("Thời điểm muốn phục hồi phải trước thời điểm hiện tại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if ((XtraMessageBox.Show("Bạn chắc chắn muốn phục hồi database " + txtDbName.Text + " về thời điểm " +
                    dateTimePickedToRestore + " ?", "Cảnh báo!", MessageBoxButtons.OKCancel,MessageBoxIcon.Warning) == DialogResult.OK))
                {
                    String month = dateRestore.DateTime.Month < 10 ? "0" + dateRestore.DateTime.Month : dateRestore.DateTime.Month.ToString();
                    String day = dateRestore.DateTime.Day < 10 ? "0" + dateRestore.DateTime.Day : dateRestore.DateTime.Day.ToString();
                    String hour = timeRestore.Time.Hour < 10 ? "0" + timeRestore.Time.Hour : timeRestore.Time.Hour.ToString();
                    String minute = timeRestore.Time.Minute < 10 ? "0" + timeRestore.Time.Minute : timeRestore.Time.Minute.ToString();
                    String second = timeRestore.Time.Second < 10 ? "0" + timeRestore.Time.Second : timeRestore.Time.Second.ToString();
                    String CheckTime = dateRestore.DateTime.Year + "/" + month + "/" + day + " " +
                    hour + ":" + minute + ":" + second;

                    String StrTendevice = "use " + txtDbName.Text.Trim() +
                        "\nselect  [Begin Time]  from  fn_dblog(null,null)" +
                        "where[Begin Time] < '" + CheckTime + "'";
                    Program.reader = Program.ExecSqlDataReader(StrTendevice);
                    if (Program.reader == null) return;
                    Program.reader.Read();

                    //có device thì ẩn btn newdevice
                    if (!Program.reader.Read())
                    {
                        XtraMessageBox.Show("Không tìm thấy bản log trong lịch sử.!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        try
                        {
                            //restore về thời điểm người dùng nhập
                            String strRestore = "ALTER DATABASE " + txtDbName.Text.Trim() + " SET SINGLE_USER WITH ROLLBACK IMMEDIATE \n" +
                                " BACKUP LOG " + txtDbName.Text + " TO DISK ='" + Program.strDefaultPath + "/" + "DEVICE_DB" +
                                txtDbName.Text.Trim() + ".trn' WITH INIT, NORECOVERY; \n" + " USE tempdb \n " +
                                " RESTORE DATABASE " + txtDbName.Text.Trim() + " FROM DEVICE_DB" + txtDbName.Text.Trim() + " WITH FILE = " + ((DataRowView)backupSetBindingSource[0])["position"].ToString() + ",NORECOVERY; \n" +
                                " RESTORE DATABASE " + txtDbName.Text.Trim() + " FROM DISK= '" + Program.strDefaultPath + "/" + "DEVICE_DB" + txtDbName.Text.Trim() + ".trn' " +
                                " WITH STOPAT= '" + strTempDatetimeBk + "' \n" +
                                " ALTER DATABASE  " + txtDbName.Text.Trim() + " SET MULTI_USER ";
                            //MessageBox.Show(strRestore);
                            err = Program.ExecSqlNonQuery(strRestore, Program.connstr, "Lỗi phục hồi csdl.");
                            if (err == 0)
                            {
                                XtraMessageBox.Show("Phục hồi cơ sở dữ liệu đến " + strTempDatetimeBk + " thành công!", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Information);
                            }

                        }
                        catch (Exception ex)
                        {
                            XtraMessageBox.Show("Lỗi Restore:\n" + ex + "\n Tự động phục hồi về bản sao lưu mới nhất!", "Lỗi xảy ra", MessageBoxButtons.OK,MessageBoxIcon.Error);
                            String strRestore = " ALTER DATABASE " + txtDbName.Text.Trim()
                            + " SET SINGLE_USER WITH ROLLBACK IMMEDIATE " +
                            " USE tempdb RESTORE DATABASE " + txtDbName.Text.Trim()
                            + " FROM   " + deviceName + " WITH FILE =  " + ((DataRowView)backupSetBindingSource[0])["position"].ToString() + ", REPLACE  "
                            + " ALTER DATABASE  " + txtDbName.Text.Trim() + " SET MULTI_USER";
                            err = Program.ExecSqlNonQuery(strRestore, Program.connstr, "Lỗi phục hồi");
                            if (err == 0)
                                XtraMessageBox.Show("Phục hồi thành công", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Information);

                        }
                    }

                }
                else return;
            }
        }

        private void ckRestoreWithTime_CheckedChanged(object sender, EventArgs e)
        {
            lbInfo.Visible = !lbInfo.Visible;
            lbNote.Visible = !lbNote.Visible;
            dateRestore.Visible = !dateRestore.Visible;
            timeRestore.Visible = !timeRestore.Visible;
            dateRestore.DateTime = DateTime.Now;
            timeRestore.Time = DateTime.Now;
        }
    }
}