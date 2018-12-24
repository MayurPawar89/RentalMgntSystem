namespace LGRentalMgntSystem
{
    partial class frmMainKitList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainKitList));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            this.formAssistant1 = new DevExpress.XtraBars.FormAssistant();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtSearch = new DevExpress.XtraEditors.TextEdit();
            this.lblTypeName = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.lblFormHeader = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gvKitList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcRowNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcKitID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcKitCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcKitName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcAbbrivation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcKitDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcAssignStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcCurrentStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcIsUsed = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcShowAsset = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnShowAsset = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gcEdit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gdDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvKitList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShowAsset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
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
            this.panelControl4.Size = new System.Drawing.Size(830, 62);
            this.panelControl4.TabIndex = 68;
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSearch.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnSearch.Location = new System.Drawing.Point(341, 28);
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
            this.labelControl2.Size = new System.Drawing.Size(279, 16);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Search By : Kit Code, Kit Name, Abbrivation";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(64, 31);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Properties.MaxLength = 100;
            this.txtSearch.Size = new System.Drawing.Size(271, 20);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.EditValueChanged += new System.EventHandler(this.txtSearch_EditValueChanged);
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
            this.panelControl1.Size = new System.Drawing.Size(830, 35);
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
            this.lblFormHeader.Size = new System.Drawing.Size(53, 18);
            this.lblFormHeader.TabIndex = 3;
            this.lblFormHeader.Text = "Kit List";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 97);
            this.gridControl1.MainView = this.gvKitList;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnEdit,
            this.btnDelete,
            this.btnShowAsset});
            this.gridControl1.Size = new System.Drawing.Size(830, 344);
            this.gridControl1.TabIndex = 69;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvKitList});
            // 
            // gvKitList
            // 
            this.gvKitList.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Transparent;
            this.gvKitList.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvKitList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcRowNo,
            this.gcKitID,
            this.gcKitCode,
            this.gcKitName,
            this.gcAbbrivation,
            this.gcKitDescription,
            this.gcAssignStatus,
            this.gcCurrentStatus,
            this.gcIsUsed,
            this.gcShowAsset,
            this.gcEdit,
            this.gdDelete});
            this.gvKitList.GridControl = this.gridControl1;
            this.gvKitList.Name = "gvKitList";
            this.gvKitList.OptionsBehavior.Editable = false;
            this.gvKitList.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm;
            this.gvKitList.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click;
            this.gvKitList.OptionsView.EnableAppearanceEvenRow = true;
            this.gvKitList.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.Hidden;
            this.gvKitList.OptionsView.ShowGroupPanel = false;
            this.gvKitList.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gvKitList_RowCellClick);
            this.gvKitList.CustomRowCellEdit += new DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventHandler(this.gvKitList_CustomRowCellEdit);
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
            // gcKitID
            // 
            this.gcKitID.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gcKitID.AppearanceHeader.Options.UseFont = true;
            this.gcKitID.Caption = "gcKitID";
            this.gcKitID.FieldName = "nKitID";
            this.gcKitID.Name = "gcKitID";
            this.gcKitID.Visible = true;
            this.gcKitID.VisibleIndex = 1;
            // 
            // gcKitCode
            // 
            this.gcKitCode.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gcKitCode.AppearanceHeader.Options.UseFont = true;
            this.gcKitCode.Caption = "Kit Code";
            this.gcKitCode.FieldName = "sKitCode";
            this.gcKitCode.Name = "gcKitCode";
            this.gcKitCode.Visible = true;
            this.gcKitCode.VisibleIndex = 3;
            // 
            // gcKitName
            // 
            this.gcKitName.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gcKitName.AppearanceHeader.Options.UseFont = true;
            this.gcKitName.Caption = "Kit Name";
            this.gcKitName.FieldName = "sKitName";
            this.gcKitName.Name = "gcKitName";
            this.gcKitName.Visible = true;
            this.gcKitName.VisibleIndex = 2;
            // 
            // gcAbbrivation
            // 
            this.gcAbbrivation.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gcAbbrivation.AppearanceHeader.Options.UseFont = true;
            this.gcAbbrivation.Caption = "Abbrivation";
            this.gcAbbrivation.FieldName = "sKitAbbrivation";
            this.gcAbbrivation.Name = "gcAbbrivation";
            this.gcAbbrivation.Visible = true;
            this.gcAbbrivation.VisibleIndex = 4;
            // 
            // gcKitDescription
            // 
            this.gcKitDescription.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gcKitDescription.AppearanceHeader.Options.UseFont = true;
            this.gcKitDescription.Caption = "sKitDescription";
            this.gcKitDescription.FieldName = "sKitDescription";
            this.gcKitDescription.Name = "gcKitDescription";
            this.gcKitDescription.Visible = true;
            this.gcKitDescription.VisibleIndex = 5;
            // 
            // gcAssignStatus
            // 
            this.gcAssignStatus.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gcAssignStatus.AppearanceHeader.Options.UseFont = true;
            this.gcAssignStatus.Caption = "Assign Status";
            this.gcAssignStatus.FieldName = "sAssignStatus";
            this.gcAssignStatus.Name = "gcAssignStatus";
            this.gcAssignStatus.Visible = true;
            this.gcAssignStatus.VisibleIndex = 6;
            // 
            // gcCurrentStatus
            // 
            this.gcCurrentStatus.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gcCurrentStatus.AppearanceHeader.Options.UseFont = true;
            this.gcCurrentStatus.Caption = "Current Status";
            this.gcCurrentStatus.FieldName = "sCurrentStatus";
            this.gcCurrentStatus.Name = "gcCurrentStatus";
            this.gcCurrentStatus.Visible = true;
            this.gcCurrentStatus.VisibleIndex = 7;
            // 
            // gcIsUsed
            // 
            this.gcIsUsed.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gcIsUsed.AppearanceHeader.Options.UseFont = true;
            this.gcIsUsed.Caption = "Used";
            this.gcIsUsed.FieldName = "IsUsed";
            this.gcIsUsed.Name = "gcIsUsed";
            this.gcIsUsed.Visible = true;
            this.gcIsUsed.VisibleIndex = 8;
            this.gcIsUsed.Width = 73;
            // 
            // gcShowAsset
            // 
            this.gcShowAsset.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gcShowAsset.AppearanceHeader.Options.UseFont = true;
            this.gcShowAsset.Caption = "Show Asset";
            this.gcShowAsset.ColumnEdit = this.btnShowAsset;
            this.gcShowAsset.Name = "gcShowAsset";
            this.gcShowAsset.Visible = true;
            this.gcShowAsset.VisibleIndex = 9;
            // 
            // btnShowAsset
            // 
            this.btnShowAsset.AutoHeight = false;
            this.btnShowAsset.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("btnShowAsset.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject4, "", null, null, true)});
            this.btnShowAsset.Name = "btnShowAsset";
            this.btnShowAsset.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // gcEdit
            // 
            this.gcEdit.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gcEdit.AppearanceHeader.Options.UseFont = true;
            this.gcEdit.Caption = "Edit";
            this.gcEdit.ColumnEdit = this.btnEdit;
            this.gcEdit.Name = "gcEdit";
            this.gcEdit.Visible = true;
            this.gcEdit.VisibleIndex = 10;
            this.gcEdit.Width = 91;
            // 
            // btnEdit
            // 
            this.btnEdit.AutoHeight = false;
            this.btnEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("btnEdit.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, "", null, null, true)});
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // gdDelete
            // 
            this.gdDelete.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gdDelete.AppearanceHeader.Options.UseFont = true;
            this.gdDelete.Caption = "Delete";
            this.gdDelete.ColumnEdit = this.btnDelete;
            this.gdDelete.Name = "gdDelete";
            this.gdDelete.Visible = true;
            this.gdDelete.VisibleIndex = 11;
            this.gdDelete.Width = 85;
            // 
            // btnDelete
            // 
            this.btnDelete.AutoHeight = false;
            this.btnDelete.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("btnDelete.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject6, "", null, null, true)});
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // frmMainKitList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 441);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelControl4);
            this.Controls.Add(this.panelControl1);
            this.MinimizeBox = false;
            this.Name = "frmMainKitList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmMainKitList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.panelControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvKitList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShowAsset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.FormAssistant formAssistant1;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtSearch;
        private DevExpress.XtraEditors.LabelControl lblTypeName;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.LabelControl lblFormHeader;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gvKitList;
        private DevExpress.XtraGrid.Columns.GridColumn gcRowNo;
        private DevExpress.XtraGrid.Columns.GridColumn gcKitID;
        private DevExpress.XtraGrid.Columns.GridColumn gcKitName;
        private DevExpress.XtraGrid.Columns.GridColumn gcAbbrivation;
        private DevExpress.XtraGrid.Columns.GridColumn gcKitCode;
        private DevExpress.XtraGrid.Columns.GridColumn gcKitDescription;
        private DevExpress.XtraGrid.Columns.GridColumn gcAssignStatus;
        private DevExpress.XtraGrid.Columns.GridColumn gcCurrentStatus;
        private DevExpress.XtraGrid.Columns.GridColumn gcIsUsed;
        private DevExpress.XtraGrid.Columns.GridColumn gcShowAsset;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnShowAsset;
        private DevExpress.XtraGrid.Columns.GridColumn gcEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnEdit;
        private DevExpress.XtraGrid.Columns.GridColumn gdDelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnDelete;
    }
}