
namespace N18DCCN171_HuynhPhuocSang_backup_restore
{
    partial class DialogForBackupName
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DialogForBackupName));
            this.txtBackupName = new DevExpress.XtraEditors.TextEdit();
            this.btnVerifyname = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtBackupName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBackupName
            // 
            this.txtBackupName.Location = new System.Drawing.Point(157, 132);
            this.txtBackupName.Name = "txtBackupName";
            this.txtBackupName.Size = new System.Drawing.Size(226, 22);
            this.txtBackupName.TabIndex = 1;
            // 
            // btnVerifyname
            // 
            this.btnVerifyname.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnVerifyname.ImageOptions.Image")));
            this.btnVerifyname.Location = new System.Drawing.Point(393, 195);
            this.btnVerifyname.Name = "btnVerifyname";
            this.btnVerifyname.Size = new System.Drawing.Size(109, 38);
            this.btnVerifyname.TabIndex = 4;
            this.btnVerifyname.Text = "Xác nhận";
            this.btnVerifyname.Click += new System.EventHandler(this.btnVerifyname_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(47, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nhập vào tên của bản backup(có thể bỏ trống): ";
            // 
            // DialogForBackupName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 263);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVerifyname);
            this.Controls.Add(this.txtBackupName);
            this.Name = "DialogForBackupName";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tên của bản backup";
            ((System.ComponentModel.ISupportInitialize)(this.txtBackupName.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtBackupName;
        private DevExpress.XtraEditors.SimpleButton btnVerifyname;
        private System.Windows.Forms.Label label1;
    }
}