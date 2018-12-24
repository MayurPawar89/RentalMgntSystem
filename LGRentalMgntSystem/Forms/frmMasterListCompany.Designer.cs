namespace LGRentalMgntSystem
{
    partial class frmMasterListCompany
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMasterListCompany));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.formAssistant1 = new DevExpress.XtraBars.FormAssistant();
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
            this.gvCompanyList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcRowNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcCompanyID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcCompanyCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcCompanyName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcCompanyType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcCompanySignatory = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcCompanyCountry = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcCompanyState = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcCompanyCity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcCompanyPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcCompanyHSNSACCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcWarehouseSupervisor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcCompanyGSTNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcCompanyTransporterID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcIsUsed = new DevExpress.XtraGrid.Columns.GridColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCompanyList)).BeginInit();
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
            this.panelControl1.Size = new System.Drawing.Size(1119, 35);
            this.panelControl1.TabIndex = 61;
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
            this.lblFormHeader.Size = new System.Drawing.Size(100, 18);
            this.lblFormHeader.TabIndex = 3;
            this.lblFormHeader.Text = "Company List";
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
            this.panelControl4.Size = new System.Drawing.Size(1119, 62);
            this.panelControl4.TabIndex = 62;
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
            this.labelControl2.Size = new System.Drawing.Size(766, 16);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Search By : Company Code, Company Name, Country, State, City, Warehouse Superviso" +
    "r, Company Type, Abbreviation";
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
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.gridControl1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 97);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1119, 492);
            this.panelControl2.TabIndex = 63;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 2);
            this.gridControl1.MainView = this.gvCompanyList;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnEdit,
            this.btnDelete});
            this.gridControl1.Size = new System.Drawing.Size(1115, 488);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCompanyList});
            // 
            // gvCompanyList
            // 
            this.gvCompanyList.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Transparent;
            this.gvCompanyList.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvCompanyList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcRowNo,
            this.gcCompanyID,
            this.gcCompanyCode,
            this.gcCompanyName,
            this.gcCompanyType,
            this.gcCompanySignatory,
            this.gcCompanyCountry,
            this.gcCompanyState,
            this.gcCompanyCity,
            this.gcCompanyPhone,
            this.gcCompanyHSNSACCode,
            this.gcWarehouseSupervisor,
            this.gcCompanyGSTNo,
            this.gcCompanyTransporterID,
            this.gcIsUsed,
            this.gcEdit,
            this.gdDelete});
            this.gvCompanyList.GridControl = this.gridControl1;
            this.gvCompanyList.Name = "gvCompanyList";
            this.gvCompanyList.OptionsBehavior.Editable = false;
            this.gvCompanyList.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm;
            this.gvCompanyList.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click;
            this.gvCompanyList.OptionsView.EnableAppearanceEvenRow = true;
            this.gvCompanyList.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.Hidden;
            this.gvCompanyList.OptionsView.ShowGroupPanel = false;
            this.gvCompanyList.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gvCompanyList_RowCellClick);
            this.gvCompanyList.CustomRowCellEdit += new DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventHandler(this.gvCompanyList_CustomRowCellEdit);
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
            // gcCompanyID
            // 
            this.gcCompanyID.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gcCompanyID.AppearanceHeader.Options.UseFont = true;
            this.gcCompanyID.Caption = "gridColumn12";
            this.gcCompanyID.FieldName = "nCompanyID";
            this.gcCompanyID.Name = "gcCompanyID";
            this.gcCompanyID.Visible = true;
            this.gcCompanyID.VisibleIndex = 1;
            // 
            // gcCompanyCode
            // 
            this.gcCompanyCode.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gcCompanyCode.AppearanceHeader.Options.UseFont = true;
            this.gcCompanyCode.Caption = "Comp. Code";
            this.gcCompanyCode.FieldName = "sCompanyCode";
            this.gcCompanyCode.Name = "gcCompanyCode";
            this.gcCompanyCode.Visible = true;
            this.gcCompanyCode.VisibleIndex = 2;
            // 
            // gcCompanyName
            // 
            this.gcCompanyName.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gcCompanyName.AppearanceHeader.Options.UseFont = true;
            this.gcCompanyName.Caption = "Comp. Name";
            this.gcCompanyName.FieldName = "sCompanyName";
            this.gcCompanyName.Name = "gcCompanyName";
            this.gcCompanyName.Visible = true;
            this.gcCompanyName.VisibleIndex = 3;
            // 
            // gcCompanyType
            // 
            this.gcCompanyType.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gcCompanyType.AppearanceHeader.Options.UseFont = true;
            this.gcCompanyType.Caption = "Comp. Type";
            this.gcCompanyType.FieldName = "sCompanyTypeName";
            this.gcCompanyType.Name = "gcCompanyType";
            this.gcCompanyType.Visible = true;
            this.gcCompanyType.VisibleIndex = 4;
            // 
            // gcCompanySignatory
            // 
            this.gcCompanySignatory.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gcCompanySignatory.AppearanceHeader.Options.UseFont = true;
            this.gcCompanySignatory.Caption = "Comp. Signatory";
            this.gcCompanySignatory.FieldName = "sStaffName";
            this.gcCompanySignatory.Name = "gcCompanySignatory";
            this.gcCompanySignatory.Visible = true;
            this.gcCompanySignatory.VisibleIndex = 5;
            // 
            // gcCompanyCountry
            // 
            this.gcCompanyCountry.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gcCompanyCountry.AppearanceHeader.Options.UseFont = true;
            this.gcCompanyCountry.Caption = "Comp. Country";
            this.gcCompanyCountry.FieldName = "sCountry";
            this.gcCompanyCountry.Name = "gcCompanyCountry";
            this.gcCompanyCountry.Visible = true;
            this.gcCompanyCountry.VisibleIndex = 6;
            // 
            // gcCompanyState
            // 
            this.gcCompanyState.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gcCompanyState.AppearanceHeader.Options.UseFont = true;
            this.gcCompanyState.Caption = "Comp. State";
            this.gcCompanyState.FieldName = "sState";
            this.gcCompanyState.Name = "gcCompanyState";
            this.gcCompanyState.Visible = true;
            this.gcCompanyState.VisibleIndex = 7;
            // 
            // gcCompanyCity
            // 
            this.gcCompanyCity.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gcCompanyCity.AppearanceHeader.Options.UseFont = true;
            this.gcCompanyCity.Caption = "Comp. City";
            this.gcCompanyCity.FieldName = "sCity";
            this.gcCompanyCity.Name = "gcCompanyCity";
            this.gcCompanyCity.Visible = true;
            this.gcCompanyCity.VisibleIndex = 8;
            // 
            // gcCompanyPhone
            // 
            this.gcCompanyPhone.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gcCompanyPhone.AppearanceHeader.Options.UseFont = true;
            this.gcCompanyPhone.Caption = "Comp. Phone";
            this.gcCompanyPhone.FieldName = "sPhoneNo";
            this.gcCompanyPhone.Name = "gcCompanyPhone";
            this.gcCompanyPhone.Visible = true;
            this.gcCompanyPhone.VisibleIndex = 9;
            // 
            // gcCompanyHSNSACCode
            // 
            this.gcCompanyHSNSACCode.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gcCompanyHSNSACCode.AppearanceHeader.Options.UseFont = true;
            this.gcCompanyHSNSACCode.Caption = "HSN/SAC Code";
            this.gcCompanyHSNSACCode.FieldName = "sHSN_SACCode";
            this.gcCompanyHSNSACCode.Name = "gcCompanyHSNSACCode";
            this.gcCompanyHSNSACCode.Visible = true;
            this.gcCompanyHSNSACCode.VisibleIndex = 10;
            // 
            // gcWarehouseSupervisor
            // 
            this.gcWarehouseSupervisor.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gcWarehouseSupervisor.AppearanceHeader.Options.UseFont = true;
            this.gcWarehouseSupervisor.Caption = "Warehouse Supervisor";
            this.gcWarehouseSupervisor.FieldName = "nSupervisorID";
            this.gcWarehouseSupervisor.Name = "gcWarehouseSupervisor";
            this.gcWarehouseSupervisor.Visible = true;
            this.gcWarehouseSupervisor.VisibleIndex = 11;
            // 
            // gcCompanyGSTNo
            // 
            this.gcCompanyGSTNo.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gcCompanyGSTNo.AppearanceHeader.Options.UseFont = true;
            this.gcCompanyGSTNo.Caption = "GST No";
            this.gcCompanyGSTNo.FieldName = "sGSTNO";
            this.gcCompanyGSTNo.Name = "gcCompanyGSTNo";
            this.gcCompanyGSTNo.Visible = true;
            this.gcCompanyGSTNo.VisibleIndex = 13;
            // 
            // gcCompanyTransporterID
            // 
            this.gcCompanyTransporterID.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gcCompanyTransporterID.AppearanceHeader.Options.UseFont = true;
            this.gcCompanyTransporterID.Caption = "Transporter ID";
            this.gcCompanyTransporterID.FieldName = "sTransportorID";
            this.gcCompanyTransporterID.Name = "gcCompanyTransporterID";
            this.gcCompanyTransporterID.Visible = true;
            this.gcCompanyTransporterID.VisibleIndex = 12;
            // 
            // gcIsUsed
            // 
            this.gcIsUsed.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gcIsUsed.AppearanceHeader.Options.UseFont = true;
            this.gcIsUsed.Caption = "Used";
            this.gcIsUsed.FieldName = "IsUsed";
            this.gcIsUsed.Name = "gcIsUsed";
            this.gcIsUsed.Visible = true;
            this.gcIsUsed.VisibleIndex = 14;
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
            this.gcEdit.VisibleIndex = 15;
            this.gcEdit.Width = 91;
            // 
            // btnEdit
            // 
            this.btnEdit.AutoHeight = false;
            this.btnEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("btnEdit.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject3, "", null, null, true)});
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
            this.gdDelete.VisibleIndex = 16;
            this.gdDelete.Width = 85;
            // 
            // btnDelete
            // 
            this.btnDelete.AutoHeight = false;
            this.btnDelete.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("btnDelete.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject4, "", null, null, true)});
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // frmMasterListCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 589);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl4);
            this.Controls.Add(this.panelControl1);
            this.MinimizeBox = false;
            this.Name = "frmMasterListCompany";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmMasterListCompany_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.gvCompanyList)).EndInit();
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
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCompanyList;
        private DevExpress.XtraGrid.Columns.GridColumn gcRowNo;
        private DevExpress.XtraGrid.Columns.GridColumn gcIsUsed;
        private DevExpress.XtraGrid.Columns.GridColumn gcEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnEdit;
        private DevExpress.XtraGrid.Columns.GridColumn gdDelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnDelete;
        private DevExpress.XtraGrid.Columns.GridColumn gcCompanyID;
        private DevExpress.XtraGrid.Columns.GridColumn gcCompanyCode;
        private DevExpress.XtraGrid.Columns.GridColumn gcCompanyName;
        private DevExpress.XtraGrid.Columns.GridColumn gcCompanyType;
        private DevExpress.XtraGrid.Columns.GridColumn gcCompanySignatory;
        private DevExpress.XtraGrid.Columns.GridColumn gcCompanyCountry;
        private DevExpress.XtraGrid.Columns.GridColumn gcCompanyState;
        private DevExpress.XtraGrid.Columns.GridColumn gcCompanyCity;
        private DevExpress.XtraGrid.Columns.GridColumn gcCompanyPhone;
        private DevExpress.XtraGrid.Columns.GridColumn gcCompanyHSNSACCode;
        private DevExpress.XtraGrid.Columns.GridColumn gcWarehouseSupervisor;
        private DevExpress.XtraGrid.Columns.GridColumn gcCompanyGSTNo;
        private DevExpress.XtraGrid.Columns.GridColumn gcCompanyTransporterID;
    }
}