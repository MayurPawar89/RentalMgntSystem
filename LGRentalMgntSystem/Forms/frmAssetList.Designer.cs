namespace LGRentalMgntSystem.Forms
{
    partial class frmAssetList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAssetList));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.lblFormHeader = new DevExpress.XtraEditors.LabelControl();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtSearch = new DevExpress.XtraEditors.TextEdit();
            this.lblTypeName = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gvMasterList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcRowNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcTypeID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcAssetMainTypeID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcTypeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcAssetMainType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcAllowAccess = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcAllowSignatory = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcCreatedOn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcModifiedOn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcIsUsed = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcEdit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gdDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gcSystemDefined = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMasterList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            this.SuspendLayout();
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
            this.panelControl1.Size = new System.Drawing.Size(942, 40);
            this.panelControl1.TabIndex = 9;
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
            this.pictureEdit1.TabIndex = 4;
            // 
            // lblFormHeader
            // 
            this.lblFormHeader.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormHeader.Location = new System.Drawing.Point(59, 12);
            this.lblFormHeader.Name = "lblFormHeader";
            this.lblFormHeader.Size = new System.Drawing.Size(28, 18);
            this.lblFormHeader.TabIndex = 3;
            this.lblFormHeader.Text = "List";
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.btnSearch);
            this.panelControl4.Controls.Add(this.labelControl2);
            this.panelControl4.Controls.Add(this.txtSearch);
            this.panelControl4.Controls.Add(this.lblTypeName);
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl4.Location = new System.Drawing.Point(0, 40);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(942, 62);
            this.panelControl4.TabIndex = 12;
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
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Teal;
            this.labelControl2.Location = new System.Drawing.Point(14, 6);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(148, 16);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Search By : Type Name";
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
            this.lblTypeName.Size = new System.Drawing.Size(69, 13);
            this.lblTypeName.TabIndex = 0;
            this.lblTypeName.Text = "Enter  Name : ";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.gridControl1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 102);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(942, 430);
            this.panelControl2.TabIndex = 13;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 2);
            this.gridControl1.MainView = this.gvMasterList;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnEdit,
            this.btnDelete});
            this.gridControl1.Size = new System.Drawing.Size(938, 426);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvMasterList});
            // 
            // gvMasterList
            // 
            this.gvMasterList.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Transparent;
            this.gvMasterList.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvMasterList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcRowNo,
            this.gcTypeID,
            this.gcAssetMainTypeID,
            this.gcTypeName,
            this.gcAssetMainType,
            this.gcAllowAccess,
            this.gcAllowSignatory,
            this.gcSystemDefined,
            this.gcCreatedOn,
            this.gcModifiedOn,
            this.gcIsUsed,
            this.gcEdit,
            this.gdDelete});
            this.gvMasterList.GridControl = this.gridControl1;
            this.gvMasterList.Name = "gvMasterList";
            this.gvMasterList.OptionsBehavior.Editable = false;
            this.gvMasterList.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm;
            this.gvMasterList.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click;
            this.gvMasterList.OptionsView.EnableAppearanceEvenRow = true;
            this.gvMasterList.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.Hidden;
            this.gvMasterList.OptionsView.ShowGroupPanel = false;
            this.gvMasterList.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gvMasterList_RowCellClick);
            this.gvMasterList.CustomRowCellEdit += new DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventHandler(this.gvMasterList_CustomRowCellEdit);
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
            // gcTypeID
            // 
            this.gcTypeID.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gcTypeID.AppearanceHeader.Options.UseFont = true;
            this.gcTypeID.Caption = "Type ID";
            this.gcTypeID.FieldName = "TypeID";
            this.gcTypeID.Name = "gcTypeID";
            this.gcTypeID.Visible = true;
            this.gcTypeID.VisibleIndex = 2;
            this.gcTypeID.Width = 92;
            // 
            // gcAssetMainTypeID
            // 
            this.gcAssetMainTypeID.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gcAssetMainTypeID.AppearanceHeader.Options.UseFont = true;
            this.gcAssetMainTypeID.Caption = "Asset Main Type ID";
            this.gcAssetMainTypeID.FieldName = "nAssetMainTypeID";
            this.gcAssetMainTypeID.Name = "gcAssetMainTypeID";
            this.gcAssetMainTypeID.Visible = true;
            this.gcAssetMainTypeID.VisibleIndex = 1;
            this.gcAssetMainTypeID.Width = 92;
            // 
            // gcTypeName
            // 
            this.gcTypeName.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gcTypeName.AppearanceHeader.Options.UseFont = true;
            this.gcTypeName.Caption = "Type Name";
            this.gcTypeName.FieldName = "TypeName";
            this.gcTypeName.Name = "gcTypeName";
            this.gcTypeName.Visible = true;
            this.gcTypeName.VisibleIndex = 3;
            this.gcTypeName.Width = 125;
            // 
            // gcAssetMainType
            // 
            this.gcAssetMainType.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gcAssetMainType.AppearanceHeader.Options.UseFont = true;
            this.gcAssetMainType.Caption = "Asset Main Type";
            this.gcAssetMainType.FieldName = "AssetType";
            this.gcAssetMainType.Name = "gcAssetMainType";
            this.gcAssetMainType.Visible = true;
            this.gcAssetMainType.VisibleIndex = 4;
            this.gcAssetMainType.Width = 108;
            // 
            // gcAllowAccess
            // 
            this.gcAllowAccess.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gcAllowAccess.AppearanceHeader.Options.UseFont = true;
            this.gcAllowAccess.Caption = "Login Access";
            this.gcAllowAccess.FieldName = "AllowAccess";
            this.gcAllowAccess.Name = "gcAllowAccess";
            this.gcAllowAccess.Visible = true;
            this.gcAllowAccess.VisibleIndex = 5;
            // 
            // gcAllowSignatory
            // 
            this.gcAllowSignatory.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gcAllowSignatory.AppearanceHeader.Options.UseFont = true;
            this.gcAllowSignatory.Caption = "Signatory";
            this.gcAllowSignatory.FieldName = "AllowSignatory";
            this.gcAllowSignatory.Name = "gcAllowSignatory";
            this.gcAllowSignatory.Visible = true;
            this.gcAllowSignatory.VisibleIndex = 6;
            // 
            // gcCreatedOn
            // 
            this.gcCreatedOn.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gcCreatedOn.AppearanceHeader.Options.UseFont = true;
            this.gcCreatedOn.Caption = "Created On";
            this.gcCreatedOn.FieldName = "CreatedOn";
            this.gcCreatedOn.Name = "gcCreatedOn";
            this.gcCreatedOn.Visible = true;
            this.gcCreatedOn.VisibleIndex = 7;
            this.gcCreatedOn.Width = 81;
            // 
            // gcModifiedOn
            // 
            this.gcModifiedOn.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gcModifiedOn.AppearanceHeader.Options.UseFont = true;
            this.gcModifiedOn.Caption = "Modified On";
            this.gcModifiedOn.FieldName = "ModifiedOn";
            this.gcModifiedOn.Name = "gcModifiedOn";
            this.gcModifiedOn.Visible = true;
            this.gcModifiedOn.VisibleIndex = 8;
            this.gcModifiedOn.Width = 81;
            // 
            // gcIsUsed
            // 
            this.gcIsUsed.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gcIsUsed.AppearanceHeader.Options.UseFont = true;
            this.gcIsUsed.Caption = "Used";
            this.gcIsUsed.FieldName = "IsUsed";
            this.gcIsUsed.Name = "gcIsUsed";
            this.gcIsUsed.Visible = true;
            this.gcIsUsed.VisibleIndex = 9;
            this.gcIsUsed.Width = 73;
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
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("btnEdit.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
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
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("btnDelete.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // gcSystemDefined
            // 
            this.gcSystemDefined.Caption = "System Defined";
            this.gcSystemDefined.FieldName = "SystemDefined";
            this.gcSystemDefined.Name = "gcSystemDefined";
            // 
            // frmAssetList
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 532);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl4);
            this.Controls.Add(this.panelControl1);
            this.Font = new System.Drawing.Font("Tahoma", 9F);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAssetList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asset List";
            this.Load += new System.EventHandler(this.frmAssetList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.panelControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMasterList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl lblFormHeader;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtSearch;
        private DevExpress.XtraEditors.LabelControl lblTypeName;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gvMasterList;
        private DevExpress.XtraGrid.Columns.GridColumn gcRowNo;
        private DevExpress.XtraGrid.Columns.GridColumn gcTypeID;
        private DevExpress.XtraGrid.Columns.GridColumn gcTypeName;
        private DevExpress.XtraGrid.Columns.GridColumn gcCreatedOn;
        private DevExpress.XtraGrid.Columns.GridColumn gcModifiedOn;
        private DevExpress.XtraGrid.Columns.GridColumn gcEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnEdit;
        private DevExpress.XtraGrid.Columns.GridColumn gdDelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnDelete;
        private DevExpress.XtraGrid.Columns.GridColumn gcAssetMainType;
        private DevExpress.XtraGrid.Columns.GridColumn gcIsUsed;
        private DevExpress.XtraGrid.Columns.GridColumn gcAssetMainTypeID;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn gcAllowAccess;
        private DevExpress.XtraGrid.Columns.GridColumn gcAllowSignatory;
        private DevExpress.XtraGrid.Columns.GridColumn gcSystemDefined;

    }
}