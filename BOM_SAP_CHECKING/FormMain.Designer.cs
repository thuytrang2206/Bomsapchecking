namespace BOM_SAP_CHECKING
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_restart = new System.Windows.Forms.Label();
            this.bunifuCircleProgressbar2 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblexport = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lbltime = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnbomsap2 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnbomsap1 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnStart = new Bunifu.Framework.UI.BunifuThinButton2();
            this.cbobom2 = new System.Windows.Forms.ComboBox();
            this.cbobom1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgvbom2 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.dtgvbom1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.dtgvresult = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvbom2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvbom1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvresult)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lbl_restart);
            this.panel1.Controls.Add(this.bunifuCircleProgressbar2);
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Controls.Add(this.lblexport);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.lbltime);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1332, 49);
            this.panel1.TabIndex = 1;
            // 
            // lbl_restart
            // 
            this.lbl_restart.AutoSize = true;
            this.lbl_restart.BackColor = System.Drawing.Color.Transparent;
            this.lbl_restart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_restart.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_restart.Location = new System.Drawing.Point(1073, 17);
            this.lbl_restart.Name = "lbl_restart";
            this.lbl_restart.Size = new System.Drawing.Size(51, 13);
            this.lbl_restart.TabIndex = 115;
            this.lbl_restart.Text = "RESTART";
            this.lbl_restart.Visible = false;
            this.lbl_restart.Click += new System.EventHandler(this.lbl_restart_Click);
            // 
            // bunifuCircleProgressbar2
            // 
            this.bunifuCircleProgressbar2.animated = true;
            this.bunifuCircleProgressbar2.animationIterval = 5;
            this.bunifuCircleProgressbar2.animationSpeed = 3;
            this.bunifuCircleProgressbar2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCircleProgressbar2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCircleProgressbar2.BackgroundImage")));
            this.bunifuCircleProgressbar2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuCircleProgressbar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.bunifuCircleProgressbar2.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuCircleProgressbar2.LabelVisible = false;
            this.bunifuCircleProgressbar2.LineProgressThickness = 0;
            this.bunifuCircleProgressbar2.LineThickness = 0;
            this.bunifuCircleProgressbar2.Location = new System.Drawing.Point(1076, 0);
            this.bunifuCircleProgressbar2.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.bunifuCircleProgressbar2.MaxValue = 100;
            this.bunifuCircleProgressbar2.Name = "bunifuCircleProgressbar2";
            this.bunifuCircleProgressbar2.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.bunifuCircleProgressbar2.ProgressColor = System.Drawing.Color.RoyalBlue;
            this.bunifuCircleProgressbar2.Size = new System.Drawing.Size(46, 46);
            this.bunifuCircleProgressbar2.TabIndex = 114;
            this.bunifuCircleProgressbar2.Value = 95;
            this.bunifuCircleProgressbar2.Visible = false;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.DimGray;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(823, 17);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(125, 17);
            this.bunifuCustomLabel1.TabIndex = 113;
            this.bunifuCustomLabel1.Text = "Export data to Excel";
            this.bunifuCustomLabel1.Click += new System.EventHandler(this.lblexport_Click);
            // 
            // lblexport
            // 
            this.lblexport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblexport.Image = ((System.Drawing.Image)(resources.GetObject("lblexport.Image")));
            this.lblexport.Location = new System.Drawing.Point(945, 4);
            this.lblexport.Name = "lblexport";
            this.lblexport.Size = new System.Drawing.Size(39, 41);
            this.lblexport.TabIndex = 112;
            this.lblexport.Click += new System.EventHandler(this.lblexport_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(64, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "UMC Electronics Viet Nam";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(1231, 21);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(39, 13);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Name";
            this.lblName.Visible = false;
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltime.ForeColor = System.Drawing.Color.Red;
            this.lbltime.Location = new System.Drawing.Point(380, 18);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(48, 13);
            this.lbltime.TabIndex = 5;
            this.lbltime.Text = "label10";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLogin.ForeColor = System.Drawing.Color.Black;
            this.btnLogin.Image = ((System.Drawing.Image)(resources.GetObject("btnLogin.Image")));
            this.btnLogin.Location = new System.Drawing.Point(1291, 3);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(38, 43);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::BOM_SAP_CHECKING.Properties.Resources.UMCVITNAM_L3hUp;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnbomsap2);
            this.groupBox1.Controls.Add(this.btnbomsap1);
            this.groupBox1.Controls.Add(this.btnStart);
            this.groupBox1.Controls.Add(this.cbobom2);
            this.groupBox1.Controls.Add(this.cbobom1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(679, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(650, 322);
            this.groupBox1.TabIndex = 96;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options:";
            // 
            // btnbomsap2
            // 
            this.btnbomsap2.ActiveBorderThickness = 1;
            this.btnbomsap2.ActiveCornerRadius = 20;
            this.btnbomsap2.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnbomsap2.ActiveForecolor = System.Drawing.Color.White;
            this.btnbomsap2.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnbomsap2.BackColor = System.Drawing.SystemColors.Control;
            this.btnbomsap2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnbomsap2.BackgroundImage")));
            this.btnbomsap2.ButtonText = "ChooseFile";
            this.btnbomsap2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbomsap2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbomsap2.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnbomsap2.IdleBorderThickness = 1;
            this.btnbomsap2.IdleCornerRadius = 20;
            this.btnbomsap2.IdleFillColor = System.Drawing.Color.White;
            this.btnbomsap2.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnbomsap2.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnbomsap2.Location = new System.Drawing.Point(495, 82);
            this.btnbomsap2.Margin = new System.Windows.Forms.Padding(5);
            this.btnbomsap2.Name = "btnbomsap2";
            this.btnbomsap2.Size = new System.Drawing.Size(96, 33);
            this.btnbomsap2.TabIndex = 102;
            this.btnbomsap2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnbomsap2.Click += new System.EventHandler(this.btnbomsap2_Click_1);
            // 
            // btnbomsap1
            // 
            this.btnbomsap1.ActiveBorderThickness = 1;
            this.btnbomsap1.ActiveCornerRadius = 20;
            this.btnbomsap1.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnbomsap1.ActiveForecolor = System.Drawing.Color.White;
            this.btnbomsap1.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnbomsap1.BackColor = System.Drawing.SystemColors.Control;
            this.btnbomsap1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnbomsap1.BackgroundImage")));
            this.btnbomsap1.ButtonText = "ChooseFile";
            this.btnbomsap1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbomsap1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbomsap1.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnbomsap1.IdleBorderThickness = 1;
            this.btnbomsap1.IdleCornerRadius = 20;
            this.btnbomsap1.IdleFillColor = System.Drawing.Color.White;
            this.btnbomsap1.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnbomsap1.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnbomsap1.Location = new System.Drawing.Point(495, 14);
            this.btnbomsap1.Margin = new System.Windows.Forms.Padding(5);
            this.btnbomsap1.Name = "btnbomsap1";
            this.btnbomsap1.Size = new System.Drawing.Size(96, 36);
            this.btnbomsap1.TabIndex = 101;
            this.btnbomsap1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnbomsap1.Click += new System.EventHandler(this.btnbomsap1_Click_1);
            // 
            // btnStart
            // 
            this.btnStart.ActiveBorderThickness = 1;
            this.btnStart.ActiveCornerRadius = 20;
            this.btnStart.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnStart.ActiveForecolor = System.Drawing.Color.White;
            this.btnStart.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnStart.BackColor = System.Drawing.SystemColors.Control;
            this.btnStart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStart.BackgroundImage")));
            this.btnStart.ButtonText = "Start";
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnStart.IdleBorderThickness = 1;
            this.btnStart.IdleCornerRadius = 20;
            this.btnStart.IdleFillColor = System.Drawing.Color.White;
            this.btnStart.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnStart.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnStart.Location = new System.Drawing.Point(285, 132);
            this.btnStart.Margin = new System.Windows.Forms.Padding(5);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(77, 41);
            this.btnStart.TabIndex = 100;
            this.btnStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click_1);
            // 
            // cbobom2
            // 
            this.cbobom2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbobom2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbobom2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbobom2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbobom2.FormattingEnabled = true;
            this.cbobom2.Location = new System.Drawing.Point(110, 82);
            this.cbobom2.Name = "cbobom2";
            this.cbobom2.Size = new System.Drawing.Size(356, 28);
            this.cbobom2.TabIndex = 91;
            this.cbobom2.SelectedIndexChanged += new System.EventHandler(this.cbobom2_SelectedIndexChanged);
            // 
            // cbobom1
            // 
            this.cbobom1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbobom1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbobom1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbobom1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbobom1.FormattingEnabled = true;
            this.cbobom1.Location = new System.Drawing.Point(110, 22);
            this.cbobom1.Name = "cbobom1";
            this.cbobom1.Size = new System.Drawing.Size(356, 28);
            this.cbobom1.TabIndex = 92;
            this.cbobom1.SelectedIndexChanged += new System.EventHandler(this.cbobom1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(12, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "BOM SAP 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(12, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "BOM SAP 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(672, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 101;
            this.label5.Text = "label5";
            this.label5.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 100;
            this.label4.Text = "label4";
            this.label4.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgvbom2);
            this.groupBox2.Controls.Add(this.dtgvbom1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(2, 383);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1332, 400);
            this.groupBox2.TabIndex = 97;
            this.groupBox2.TabStop = false;
            // 
            // dtgvbom2
            // 
            this.dtgvbom2.AllowUserToAddRows = false;
            this.dtgvbom2.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtgvbom2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvbom2.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dtgvbom2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvbom2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvbom2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvbom2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvbom2.DoubleBuffered = true;
            this.dtgvbom2.EnableHeadersVisualStyles = false;
            this.dtgvbom2.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dtgvbom2.HeaderForeColor = System.Drawing.Color.White;
            this.dtgvbom2.Location = new System.Drawing.Point(675, 39);
            this.dtgvbom2.Name = "dtgvbom2";
            this.dtgvbom2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgvbom2.RowHeadersVisible = false;
            this.dtgvbom2.Size = new System.Drawing.Size(650, 355);
            this.dtgvbom2.TabIndex = 105;
            // 
            // dtgvbom1
            // 
            this.dtgvbom1.AllowUserToAddRows = false;
            this.dtgvbom1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtgvbom1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvbom1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dtgvbom1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvbom1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvbom1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgvbom1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvbom1.DoubleBuffered = true;
            this.dtgvbom1.EnableHeadersVisualStyles = false;
            this.dtgvbom1.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dtgvbom1.HeaderForeColor = System.Drawing.Color.White;
            this.dtgvbom1.Location = new System.Drawing.Point(11, 39);
            this.dtgvbom1.Name = "dtgvbom1";
            this.dtgvbom1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgvbom1.RowHeadersVisible = false;
            this.dtgvbom1.Size = new System.Drawing.Size(650, 355);
            this.dtgvbom1.TabIndex = 104;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4,
            this.toolStripStatusLabel6,
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel5,
            this.lblVersion});
            this.statusStrip1.Location = new System.Drawing.Point(0, 786);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1334, 25);
            this.statusStrip1.TabIndex = 108;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.toolStripStatusLabel3.ForeColor = System.Drawing.Color.DimGray;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(55, 20);
            this.toolStripStatusLabel3.Text = "Support: ";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.toolStripStatusLabel4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.toolStripStatusLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(33, 20);
            this.toolStripStatusLabel4.Text = "PE-IT";
            // 
            // toolStripStatusLabel6
            // 
            this.toolStripStatusLabel6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripStatusLabel6.Image")));
            this.toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            this.toolStripStatusLabel6.Size = new System.Drawing.Size(20, 20);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.DimGray;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 20);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripStatusLabel2.Image")));
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(20, 20);
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.toolStripStatusLabel5.ForeColor = System.Drawing.Color.DimGray;
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(48, 20);
            this.toolStripStatusLabel5.Text = "Version:";
            // 
            // lblVersion
            // 
            this.lblVersion.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblVersion.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(13, 20);
            this.lblVersion.Text = "0";
            // 
            // dtgvresult
            // 
            this.dtgvresult.AllowUserToAddRows = false;
            this.dtgvresult.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtgvresult.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgvresult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvresult.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dtgvresult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvresult.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvresult.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dtgvresult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvresult.DoubleBuffered = true;
            this.dtgvresult.EnableHeadersVisualStyles = false;
            this.dtgvresult.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dtgvresult.HeaderForeColor = System.Drawing.Color.White;
            this.dtgvresult.Location = new System.Drawing.Point(12, 94);
            this.dtgvresult.Name = "dtgvresult";
            this.dtgvresult.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgvresult.RowHeadersVisible = false;
            this.dtgvresult.Size = new System.Drawing.Size(651, 283);
            this.dtgvresult.TabIndex = 109;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(11, 56);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(651, 32);
            this.panel2.TabIndex = 110;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.SeaGreen;
            this.label6.Location = new System.Drawing.Point(130, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "label6";
            this.label6.Visible = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 811);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dtgvresult);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BOM SAP CHECKING";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvbom2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvbom1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvresult)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbobom2;
        private System.Windows.Forms.ComboBox cbobom1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private Bunifu.Framework.UI.BunifuThinButton2 btnbomsap1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnStart;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dtgvbom2;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dtgvbom1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnbomsap2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel6;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel lblVersion;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dtgvresult;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.LinkLabel lblexport;
        private System.Windows.Forms.Label lbl_restart;
        private Bunifu.Framework.UI.BunifuCircleProgressbar bunifuCircleProgressbar2;
    }
}

