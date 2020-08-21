namespace Assignment5
{
    partial class ProductInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductInfoForm));
            this.ProductInfoMenuStrip = new System.Windows.Forms.MenuStrip();
            this.FileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.EditMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.SelectProductMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.ProductIdTextBox = new System.Windows.Forms.TextBox();
            this.ConditionTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CostTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ModelTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.OSTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ManufacturerTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PlatformTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.WebCamTextBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.GpuTypeTextBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.HddTextBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.CpuSpeedTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.CpuNumberTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.LcdSizeTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.CpuTypeTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.CpuBrandTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.MemoryTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.SelectProductButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.ProductInfoOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.ProductInfoSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.ProductInfoMenuStrip.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProductInfoMenuStrip
            // 
            this.ProductInfoMenuStrip.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ProductInfoMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ProductInfoMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenu,
            this.EditMenu});
            this.ProductInfoMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.ProductInfoMenuStrip.Name = "ProductInfoMenuStrip";
            this.ProductInfoMenuStrip.Size = new System.Drawing.Size(720, 28);
            this.ProductInfoMenuStrip.TabIndex = 0;
            this.ProductInfoMenuStrip.Text = "Product Info Menu";
            this.ProductInfoMenuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ProductInfoMenuStrip_ItemClicked);
            // 
            // FileMenu
            // 
            this.FileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenMenu,
            this.SaveMenu,
            this.toolStripSeparator1,
            this.ExitMenu});
            this.FileMenu.Name = "FileMenu";
            this.FileMenu.Size = new System.Drawing.Size(46, 24);
            this.FileMenu.Text = "&File";
            // 
            // OpenMenu
            // 
            this.OpenMenu.Name = "OpenMenu";
            this.OpenMenu.Size = new System.Drawing.Size(128, 26);
            this.OpenMenu.Text = "&Open";
            this.OpenMenu.Click += new System.EventHandler(this.OpenMenu_Click);
            // 
            // SaveMenu
            // 
            this.SaveMenu.Name = "SaveMenu";
            this.SaveMenu.Size = new System.Drawing.Size(128, 26);
            this.SaveMenu.Text = "&Save";
            this.SaveMenu.Click += new System.EventHandler(this.SaveMenu_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(125, 6);
            // 
            // ExitMenu
            // 
            this.ExitMenu.Name = "ExitMenu";
            this.ExitMenu.Size = new System.Drawing.Size(128, 26);
            this.ExitMenu.Text = "E&xit";
            this.ExitMenu.Click += new System.EventHandler(this.ExitApplication);
            // 
            // EditMenu
            // 
            this.EditMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SelectProductMenu});
            this.EditMenu.Name = "EditMenu";
            this.EditMenu.Size = new System.Drawing.Size(49, 24);
            this.EditMenu.Text = "&Edit";
            // 
            // SelectProductMenu
            // 
            this.SelectProductMenu.Name = "SelectProductMenu";
            this.SelectProductMenu.Size = new System.Drawing.Size(244, 26);
            this.SelectProductMenu.Text = "Se&lect Another Product";
            this.SelectProductMenu.Click += new System.EventHandler(this.SelectAnotherProduct);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Product ID:";
            // 
            // ProductIdTextBox
            // 
            this.ProductIdTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.ProductIdTextBox.Location = new System.Drawing.Point(114, 43);
            this.ProductIdTextBox.Name = "ProductIdTextBox";
            this.ProductIdTextBox.ReadOnly = true;
            this.ProductIdTextBox.Size = new System.Drawing.Size(100, 26);
            this.ProductIdTextBox.TabIndex = 2;
            this.ProductIdTextBox.TabStop = false;
            // 
            // ConditionTextBox
            // 
            this.ConditionTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.ConditionTextBox.Location = new System.Drawing.Point(335, 43);
            this.ConditionTextBox.Name = "ConditionTextBox";
            this.ConditionTextBox.ReadOnly = true;
            this.ConditionTextBox.Size = new System.Drawing.Size(97, 26);
            this.ConditionTextBox.TabIndex = 4;
            this.ConditionTextBox.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Condition:";
            // 
            // CostTextBox
            // 
            this.CostTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.CostTextBox.Location = new System.Drawing.Point(517, 43);
            this.CostTextBox.Name = "CostTextBox";
            this.CostTextBox.ReadOnly = true;
            this.CostTextBox.Size = new System.Drawing.Size(100, 26);
            this.CostTextBox.TabIndex = 6;
            this.CostTextBox.TabStop = false;
            this.CostTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(473, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cost:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.ModelTextBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.OSTextBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.ManufacturerTextBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.PlatformTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(696, 96);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product Info";
            // 
            // ModelTextBox
            // 
            this.ModelTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.ModelTextBox.Location = new System.Drawing.Point(308, 54);
            this.ModelTextBox.Name = "ModelTextBox";
            this.ModelTextBox.ReadOnly = true;
            this.ModelTextBox.Size = new System.Drawing.Size(371, 26);
            this.ModelTextBox.TabIndex = 10;
            this.ModelTextBox.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(253, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Model:";
            // 
            // OSTextBox
            // 
            this.OSTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.OSTextBox.Location = new System.Drawing.Point(308, 21);
            this.OSTextBox.Name = "OSTextBox";
            this.OSTextBox.ReadOnly = true;
            this.OSTextBox.Size = new System.Drawing.Size(371, 26);
            this.OSTextBox.TabIndex = 8;
            this.OSTextBox.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(272, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "OS:";
            // 
            // ManufacturerTextBox
            // 
            this.ManufacturerTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.ManufacturerTextBox.Location = new System.Drawing.Point(102, 54);
            this.ManufacturerTextBox.Name = "ManufacturerTextBox";
            this.ManufacturerTextBox.ReadOnly = true;
            this.ManufacturerTextBox.Size = new System.Drawing.Size(100, 26);
            this.ManufacturerTextBox.TabIndex = 6;
            this.ManufacturerTextBox.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Manufacturer:";
            // 
            // PlatformTextBox
            // 
            this.PlatformTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.PlatformTextBox.Location = new System.Drawing.Point(102, 21);
            this.PlatformTextBox.Name = "PlatformTextBox";
            this.PlatformTextBox.ReadOnly = true;
            this.PlatformTextBox.Size = new System.Drawing.Size(100, 26);
            this.PlatformTextBox.TabIndex = 4;
            this.PlatformTextBox.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Platform:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.WebCamTextBox);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.GpuTypeTextBox);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.HddTextBox);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.CpuSpeedTextBox);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.CpuNumberTextBox);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.LcdSizeTextBox);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.CpuTypeTextBox);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.CpuBrandTextBox);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.MemoryTextBox);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(12, 190);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(696, 135);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tech Specs";
            // 
            // WebCamTextBox
            // 
            this.WebCamTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.WebCamTextBox.Location = new System.Drawing.Point(505, 87);
            this.WebCamTextBox.Name = "WebCamTextBox";
            this.WebCamTextBox.ReadOnly = true;
            this.WebCamTextBox.Size = new System.Drawing.Size(174, 26);
            this.WebCamTextBox.TabIndex = 24;
            this.WebCamTextBox.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(431, 90);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 20);
            this.label14.TabIndex = 23;
            this.label14.Text = "WebCam:";
            // 
            // GpuTypeTextBox
            // 
            this.GpuTypeTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.GpuTypeTextBox.Location = new System.Drawing.Point(505, 54);
            this.GpuTypeTextBox.Name = "GpuTypeTextBox";
            this.GpuTypeTextBox.ReadOnly = true;
            this.GpuTypeTextBox.Size = new System.Drawing.Size(174, 26);
            this.GpuTypeTextBox.TabIndex = 22;
            this.GpuTypeTextBox.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(424, 57);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(91, 20);
            this.label15.TabIndex = 21;
            this.label15.Text = "GPU Type:";
            // 
            // HddTextBox
            // 
            this.HddTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.HddTextBox.Location = new System.Drawing.Point(505, 21);
            this.HddTextBox.Name = "HddTextBox";
            this.HddTextBox.ReadOnly = true;
            this.HddTextBox.Size = new System.Drawing.Size(174, 26);
            this.HddTextBox.TabIndex = 20;
            this.HddTextBox.TabStop = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(458, 24);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 20);
            this.label16.TabIndex = 19;
            this.label16.Text = "HDD:";
            // 
            // CpuSpeedTextBox
            // 
            this.CpuSpeedTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.CpuSpeedTextBox.Location = new System.Drawing.Point(308, 87);
            this.CpuSpeedTextBox.Name = "CpuSpeedTextBox";
            this.CpuSpeedTextBox.ReadOnly = true;
            this.CpuSpeedTextBox.Size = new System.Drawing.Size(100, 26);
            this.CpuSpeedTextBox.TabIndex = 18;
            this.CpuSpeedTextBox.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(219, 90);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 20);
            this.label11.TabIndex = 17;
            this.label11.Text = "CPU Speed:";
            // 
            // CpuNumberTextBox
            // 
            this.CpuNumberTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.CpuNumberTextBox.Location = new System.Drawing.Point(308, 54);
            this.CpuNumberTextBox.Name = "CpuNumberTextBox";
            this.CpuNumberTextBox.ReadOnly = true;
            this.CpuNumberTextBox.Size = new System.Drawing.Size(100, 26);
            this.CpuNumberTextBox.TabIndex = 16;
            this.CpuNumberTextBox.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(212, 57);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 20);
            this.label12.TabIndex = 15;
            this.label12.Text = "CPU Number:";
            // 
            // LcdSizeTextBox
            // 
            this.LcdSizeTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.LcdSizeTextBox.Location = new System.Drawing.Point(308, 21);
            this.LcdSizeTextBox.Name = "LcdSizeTextBox";
            this.LcdSizeTextBox.ReadOnly = true;
            this.LcdSizeTextBox.Size = new System.Drawing.Size(100, 26);
            this.LcdSizeTextBox.TabIndex = 14;
            this.LcdSizeTextBox.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(236, 24);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 20);
            this.label13.TabIndex = 13;
            this.label13.Text = "LCD Size:";
            // 
            // CpuTypeTextBox
            // 
            this.CpuTypeTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.CpuTypeTextBox.Location = new System.Drawing.Point(102, 87);
            this.CpuTypeTextBox.Name = "CpuTypeTextBox";
            this.CpuTypeTextBox.ReadOnly = true;
            this.CpuTypeTextBox.Size = new System.Drawing.Size(100, 26);
            this.CpuTypeTextBox.TabIndex = 12;
            this.CpuTypeTextBox.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 90);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 20);
            this.label10.TabIndex = 11;
            this.label10.Text = "CPU Type:";
            // 
            // CpuBrandTextBox
            // 
            this.CpuBrandTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.CpuBrandTextBox.Location = new System.Drawing.Point(102, 54);
            this.CpuBrandTextBox.Name = "CpuBrandTextBox";
            this.CpuBrandTextBox.ReadOnly = true;
            this.CpuBrandTextBox.Size = new System.Drawing.Size(100, 26);
            this.CpuBrandTextBox.TabIndex = 10;
            this.CpuBrandTextBox.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "CPU Brand:";
            // 
            // MemoryTextBox
            // 
            this.MemoryTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.MemoryTextBox.Location = new System.Drawing.Point(102, 21);
            this.MemoryTextBox.Name = "MemoryTextBox";
            this.MemoryTextBox.ReadOnly = true;
            this.MemoryTextBox.Size = new System.Drawing.Size(100, 26);
            this.MemoryTextBox.TabIndex = 8;
            this.MemoryTextBox.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 20);
            this.label9.TabIndex = 7;
            this.label9.Text = "Memory:";
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(20, 356);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(322, 20);
            this.label17.TabIndex = 9;
            this.label17.Text = "Click Next to Confirm Your Selection.";
            // 
            // SelectProductButton
            // 
            this.SelectProductButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectProductButton.Location = new System.Drawing.Point(315, 347);
            this.SelectProductButton.Name = "SelectProductButton";
            this.SelectProductButton.Size = new System.Drawing.Size(181, 35);
            this.SelectProductButton.TabIndex = 10;
            this.SelectProductButton.Text = "Select Another Product";
            this.SelectProductButton.UseVisualStyleBackColor = true;
            this.SelectProductButton.Click += new System.EventHandler(this.SelectAnotherProduct);
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelButton.Location = new System.Drawing.Point(502, 347);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(100, 35);
            this.CancelButton.TabIndex = 11;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.ExitApplication);
            // 
            // NextButton
            // 
            this.NextButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.NextButton.Enabled = false;
            this.NextButton.Location = new System.Drawing.Point(608, 347);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(100, 35);
            this.NextButton.TabIndex = 12;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // ProductInfoOpenFileDialog
            // 
            this.ProductInfoOpenFileDialog.DefaultExt = "txt";
            this.ProductInfoOpenFileDialog.FileName = "Product";
            this.ProductInfoOpenFileDialog.Filter = "txt files|*.txt|All files|*.*";
            // 
            // ProductInfoSaveFileDialog
            // 
            this.ProductInfoSaveFileDialog.DefaultExt = "txt";
            this.ProductInfoSaveFileDialog.FileName = "Product";
            this.ProductInfoSaveFileDialog.Filter = "txt files|*.txt|All files|*.*";
            // 
            // ProductInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(720, 401);
            this.ControlBox = false;
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SelectProductButton);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CostTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ConditionTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ProductIdTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProductInfoMenuStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.ProductInfoMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ProductInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dollar Computers - Product Information Form";
            this.Load += new System.EventHandler(this.ProductInfoForm_Load);
            this.ProductInfoMenuStrip.ResumeLayout(false);
            this.ProductInfoMenuStrip.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ProductInfoMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem FileMenu;
        private System.Windows.Forms.ToolStripMenuItem OpenMenu;
        private System.Windows.Forms.ToolStripMenuItem SaveMenu;
        private System.Windows.Forms.ToolStripMenuItem ExitMenu;
        private System.Windows.Forms.ToolStripMenuItem EditMenu;
        private System.Windows.Forms.ToolStripMenuItem SelectProductMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ProductIdTextBox;
        private System.Windows.Forms.TextBox ConditionTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CostTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox ModelTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox OSTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ManufacturerTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PlatformTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox CpuSpeedTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox CpuNumberTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox LcdSizeTextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox CpuTypeTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox CpuBrandTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox MemoryTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox WebCamTextBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox GpuTypeTextBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox HddTextBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button SelectProductButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.OpenFileDialog ProductInfoOpenFileDialog;
        private System.Windows.Forms.SaveFileDialog ProductInfoSaveFileDialog;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}