
namespace N18DCCN171_HuynhPhuocSang_backup_restore
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDeleteBackupDevice = new DevExpress.XtraEditors.SimpleButton();
            this.btnDeleteBackupSet = new DevExpress.XtraEditors.SimpleButton();
            this.ckRestoreWithTime = new System.Windows.Forms.CheckBox();
            this.btnCreateBackupDevice = new DevExpress.XtraEditors.SimpleButton();
            this.btnLogout = new DevExpress.XtraEditors.SimpleButton();
            this.btnRestore = new DevExpress.XtraEditors.SimpleButton();
            this.btnBackup = new DevExpress.XtraEditors.SimpleButton();
            this.dataSet1 = new N18DCCN171_HuynhPhuocSang_backup_restore.DataSet1();
            this.databasesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databasesTableAdapter = new N18DCCN171_HuynhPhuocSang_backup_restore.DataSet1TableAdapters.databasesTableAdapter();
            this.tableAdapterManager = new N18DCCN171_HuynhPhuocSang_backup_restore.DataSet1TableAdapters.TableAdapterManager();
            this.databasesGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridviewDatabase = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.backupSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.backupSetTableAdapter = new N18DCCN171_HuynhPhuocSang_backup_restore.DataSet1TableAdapters.BackupSetTableAdapter();
            this.fillToolStrip = new System.Windows.Forms.ToolStrip();
            this.dBNAMEToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.txtDbName = new System.Windows.Forms.ToolStripTextBox();
            this.fillToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.backupSetGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colposition = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colname1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbackup_start_date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coluser_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.backupDevicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.backupDevicesTableAdapter = new N18DCCN171_HuynhPhuocSang_backup_restore.DataSet1TableAdapters.BackupDevicesTableAdapter();
            this.ckDelOldBackups = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databasesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databasesGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewDatabase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backupSetBindingSource)).BeginInit();
            this.fillToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backupSetGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backupDevicesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDeleteBackupDevice);
            this.panel1.Controls.Add(this.btnDeleteBackupSet);
            this.panel1.Controls.Add(this.ckRestoreWithTime);
            this.panel1.Controls.Add(this.btnCreateBackupDevice);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnRestore);
            this.panel1.Controls.Add(this.btnBackup);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1237, 93);
            this.panel1.TabIndex = 0;
            // 
            // btnDeleteBackupDevice
            // 
            this.btnDeleteBackupDevice.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteBackupDevice.ImageOptions.Image")));
            this.btnDeleteBackupDevice.Location = new System.Drawing.Point(771, 16);
            this.btnDeleteBackupDevice.Name = "btnDeleteBackupDevice";
            this.btnDeleteBackupDevice.Size = new System.Drawing.Size(148, 43);
            this.btnDeleteBackupDevice.TabIndex = 2;
            this.btnDeleteBackupDevice.Text = "Xóa backup device";
            this.btnDeleteBackupDevice.Click += new System.EventHandler(this.btnDeleteBackupDevice_Click);
            // 
            // btnDeleteBackupSet
            // 
            this.btnDeleteBackupSet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteBackupSet.ImageOptions.Image")));
            this.btnDeleteBackupSet.Location = new System.Drawing.Point(572, 16);
            this.btnDeleteBackupSet.Name = "btnDeleteBackupSet";
            this.btnDeleteBackupSet.Size = new System.Drawing.Size(145, 43);
            this.btnDeleteBackupSet.TabIndex = 2;
            this.btnDeleteBackupSet.Text = "Xóa bản sao lưu";
            // 
            // ckRestoreWithTime
            // 
            this.ckRestoreWithTime.AutoSize = true;
            this.ckRestoreWithTime.Location = new System.Drawing.Point(158, 65);
            this.ckRestoreWithTime.Name = "ckRestoreWithTime";
            this.ckRestoreWithTime.Size = new System.Drawing.Size(225, 21);
            this.ckRestoreWithTime.TabIndex = 1;
            this.ckRestoreWithTime.Text = "Phục hồi theo tham số thời gian";
            this.ckRestoreWithTime.UseVisualStyleBackColor = true;
            // 
            // btnCreateBackupDevice
            // 
            this.btnCreateBackupDevice.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCreateBackupDevice.ImageOptions.Image")));
            this.btnCreateBackupDevice.Location = new System.Drawing.Point(337, 12);
            this.btnCreateBackupDevice.Name = "btnCreateBackupDevice";
            this.btnCreateBackupDevice.Size = new System.Drawing.Size(166, 44);
            this.btnCreateBackupDevice.TabIndex = 0;
            this.btnCreateBackupDevice.Text = "Tạo backup device";
            this.btnCreateBackupDevice.Click += new System.EventHandler(this.btnCreateBackupDevice_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLogout.ImageOptions.SvgImage")));
            this.btnLogout.Location = new System.Drawing.Point(982, 16);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(116, 43);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRestore.ImageOptions.Image")));
            this.btnRestore.Location = new System.Drawing.Point(158, 12);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(110, 47);
            this.btnRestore.TabIndex = 0;
            this.btnRestore.Text = "Phục hồi";
            // 
            // btnBackup
            // 
            this.btnBackup.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnBackup.ImageOptions.SvgImage")));
            this.btnBackup.Location = new System.Drawing.Point(26, 12);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(101, 47);
            this.btnBackup.TabIndex = 0;
            this.btnBackup.Text = "Sao lưu";
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // databasesBindingSource
            // 
            this.databasesBindingSource.DataMember = "databases";
            this.databasesBindingSource.DataSource = this.dataSet1;
            // 
            // databasesTableAdapter
            // 
            this.databasesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = N18DCCN171_HuynhPhuocSang_backup_restore.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // databasesGridControl
            // 
            this.databasesGridControl.DataSource = this.databasesBindingSource;
            this.databasesGridControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.databasesGridControl.Location = new System.Drawing.Point(0, 93);
            this.databasesGridControl.MainView = this.gridviewDatabase;
            this.databasesGridControl.Name = "databasesGridControl";
            this.databasesGridControl.Size = new System.Drawing.Size(370, 488);
            this.databasesGridControl.TabIndex = 2;
            this.databasesGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridviewDatabase});
            this.databasesGridControl.Click += new System.EventHandler(this.databasesGridControl_Click);
            // 
            // gridviewDatabase
            // 
            this.gridviewDatabase.Appearance.GroupPanel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.gridviewDatabase.Appearance.GroupPanel.Font = new System.Drawing.Font("Tahoma", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridviewDatabase.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridviewDatabase.Appearance.GroupPanel.Options.UseFont = true;
            this.gridviewDatabase.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colname});
            this.gridviewDatabase.GridControl = this.databasesGridControl;
            this.gridviewDatabase.GroupPanelText = "Cơ sở dữ liệu";
            this.gridviewDatabase.Name = "gridviewDatabase";
            // 
            // colname
            // 
            this.colname.AppearanceHeader.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.colname.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colname.AppearanceHeader.Options.UseBackColor = true;
            this.colname.AppearanceHeader.Options.UseFont = true;
            this.colname.Caption = "Tên CSDL";
            this.colname.FieldName = "name";
            this.colname.MinWidth = 25;
            this.colname.Name = "colname";
            this.colname.OptionsColumn.AllowEdit = false;
            this.colname.OptionsColumn.ShowInExpressionEditor = false;
            this.colname.Visible = true;
            this.colname.VisibleIndex = 0;
            this.colname.Width = 94;
            // 
            // backupSetBindingSource
            // 
            this.backupSetBindingSource.DataMember = "BackupSet";
            this.backupSetBindingSource.DataSource = this.dataSet1;
            // 
            // backupSetTableAdapter
            // 
            this.backupSetTableAdapter.ClearBeforeFill = true;
            // 
            // fillToolStrip
            // 
            this.fillToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dBNAMEToolStripLabel,
            this.txtDbName,
            this.fillToolStripButton});
            this.fillToolStrip.Location = new System.Drawing.Point(370, 93);
            this.fillToolStrip.Name = "fillToolStrip";
            this.fillToolStrip.Size = new System.Drawing.Size(867, 30);
            this.fillToolStrip.TabIndex = 3;
            this.fillToolStrip.Text = "fillToolStrip";
            // 
            // dBNAMEToolStripLabel
            // 
            this.dBNAMEToolStripLabel.Name = "dBNAMEToolStripLabel";
            this.dBNAMEToolStripLabel.Size = new System.Drawing.Size(97, 27);
            this.dBNAMEToolStripLabel.Text = "Tên database";
            // 
            // txtDbName
            // 
            this.txtDbName.Enabled = false;
            this.txtDbName.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDbName.Name = "txtDbName";
            this.txtDbName.Size = new System.Drawing.Size(100, 30);
            // 
            // fillToolStripButton
            // 
            this.fillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillToolStripButton.Name = "fillToolStripButton";
            this.fillToolStripButton.Size = new System.Drawing.Size(32, 27);
            this.fillToolStripButton.Text = "Fill";
            this.fillToolStripButton.Click += new System.EventHandler(this.fillToolStripButton_Click);
            // 
            // backupSetGridControl
            // 
            this.backupSetGridControl.DataSource = this.backupSetBindingSource;
            this.backupSetGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.backupSetGridControl.Location = new System.Drawing.Point(370, 123);
            this.backupSetGridControl.MainView = this.gridView1;
            this.backupSetGridControl.Name = "backupSetGridControl";
            this.backupSetGridControl.Size = new System.Drawing.Size(867, 290);
            this.backupSetGridControl.TabIndex = 3;
            this.backupSetGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colposition,
            this.colname1,
            this.colbackup_start_date,
            this.coluser_name});
            this.gridView1.GridControl = this.backupSetGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colposition
            // 
            this.colposition.AppearanceCell.Options.UseTextOptions = true;
            this.colposition.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colposition.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colposition.AppearanceHeader.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.colposition.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colposition.AppearanceHeader.Options.UseBackColor = true;
            this.colposition.AppearanceHeader.Options.UseFont = true;
            this.colposition.AppearanceHeader.Options.UseTextOptions = true;
            this.colposition.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colposition.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colposition.Caption = "Vị trí";
            this.colposition.FieldName = "position";
            this.colposition.MinWidth = 25;
            this.colposition.Name = "colposition";
            this.colposition.OptionsColumn.AllowEdit = false;
            this.colposition.OptionsColumn.ShowInExpressionEditor = false;
            this.colposition.Visible = true;
            this.colposition.VisibleIndex = 0;
            this.colposition.Width = 94;
            // 
            // colname1
            // 
            this.colname1.AppearanceCell.Options.UseTextOptions = true;
            this.colname1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colname1.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colname1.AppearanceHeader.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.colname1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colname1.AppearanceHeader.Options.UseBackColor = true;
            this.colname1.AppearanceHeader.Options.UseFont = true;
            this.colname1.AppearanceHeader.Options.UseTextOptions = true;
            this.colname1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colname1.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colname1.Caption = "Tên bản sao lưu";
            this.colname1.FieldName = "name";
            this.colname1.MinWidth = 25;
            this.colname1.Name = "colname1";
            this.colname1.OptionsColumn.AllowEdit = false;
            this.colname1.OptionsColumn.ShowInExpressionEditor = false;
            this.colname1.Visible = true;
            this.colname1.VisibleIndex = 1;
            this.colname1.Width = 94;
            // 
            // colbackup_start_date
            // 
            this.colbackup_start_date.AppearanceCell.Options.UseTextOptions = true;
            this.colbackup_start_date.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colbackup_start_date.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colbackup_start_date.AppearanceHeader.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.colbackup_start_date.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colbackup_start_date.AppearanceHeader.Options.UseBackColor = true;
            this.colbackup_start_date.AppearanceHeader.Options.UseFont = true;
            this.colbackup_start_date.AppearanceHeader.Options.UseTextOptions = true;
            this.colbackup_start_date.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colbackup_start_date.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colbackup_start_date.Caption = "Ngày sao lưu";
            this.colbackup_start_date.DisplayFormat.FormatString = "G";
            this.colbackup_start_date.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colbackup_start_date.FieldName = "backup_start_date";
            this.colbackup_start_date.MinWidth = 25;
            this.colbackup_start_date.Name = "colbackup_start_date";
            this.colbackup_start_date.OptionsColumn.AllowEdit = false;
            this.colbackup_start_date.OptionsColumn.ShowInExpressionEditor = false;
            this.colbackup_start_date.Visible = true;
            this.colbackup_start_date.VisibleIndex = 2;
            this.colbackup_start_date.Width = 94;
            // 
            // coluser_name
            // 
            this.coluser_name.AppearanceCell.Options.UseTextOptions = true;
            this.coluser_name.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coluser_name.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.coluser_name.AppearanceHeader.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.coluser_name.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coluser_name.AppearanceHeader.Options.UseBackColor = true;
            this.coluser_name.AppearanceHeader.Options.UseFont = true;
            this.coluser_name.AppearanceHeader.Options.UseTextOptions = true;
            this.coluser_name.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coluser_name.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.coluser_name.Caption = "Tài khoản sao lưu";
            this.coluser_name.FieldName = "user_name";
            this.coluser_name.MinWidth = 25;
            this.coluser_name.Name = "coluser_name";
            this.coluser_name.OptionsColumn.AllowEdit = false;
            this.coluser_name.OptionsColumn.ShowInExpressionEditor = false;
            this.coluser_name.Visible = true;
            this.coluser_name.VisibleIndex = 3;
            this.coluser_name.Width = 94;
            // 
            // backupDevicesBindingSource
            // 
            this.backupDevicesBindingSource.DataMember = "BackupDevices";
            this.backupDevicesBindingSource.DataSource = this.dataSet1;
            // 
            // backupDevicesTableAdapter
            // 
            this.backupDevicesTableAdapter.ClearBeforeFill = true;
            // 
            // ckDelOldBackups
            // 
            this.ckDelOldBackups.AutoSize = true;
            this.ckDelOldBackups.Location = new System.Drawing.Point(651, 438);
            this.ckDelOldBackups.Name = "ckDelOldBackups";
            this.ckDelOldBackups.Size = new System.Drawing.Size(332, 21);
            this.ckDelOldBackups.TabIndex = 4;
            this.ckDelOldBackups.Text = "Xóa các bản sao lưu cũ trước khi sao lưu bản mới";
            this.ckDelOldBackups.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 581);
            this.ControlBox = false;
            this.Controls.Add(this.ckDelOldBackups);
            this.Controls.Add(this.backupSetGridControl);
            this.Controls.Add(this.fillToolStrip);
            this.Controls.Add(this.databasesGridControl);
            this.Controls.Add(this.panel1);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý backup-restore";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databasesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databasesGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewDatabase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backupSetBindingSource)).EndInit();
            this.fillToolStrip.ResumeLayout(false);
            this.fillToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backupSetGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backupDevicesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnLogout;
        private DevExpress.XtraEditors.SimpleButton btnRestore;
        private DevExpress.XtraEditors.SimpleButton btnBackup;
        private DevExpress.XtraEditors.SimpleButton btnCreateBackupDevice;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource databasesBindingSource;
        private DataSet1TableAdapters.databasesTableAdapter databasesTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl databasesGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridviewDatabase;
        private DevExpress.XtraGrid.Columns.GridColumn colname;
        private System.Windows.Forms.CheckBox ckRestoreWithTime;
        private System.Windows.Forms.BindingSource backupSetBindingSource;
        private DataSet1TableAdapters.BackupSetTableAdapter backupSetTableAdapter;
        private System.Windows.Forms.ToolStrip fillToolStrip;
        private System.Windows.Forms.ToolStripLabel dBNAMEToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox txtDbName;
        private System.Windows.Forms.ToolStripButton fillToolStripButton;
        private DevExpress.XtraGrid.GridControl backupSetGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colposition;
        private DevExpress.XtraGrid.Columns.GridColumn colname1;
        private DevExpress.XtraGrid.Columns.GridColumn colbackup_start_date;
        private DevExpress.XtraGrid.Columns.GridColumn coluser_name;
        private System.Windows.Forms.BindingSource backupDevicesBindingSource;
        private DataSet1TableAdapters.BackupDevicesTableAdapter backupDevicesTableAdapter;
        private DevExpress.XtraEditors.SimpleButton btnDeleteBackupDevice;
        private DevExpress.XtraEditors.SimpleButton btnDeleteBackupSet;
        private System.Windows.Forms.CheckBox ckDelOldBackups;
    }
}