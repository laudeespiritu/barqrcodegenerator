namespace BarQRCodeGenerator
{
    partial class Generator
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Generator));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBGColor = new System.Windows.Forms.Button();
            this.btnFGColor = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.tabMenu = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ddlLabelPosition = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtBarcodeLabel = new System.Windows.Forms.TextBox();
            this.chkAddLabel = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtAspectRatio = new System.Windows.Forms.TextBox();
            this.txtBarWidth = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ddlAlignment = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ddlRotate = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ddlEncoding = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtIconPath = new System.Windows.Forms.TextBox();
            this.btnUploadIcon = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.numIconSize = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.ddlECCLevel = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbPreview = new System.Windows.Forms.GroupBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslGenerateType = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslEncoding = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslECCLevel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslBarcodeCredits = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslQRCodeCredits = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslAppCredits = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1.SuspendLayout();
            this.tabMenu.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numIconSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnBGColor);
            this.panel1.Controls.Add(this.btnFGColor);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnGenerate);
            this.panel1.Controls.Add(this.tabMenu);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtData);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(299, 583);
            this.panel1.TabIndex = 0;
            // 
            // btnBGColor
            // 
            this.btnBGColor.BackColor = System.Drawing.Color.White;
            this.btnBGColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBGColor.Location = new System.Drawing.Point(171, 85);
            this.btnBGColor.Name = "btnBGColor";
            this.btnBGColor.Size = new System.Drawing.Size(111, 23);
            this.btnBGColor.TabIndex = 2;
            this.btnBGColor.UseVisualStyleBackColor = false;
            this.btnBGColor.Click += new System.EventHandler(this.btnBGColor_Click);
            // 
            // btnFGColor
            // 
            this.btnFGColor.BackColor = System.Drawing.Color.Black;
            this.btnFGColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFGColor.Location = new System.Drawing.Point(14, 85);
            this.btnFGColor.Name = "btnFGColor";
            this.btnFGColor.Size = new System.Drawing.Size(111, 23);
            this.btnFGColor.TabIndex = 1;
            this.btnFGColor.UseVisualStyleBackColor = false;
            this.btnFGColor.Click += new System.EventHandler(this.btnFGColor_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(145, 508);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(132, 43);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(13, 508);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(125, 43);
            this.btnGenerate.TabIndex = 14;
            this.btnGenerate.Text = "G&enerate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // tabMenu
            // 
            this.tabMenu.Controls.Add(this.tabPage1);
            this.tabMenu.Controls.Add(this.tabPage2);
            this.tabMenu.Location = new System.Drawing.Point(12, 120);
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.SelectedIndex = 0;
            this.tabMenu.Size = new System.Drawing.Size(270, 367);
            this.tabMenu.TabIndex = 3;
            this.tabMenu.SelectedIndexChanged += new System.EventHandler(this.tabMenu_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ddlLabelPosition);
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Controls.Add(this.txtBarcodeLabel);
            this.tabPage1.Controls.Add(this.chkAddLabel);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.ddlAlignment);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.ddlRotate);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.ddlEncoding);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(262, 341);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Barcode";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ddlLabelPosition
            // 
            this.ddlLabelPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlLabelPosition.FormattingEnabled = true;
            this.ddlLabelPosition.Items.AddRange(new object[] {
            "BottomCenter",
            "BottomLeft",
            "BottomRight",
            "TopCenter",
            "TopLeft",
            "TopRight"});
            this.ddlLabelPosition.Location = new System.Drawing.Point(94, 256);
            this.ddlLabelPosition.Name = "ddlLabelPosition";
            this.ddlLabelPosition.Size = new System.Drawing.Size(150, 21);
            this.ddlLabelPosition.TabIndex = 13;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(15, 259);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(73, 13);
            this.label18.TabIndex = 14;
            this.label18.Text = "Label Position";
            // 
            // txtBarcodeLabel
            // 
            this.txtBarcodeLabel.Location = new System.Drawing.Point(94, 230);
            this.txtBarcodeLabel.Name = "txtBarcodeLabel";
            this.txtBarcodeLabel.Size = new System.Drawing.Size(150, 20);
            this.txtBarcodeLabel.TabIndex = 12;
            // 
            // chkAddLabel
            // 
            this.chkAddLabel.AutoSize = true;
            this.chkAddLabel.Location = new System.Drawing.Point(14, 232);
            this.chkAddLabel.Name = "chkAddLabel";
            this.chkAddLabel.Size = new System.Drawing.Size(74, 17);
            this.chkAddLabel.TabIndex = 11;
            this.chkAddLabel.Text = "Add Label";
            this.chkAddLabel.UseVisualStyleBackColor = true;
            this.chkAddLabel.CheckedChanged += new System.EventHandler(this.chkAddLabel_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtAspectRatio);
            this.groupBox2.Controls.Add(this.txtBarWidth);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtHeight);
            this.groupBox2.Controls.Add(this.txtWidth);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(14, 101);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(230, 123);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dimensions";
            // 
            // txtAspectRatio
            // 
            this.txtAspectRatio.Location = new System.Drawing.Point(110, 91);
            this.txtAspectRatio.Name = "txtAspectRatio";
            this.txtAspectRatio.Size = new System.Drawing.Size(57, 20);
            this.txtAspectRatio.TabIndex = 10;
            // 
            // txtBarWidth
            // 
            this.txtBarWidth.Location = new System.Drawing.Point(21, 91);
            this.txtBarWidth.Name = "txtBarWidth";
            this.txtBarWidth.Size = new System.Drawing.Size(57, 20);
            this.txtBarWidth.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(107, 75);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Aspect Ratio";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 75);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "Bar Width";
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(110, 41);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(57, 20);
            this.txtHeight.TabIndex = 8;
            this.txtHeight.Text = "300";
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(21, 41);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(57, 20);
            this.txtWidth.TabIndex = 7;
            this.txtWidth.Text = "600";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(107, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Height";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Width";
            // 
            // ddlAlignment
            // 
            this.ddlAlignment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlAlignment.FormattingEnabled = true;
            this.ddlAlignment.Items.AddRange(new object[] {
            "Center",
            "Left",
            "Right"});
            this.ddlAlignment.Location = new System.Drawing.Point(156, 73);
            this.ddlAlignment.Name = "ddlAlignment";
            this.ddlAlignment.Size = new System.Drawing.Size(88, 21);
            this.ddlAlignment.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(153, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Alignment";
            // 
            // ddlRotate
            // 
            this.ddlRotate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlRotate.FormattingEnabled = true;
            this.ddlRotate.Items.AddRange(new object[] {
            "Center",
            "Left",
            "Right"});
            this.ddlRotate.Location = new System.Drawing.Point(14, 73);
            this.ddlRotate.Name = "ddlRotate";
            this.ddlRotate.Size = new System.Drawing.Size(136, 21);
            this.ddlRotate.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Rotate";
            // 
            // ddlEncoding
            // 
            this.ddlEncoding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlEncoding.FormattingEnabled = true;
            this.ddlEncoding.Items.AddRange(new object[] {
            "UPC-A",
            "UPC-E",
            "UPC 2 Digit Ext.",
            "UPC 5 Digit Ext.",
            "EAN-13",
            "JAN-13",
            "EAN-8",
            "ITF-14",
            "Interleaved 2 of 5",
            "Interleaved 2 of 5 Mod 10",
            "Standard 2 of 5",
            "Standard 2 of 5 Mod 10",
            "Codabar",
            "PostNet",
            "Bookland/ISBN",
            "Code 11",
            "Code 39",
            "Code 39 Extended",
            "Code 39 Mod 43",
            "Code 93",
            "Code 128",
            "Code 128-A",
            "Code 128-B",
            "Code 128-C",
            "LOGMARS",
            "MSI",
            "Telepen",
            "FIM",
            "Pharmacode"});
            this.ddlEncoding.Location = new System.Drawing.Point(14, 33);
            this.ddlEncoding.Name = "ddlEncoding";
            this.ddlEncoding.Size = new System.Drawing.Size(230, 21);
            this.ddlEncoding.TabIndex = 4;
            this.ddlEncoding.SelectedIndexChanged += new System.EventHandler(this.ddlEncoding_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Encoding";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtIconPath);
            this.tabPage2.Controls.Add(this.btnUploadIcon);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.numIconSize);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.ddlECCLevel);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(262, 341);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "QR Code";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtIconPath
            // 
            this.txtIconPath.Location = new System.Drawing.Point(14, 73);
            this.txtIconPath.Name = "txtIconPath";
            this.txtIconPath.ReadOnly = true;
            this.txtIconPath.Size = new System.Drawing.Size(154, 20);
            this.txtIconPath.TabIndex = 5;
            // 
            // btnUploadIcon
            // 
            this.btnUploadIcon.Location = new System.Drawing.Point(174, 71);
            this.btnUploadIcon.Name = "btnUploadIcon";
            this.btnUploadIcon.Size = new System.Drawing.Size(70, 23);
            this.btnUploadIcon.TabIndex = 6;
            this.btnUploadIcon.Text = "Sele&ct";
            this.btnUploadIcon.UseVisualStyleBackColor = true;
            this.btnUploadIcon.Click += new System.EventHandler(this.btnUploadIcon_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(11, 57);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(28, 13);
            this.label17.TabIndex = 8;
            this.label17.Text = "Icon";
            // 
            // numIconSize
            // 
            this.numIconSize.Location = new System.Drawing.Point(14, 112);
            this.numIconSize.Name = "numIconSize";
            this.numIconSize.Size = new System.Drawing.Size(82, 20);
            this.numIconSize.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Icon Size";
            // 
            // ddlECCLevel
            // 
            this.ddlECCLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlECCLevel.FormattingEnabled = true;
            this.ddlECCLevel.Items.AddRange(new object[] {
            "L",
            "M",
            "Q",
            "H"});
            this.ddlECCLevel.Location = new System.Drawing.Point(14, 33);
            this.ddlECCLevel.Name = "ddlECCLevel";
            this.ddlECCLevel.Size = new System.Drawing.Size(230, 21);
            this.ddlECCLevel.TabIndex = 4;
            this.ddlECCLevel.SelectedIndexChanged += new System.EventHandler(this.ddlECCLevel_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "ECC-Level";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(168, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "BG Color";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "FG Color";
            // 
            // txtData
            // 
            this.txtData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData.Location = new System.Drawing.Point(9, 39);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(273, 22);
            this.txtData.TabIndex = 0;
            this.txtData.Text = "036000291452";
            this.txtData.TextChanged += new System.EventHandler(this.txtData_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Value";
            // 
            // gbPreview
            // 
            this.gbPreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.gbPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbPreview.Location = new System.Drawing.Point(0, 0);
            this.gbPreview.Name = "gbPreview";
            this.gbPreview.Size = new System.Drawing.Size(704, 601);
            this.gbPreview.TabIndex = 1;
            this.gbPreview.TabStop = false;
            this.gbPreview.Text = "Generated Preview";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gbPreview);
            this.splitContainer1.Size = new System.Drawing.Size(1015, 601);
            this.splitContainer1.SplitterDistance = 307;
            this.splitContainer1.TabIndex = 2;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslGenerateType,
            this.tsslEncoding,
            this.tsslECCLevel,
            this.tsslBarcodeCredits,
            this.tsslQRCodeCredits,
            this.tsslAppCredits});
            this.statusStrip1.Location = new System.Drawing.Point(0, 577);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1015, 24);
            this.statusStrip1.TabIndex = 3;
            // 
            // tsslGenerateType
            // 
            this.tsslGenerateType.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tsslGenerateType.Name = "tsslGenerateType";
            this.tsslGenerateType.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.tsslGenerateType.Size = new System.Drawing.Size(24, 19);
            // 
            // tsslEncoding
            // 
            this.tsslEncoding.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tsslEncoding.Name = "tsslEncoding";
            this.tsslEncoding.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.tsslEncoding.Size = new System.Drawing.Size(24, 19);
            this.tsslEncoding.Visible = false;
            // 
            // tsslECCLevel
            // 
            this.tsslECCLevel.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tsslECCLevel.Name = "tsslECCLevel";
            this.tsslECCLevel.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.tsslECCLevel.Size = new System.Drawing.Size(24, 19);
            this.tsslECCLevel.Visible = false;
            // 
            // tsslBarcodeCredits
            // 
            this.tsslBarcodeCredits.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tsslBarcodeCredits.Name = "tsslBarcodeCredits";
            this.tsslBarcodeCredits.Size = new System.Drawing.Size(325, 19);
            this.tsslBarcodeCredits.Spring = true;
            this.tsslBarcodeCredits.Text = "BarcodeLib by: Brad Barnhill (v2.2.6)";
            // 
            // tsslQRCodeCredits
            // 
            this.tsslQRCodeCredits.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tsslQRCodeCredits.Name = "tsslQRCodeCredits";
            this.tsslQRCodeCredits.Size = new System.Drawing.Size(325, 19);
            this.tsslQRCodeCredits.Spring = true;
            this.tsslQRCodeCredits.Text = "QRCoder by: Raffael Herrmann (v1.4.1)";
            // 
            // tsslAppCredits
            // 
            this.tsslAppCredits.Name = "tsslAppCredits";
            this.tsslAppCredits.Size = new System.Drawing.Size(325, 19);
            this.tsslAppCredits.Spring = true;
            this.tsslAppCredits.Text = "App by: Laude François";
            // 
            // Generator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 601);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(500, 350);
            this.Name = "Generator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bar | QR Code Generator";
            this.Load += new System.EventHandler(this.Generator_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabMenu.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numIconSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbPreview;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabMenu;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtAspectRatio;
        private System.Windows.Forms.TextBox txtBarWidth;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox ddlAlignment;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox ddlRotate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox ddlEncoding;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBarcodeLabel;
        private System.Windows.Forms.CheckBox chkAddLabel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnBGColor;
        private System.Windows.Forms.Button btnFGColor;
        private System.Windows.Forms.TextBox txtIconPath;
        private System.Windows.Forms.Button btnUploadIcon;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown numIconSize;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox ddlECCLevel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox ddlLabelPosition;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslEncoding;
        private System.Windows.Forms.ToolStripStatusLabel tsslGenerateType;
        private System.Windows.Forms.ToolStripStatusLabel tsslECCLevel;
        private System.Windows.Forms.ToolStripStatusLabel tsslBarcodeCredits;
        private System.Windows.Forms.ToolStripStatusLabel tsslQRCodeCredits;
        private System.Windows.Forms.ToolStripStatusLabel tsslAppCredits;
        private System.Windows.Forms.TextBox txtWidth;
    }
}

