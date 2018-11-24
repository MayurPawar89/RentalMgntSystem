namespace LGRentalMgntSystem
{
    partial class frmDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboard));
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.companyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.partyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehicleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.associationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.companyWarehouseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.companyTransportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMainStrip = new System.Windows.Forms.ToolStrip();
            this.tsb_Asset = new System.Windows.Forms.ToolStripButton();
            this.assetTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assetToolStripMenuItemAsset = new System.Windows.Forms.ToolStripMenuItem();
            this.assetTypeToolStripMenuItemMainType = new System.Windows.Forms.ToolStripMenuItem();
            this.assetMaterialToolStripMenuItemMaterial = new System.Windows.Forms.ToolStripMenuItem();
            this.assetTypeToolStripMenuItemType = new System.Windows.Forms.ToolStripMenuItem();
            this.assetType1ToolStripMenuItemType1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMain.SuspendLayout();
            this.tsMainStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.goToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.reportToolStripMenuItem,
            this.settingToolStripMenuItem,
            this.toolToolStripMenuItem});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(1238, 24);
            this.mnuMain.TabIndex = 0;
            this.mnuMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.dashboardToolStripMenuItem.Text = "&Dashboard";
            this.dashboardToolStripMenuItem.Click += new System.EventHandler(this.dashboardToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masterToolStripMenuItem,
            this.associationToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // masterToolStripMenuItem
            // 
            this.masterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.assetToolStripMenuItem,
            this.kitToolStripMenuItem,
            this.companyToolStripMenuItem,
            this.partyToolStripMenuItem,
            this.siteToolStripMenuItem,
            this.userToolStripMenuItem,
            this.staffToolStripMenuItem,
            this.vehicleToolStripMenuItem,
            this.assetTypeToolStripMenuItem});
            this.masterToolStripMenuItem.Name = "masterToolStripMenuItem";
            this.masterToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.masterToolStripMenuItem.Text = "&Master";
            // 
            // assetToolStripMenuItem
            // 
            this.assetToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.assetToolStripMenuItemAsset,
            this.assetTypeToolStripMenuItemMainType,
            this.assetMaterialToolStripMenuItemMaterial,
            this.assetTypeToolStripMenuItemType,
            this.assetType1ToolStripMenuItemType1});
            this.assetToolStripMenuItem.Name = "assetToolStripMenuItem";
            this.assetToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.assetToolStripMenuItem.Text = "&Asset";
            this.assetToolStripMenuItem.Click += new System.EventHandler(this.assetToolStripMenuItem_Click);
            // 
            // kitToolStripMenuItem
            // 
            this.kitToolStripMenuItem.Name = "kitToolStripMenuItem";
            this.kitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.kitToolStripMenuItem.Text = "&Kit";
            this.kitToolStripMenuItem.Click += new System.EventHandler(this.kitToolStripMenuItem_Click);
            // 
            // companyToolStripMenuItem
            // 
            this.companyToolStripMenuItem.Name = "companyToolStripMenuItem";
            this.companyToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.companyToolStripMenuItem.Text = "&Company";
            this.companyToolStripMenuItem.Click += new System.EventHandler(this.companyToolStripMenuItem_Click);
            // 
            // partyToolStripMenuItem
            // 
            this.partyToolStripMenuItem.Name = "partyToolStripMenuItem";
            this.partyToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.partyToolStripMenuItem.Text = "&Party";
            this.partyToolStripMenuItem.Click += new System.EventHandler(this.partyToolStripMenuItem_Click);
            // 
            // siteToolStripMenuItem
            // 
            this.siteToolStripMenuItem.Name = "siteToolStripMenuItem";
            this.siteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.siteToolStripMenuItem.Text = "&Site";
            this.siteToolStripMenuItem.Click += new System.EventHandler(this.siteToolStripMenuItem_Click);
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.userToolStripMenuItem.Text = "&User";
            this.userToolStripMenuItem.Click += new System.EventHandler(this.userToolStripMenuItem_Click);
            // 
            // staffToolStripMenuItem
            // 
            this.staffToolStripMenuItem.Name = "staffToolStripMenuItem";
            this.staffToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.staffToolStripMenuItem.Text = "&Staff";
            this.staffToolStripMenuItem.Click += new System.EventHandler(this.staffToolStripMenuItem_Click);
            // 
            // vehicleToolStripMenuItem
            // 
            this.vehicleToolStripMenuItem.Name = "vehicleToolStripMenuItem";
            this.vehicleToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.vehicleToolStripMenuItem.Text = "&Vehicle";
            this.vehicleToolStripMenuItem.Click += new System.EventHandler(this.vehicleToolStripMenuItem_Click);
            // 
            // associationToolStripMenuItem
            // 
            this.associationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kitToolStripMenuItem1,
            this.companyWarehouseToolStripMenuItem,
            this.companyTransportToolStripMenuItem});
            this.associationToolStripMenuItem.Name = "associationToolStripMenuItem";
            this.associationToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.associationToolStripMenuItem.Text = "&Association";
            // 
            // kitToolStripMenuItem1
            // 
            this.kitToolStripMenuItem1.Name = "kitToolStripMenuItem1";
            this.kitToolStripMenuItem1.Size = new System.Drawing.Size(201, 22);
            this.kitToolStripMenuItem1.Text = "Kit && Asset";
            // 
            // companyWarehouseToolStripMenuItem
            // 
            this.companyWarehouseToolStripMenuItem.Name = "companyWarehouseToolStripMenuItem";
            this.companyWarehouseToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.companyWarehouseToolStripMenuItem.Text = "Company && Warehouse";
            // 
            // companyTransportToolStripMenuItem
            // 
            this.companyTransportToolStripMenuItem.Name = "companyTransportToolStripMenuItem";
            this.companyTransportToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.companyTransportToolStripMenuItem.Text = "Company && Transport";
            // 
            // goToolStripMenuItem
            // 
            this.goToolStripMenuItem.Name = "goToolStripMenuItem";
            this.goToolStripMenuItem.Size = new System.Drawing.Size(34, 20);
            this.goToolStripMenuItem.Text = "&Go";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "&View";
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.reportToolStripMenuItem.Text = "&Report";
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.settingToolStripMenuItem.Text = "&Setting";
            // 
            // toolToolStripMenuItem
            // 
            this.toolToolStripMenuItem.Name = "toolToolStripMenuItem";
            this.toolToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.toolToolStripMenuItem.Text = "&Tool";
            // 
            // tsMainStrip
            // 
            this.tsMainStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_Asset});
            this.tsMainStrip.Location = new System.Drawing.Point(0, 24);
            this.tsMainStrip.Name = "tsMainStrip";
            this.tsMainStrip.Size = new System.Drawing.Size(1238, 38);
            this.tsMainStrip.TabIndex = 1;
            this.tsMainStrip.Text = "toolStrip1";
            // 
            // tsb_Asset
            // 
            this.tsb_Asset.Image = ((System.Drawing.Image)(resources.GetObject("tsb_Asset.Image")));
            this.tsb_Asset.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Asset.Name = "tsb_Asset";
            this.tsb_Asset.Size = new System.Drawing.Size(39, 35);
            this.tsb_Asset.Text = "Asset";
            this.tsb_Asset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsb_Asset.Click += new System.EventHandler(this.tsb_Asset_Click);
            // 
            // assetTypeToolStripMenuItem
            // 
            this.assetTypeToolStripMenuItem.Name = "assetTypeToolStripMenuItem";
            this.assetTypeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.assetTypeToolStripMenuItem.Text = "Asset Type";
            // 
            // assetToolStripMenuItemAsset
            // 
            this.assetToolStripMenuItemAsset.Name = "assetToolStripMenuItemAsset";
            this.assetToolStripMenuItemAsset.Size = new System.Drawing.Size(160, 22);
            this.assetToolStripMenuItemAsset.Text = "&Asset";
            this.assetToolStripMenuItemAsset.Click += new System.EventHandler(this.assetToolStripMenuItemAsset_Click);
            // 
            // assetTypeToolStripMenuItemMainType
            // 
            this.assetTypeToolStripMenuItemMainType.Name = "assetTypeToolStripMenuItemMainType";
            this.assetTypeToolStripMenuItemMainType.Size = new System.Drawing.Size(160, 22);
            this.assetTypeToolStripMenuItemMainType.Text = "Asset Main Type";
            // 
            // assetMaterialToolStripMenuItemMaterial
            // 
            this.assetMaterialToolStripMenuItemMaterial.Name = "assetMaterialToolStripMenuItemMaterial";
            this.assetMaterialToolStripMenuItemMaterial.Size = new System.Drawing.Size(160, 22);
            this.assetMaterialToolStripMenuItemMaterial.Text = "Asset Material";
            // 
            // assetTypeToolStripMenuItemType
            // 
            this.assetTypeToolStripMenuItemType.Name = "assetTypeToolStripMenuItemType";
            this.assetTypeToolStripMenuItemType.Size = new System.Drawing.Size(160, 22);
            this.assetTypeToolStripMenuItemType.Text = "Asset Type";
            // 
            // assetType1ToolStripMenuItemType1
            // 
            this.assetType1ToolStripMenuItemType1.Name = "assetType1ToolStripMenuItemType1";
            this.assetType1ToolStripMenuItemType1.Size = new System.Drawing.Size(160, 22);
            this.assetType1ToolStripMenuItemType1.Text = "Asset Type 1";
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1238, 533);
            this.Controls.Add(this.tsMainStrip);
            this.Controls.Add(this.mnuMain);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.mnuMain;
            this.Name = "frmDashboard";
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.tsMainStrip.ResumeLayout(false);
            this.tsMainStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem staffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem partyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vehicleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem companyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem associationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem companyWarehouseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem companyTransportToolStripMenuItem;
        private System.Windows.Forms.ToolStrip tsMainStrip;
        private System.Windows.Forms.ToolStripButton tsb_Asset;
        private System.Windows.Forms.ToolStripMenuItem assetToolStripMenuItemAsset;
        private System.Windows.Forms.ToolStripMenuItem assetTypeToolStripMenuItemMainType;
        private System.Windows.Forms.ToolStripMenuItem assetMaterialToolStripMenuItemMaterial;
        private System.Windows.Forms.ToolStripMenuItem assetTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assetTypeToolStripMenuItemType;
        private System.Windows.Forms.ToolStripMenuItem assetType1ToolStripMenuItemType1;
    }
}