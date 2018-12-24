namespace LGRentalMgntSystem
{
    partial class frmMasterListLocation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMasterListLocation));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject9 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject10 = new DevExpress.Utils.SerializableAppearanceObject();
            this.formAssistant1 = new DevExpress.XtraBars.FormAssistant();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gvLocationList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcRowNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcnLocationID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcLocationCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcCountry = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcCity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcPincode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcIsUsed = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcEdit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gcDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtSearch = new DevExpress.XtraEditors.TextEdit();
            this.lblTypeName = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.lblFormHeader = new DevExpress.XtraEditors.LabelControl();
            this.gcAddressLine1 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLocationList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 97);
            this.gridControl1.MainView = this.gvLocationList;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnEdit,
            this.btnDelete});
            this.gridControl1.Size = new System.Drawing.Size(900, 376);
            this.gridControl1.TabIndex = 72;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvLocationList});
            // 
            // gvLocationList
            // 
            this.gvLocationList.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Transparent;
            this.gvLocationList.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvLocationList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcRowNo,
            this.gcnLocationID,
            this.gcLocationCode,
            this.gcDescription,
            this.gcAddressLine1,
            this.gcCountry,
            this.gcCity,
            this.gcPincode,
            this.gcIsUsed,
            this.gcEdit,
            this.gcDelete});
            this.gvLocationList.GridControl = this.gridControl1;
            this.gvLocationList.Name = "gvLocationList";
            this.gvLocationList.OptionsBehavior.Editable = false;
            this.gvLocationList.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm;
            this.gvLocationList.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click;
            this.gvLocationList.OptionsView.EnableAppearanceEvenRow = true;
            this.gvLocationList.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.Hidden;
            this.gvLocationList.OptionsView.ShowGroupPanel = false;
            this.gvLocationList.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gvLocationList_RowCellClick);
            this.gvLocationList.CustomRowCellEdit += new DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventHandler(this.gvLocationList_CustomRowCellEdit);
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
            // gcnLocationID
            // 
            this.gcnLocationID.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gcnLocationID.AppearanceHeader.Options.UseFont = true;
            this.gcnLocationID.Caption = "gcnLocationID";
            this.gcnLocationID.FieldName = "nLocationID";
            this.gcnLocationID.Name = "gcnLocationID";
            this.gcnLocationID.Visible = true;
            this.gcnLocationID.VisibleIndex = 1;
            // 
            // gcLocationCode
            // 
            this.gcLocationCode.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gcLocationCode.AppearanceHeader.Options.UseFont = true;
            this.gcLocationCode.Caption = "Location Code";
            this.gcLocationCode.FieldName = "sLocationCode";
            this.gcLocationCode.Name = "gcLocationCode";
            this.gcLocationCode.Visible = true;
            this.gcLocationCode.VisibleIndex = 2;
            // 
            // gcDescription
            // 
            this.gcDescription.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gcDescription.AppearanceHeader.Options.UseFont = true;
            this.gcDescription.Caption = "Description";
            this.gcDescription.FieldName = "sDescription";
            this.gcDescription.Name = "gcDescription";
            this.gcDescription.Visible = true;
            this.gcDescription.VisibleIndex = 4;
            // 
            // gcCountry
            // 
            this.gcCountry.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gcCountry.AppearanceHeader.Options.UseFont = true;
            this.gcCountry.Caption = "Country";
            this.gcCountry.FieldName = "sCountry";
            this.gcCountry.Name = "gcCountry";
            this.gcCountry.Visible = true;
            this.gcCountry.VisibleIndex = 8;
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
            // gcPincode
            // 
            this.gcPincode.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gcPincode.AppearanceHeader.Options.UseFont = true;
            this.gcPincode.Caption = "Pincode";
            this.gcPincode.FieldName = "sPincode";
            this.gcPincode.Name = "gcPincode";
            this.gcPincode.Visible = true;
            this.gcPincode.VisibleIndex = 5;
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
            this.gcEdit.VisibleIndex = 9;
            this.gcEdit.Width = 91;
            // 
            // btnEdit
            // 
            this.btnEdit.AutoHeight = false;
            this.btnEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("btnEdit.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject9, "", null, null, true)});
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
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("btnDelete.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject10, "", null, null, true)});
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
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
            this.panelControl4.Size = new System.Drawing.Size(900, 62);
            this.panelControl4.TabIndex = 71;
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
            this.labelControl2.Size = new System.Drawing.Size(288, 16);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Search By : Description, Country, State, City";
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
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.ContentImage = ((System.Drawing.Image)(resources.GetObject("panelControl1.ContentImage")));
            this.panelControl1.Controls.Add(this.pictureEdit1);
            this.panelControl1.Controls.Add(this.lblFormHeader);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(900, 35);
            this.panelControl1.TabIndex = 70;
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
            this.lblFormHeader.Size = new System.Drawing.Size(96, 18);
            this.lblFormHeader.TabIndex = 3;
            this.lblFormHeader.Text = "Location List";
            // 
            // gcAddressLine1
            // 
            this.gcAddressLine1.Caption = "Address";
            this.gcAddressLine1.FieldName = "sAddressLine1";
            this.gcAddressLine1.Name = "gcAddressLine1";
            this.gcAddressLine1.Visible = true;
            this.gcAddressLine1.VisibleIndex = 3;
            // 
            // frmMasterListLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 473);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelControl4);
            this.Controls.Add(this.panelControl1);
            this.MinimizeBox = false;
            this.Name = "frmMasterListLocation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmMasterListLocation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLocationList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.panelControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.FormAssistant formAssistant1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gvLocationList;
        private DevExpress.XtraGrid.Columns.GridColumn gcRowNo;
        private DevExpress.XtraGrid.Columns.GridColumn gcnLocationID;
        private DevExpress.XtraGrid.Columns.GridColumn gcLocationCode;
        private DevExpress.XtraGrid.Columns.GridColumn gcDescription;
        private DevExpress.XtraGrid.Columns.GridColumn gcCountry;
        private DevExpress.XtraGrid.Columns.GridColumn gcCity;
        private DevExpress.XtraGrid.Columns.GridColumn gcPincode;
        private DevExpress.XtraGrid.Columns.GridColumn gcIsUsed;
        private DevExpress.XtraGrid.Columns.GridColumn gcEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnEdit;
        private DevExpress.XtraGrid.Columns.GridColumn gcDelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnDelete;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtSearch;
        private DevExpress.XtraEditors.LabelControl lblTypeName;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.LabelControl lblFormHeader;
        private DevExpress.XtraGrid.Columns.GridColumn gcAddressLine1;
    }
}