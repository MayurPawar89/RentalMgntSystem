namespace LGRentalMgntSystem
{
    partial class frmMainAssetList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainAssetList));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            this.formAssistant1 = new DevExpress.XtraBars.FormAssistant();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.lblFormHeader = new DevExpress.XtraEditors.LabelControl();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtSearch = new DevExpress.XtraEditors.TextEdit();
            this.lblTypeName = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gvAssetList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcRowNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcAssetID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcAssetName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcAbbrivation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcsAssetType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcCompanyName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcReorderDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcRate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcIsUsed = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcShowAsset = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnShowAsset = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gcEdit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gdDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAssetList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShowAsset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            this.SuspendLayout();
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
            this.panelControl1.Size = new System.Drawing.Size(1002, 35);
            this.panelControl1.TabIndex = 65;
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
            this.lblFormHeader.Size = new System.Drawing.Size(73, 18);
            this.lblFormHeader.TabIndex = 3;
            this.lblFormHeader.Text = "Asset List";
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
            this.panelControl4.Size = new System.Drawing.Size(1002, 62);
            this.panelControl4.TabIndex = 66;
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSearch.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnSearch.Location = new System.Drawing.Point(462, 28);
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
            this.labelControl2.Size = new System.Drawing.Size(239, 16);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Search By : Asset Name, Abbrivation";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(185, 31);
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
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 97);
            this.gridControl1.MainView = this.gvAssetList;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnEdit,
            this.btnDelete,
            this.btnShowAsset});
            this.gridControl1.Size = new System.Drawing.Size(1002, 375);
            this.gridControl1.TabIndex = 67;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvAssetList});
            // 
            // gvAssetList
            // 
            this.gvAssetList.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Transparent;
            this.gvAssetList.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvAssetList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcRowNo,
            this.gcAssetID,
            this.gcAssetName,
            this.gcAbbrivation,
            this.gcsAssetType,
            this.gcCompanyName,
            this.gcReorderDate,
            this.gcRate,
            this.gcIsUsed,
            this.gcShowAsset,
            this.gcEdit,
            this.gdDelete});
            this.gvAssetList.GridControl = this.gridControl1;
            this.gvAssetList.Name = "gvAssetList";
            this.gvAssetList.OptionsBehavior.Editable = false;
            this.gvAssetList.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm;
            this.gvAssetList.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click;
            this.gvAssetList.OptionsView.EnableAppearanceEvenRow = true;
            this.gvAssetList.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.Hidden;
            this.gvAssetList.OptionsView.ShowGroupPanel = false;
            this.gvAssetList.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gvAssetList_RowCellClick);
            this.gvAssetList.CustomRowCellEdit += new DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventHandler(this.gvAssetList_CustomRowCellEdit);
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
            this.gcAssetID.VisibleIndex = 1;
            // 
            // gcAssetName
            // 
            this.gcAssetName.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gcAssetName.AppearanceHeader.Options.UseFont = true;
            this.gcAssetName.Caption = "Asset Name";
            this.gcAssetName.FieldName = "sAssetName";
            this.gcAssetName.Name = "gcAssetName";
            this.gcAssetName.Visible = true;
            this.gcAssetName.VisibleIndex = 2;
            // 
            // gcAbbrivation
            // 
            this.gcAbbrivation.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gcAbbrivation.AppearanceHeader.Options.UseFont = true;
            this.gcAbbrivation.Caption = "Abbrivation";
            this.gcAbbrivation.FieldName = "sAssetAbbrivation";
            this.gcAbbrivation.Name = "gcAbbrivation";
            this.gcAbbrivation.Visible = true;
            this.gcAbbrivation.VisibleIndex = 4;
            // 
            // gcsAssetType
            // 
            this.gcsAssetType.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gcsAssetType.AppearanceHeader.Options.UseFont = true;
            this.gcsAssetType.Caption = "Asset Type";
            this.gcsAssetType.FieldName = "sAssetType";
            this.gcsAssetType.Name = "gcsAssetType";
            this.gcsAssetType.Visible = true;
            this.gcsAssetType.VisibleIndex = 3;
            // 
            // gcCompanyName
            // 
            this.gcCompanyName.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gcCompanyName.AppearanceHeader.Options.UseFont = true;
            this.gcCompanyName.Caption = "Company Name";
            this.gcCompanyName.FieldName = "sCompanyName";
            this.gcCompanyName.Name = "gcCompanyName";
            this.gcCompanyName.Visible = true;
            this.gcCompanyName.VisibleIndex = 5;
            // 
            // gcReorderDate
            // 
            this.gcReorderDate.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gcReorderDate.AppearanceHeader.Options.UseFont = true;
            this.gcReorderDate.Caption = "Re-Order Date";
            this.gcReorderDate.FieldName = "dtReorderDate";
            this.gcReorderDate.Name = "gcReorderDate";
            this.gcReorderDate.Visible = true;
            this.gcReorderDate.VisibleIndex = 6;
            // 
            // gcRate
            // 
            this.gcRate.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gcRate.AppearanceHeader.Options.UseFont = true;
            this.gcRate.Caption = "Rate";
            this.gcRate.FieldName = "sRate";
            this.gcRate.Name = "gcRate";
            this.gcRate.Visible = true;
            this.gcRate.VisibleIndex = 7;
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
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("btnShowAsset.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
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
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("btnEdit.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
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
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("btnDelete.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject3, "", null, null, true)});
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // frmMainAssetList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 472);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelControl4);
            this.Controls.Add(this.panelControl1);
            this.MinimizeBox = false;
            this.Name = "frmMainAssetList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmMainAssetList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.panelControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAssetList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShowAsset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.FormAssistant formAssistant1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.LabelControl lblFormHeader;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtSearch;
        private DevExpress.XtraEditors.LabelControl lblTypeName;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gvAssetList;
        private DevExpress.XtraGrid.Columns.GridColumn gcRowNo;
        private DevExpress.XtraGrid.Columns.GridColumn gcAssetID;
        private DevExpress.XtraGrid.Columns.GridColumn gcAssetName;
        private DevExpress.XtraGrid.Columns.GridColumn gcAbbrivation;
        private DevExpress.XtraGrid.Columns.GridColumn gcsAssetType;
        private DevExpress.XtraGrid.Columns.GridColumn gcCompanyName;
        private DevExpress.XtraGrid.Columns.GridColumn gcReorderDate;
        private DevExpress.XtraGrid.Columns.GridColumn gcRate;
        private DevExpress.XtraGrid.Columns.GridColumn gcShowAsset;
        private DevExpress.XtraGrid.Columns.GridColumn gcIsUsed;
        private DevExpress.XtraGrid.Columns.GridColumn gcEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnEdit;
        private DevExpress.XtraGrid.Columns.GridColumn gdDelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnDelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnShowAsset;
    }
}