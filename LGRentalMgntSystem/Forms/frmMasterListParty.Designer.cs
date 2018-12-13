namespace LGRentalMgntSystem
{
    partial class frmMasterListParty
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMasterListParty));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
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
            this.gvPartyList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcRowNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcPartyID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcPartyCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcPartyName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcsPartyType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcCity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcState = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcPhoneNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcIsUsed = new DevExpress.XtraGrid.Columns.GridColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.gvPartyList)).BeginInit();
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
            this.panelControl4.Size = new System.Drawing.Size(808, 62);
            this.panelControl4.TabIndex = 65;
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
            this.labelControl2.Size = new System.Drawing.Size(389, 16);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Search By : Party Code, Party Name, Party Type, State, City";
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
            this.panelControl1.Size = new System.Drawing.Size(808, 35);
            this.panelControl1.TabIndex = 64;
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
            this.lblFormHeader.Text = "Party List";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 97);
            this.gridControl1.MainView = this.gvPartyList;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnEdit,
            this.btnDelete});
            this.gridControl1.Size = new System.Drawing.Size(808, 322);
            this.gridControl1.TabIndex = 66;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPartyList});
            // 
            // gvPartyList
            // 
            this.gvPartyList.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Transparent;
            this.gvPartyList.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvPartyList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcRowNo,
            this.gcPartyID,
            this.gcPartyCode,
            this.gcPartyName,
            this.gcsPartyType,
            this.gcEmail,
            this.gcCity,
            this.gcState,
            this.gcPhoneNo,
            this.gcIsUsed,
            this.gcEdit,
            this.gdDelete});
            this.gvPartyList.GridControl = this.gridControl1;
            this.gvPartyList.Name = "gvPartyList";
            this.gvPartyList.OptionsBehavior.Editable = false;
            this.gvPartyList.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm;
            this.gvPartyList.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click;
            this.gvPartyList.OptionsView.EnableAppearanceEvenRow = true;
            this.gvPartyList.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.Hidden;
            this.gvPartyList.OptionsView.ShowGroupPanel = false;
            this.gvPartyList.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gvCompanyList_RowCellClick);
            this.gvPartyList.CustomRowCellEdit += new DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventHandler(this.gvCompanyList_CustomRowCellEdit);
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
            // gcPartyID
            // 
            this.gcPartyID.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gcPartyID.AppearanceHeader.Options.UseFont = true;
            this.gcPartyID.Caption = "gcPartyID";
            this.gcPartyID.FieldName = "nPartyID";
            this.gcPartyID.Name = "gcPartyID";
            this.gcPartyID.Visible = true;
            this.gcPartyID.VisibleIndex = 1;
            // 
            // gcPartyCode
            // 
            this.gcPartyCode.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gcPartyCode.AppearanceHeader.Options.UseFont = true;
            this.gcPartyCode.Caption = "Party Code";
            this.gcPartyCode.FieldName = "sPartyCode";
            this.gcPartyCode.Name = "gcPartyCode";
            this.gcPartyCode.Visible = true;
            this.gcPartyCode.VisibleIndex = 2;
            // 
            // gcPartyName
            // 
            this.gcPartyName.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gcPartyName.AppearanceHeader.Options.UseFont = true;
            this.gcPartyName.Caption = "Party Name";
            this.gcPartyName.FieldName = "sPartyName";
            this.gcPartyName.Name = "gcPartyName";
            this.gcPartyName.Visible = true;
            this.gcPartyName.VisibleIndex = 4;
            // 
            // gcsPartyType
            // 
            this.gcsPartyType.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gcsPartyType.AppearanceHeader.Options.UseFont = true;
            this.gcsPartyType.Caption = "Party Type";
            this.gcsPartyType.FieldName = "sPartyTypeName";
            this.gcsPartyType.Name = "gcsPartyType";
            this.gcsPartyType.Visible = true;
            this.gcsPartyType.VisibleIndex = 3;
            // 
            // gcEmail
            // 
            this.gcEmail.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gcEmail.AppearanceHeader.Options.UseFont = true;
            this.gcEmail.Caption = "Email";
            this.gcEmail.FieldName = "sEmail";
            this.gcEmail.Name = "gcEmail";
            this.gcEmail.Visible = true;
            this.gcEmail.VisibleIndex = 6;
            // 
            // gcCity
            // 
            this.gcCity.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gcCity.AppearanceHeader.Options.UseFont = true;
            this.gcCity.Caption = "City";
            this.gcCity.FieldName = "sCity";
            this.gcCity.Name = "gcCity";
            this.gcCity.Visible = true;
            this.gcCity.VisibleIndex = 7;
            // 
            // gcState
            // 
            this.gcState.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gcState.AppearanceHeader.Options.UseFont = true;
            this.gcState.Caption = "State";
            this.gcState.FieldName = "sState";
            this.gcState.Name = "gcState";
            this.gcState.Visible = true;
            this.gcState.VisibleIndex = 8;
            // 
            // gcPhoneNo
            // 
            this.gcPhoneNo.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gcPhoneNo.AppearanceHeader.Options.UseFont = true;
            this.gcPhoneNo.Caption = "Phone No";
            this.gcPhoneNo.FieldName = "sPhoneNo";
            this.gcPhoneNo.Name = "gcPhoneNo";
            this.gcPhoneNo.Visible = true;
            this.gcPhoneNo.VisibleIndex = 5;
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
            this.gdDelete.VisibleIndex = 11;
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
            // frmMasterListParty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 419);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelControl4);
            this.Controls.Add(this.panelControl1);
            this.MinimizeBox = false;
            this.Name = "frmMasterListParty";
            this.Load += new System.EventHandler(this.frmMasterListParty_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.panelControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPartyList)).EndInit();
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
        private DevExpress.XtraGrid.Views.Grid.GridView gvPartyList;
        private DevExpress.XtraGrid.Columns.GridColumn gcRowNo;
        private DevExpress.XtraGrid.Columns.GridColumn gcPartyID;
        private DevExpress.XtraGrid.Columns.GridColumn gcPartyCode;
        private DevExpress.XtraGrid.Columns.GridColumn gcsPartyType;
        private DevExpress.XtraGrid.Columns.GridColumn gcPartyName;
        private DevExpress.XtraGrid.Columns.GridColumn gcPhoneNo;
        private DevExpress.XtraGrid.Columns.GridColumn gcState;
        private DevExpress.XtraGrid.Columns.GridColumn gcIsUsed;
        private DevExpress.XtraGrid.Columns.GridColumn gcEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnEdit;
        private DevExpress.XtraGrid.Columns.GridColumn gdDelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnDelete;
        private DevExpress.XtraGrid.Columns.GridColumn gcEmail;
        private DevExpress.XtraGrid.Columns.GridColumn gcCity;
    }
}