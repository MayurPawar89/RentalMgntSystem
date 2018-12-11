namespace LGRentalMgntSystem
{
    partial class frmAsset
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAsset));
            this.tsMain = new System.Windows.Forms.ToolStrip();
            this.tsb_Save = new System.Windows.Forms.ToolStripButton();
            this.tsb_Close = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbAssetType1 = new System.Windows.Forms.ComboBox();
            this.cmbAssetType = new System.Windows.Forms.ComboBox();
            this.cmbAssetmaterialType = new System.Windows.Forms.ComboBox();
            this.cmbAssetTypeName = new System.Windows.Forms.ComboBox();
            this.dtpRetirementDate = new System.Windows.Forms.DateTimePicker();
            this.dtpIntroductionDate = new System.Windows.Forms.DateTimePicker();
            this.cmbAssetShelfLifeUnit = new System.Windows.Forms.ComboBox();
            this.cmbCompanyList = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtAssetRentalRate = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtAssetRate = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.txtAssetReorderTime = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.txtAssetVendor = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtAssetHSNOrSACCode = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtAssetShelfLife = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtAssetPackingDimention = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtAssetWeight = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtAssetMake = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtAssetQuality = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtAssetDensity = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAssetCapacity = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAssetSize = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAssetBarcode = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAssetShortDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAssetDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAssetName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAssetCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rentalSystemDataSet1 = new LGRentalMgntSystem.RentalSystemDataSet();
            this.tsMain.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rentalSystemDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // tsMain
            // 
            this.tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_Save,
            this.tsb_Close});
            this.tsMain.Location = new System.Drawing.Point(0, 0);
            this.tsMain.Name = "tsMain";
            this.tsMain.Size = new System.Drawing.Size(969, 25);
            this.tsMain.TabIndex = 0;
            this.tsMain.Text = "toolStrip1";
            // 
            // tsb_Save
            // 
            this.tsb_Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tsb_Save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Save.Name = "tsb_Save";
            this.tsb_Save.Size = new System.Drawing.Size(35, 22);
            this.tsb_Save.Text = "&Save";
            this.tsb_Save.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.tsb_Save.Click += new System.EventHandler(this.tsb_Save_Click);
            // 
            // tsb_Close
            // 
            this.tsb_Close.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsb_Close.Image = ((System.Drawing.Image)(resources.GetObject("tsb_Close.Image")));
            this.tsb_Close.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Close.Name = "tsb_Close";
            this.tsb_Close.Size = new System.Drawing.Size(40, 22);
            this.tsb_Close.Text = "&Close";
            this.tsb_Close.Click += new System.EventHandler(this.tsb_Close_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbAssetType1);
            this.panel1.Controls.Add(this.cmbAssetType);
            this.panel1.Controls.Add(this.cmbAssetmaterialType);
            this.panel1.Controls.Add(this.cmbAssetTypeName);
            this.panel1.Controls.Add(this.dtpRetirementDate);
            this.panel1.Controls.Add(this.dtpIntroductionDate);
            this.panel1.Controls.Add(this.cmbAssetShelfLifeUnit);
            this.panel1.Controls.Add(this.cmbCompanyList);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.txtAssetRentalRate);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.txtAssetRate);
            this.panel1.Controls.Add(this.label23);
            this.panel1.Controls.Add(this.label24);
            this.panel1.Controls.Add(this.label25);
            this.panel1.Controls.Add(this.txtAssetReorderTime);
            this.panel1.Controls.Add(this.label26);
            this.panel1.Controls.Add(this.txtAssetVendor);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txtAssetHSNOrSACCode);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.txtAssetShelfLife);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.txtAssetPackingDimention);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.txtAssetWeight);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.txtAssetMake);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.txtAssetQuality);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.txtAssetDensity);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtAssetCapacity);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtAssetSize);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtAssetBarcode);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtAssetShortDescription);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtAssetDescription);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtAssetName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtAssetCode);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(969, 455);
            this.panel1.TabIndex = 1;
            // 
            // cmbAssetType1
            // 
            this.cmbAssetType1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAssetType1.FormattingEnabled = true;
            this.cmbAssetType1.Location = new System.Drawing.Point(167, 266);
            this.cmbAssetType1.Name = "cmbAssetType1";
            this.cmbAssetType1.Size = new System.Drawing.Size(276, 22);
            this.cmbAssetType1.TabIndex = 59;
            // 
            // cmbAssetType
            // 
            this.cmbAssetType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAssetType.FormattingEnabled = true;
            this.cmbAssetType.Location = new System.Drawing.Point(627, 266);
            this.cmbAssetType.Name = "cmbAssetType";
            this.cmbAssetType.Size = new System.Drawing.Size(276, 22);
            this.cmbAssetType.TabIndex = 58;
            // 
            // cmbAssetmaterialType
            // 
            this.cmbAssetmaterialType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAssetmaterialType.FormattingEnabled = true;
            this.cmbAssetmaterialType.Location = new System.Drawing.Point(627, 236);
            this.cmbAssetmaterialType.Name = "cmbAssetmaterialType";
            this.cmbAssetmaterialType.Size = new System.Drawing.Size(276, 22);
            this.cmbAssetmaterialType.TabIndex = 57;
            // 
            // cmbAssetTypeName
            // 
            this.cmbAssetTypeName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAssetTypeName.FormattingEnabled = true;
            this.cmbAssetTypeName.Location = new System.Drawing.Point(627, 146);
            this.cmbAssetTypeName.Name = "cmbAssetTypeName";
            this.cmbAssetTypeName.Size = new System.Drawing.Size(276, 22);
            this.cmbAssetTypeName.TabIndex = 56;
            // 
            // dtpRetirementDate
            // 
            this.dtpRetirementDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRetirementDate.Location = new System.Drawing.Point(167, 414);
            this.dtpRetirementDate.Name = "dtpRetirementDate";
            this.dtpRetirementDate.Size = new System.Drawing.Size(276, 22);
            this.dtpRetirementDate.TabIndex = 55;
            // 
            // dtpIntroductionDate
            // 
            this.dtpIntroductionDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpIntroductionDate.Location = new System.Drawing.Point(167, 384);
            this.dtpIntroductionDate.Name = "dtpIntroductionDate";
            this.dtpIntroductionDate.Size = new System.Drawing.Size(276, 22);
            this.dtpIntroductionDate.TabIndex = 54;
            // 
            // cmbAssetShelfLifeUnit
            // 
            this.cmbAssetShelfLifeUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAssetShelfLifeUnit.FormattingEnabled = true;
            this.cmbAssetShelfLifeUnit.Location = new System.Drawing.Point(845, 325);
            this.cmbAssetShelfLifeUnit.Name = "cmbAssetShelfLifeUnit";
            this.cmbAssetShelfLifeUnit.Size = new System.Drawing.Size(97, 22);
            this.cmbAssetShelfLifeUnit.TabIndex = 53;
            // 
            // cmbCompanyList
            // 
            this.cmbCompanyList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCompanyList.FormattingEnabled = true;
            this.cmbCompanyList.Location = new System.Drawing.Point(167, 145);
            this.cmbCompanyList.Name = "cmbCompanyList";
            this.cmbCompanyList.Size = new System.Drawing.Size(276, 22);
            this.cmbCompanyList.TabIndex = 52;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(798, 329);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(41, 14);
            this.label21.TabIndex = 50;
            this.label21.Text = "Unit : ";
            // 
            // txtAssetRentalRate
            // 
            this.txtAssetRentalRate.Location = new System.Drawing.Point(627, 415);
            this.txtAssetRentalRate.Name = "txtAssetRentalRate";
            this.txtAssetRentalRate.Size = new System.Drawing.Size(276, 22);
            this.txtAssetRentalRate.TabIndex = 49;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(505, 419);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(116, 14);
            this.label22.TabIndex = 48;
            this.label22.Text = "Asset Rental Rate : ";
            // 
            // txtAssetRate
            // 
            this.txtAssetRate.Location = new System.Drawing.Point(627, 385);
            this.txtAssetRate.Name = "txtAssetRate";
            this.txtAssetRate.Size = new System.Drawing.Size(276, 22);
            this.txtAssetRate.TabIndex = 47;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(543, 389);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(78, 14);
            this.label23.TabIndex = 46;
            this.label23.Text = "Asset Rate : ";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(20, 418);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(144, 14);
            this.label24.TabIndex = 44;
            this.label24.Text = "Asset Retirement Date : ";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(13, 388);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(151, 14);
            this.label25.TabIndex = 42;
            this.label25.Text = "Asset Introduction Date : ";
            // 
            // txtAssetReorderTime
            // 
            this.txtAssetReorderTime.Location = new System.Drawing.Point(167, 356);
            this.txtAssetReorderTime.Name = "txtAssetReorderTime";
            this.txtAssetReorderTime.Size = new System.Drawing.Size(276, 22);
            this.txtAssetReorderTime.TabIndex = 41;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(37, 360);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(127, 14);
            this.label26.TabIndex = 40;
            this.label26.Text = "Asset Reorder Time : ";
            // 
            // txtAssetVendor
            // 
            this.txtAssetVendor.Location = new System.Drawing.Point(627, 355);
            this.txtAssetVendor.Name = "txtAssetVendor";
            this.txtAssetVendor.Size = new System.Drawing.Size(276, 22);
            this.txtAssetVendor.TabIndex = 39;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(528, 359);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 14);
            this.label11.TabIndex = 38;
            this.label11.Text = "Asset Vendor : ";
            // 
            // txtAssetHSNOrSACCode
            // 
            this.txtAssetHSNOrSACCode.Location = new System.Drawing.Point(167, 326);
            this.txtAssetHSNOrSACCode.Name = "txtAssetHSNOrSACCode";
            this.txtAssetHSNOrSACCode.Size = new System.Drawing.Size(276, 22);
            this.txtAssetHSNOrSACCode.TabIndex = 37;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(27, 330);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(135, 14);
            this.label12.TabIndex = 36;
            this.label12.Text = "Asset HSN/SAC Code : ";
            // 
            // txtAssetShelfLife
            // 
            this.txtAssetShelfLife.Location = new System.Drawing.Point(627, 325);
            this.txtAssetShelfLife.Name = "txtAssetShelfLife";
            this.txtAssetShelfLife.Size = new System.Drawing.Size(160, 22);
            this.txtAssetShelfLife.TabIndex = 35;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(518, 329);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(103, 14);
            this.label13.TabIndex = 34;
            this.label13.Text = "Asset Shelf Life : ";
            // 
            // txtAssetPackingDimention
            // 
            this.txtAssetPackingDimention.Location = new System.Drawing.Point(167, 296);
            this.txtAssetPackingDimention.Name = "txtAssetPackingDimention";
            this.txtAssetPackingDimention.Size = new System.Drawing.Size(276, 22);
            this.txtAssetPackingDimention.TabIndex = 33;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 300);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(153, 14);
            this.label14.TabIndex = 32;
            this.label14.Text = "Asset Packing Dimention : ";
            // 
            // txtAssetWeight
            // 
            this.txtAssetWeight.Location = new System.Drawing.Point(627, 295);
            this.txtAssetWeight.Name = "txtAssetWeight";
            this.txtAssetWeight.Size = new System.Drawing.Size(276, 22);
            this.txtAssetWeight.TabIndex = 31;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(528, 299);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(93, 14);
            this.label15.TabIndex = 30;
            this.label15.Text = "Asset Weight : ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(69, 270);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(92, 14);
            this.label16.TabIndex = 28;
            this.label16.Text = "Asset Type 1 : ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(540, 269);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(81, 14);
            this.label17.TabIndex = 26;
            this.label17.Text = "Asset Type : ";
            // 
            // txtAssetMake
            // 
            this.txtAssetMake.Location = new System.Drawing.Point(167, 236);
            this.txtAssetMake.Name = "txtAssetMake";
            this.txtAssetMake.Size = new System.Drawing.Size(276, 22);
            this.txtAssetMake.TabIndex = 25;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(80, 240);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(81, 14);
            this.label18.TabIndex = 24;
            this.label18.Text = "Asset Make : ";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(495, 239);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(126, 14);
            this.label19.TabIndex = 22;
            this.label19.Text = "Asset Material Type : ";
            // 
            // txtAssetQuality
            // 
            this.txtAssetQuality.Location = new System.Drawing.Point(167, 206);
            this.txtAssetQuality.Name = "txtAssetQuality";
            this.txtAssetQuality.Size = new System.Drawing.Size(276, 22);
            this.txtAssetQuality.TabIndex = 21;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(71, 210);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(90, 14);
            this.label20.TabIndex = 20;
            this.label20.Text = "Asset Quality : ";
            // 
            // txtAssetDensity
            // 
            this.txtAssetDensity.Location = new System.Drawing.Point(627, 205);
            this.txtAssetDensity.Name = "txtAssetDensity";
            this.txtAssetDensity.Size = new System.Drawing.Size(276, 22);
            this.txtAssetDensity.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(531, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 14);
            this.label6.TabIndex = 18;
            this.label6.Text = "Asset Density : ";
            // 
            // txtAssetCapacity
            // 
            this.txtAssetCapacity.Location = new System.Drawing.Point(167, 176);
            this.txtAssetCapacity.Name = "txtAssetCapacity";
            this.txtAssetCapacity.Size = new System.Drawing.Size(276, 22);
            this.txtAssetCapacity.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(66, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 14);
            this.label7.TabIndex = 16;
            this.label7.Text = "Asset Capacity : ";
            // 
            // txtAssetSize
            // 
            this.txtAssetSize.Location = new System.Drawing.Point(627, 175);
            this.txtAssetSize.Name = "txtAssetSize";
            this.txtAssetSize.Size = new System.Drawing.Size(276, 22);
            this.txtAssetSize.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(550, 179);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 14);
            this.label8.TabIndex = 14;
            this.label8.Text = "Asset Size : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(511, 149);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 14);
            this.label9.TabIndex = 12;
            this.label9.Text = "Asset Type Name : ";
            // 
            // txtAssetBarcode
            // 
            this.txtAssetBarcode.Location = new System.Drawing.Point(627, 15);
            this.txtAssetBarcode.Name = "txtAssetBarcode";
            this.txtAssetBarcode.Size = new System.Drawing.Size(276, 22);
            this.txtAssetBarcode.TabIndex = 11;
            this.txtAssetBarcode.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(527, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 14);
            this.label10.TabIndex = 10;
            this.label10.Text = "Asset Barcode : ";
            this.label10.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 14);
            this.label5.TabIndex = 8;
            this.label5.Text = "Asset Company : ";
            // 
            // txtAssetShortDescription
            // 
            this.txtAssetShortDescription.Location = new System.Drawing.Point(627, 79);
            this.txtAssetShortDescription.MaxLength = 255;
            this.txtAssetShortDescription.Multiline = true;
            this.txtAssetShortDescription.Name = "txtAssetShortDescription";
            this.txtAssetShortDescription.Size = new System.Drawing.Size(276, 58);
            this.txtAssetShortDescription.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(477, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 14);
            this.label4.TabIndex = 6;
            this.label4.Text = "Asset Short Description : ";
            // 
            // txtAssetDescription
            // 
            this.txtAssetDescription.Location = new System.Drawing.Point(167, 79);
            this.txtAssetDescription.MaxLength = 500;
            this.txtAssetDescription.Multiline = true;
            this.txtAssetDescription.Name = "txtAssetDescription";
            this.txtAssetDescription.Size = new System.Drawing.Size(276, 58);
            this.txtAssetDescription.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "Asset Description : ";
            // 
            // txtAssetName
            // 
            this.txtAssetName.Location = new System.Drawing.Point(167, 49);
            this.txtAssetName.Name = "txtAssetName";
            this.txtAssetName.Size = new System.Drawing.Size(276, 22);
            this.txtAssetName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Asset Name : ";
            // 
            // txtAssetCode
            // 
            this.txtAssetCode.Location = new System.Drawing.Point(167, 19);
            this.txtAssetCode.Name = "txtAssetCode";
            this.txtAssetCode.ReadOnly = true;
            this.txtAssetCode.Size = new System.Drawing.Size(245, 22);
            this.txtAssetCode.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Asset Code : ";
            // 
            // rentalSystemDataSet1
            // 
            this.rentalSystemDataSet1.DataSetName = "RentalSystemDataSet";
            this.rentalSystemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frmAsset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(969, 480);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tsMain);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAsset";
            this.ShowInTaskbar = false;
            this.Text = "frmAsset";
            this.Load += new System.EventHandler(this.frmAsset_Load);
            this.tsMain.ResumeLayout(false);
            this.tsMain.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rentalSystemDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsMain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtAssetRentalRate;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtAssetRate;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtAssetReorderTime;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtAssetVendor;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtAssetHSNOrSACCode;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtAssetShelfLife;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtAssetPackingDimention;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtAssetWeight;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtAssetMake;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtAssetQuality;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtAssetDensity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAssetCapacity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAssetSize;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAssetBarcode;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtAssetShortDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAssetDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAssetName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAssetCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbAssetShelfLifeUnit;
        private System.Windows.Forms.ComboBox cmbCompanyList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpRetirementDate;
        private System.Windows.Forms.DateTimePicker dtpIntroductionDate;
        private System.Windows.Forms.ToolStripButton tsb_Save;
        private System.Windows.Forms.ToolStripButton tsb_Close;
        private System.Windows.Forms.ComboBox cmbAssetType1;
        private System.Windows.Forms.ComboBox cmbAssetType;
        private System.Windows.Forms.ComboBox cmbAssetmaterialType;
        private System.Windows.Forms.ComboBox cmbAssetTypeName;
        private RentalSystemDataSet rentalSystemDataSet1;
    }
}