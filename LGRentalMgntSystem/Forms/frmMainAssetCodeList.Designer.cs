namespace LGRentalMgntSystem
{
    partial class frmMainAssetCodeList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainAssetCodeList));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtSearch = new DevExpress.XtraEditors.TextEdit();
            this.lblTypeName = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.lblFormHeader = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gvAssetCodeList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcRowNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcAssetID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcAssetCodeID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcAssetCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcDateRetirement = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcShelfLife = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcShelfLifeUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcDamageStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcAssignStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcCurrentStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.btnDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.btnShowAsset = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.formAssistant1 = new DevExpress.XtraBars.FormAssistant();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAssetCodeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShowAsset)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.btnSearch);
            this.panelControl4.Controls.Add(this.labelControl2);
            this.panelControl4.Controls.Add(this.txtSearch);
            this.panelControl4.Controls.Add(this.lblTypeName);
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl4.Location = new System.Drawing.Point(0, 35);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(1005, 62);
            this.panelControl4.TabIndex = 68;
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSearch.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnSearch.Location = new System.Drawing.Point(342, 28);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(110, 25);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Teal;
            this.labelControl2.Location = new System.Drawing.Point(14, 6);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(152, 16);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Search By : Asset Code";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(65, 31);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Properties.MaxLength = 100;
            this.txtSearch.Size = new System.Drawing.Size(271, 20);
            this.txtSearch.TabIndex = 1;
            // 
            // lblTypeName
            // 
            this.lblTypeName.Location = new System.Drawing.Point(14, 34);
            this.lblTypeName.Name = "lblTypeName";
            this.lblTypeName.Size = new System.Drawing.Size(43, 13);
            this.lblTypeName.TabIndex = 0;
            this.lblTypeName.Text = "Search : ";
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.ContentImage = global::LGRentalMgntSystem.Properties.Resources.pnlBackground;
            this.panelControl1.Controls.Add(this.pictureEdit1);
            this.panelControl1.Controls.Add(this.lblFormHeader);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1005, 35);
            this.panelControl1.TabIndex = 67;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureEdit1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(2, 2);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Size = new System.Drawing.Size(28, 31);
            this.pictureEdit1.TabIndex = 5;
            // 
            // lblFormHeader
            // 
            this.lblFormHeader.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormHeader.Location = new System.Drawing.Point(36, 9);
            this.lblFormHeader.Name = "lblFormHeader";
            this.lblFormHeader.Size = new System.Drawing.Size(114, 18);
            this.lblFormHeader.TabIndex = 3;
            this.lblFormHeader.Text = "Asset Code List";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 97);
            this.gridControl1.MainView = this.gvAssetCodeList;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnEdit,
            this.btnDelete,
            this.btnShowAsset});
            this.gridControl1.Size = new System.Drawing.Size(1005, 320);
            this.gridControl1.TabIndex = 69;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvAssetCodeList});
            // 
            // gvAssetCodeList
            // 
            this.gvAssetCodeList.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Transparent;
            this.gvAssetCodeList.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvAssetCodeList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcRowNo,
            this.gcAssetID,
            this.gcAssetCodeID,
            this.gcAssetCode,
            this.gcDateRetirement,
            this.gcShelfLife,
            this.gcShelfLifeUnit,
            this.gcDamageStatus,
            this.gcAssignStatus,
            this.gcCurrentStatus});
            this.gvAssetCodeList.GridControl = this.gridControl1;
            this.gvAssetCodeList.Name = "gvAssetCodeList";
            this.gvAssetCodeList.OptionsBehavior.Editable = false;
            this.gvAssetCodeList.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm;
            this.gvAssetCodeList.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click;
            this.gvAssetCodeList.OptionsView.EnableAppearanceEvenRow = true;
            this.gvAssetCodeList.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.Hidden;
            this.gvAssetCodeList.OptionsView.ShowGroupPanel = false;
            // 
            // gcRowNo
            // 
            this.gcRowNo.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gcRowNo.AppearanceHeader.Options.UseFont = true;
            this.gcRowNo.Caption = "Sr. No.";
            this.gcRowNo.FieldName = "RowNo";
            this.gcRowNo.Name = "gcRowNo";
            this.gcRowNo.Visible = true;
            this.gcRowNo.VisibleIndex = 0;
            // 
            // gcAssetID
            // 
            this.gcAssetID.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gcAssetID.AppearanceHeader.Options.UseFont = true;
            this.gcAssetID.Caption = "gcAssetID";
            this.gcAssetID.FieldName = "nAssetID";
            this.gcAssetID.Name = "gcAssetID";
            this.gcAssetID.Visible = true;
            this.gcAssetID.VisibleIndex = 2;
            // 
            // gcAssetCodeID
            // 
            this.gcAssetCodeID.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gcAssetCodeID.AppearanceHeader.Options.UseFont = true;
            this.gcAssetCodeID.Caption = "gcAssetCodeID";
            this.gcAssetCodeID.FieldName = "nAssetCodeID";
            this.gcAssetCodeID.Name = "gcAssetCodeID";
            this.gcAssetCodeID.Visible = true;
            this.gcAssetCodeID.VisibleIndex = 1;
            // 
            // gcAssetCode
            // 
            this.gcAssetCode.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gcAssetCode.AppearanceHeader.Options.UseFont = true;
            this.gcAssetCode.Caption = "Asset Code";
            this.gcAssetCode.FieldName = "sUniqueCode";
            this.gcAssetCode.Name = "gcAssetCode";
            this.gcAssetCode.Visible = true;
            this.gcAssetCode.VisibleIndex = 3;
            // 
            // gcDateRetirement
            // 
            this.gcDateRetirement.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gcDateRetirement.AppearanceHeader.Options.UseFont = true;
            this.gcDateRetirement.Caption = "Date Of Retirement";
            this.gcDateRetirement.FieldName = "dtRetirementDate";
            this.gcDateRetirement.Name = "gcDateRetirement";
            this.gcDateRetirement.Visible = true;
            this.gcDateRetirement.VisibleIndex = 6;
            // 
            // gcShelfLife
            // 
            this.gcShelfLife.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gcShelfLife.AppearanceHeader.Options.UseFont = true;
            this.gcShelfLife.Caption = "Shelf Life";
            this.gcShelfLife.FieldName = "dtShelfLife";
            this.gcShelfLife.Name = "gcShelfLife";
            this.gcShelfLife.Visible = true;
            this.gcShelfLife.VisibleIndex = 4;
            // 
            // gcShelfLifeUnit
            // 
            this.gcShelfLifeUnit.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gcShelfLifeUnit.AppearanceHeader.Options.UseFont = true;
            this.gcShelfLifeUnit.Caption = "Shelf Life Unit";
            this.gcShelfLifeUnit.FieldName = "sShelfLifeUnit";
            this.gcShelfLifeUnit.Name = "gcShelfLifeUnit";
            this.gcShelfLifeUnit.Visible = true;
            this.gcShelfLifeUnit.VisibleIndex = 5;
            // 
            // gcDamageStatus
            // 
            this.gcDamageStatus.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gcDamageStatus.AppearanceHeader.Options.UseFont = true;
            this.gcDamageStatus.Caption = "Damage Status";
            this.gcDamageStatus.FieldName = "sDamageStatus";
            this.gcDamageStatus.Name = "gcDamageStatus";
            this.gcDamageStatus.Visible = true;
            this.gcDamageStatus.VisibleIndex = 7;
            // 
            // gcAssignStatus
            // 
            this.gcAssignStatus.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gcAssignStatus.AppearanceHeader.Options.UseFont = true;
            this.gcAssignStatus.Caption = "Assign Staus";
            this.gcAssignStatus.FieldName = "sAssignStatus";
            this.gcAssignStatus.Name = "gcAssignStatus";
            this.gcAssignStatus.Visible = true;
            this.gcAssignStatus.VisibleIndex = 8;
            // 
            // gcCurrentStatus
            // 
            this.gcCurrentStatus.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gcCurrentStatus.AppearanceHeader.Options.UseFont = true;
            this.gcCurrentStatus.Caption = "Current Status";
            this.gcCurrentStatus.FieldName = "sCurrentStatus";
            this.gcCurrentStatus.Name = "gcCurrentStatus";
            this.gcCurrentStatus.Visible = true;
            this.gcCurrentStatus.VisibleIndex = 9;
            // 
            // btnEdit
            // 
            this.btnEdit.AutoHeight = false;
            this.btnEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("btnEdit.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // btnDelete
            // 
            this.btnDelete.AutoHeight = false;
            this.btnDelete.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("btnDelete.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // btnShowAsset
            // 
            this.btnShowAsset.AutoHeight = false;
            this.btnShowAsset.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("btnShowAsset.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject3, "", null, null, true)});
            this.btnShowAsset.Name = "btnShowAsset";
            this.btnShowAsset.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // frmMainAssetCodeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 417);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelControl4);
            this.Controls.Add(this.panelControl1);
            this.MinimizeBox = false;
            this.Name = "frmMainAssetCodeList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmMainAssetCodeList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.panelControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAssetCodeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShowAsset)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtSearch;
        private DevExpress.XtraEditors.LabelControl lblTypeName;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.LabelControl lblFormHeader;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gvAssetCodeList;
        private DevExpress.XtraGrid.Columns.GridColumn gcRowNo;
        private DevExpress.XtraGrid.Columns.GridColumn gcAssetID;
        private DevExpress.XtraGrid.Columns.GridColumn gcAssetCodeID;
        private DevExpress.XtraGrid.Columns.GridColumn gcAssetCode;
        private DevExpress.XtraGrid.Columns.GridColumn gcDateRetirement;
        private DevExpress.XtraGrid.Columns.GridColumn gcShelfLife;
        private DevExpress.XtraGrid.Columns.GridColumn gcDamageStatus;
        private DevExpress.XtraGrid.Columns.GridColumn gcAssignStatus;
        private DevExpress.XtraGrid.Columns.GridColumn gcCurrentStatus;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnDelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnShowAsset;
        private DevExpress.XtraGrid.Columns.GridColumn gcShelfLifeUnit;
        private DevExpress.XtraBars.FormAssistant formAssistant1;
    }
}