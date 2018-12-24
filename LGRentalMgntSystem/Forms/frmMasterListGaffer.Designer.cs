namespace LGRentalMgntSystem
{
    partial class frmMasterListGaffer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMasterListGaffer));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
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
            this.gvGafferList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcRowNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcGafferID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcGafferCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcGafferName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcState = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcCity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcIsUsed = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcEdit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gcDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvGafferList)).BeginInit();
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
            this.panelControl1.Size = new System.Drawing.Size(739, 35);
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
            this.lblFormHeader.Size = new System.Drawing.Size(84, 18);
            this.lblFormHeader.TabIndex = 3;
            this.lblFormHeader.Text = "Gaffer  List";
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
            this.panelControl4.Size = new System.Drawing.Size(739, 62);
            this.panelControl4.TabIndex = 66;
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSearch.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnSearch.Location = new System.Drawing.Point(338, 29);
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
            this.labelControl2.Size = new System.Drawing.Size(245, 16);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Search By : Code, Name, Abbreviation";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(61, 32);
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
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 97);
            this.gridControl1.MainView = this.gvGafferList;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnEdit,
            this.btnDelete});
            this.gridControl1.Size = new System.Drawing.Size(739, 358);
            this.gridControl1.TabIndex = 69;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvGafferList});
            // 
            // gvGafferList
            // 
            this.gvGafferList.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Transparent;
            this.gvGafferList.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvGafferList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcRowNo,
            this.gcGafferID,
            this.gcGafferCode,
            this.gcGafferName,
            this.gcState,
            this.gcCity,
            this.gcPhone,
            this.gcEmail,
            this.gcIsUsed,
            this.gcEdit,
            this.gcDelete});
            this.gvGafferList.GridControl = this.gridControl1;
            this.gvGafferList.Name = "gvGafferList";
            this.gvGafferList.OptionsBehavior.Editable = false;
            this.gvGafferList.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm;
            this.gvGafferList.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click;
            this.gvGafferList.OptionsView.EnableAppearanceEvenRow = true;
            this.gvGafferList.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.Hidden;
            this.gvGafferList.OptionsView.ShowGroupPanel = false;
            this.gvGafferList.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gvGafferList_RowCellClick);
            this.gvGafferList.CustomRowCellEdit += new DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventHandler(this.gvGafferList_CustomRowCellEdit);
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
            // gcGafferID
            // 
            this.gcGafferID.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gcGafferID.AppearanceHeader.Options.UseFont = true;
            this.gcGafferID.Caption = "gcGafferID";
            this.gcGafferID.FieldName = "nGafferID";
            this.gcGafferID.Name = "gcGafferID";
            this.gcGafferID.Visible = true;
            this.gcGafferID.VisibleIndex = 1;
            // 
            // gcGafferCode
            // 
            this.gcGafferCode.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gcGafferCode.AppearanceHeader.Options.UseFont = true;
            this.gcGafferCode.Caption = "Gaffer Code";
            this.gcGafferCode.FieldName = "sGafferCode";
            this.gcGafferCode.Name = "gcGafferCode";
            this.gcGafferCode.Visible = true;
            this.gcGafferCode.VisibleIndex = 2;
            // 
            // gcGafferName
            // 
            this.gcGafferName.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gcGafferName.AppearanceHeader.Options.UseFont = true;
            this.gcGafferName.Caption = "Gaffer Name";
            this.gcGafferName.FieldName = "sGafferName";
            this.gcGafferName.Name = "gcGafferName";
            this.gcGafferName.Visible = true;
            this.gcGafferName.VisibleIndex = 3;
            // 
            // gcState
            // 
            this.gcState.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gcState.AppearanceHeader.Options.UseFont = true;
            this.gcState.Caption = "State";
            this.gcState.FieldName = "sState";
            this.gcState.Name = "gcState";
            this.gcState.Visible = true;
            this.gcState.VisibleIndex = 7;
            // 
            // gcCity
            // 
            this.gcCity.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gcCity.AppearanceHeader.Options.UseFont = true;
            this.gcCity.Caption = "City";
            this.gcCity.FieldName = "sCity";
            this.gcCity.Name = "gcCity";
            this.gcCity.Visible = true;
            this.gcCity.VisibleIndex = 6;
            // 
            // gcPhone
            // 
            this.gcPhone.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gcPhone.AppearanceHeader.Options.UseFont = true;
            this.gcPhone.Caption = "Phone No";
            this.gcPhone.FieldName = "sPhoneNo";
            this.gcPhone.Name = "gcPhone";
            this.gcPhone.Visible = true;
            this.gcPhone.VisibleIndex = 4;
            // 
            // gcEmail
            // 
            this.gcEmail.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gcEmail.AppearanceHeader.Options.UseFont = true;
            this.gcEmail.Caption = "Email";
            this.gcEmail.FieldName = "sEmail";
            this.gcEmail.Name = "gcEmail";
            this.gcEmail.Visible = true;
            this.gcEmail.VisibleIndex = 5;
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
            // gcEdit
            // 
            this.gcEdit.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gcEdit.AppearanceHeader.Options.UseFont = true;
            this.gcEdit.Caption = "Edit";
            this.gcEdit.ColumnEdit = this.btnEdit;
            this.gcEdit.Name = "gcEdit";
            this.gcEdit.Visible = true;
            this.gcEdit.VisibleIndex = 9;
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
            // gcDelete
            // 
            this.gcDelete.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gcDelete.AppearanceHeader.Options.UseFont = true;
            this.gcDelete.Caption = "Delete";
            this.gcDelete.ColumnEdit = this.btnDelete;
            this.gcDelete.Name = "gcDelete";
            this.gcDelete.Visible = true;
            this.gcDelete.VisibleIndex = 10;
            this.gcDelete.Width = 85;
            // 
            // btnDelete
            // 
            this.btnDelete.AutoHeight = false;
            this.btnDelete.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("btnDelete.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // gridColumn9
            // 
            this.gridColumn9.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridColumn9.AppearanceHeader.Options.UseFont = true;
            this.gridColumn9.Caption = "Sr. No.";
            this.gridColumn9.FieldName = "RowNo";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 0;
            // 
            // frmMasterListGaffer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 455);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelControl4);
            this.Controls.Add(this.panelControl1);
            this.MinimizeBox = false;
            this.Name = "frmMasterListGaffer";
            this.Load += new System.EventHandler(this.frmMasterListGaffer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.panelControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvGafferList)).EndInit();
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
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnDelete;
        private DevExpress.XtraGrid.Views.Grid.GridView gvGafferList;
        private DevExpress.XtraGrid.Columns.GridColumn gcRowNo;
        private DevExpress.XtraGrid.Columns.GridColumn gcGafferID;
        private DevExpress.XtraGrid.Columns.GridColumn gcGafferCode;
        private DevExpress.XtraGrid.Columns.GridColumn gcGafferName;
        private DevExpress.XtraGrid.Columns.GridColumn gcState;
        private DevExpress.XtraGrid.Columns.GridColumn gcCity;
        private DevExpress.XtraGrid.Columns.GridColumn gcPhone;
        private DevExpress.XtraGrid.Columns.GridColumn gcEmail;
        private DevExpress.XtraGrid.Columns.GridColumn gcIsUsed;
        private DevExpress.XtraGrid.Columns.GridColumn gcEdit;
        private DevExpress.XtraGrid.Columns.GridColumn gcDelete;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
    }
}