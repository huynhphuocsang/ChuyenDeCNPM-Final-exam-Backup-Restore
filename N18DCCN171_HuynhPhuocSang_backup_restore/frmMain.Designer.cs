
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
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databasesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databasesGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewDatabase)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ckRestoreWithTime);
            this.panel1.Controls.Add(this.btnCreateBackupDevice);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnRestore);
            this.panel1.Controls.Add(this.btnBackup);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1237, 111);
            this.panel1.TabIndex = 0;
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
            // 
            // btnLogout
            // 
            this.btnLogout.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLogout.ImageOptions.SvgImage")));
            this.btnLogout.Location = new System.Drawing.Point(556, 16);
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
            this.btnBackup.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBackup.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnBackup.ImageOptions.SvgImage")));
            this.btnBackup.Location = new System.Drawing.Point(26, 12);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(101, 47);
            this.btnBackup.TabIndex = 0;
            this.btnBackup.Text = "Sao lưu";
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
            this.databasesGridControl.Location = new System.Drawing.Point(0, 111);
            this.databasesGridControl.MainView = this.gridviewDatabase;
            this.databasesGridControl.Name = "databasesGridControl";
            this.databasesGridControl.Size = new System.Drawing.Size(370, 470);
            this.databasesGridControl.TabIndex = 2;
            this.databasesGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridviewDatabase});
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
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 581);
            this.ControlBox = false;
            this.Controls.Add(this.databasesGridControl);
            this.Controls.Add(this.panel1);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databasesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databasesGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewDatabase)).EndInit();
            this.ResumeLayout(false);

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
    }
}