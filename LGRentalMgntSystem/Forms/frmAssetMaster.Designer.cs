namespace LGRentalMgntSystem
{
    partial class frmAssetMaster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAssetMaster));
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.lblTypeID = new DevExpress.XtraEditors.LabelControl();
            this.txtMainTypeName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.pnlAssetMainType = new DevExpress.XtraEditors.PanelControl();
            this.cmbAssetMainType = new System.Windows.Forms.ComboBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.lblFormHeader = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMainTypeName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlAssetMainType)).BeginInit();
            this.pnlAssetMainType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.lblTypeID);
            this.panelControl4.Controls.Add(this.txtMainTypeName);
            this.panelControl4.Controls.Add(this.labelControl1);
            this.panelControl4.Controls.Add(this.btnSave);
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl4.Location = new System.Drawing.Point(0, 74);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(395, 91);
            this.panelControl4.TabIndex = 11;
            // 
            // lblTypeID
            // 
            this.lblTypeID.Location = new System.Drawing.Point(12, 50);
            this.lblTypeID.Name = "lblTypeID";
            this.lblTypeID.Size = new System.Drawing.Size(6, 13);
            this.lblTypeID.TabIndex = 3;
            this.lblTypeID.Text = "0";
            this.lblTypeID.Visible = false;
            // 
            // txtMainTypeName
            // 
            this.txtMainTypeName.Location = new System.Drawing.Point(124, 6);
            this.txtMainTypeName.Name = "txtMainTypeName";
            this.txtMainTypeName.Properties.MaxLength = 100;
            this.txtMainTypeName.Size = new System.Drawing.Size(232, 20);
            this.txtMainTypeName.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(40, 9);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(69, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Enter  Name : ";
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSave.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnSave.Location = new System.Drawing.Point(262, 40);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlAssetMainType
            // 
            this.pnlAssetMainType.Controls.Add(this.cmbAssetMainType);
            this.pnlAssetMainType.Controls.Add(this.labelControl2);
            this.pnlAssetMainType.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAssetMainType.Location = new System.Drawing.Point(0, 40);
            this.pnlAssetMainType.Name = "pnlAssetMainType";
            this.pnlAssetMainType.Size = new System.Drawing.Size(395, 34);
            this.pnlAssetMainType.TabIndex = 10;
            // 
            // cmbAssetMainType
            // 
            this.cmbAssetMainType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbAssetMainType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbAssetMainType.FormattingEnabled = true;
            this.cmbAssetMainType.Location = new System.Drawing.Point(124, 6);
            this.cmbAssetMainType.Name = "cmbAssetMainType";
            this.cmbAssetMainType.Size = new System.Drawing.Size(232, 21);
            this.cmbAssetMainType.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(45, 9);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(64, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Asset Type : ";
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.ContentImage = global::LGRentalMgntSystem.Properties.Resources.btnBackground;
            this.panelControl1.Controls.Add(this.pictureEdit1);
            this.panelControl1.Controls.Add(this.lblFormHeader);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(395, 40);
            this.panelControl1.TabIndex = 8;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureEdit1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(2, 2);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Size = new System.Drawing.Size(51, 36);
            this.pictureEdit1.TabIndex = 5;
            // 
            // lblFormHeader
            // 
            this.lblFormHeader.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormHeader.Location = new System.Drawing.Point(59, 12);
            this.lblFormHeader.Name = "lblFormHeader";
            this.lblFormHeader.Size = new System.Drawing.Size(52, 18);
            this.lblFormHeader.TabIndex = 3;
            this.lblFormHeader.Text = "Master";
            // 
            // frmAssetMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 165);
            this.Controls.Add(this.panelControl4);
            this.Controls.Add(this.pnlAssetMainType);
            this.Controls.Add(this.panelControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAssetMaster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAssetMaster";
            this.Load += new System.EventHandler(this.frmAssetMaster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.panelControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMainTypeName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlAssetMainType)).EndInit();
            this.pnlAssetMainType.ResumeLayout(false);
            this.pnlAssetMainType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.TextEdit txtMainTypeName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl lblFormHeader;
        private DevExpress.XtraEditors.PanelControl pnlAssetMainType;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.ComboBox cmbAssetMainType;
        private DevExpress.XtraEditors.LabelControl lblTypeID;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
    }
}