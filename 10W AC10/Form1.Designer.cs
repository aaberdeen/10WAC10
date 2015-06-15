namespace AC10
{
    partial class Form1
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.deviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.txtSendData = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.USB_EN_CheckBox = new System.Windows.Forms.CheckBox();
            this.ENABLE_MAINS_checkBox = new System.Windows.Forms.CheckBox();
            this.ENABLE_STK_checkbox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EXT_5V_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.V_STK = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.V_BAT_textBox = new System.Windows.Forms.TextBox();
            this.V_STK_textBox = new System.Windows.Forms.TextBox();
            this.I_STK_textBox = new System.Windows.Forms.TextBox();
            this.I_BAT_textBox = new System.Windows.Forms.TextBox();
            this.ENABLE_BAT_checkBox = new System.Windows.Forms.CheckBox();
            this.DCDC_ENABLE_checkBox = new System.Windows.Forms.CheckBox();
            this.NCHRG_ENABLE_checkBox = new System.Windows.Forms.CheckBox();
            this.read_gpio_button = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Reg1_textBox = new System.Windows.Forms.TextBox();
            this.Reg2_textBox = new System.Windows.Forms.TextBox();
            this.Reg3_textBox = new System.Windows.Forms.TextBox();
            this.Reg4_textBox = new System.Windows.Forms.TextBox();
            this.batchg_r_button = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.VUSB_textBox = new System.Windows.Forms.TextBox();
            this.Read_ADC_button = new System.Windows.Forms.Button();
            this.DCDC_IN_textBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Auto_Read_checkBox = new System.Windows.Forms.CheckBox();
            this.I_USB_textBox = new System.Windows.Forms.TextBox();
            this.I_USB = new System.Windows.Forms.Label();
            this.I_BOP_textBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.VBOP_textBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.CARTRIDGE_PWR_checkBox = new System.Windows.Forms.CheckBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.inlet_duty_textBox = new System.Windows.Forms.TextBox();
            this.purge_duty_textBox = new System.Windows.Forms.TextBox();
            this.DIVIDER_MODE_SEL_checkBox = new System.Windows.Forms.CheckBox();
            this.V_BAT_MEAS_EN_checkBox = new System.Windows.Forms.CheckBox();
            this.HYDRATE_checkBox = new System.Windows.Forms.CheckBox();
            this.RED_LED_checkBox = new System.Windows.Forms.CheckBox();
            this.GREEN_LED_checkBox = new System.Windows.Forms.CheckBox();
            this.label17 = new System.Windows.Forms.Label();
            this.VDROP_textBox = new System.Windows.Forms.TextBox();
            this.DAC1_textBox = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.PRESS_H2_textBox = new System.Windows.Forms.TextBox();
            this.TEMP_STK_textBox = new System.Windows.Forms.TextBox();
            this.TEMP_STK_label = new System.Windows.Forms.Label();
            this.STAT_textBox = new System.Windows.Forms.TextBox();
            this.fault_textBox = new System.Windows.Forms.TextBox();
            this.V_BAT_prog = new System.Windows.Forms.ProgressBar();
            this.W_BOP_textBox = new System.Windows.Forms.TextBox();
            this.W_USB_textBox = new System.Windows.Forms.TextBox();
            this.W_BAT_textBox = new System.Windows.Forms.TextBox();
            this.Chg_current_trackBar = new System.Windows.Forms.TrackBar();
            this.label20 = new System.Windows.Forms.Label();
            this.chg_rate_textBox = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.Chr_rate_send_button = new System.Windows.Forms.Button();
            this.Iin_limit_textBox = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.EN_STAT_checkbox = new System.Windows.Forms.CheckBox();
            this.EN_TERM_checkBox = new System.Windows.Forms.CheckBox();
            this.nCH_checkBox = new System.Windows.Forms.CheckBox();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chg_current_trackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deviceToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1272, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // deviceToolStripMenuItem
            // 
            this.deviceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem,
            this.setupToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.deviceToolStripMenuItem.Name = "deviceToolStripMenuItem";
            this.deviceToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.deviceToolStripMenuItem.Text = "Device";
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.connectToolStripMenuItem.Text = "Connect";
            this.connectToolStripMenuItem.Click += new System.EventHandler(this.connectToolStripMenuItem_Click);
            // 
            // setupToolStripMenuItem
            // 
            this.setupToolStripMenuItem.Name = "setupToolStripMenuItem";
            this.setupToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.setupToolStripMenuItem.Text = "Setup";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 26);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(99, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBox1_MouseClick);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 554);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(238, 106);
            this.richTextBox1.TabIndex = 15;
            this.richTextBox1.Text = "";
            // 
            // txtSendData
            // 
            this.txtSendData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSendData.Location = new System.Drawing.Point(12, 666);
            this.txtSendData.Name = "txtSendData";
            this.txtSendData.Size = new System.Drawing.Size(234, 20);
            this.txtSendData.TabIndex = 16;
            this.txtSendData.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSendData_KeyPress);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Location = new System.Drawing.Point(12, 692);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 17;
            this.button4.Text = "Send Data";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // USB_EN_CheckBox
            // 
            this.USB_EN_CheckBox.AutoSize = true;
            this.USB_EN_CheckBox.Location = new System.Drawing.Point(1107, 94);
            this.USB_EN_CheckBox.Name = "USB_EN_CheckBox";
            this.USB_EN_CheckBox.Size = new System.Drawing.Size(69, 17);
            this.USB_EN_CheckBox.TabIndex = 18;
            this.USB_EN_CheckBox.Text = "USB_EN";
            this.USB_EN_CheckBox.UseVisualStyleBackColor = true;
            this.USB_EN_CheckBox.CheckStateChanged += new System.EventHandler(this.USB_EN_CheckBox_CheckStateChanged);
            // 
            // ENABLE_MAINS_checkBox
            // 
            this.ENABLE_MAINS_checkBox.AutoSize = true;
            this.ENABLE_MAINS_checkBox.Location = new System.Drawing.Point(767, 26);
            this.ENABLE_MAINS_checkBox.Name = "ENABLE_MAINS_checkBox";
            this.ENABLE_MAINS_checkBox.Size = new System.Drawing.Size(108, 17);
            this.ENABLE_MAINS_checkBox.TabIndex = 19;
            this.ENABLE_MAINS_checkBox.Text = "ENABLE_MAINS";
            this.ENABLE_MAINS_checkBox.UseVisualStyleBackColor = true;
            this.ENABLE_MAINS_checkBox.CheckStateChanged += new System.EventHandler(this.ENABLE_MAINS_checkBox_CheckStateChanged);
            // 
            // ENABLE_STK_checkbox
            // 
            this.ENABLE_STK_checkbox.AutoSize = true;
            this.ENABLE_STK_checkbox.Location = new System.Drawing.Point(767, 140);
            this.ENABLE_STK_checkbox.Name = "ENABLE_STK_checkbox";
            this.ENABLE_STK_checkbox.Size = new System.Drawing.Size(95, 17);
            this.ENABLE_STK_checkbox.TabIndex = 20;
            this.ENABLE_STK_checkbox.Text = "ENABLE_STK";
            this.ENABLE_STK_checkbox.UseVisualStyleBackColor = true;
            this.ENABLE_STK_checkbox.CheckStateChanged += new System.EventHandler(this.ENABLE_STK_checkbox_CheckStateChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(443, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "EXT_5V";
            // 
            // EXT_5V_textBox
            // 
            this.EXT_5V_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.EXT_5V_textBox.Location = new System.Drawing.Point(443, 46);
            this.EXT_5V_textBox.Name = "EXT_5V_textBox";
            this.EXT_5V_textBox.Size = new System.Drawing.Size(53, 20);
            this.EXT_5V_textBox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(434, 521);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "I_BAT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(445, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "I_STK";
            // 
            // V_STK
            // 
            this.V_STK.AutoSize = true;
            this.V_STK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.V_STK.Location = new System.Drawing.Point(443, 217);
            this.V_STK.Name = "V_STK";
            this.V_STK.Size = new System.Drawing.Size(41, 13);
            this.V_STK.TabIndex = 11;
            this.V_STK.Text = "V_STK";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(432, 482);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "V_BAT";
            // 
            // V_BAT_textBox
            // 
            this.V_BAT_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.V_BAT_textBox.Location = new System.Drawing.Point(433, 498);
            this.V_BAT_textBox.Name = "V_BAT_textBox";
            this.V_BAT_textBox.Size = new System.Drawing.Size(76, 20);
            this.V_BAT_textBox.TabIndex = 9;
            this.V_BAT_textBox.TextChanged += new System.EventHandler(this.V_BAT_textBox_TextChanged);
            // 
            // V_STK_textBox
            // 
            this.V_STK_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.V_STK_textBox.Location = new System.Drawing.Point(443, 233);
            this.V_STK_textBox.Name = "V_STK_textBox";
            this.V_STK_textBox.Size = new System.Drawing.Size(59, 20);
            this.V_STK_textBox.TabIndex = 13;
            // 
            // I_STK_textBox
            // 
            this.I_STK_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.I_STK_textBox.Location = new System.Drawing.Point(443, 272);
            this.I_STK_textBox.Name = "I_STK_textBox";
            this.I_STK_textBox.Size = new System.Drawing.Size(59, 20);
            this.I_STK_textBox.TabIndex = 14;
            // 
            // I_BAT_textBox
            // 
            this.I_BAT_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.I_BAT_textBox.Location = new System.Drawing.Point(435, 537);
            this.I_BAT_textBox.Name = "I_BAT_textBox";
            this.I_BAT_textBox.Size = new System.Drawing.Size(72, 20);
            this.I_BAT_textBox.TabIndex = 10;
            // 
            // ENABLE_BAT_checkBox
            // 
            this.ENABLE_BAT_checkBox.AutoSize = true;
            this.ENABLE_BAT_checkBox.Location = new System.Drawing.Point(767, 461);
            this.ENABLE_BAT_checkBox.Name = "ENABLE_BAT_checkBox";
            this.ENABLE_BAT_checkBox.Size = new System.Drawing.Size(95, 17);
            this.ENABLE_BAT_checkBox.TabIndex = 22;
            this.ENABLE_BAT_checkBox.Text = "ENABLE_BAT";
            this.ENABLE_BAT_checkBox.UseVisualStyleBackColor = true;
            this.ENABLE_BAT_checkBox.CheckStateChanged += new System.EventHandler(this.ENABLE_BAT_checkBox_CheckStateChanged);
            // 
            // DCDC_ENABLE_checkBox
            // 
            this.DCDC_ENABLE_checkBox.AutoSize = true;
            this.DCDC_ENABLE_checkBox.Location = new System.Drawing.Point(964, 95);
            this.DCDC_ENABLE_checkBox.Name = "DCDC_ENABLE_checkBox";
            this.DCDC_ENABLE_checkBox.Size = new System.Drawing.Size(104, 17);
            this.DCDC_ENABLE_checkBox.TabIndex = 23;
            this.DCDC_ENABLE_checkBox.Text = "DCDC_ENABLE";
            this.DCDC_ENABLE_checkBox.UseVisualStyleBackColor = true;
            this.DCDC_ENABLE_checkBox.CheckStateChanged += new System.EventHandler(this.DCDC_ENABLE_checkBox_CheckStateChanged);
            // 
            // NCHRG_ENABLE_checkBox
            // 
            this.NCHRG_ENABLE_checkBox.AutoSize = true;
            this.NCHRG_ENABLE_checkBox.Location = new System.Drawing.Point(329, 585);
            this.NCHRG_ENABLE_checkBox.Name = "NCHRG_ENABLE_checkBox";
            this.NCHRG_ENABLE_checkBox.Size = new System.Drawing.Size(113, 17);
            this.NCHRG_ENABLE_checkBox.TabIndex = 25;
            this.NCHRG_ENABLE_checkBox.Text = "NCHRG_ENABLE";
            this.NCHRG_ENABLE_checkBox.UseVisualStyleBackColor = true;
            this.NCHRG_ENABLE_checkBox.CheckStateChanged += new System.EventHandler(this.NCHRG_ENABLE_checkBox_CheckStateChanged);
            // 
            // read_gpio_button
            // 
            this.read_gpio_button.Location = new System.Drawing.Point(12, 73);
            this.read_gpio_button.Name = "read_gpio_button";
            this.read_gpio_button.Size = new System.Drawing.Size(99, 23);
            this.read_gpio_button.TabIndex = 26;
            this.read_gpio_button.Text = "Read GPIO";
            this.read_gpio_button.UseVisualStyleBackColor = true;
            this.read_gpio_button.Click += new System.EventHandler(this.read_gpio_button_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(332, 611);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Reg #1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(332, 633);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Reg #2";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(332, 653);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "Reg #3";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(332, 673);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "Reg #4";
            // 
            // Reg1_textBox
            // 
            this.Reg1_textBox.Location = new System.Drawing.Point(381, 608);
            this.Reg1_textBox.Name = "Reg1_textBox";
            this.Reg1_textBox.Size = new System.Drawing.Size(45, 20);
            this.Reg1_textBox.TabIndex = 31;
            this.Reg1_textBox.TextChanged += new System.EventHandler(this.Reg1_textBox_TextChanged);
            this.Reg1_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Reg1_textBox_KeyPress);
            // 
            // Reg2_textBox
            // 
            this.Reg2_textBox.Location = new System.Drawing.Point(381, 630);
            this.Reg2_textBox.Name = "Reg2_textBox";
            this.Reg2_textBox.Size = new System.Drawing.Size(45, 20);
            this.Reg2_textBox.TabIndex = 32;
            this.Reg2_textBox.TextChanged += new System.EventHandler(this.Reg2_textBox_TextChanged);
            // 
            // Reg3_textBox
            // 
            this.Reg3_textBox.Location = new System.Drawing.Point(381, 650);
            this.Reg3_textBox.Name = "Reg3_textBox";
            this.Reg3_textBox.Size = new System.Drawing.Size(45, 20);
            this.Reg3_textBox.TabIndex = 33;
            // 
            // Reg4_textBox
            // 
            this.Reg4_textBox.Location = new System.Drawing.Point(381, 670);
            this.Reg4_textBox.Name = "Reg4_textBox";
            this.Reg4_textBox.Size = new System.Drawing.Size(45, 20);
            this.Reg4_textBox.TabIndex = 34;
            this.Reg4_textBox.TextChanged += new System.EventHandler(this.Reg4_textBox_TextChanged);
            // 
            // batchg_r_button
            // 
            this.batchg_r_button.Location = new System.Drawing.Point(12, 102);
            this.batchg_r_button.Name = "batchg_r_button";
            this.batchg_r_button.Size = new System.Drawing.Size(99, 23);
            this.batchg_r_button.TabIndex = 35;
            this.batchg_r_button.Text = "Read batchg";
            this.batchg_r_button.UseVisualStyleBackColor = true;
            this.batchg_r_button.Click += new System.EventHandler(this.batchg_r_button_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(163, 216);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 36;
            this.label10.Text = "Fan1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(163, 289);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 37;
            this.label11.Text = "Fan2";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(200, 214);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(53, 20);
            this.textBox6.TabIndex = 38;
            this.textBox6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox6_KeyPress);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(202, 289);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(53, 20);
            this.textBox7.TabIndex = 39;
            this.textBox7.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox7_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1200, 140);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 13);
            this.label12.TabIndex = 40;
            this.label12.Text = "VUSB";
            // 
            // VUSB_textBox
            // 
            this.VUSB_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.VUSB_textBox.Location = new System.Drawing.Point(1198, 156);
            this.VUSB_textBox.Name = "VUSB_textBox";
            this.VUSB_textBox.Size = new System.Drawing.Size(53, 20);
            this.VUSB_textBox.TabIndex = 41;
            this.VUSB_textBox.TextChanged += new System.EventHandler(this.VUSB_textBox_TextChanged);
            // 
            // Read_ADC_button
            // 
            this.Read_ADC_button.Location = new System.Drawing.Point(12, 130);
            this.Read_ADC_button.Name = "Read_ADC_button";
            this.Read_ADC_button.Size = new System.Drawing.Size(99, 23);
            this.Read_ADC_button.TabIndex = 42;
            this.Read_ADC_button.Text = "Read ADC";
            this.Read_ADC_button.UseVisualStyleBackColor = true;
            this.Read_ADC_button.Click += new System.EventHandler(this.Read_ADC_button_Click);
            // 
            // DCDC_IN_textBox
            // 
            this.DCDC_IN_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.DCDC_IN_textBox.Location = new System.Drawing.Point(886, 156);
            this.DCDC_IN_textBox.Name = "DCDC_IN_textBox";
            this.DCDC_IN_textBox.Size = new System.Drawing.Size(62, 20);
            this.DCDC_IN_textBox.TabIndex = 44;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label13.Location = new System.Drawing.Point(886, 140);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 13);
            this.label13.TabIndex = 43;
            this.label13.Text = "DCDC IN V";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Auto_Read_checkBox
            // 
            this.Auto_Read_checkBox.AutoSize = true;
            this.Auto_Read_checkBox.Location = new System.Drawing.Point(12, 182);
            this.Auto_Read_checkBox.Name = "Auto_Read_checkBox";
            this.Auto_Read_checkBox.Size = new System.Drawing.Size(77, 17);
            this.Auto_Read_checkBox.TabIndex = 45;
            this.Auto_Read_checkBox.Text = "Auto Read";
            this.Auto_Read_checkBox.UseVisualStyleBackColor = true;
            this.Auto_Read_checkBox.CheckStateChanged += new System.EventHandler(this.Auto_Read_checkBox_CheckStateChanged);
            // 
            // I_USB_textBox
            // 
            this.I_USB_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.I_USB_textBox.Location = new System.Drawing.Point(1198, 195);
            this.I_USB_textBox.Name = "I_USB_textBox";
            this.I_USB_textBox.Size = new System.Drawing.Size(74, 20);
            this.I_USB_textBox.TabIndex = 47;
            // 
            // I_USB
            // 
            this.I_USB.AutoSize = true;
            this.I_USB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.I_USB.Location = new System.Drawing.Point(1200, 179);
            this.I_USB.Name = "I_USB";
            this.I_USB.Size = new System.Drawing.Size(38, 13);
            this.I_USB.TabIndex = 46;
            this.I_USB.Text = "I_USB";
            // 
            // I_BOP_textBox
            // 
            this.I_BOP_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.I_BOP_textBox.Location = new System.Drawing.Point(1063, 302);
            this.I_BOP_textBox.Name = "I_BOP_textBox";
            this.I_BOP_textBox.Size = new System.Drawing.Size(74, 20);
            this.I_BOP_textBox.TabIndex = 51;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label14.Location = new System.Drawing.Point(1065, 286);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 13);
            this.label14.TabIndex = 50;
            this.label14.Text = "I_BOP";
            // 
            // VBOP_textBox
            // 
            this.VBOP_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.VBOP_textBox.Location = new System.Drawing.Point(1063, 263);
            this.VBOP_textBox.Name = "VBOP_textBox";
            this.VBOP_textBox.Size = new System.Drawing.Size(53, 20);
            this.VBOP_textBox.TabIndex = 49;
            this.VBOP_textBox.TextChanged += new System.EventHandler(this.VBOP_textBox_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(1065, 247);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(36, 13);
            this.label15.TabIndex = 48;
            this.label15.Text = "VBOP";
            // 
            // CARTRIDGE_PWR_checkBox
            // 
            this.CARTRIDGE_PWR_checkBox.AutoSize = true;
            this.CARTRIDGE_PWR_checkBox.Location = new System.Drawing.Point(154, 27);
            this.CARTRIDGE_PWR_checkBox.Name = "CARTRIDGE_PWR_checkBox";
            this.CARTRIDGE_PWR_checkBox.Size = new System.Drawing.Size(121, 17);
            this.CARTRIDGE_PWR_checkBox.TabIndex = 63;
            this.CARTRIDGE_PWR_checkBox.Text = "CARTRIDGE_PWR";
            this.CARTRIDGE_PWR_checkBox.UseVisualStyleBackColor = true;
            this.CARTRIDGE_PWR_checkBox.CheckStateChanged += new System.EventHandler(this.CARTRIDGE_PWR_checkBox_CheckStateChanged);
            // 
            // pictureBox12
            // 
            this.pictureBox12.Image = global::AC10.Properties.Resources.valve;
            this.pictureBox12.Location = new System.Drawing.Point(261, 328);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(70, 39);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox12.TabIndex = 64;
            this.pictureBox12.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = global::AC10.Properties.Resources.dcdc;
            this.pictureBox11.Location = new System.Drawing.Point(605, 472);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(92, 85);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox11.TabIndex = 62;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::AC10.Properties.Resources.diode;
            this.pictureBox10.Location = new System.Drawing.Point(767, 498);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(100, 50);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 61;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::AC10.Properties.Resources.diode;
            this.pictureBox9.Location = new System.Drawing.Point(767, 173);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(100, 50);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 60;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox8.Image = global::AC10.Properties.Resources.diode;
            this.pictureBox8.Location = new System.Drawing.Point(767, 49);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(100, 50);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 59;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::AC10.Properties.Resources.dcdc;
            this.pictureBox7.Location = new System.Drawing.Point(964, 139);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(92, 85);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 58;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::AC10.Properties.Resources.usb_power;
            this.pictureBox6.Location = new System.Drawing.Point(1107, 140);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(87, 85);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 57;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::AC10.Properties.Resources.usb_plug;
            this.pictureBox5.Location = new System.Drawing.Point(340, 30);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(97, 82);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 56;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::AC10.Properties.Resources.battery_energy_icon;
            this.pictureBox4.Location = new System.Drawing.Point(326, 478);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 95);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 55;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::AC10.Properties.Resources.fan;
            this.pictureBox3.Location = new System.Drawing.Point(261, 272);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(70, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 54;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::AC10.Properties.Resources.stack;
            this.pictureBox2.Location = new System.Drawing.Point(337, 213);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 109);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 53;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AC10.Properties.Resources.fan;
            this.pictureBox1.Location = new System.Drawing.Point(261, 214);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 52;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox13
            // 
            this.pictureBox13.Image = global::AC10.Properties.Resources.valve;
            this.pictureBox13.Location = new System.Drawing.Point(261, 173);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(70, 33);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox13.TabIndex = 65;
            this.pictureBox13.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(137, 342);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 66;
            this.label4.Text = "Inlet PWM";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(137, 179);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 13);
            this.label16.TabIndex = 67;
            this.label16.Text = "Purge PWM";
            // 
            // inlet_duty_textBox
            // 
            this.inlet_duty_textBox.Location = new System.Drawing.Point(200, 339);
            this.inlet_duty_textBox.Name = "inlet_duty_textBox";
            this.inlet_duty_textBox.Size = new System.Drawing.Size(53, 20);
            this.inlet_duty_textBox.TabIndex = 68;
            this.inlet_duty_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inlet_duty_textBox_KeyPress);
            // 
            // purge_duty_textBox
            // 
            this.purge_duty_textBox.Location = new System.Drawing.Point(202, 176);
            this.purge_duty_textBox.Name = "purge_duty_textBox";
            this.purge_duty_textBox.Size = new System.Drawing.Size(53, 20);
            this.purge_duty_textBox.TabIndex = 69;
            this.purge_duty_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.purge_duty_textBox_KeyPress);
            // 
            // DIVIDER_MODE_SEL_checkBox
            // 
            this.DIVIDER_MODE_SEL_checkBox.AutoSize = true;
            this.DIVIDER_MODE_SEL_checkBox.Location = new System.Drawing.Point(1107, 117);
            this.DIVIDER_MODE_SEL_checkBox.Name = "DIVIDER_MODE_SEL_checkBox";
            this.DIVIDER_MODE_SEL_checkBox.Size = new System.Drawing.Size(134, 17);
            this.DIVIDER_MODE_SEL_checkBox.TabIndex = 70;
            this.DIVIDER_MODE_SEL_checkBox.Text = "DIVIDER_MODE_SEL";
            this.DIVIDER_MODE_SEL_checkBox.UseVisualStyleBackColor = true;
            this.DIVIDER_MODE_SEL_checkBox.CheckStateChanged += new System.EventHandler(this.DIVIDER_MODE_SEL_checkBox_CheckStateChanged);
            // 
            // V_BAT_MEAS_EN_checkBox
            // 
            this.V_BAT_MEAS_EN_checkBox.AutoSize = true;
            this.V_BAT_MEAS_EN_checkBox.Location = new System.Drawing.Point(430, 446);
            this.V_BAT_MEAS_EN_checkBox.Name = "V_BAT_MEAS_EN_checkBox";
            this.V_BAT_MEAS_EN_checkBox.Size = new System.Drawing.Size(117, 17);
            this.V_BAT_MEAS_EN_checkBox.TabIndex = 71;
            this.V_BAT_MEAS_EN_checkBox.Text = "V_BAT_MEAS_EN";
            this.V_BAT_MEAS_EN_checkBox.UseVisualStyleBackColor = true;
            this.V_BAT_MEAS_EN_checkBox.CheckStateChanged += new System.EventHandler(this.V_BAT_MEAS_EN_checkBox_CheckStateChanged);
            // 
            // HYDRATE_checkBox
            // 
            this.HYDRATE_checkBox.AutoSize = true;
            this.HYDRATE_checkBox.Location = new System.Drawing.Point(348, 159);
            this.HYDRATE_checkBox.Name = "HYDRATE_checkBox";
            this.HYDRATE_checkBox.Size = new System.Drawing.Size(78, 17);
            this.HYDRATE_checkBox.TabIndex = 72;
            this.HYDRATE_checkBox.Text = "HYDRATE";
            this.HYDRATE_checkBox.UseVisualStyleBackColor = true;
            this.HYDRATE_checkBox.CheckStateChanged += new System.EventHandler(this.HYDRATE_checkBox_CheckStateChanged);
            // 
            // RED_LED_checkBox
            // 
            this.RED_LED_checkBox.AutoSize = true;
            this.RED_LED_checkBox.Location = new System.Drawing.Point(12, 213);
            this.RED_LED_checkBox.Name = "RED_LED_checkBox";
            this.RED_LED_checkBox.Size = new System.Drawing.Size(76, 17);
            this.RED_LED_checkBox.TabIndex = 73;
            this.RED_LED_checkBox.Text = "RED_LED";
            this.RED_LED_checkBox.UseVisualStyleBackColor = true;
            this.RED_LED_checkBox.CheckStateChanged += new System.EventHandler(this.RED_LED_checkBox_CheckStateChanged);
            // 
            // GREEN_LED_checkBox
            // 
            this.GREEN_LED_checkBox.AutoSize = true;
            this.GREEN_LED_checkBox.Location = new System.Drawing.Point(12, 233);
            this.GREEN_LED_checkBox.Name = "GREEN_LED_checkBox";
            this.GREEN_LED_checkBox.Size = new System.Drawing.Size(91, 17);
            this.GREEN_LED_checkBox.TabIndex = 74;
            this.GREEN_LED_checkBox.Text = "GREEN_LED";
            this.GREEN_LED_checkBox.UseVisualStyleBackColor = true;
            this.GREEN_LED_checkBox.CheckStateChanged += new System.EventHandler(this.GREEN_LED_checkBox_CheckStateChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(626, 560);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(45, 13);
            this.label17.TabIndex = 75;
            this.label17.Text = "VDROP";
            // 
            // VDROP_textBox
            // 
            this.VDROP_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.VDROP_textBox.Location = new System.Drawing.Point(605, 576);
            this.VDROP_textBox.Name = "VDROP_textBox";
            this.VDROP_textBox.Size = new System.Drawing.Size(76, 20);
            this.VDROP_textBox.TabIndex = 76;
            // 
            // DAC1_textBox
            // 
            this.DAC1_textBox.Location = new System.Drawing.Point(618, 446);
            this.DAC1_textBox.Name = "DAC1_textBox";
            this.DAC1_textBox.Size = new System.Drawing.Size(53, 20);
            this.DAC1_textBox.TabIndex = 77;
            this.DAC1_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DAC1_textBox_KeyPress);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(626, 430);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(35, 13);
            this.label18.TabIndex = 78;
            this.label18.Text = "DAC1";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(131, 376);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(63, 13);
            this.label19.TabIndex = 79;
            this.label19.Text = "PRESS_H2";
            // 
            // PRESS_H2_textBox
            // 
            this.PRESS_H2_textBox.Location = new System.Drawing.Point(200, 373);
            this.PRESS_H2_textBox.Name = "PRESS_H2_textBox";
            this.PRESS_H2_textBox.Size = new System.Drawing.Size(92, 20);
            this.PRESS_H2_textBox.TabIndex = 80;
            // 
            // TEMP_STK_textBox
            // 
            this.TEMP_STK_textBox.Location = new System.Drawing.Point(200, 399);
            this.TEMP_STK_textBox.Name = "TEMP_STK_textBox";
            this.TEMP_STK_textBox.Size = new System.Drawing.Size(92, 20);
            this.TEMP_STK_textBox.TabIndex = 81;
            // 
            // TEMP_STK_label
            // 
            this.TEMP_STK_label.AutoSize = true;
            this.TEMP_STK_label.Location = new System.Drawing.Point(130, 402);
            this.TEMP_STK_label.Name = "TEMP_STK_label";
            this.TEMP_STK_label.Size = new System.Drawing.Size(64, 13);
            this.TEMP_STK_label.TabIndex = 82;
            this.TEMP_STK_label.Text = "TEMP_STK";
            // 
            // STAT_textBox
            // 
            this.STAT_textBox.Enabled = false;
            this.STAT_textBox.Location = new System.Drawing.Point(504, 608);
            this.STAT_textBox.Name = "STAT_textBox";
            this.STAT_textBox.Size = new System.Drawing.Size(72, 20);
            this.STAT_textBox.TabIndex = 83;
            // 
            // fault_textBox
            // 
            this.fault_textBox.Enabled = false;
            this.fault_textBox.Location = new System.Drawing.Point(582, 608);
            this.fault_textBox.Name = "fault_textBox";
            this.fault_textBox.Size = new System.Drawing.Size(140, 20);
            this.fault_textBox.TabIndex = 84;
            // 
            // V_BAT_prog
            // 
            this.V_BAT_prog.Location = new System.Drawing.Point(326, 455);
            this.V_BAT_prog.Maximum = 4100;
            this.V_BAT_prog.Minimum = 3000;
            this.V_BAT_prog.Name = "V_BAT_prog";
            this.V_BAT_prog.Size = new System.Drawing.Size(100, 23);
            this.V_BAT_prog.Step = 50;
            this.V_BAT_prog.TabIndex = 85;
            this.V_BAT_prog.Value = 3000;
            // 
            // W_BOP_textBox
            // 
            this.W_BOP_textBox.Location = new System.Drawing.Point(1063, 335);
            this.W_BOP_textBox.Name = "W_BOP_textBox";
            this.W_BOP_textBox.Size = new System.Drawing.Size(74, 20);
            this.W_BOP_textBox.TabIndex = 86;
            // 
            // W_USB_textBox
            // 
            this.W_USB_textBox.Location = new System.Drawing.Point(1198, 240);
            this.W_USB_textBox.Name = "W_USB_textBox";
            this.W_USB_textBox.Size = new System.Drawing.Size(74, 20);
            this.W_USB_textBox.TabIndex = 87;
            // 
            // W_BAT_textBox
            // 
            this.W_BAT_textBox.Location = new System.Drawing.Point(435, 560);
            this.W_BAT_textBox.Name = "W_BAT_textBox";
            this.W_BAT_textBox.Size = new System.Drawing.Size(74, 20);
            this.W_BAT_textBox.TabIndex = 88;
            // 
            // Chg_current_trackBar
            // 
            this.Chg_current_trackBar.LargeChange = 50;
            this.Chg_current_trackBar.Location = new System.Drawing.Point(541, 670);
            this.Chg_current_trackBar.Maximum = 2000;
            this.Chg_current_trackBar.Minimum = 500;
            this.Chg_current_trackBar.Name = "Chg_current_trackBar";
            this.Chg_current_trackBar.Size = new System.Drawing.Size(193, 45);
            this.Chg_current_trackBar.SmallChange = 50;
            this.Chg_current_trackBar.TabIndex = 89;
            this.Chg_current_trackBar.TickFrequency = 50;
            this.Chg_current_trackBar.Value = 500;
            this.Chg_current_trackBar.Scroll += new System.EventHandler(this.Chg_current_trackBar_Scroll);
            this.Chg_current_trackBar.ValueChanged += new System.EventHandler(this.Chg_current_trackBar_ValueChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(468, 673);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(67, 13);
            this.label20.TabIndex = 90;
            this.label20.Text = "Charge Rate";
            // 
            // chg_rate_textBox
            // 
            this.chg_rate_textBox.Enabled = false;
            this.chg_rate_textBox.Location = new System.Drawing.Point(728, 673);
            this.chg_rate_textBox.Name = "chg_rate_textBox";
            this.chg_rate_textBox.Size = new System.Drawing.Size(30, 20);
            this.chg_rate_textBox.TabIndex = 91;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(764, 680);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(22, 13);
            this.label21.TabIndex = 92;
            this.label21.Text = "mA";
            // 
            // Chr_rate_send_button
            // 
            this.Chr_rate_send_button.Location = new System.Drawing.Point(787, 673);
            this.Chr_rate_send_button.Name = "Chr_rate_send_button";
            this.Chr_rate_send_button.Size = new System.Drawing.Size(49, 23);
            this.Chr_rate_send_button.TabIndex = 93;
            this.Chr_rate_send_button.Text = "Send";
            this.Chr_rate_send_button.UseVisualStyleBackColor = true;
            this.Chr_rate_send_button.Click += new System.EventHandler(this.Chr_rate_send_button_Click);
            // 
            // Iin_limit_textBox
            // 
            this.Iin_limit_textBox.Enabled = false;
            this.Iin_limit_textBox.Location = new System.Drawing.Point(504, 630);
            this.Iin_limit_textBox.Name = "Iin_limit_textBox";
            this.Iin_limit_textBox.Size = new System.Drawing.Size(53, 20);
            this.Iin_limit_textBox.TabIndex = 94;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(461, 634);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(41, 13);
            this.label22.TabIndex = 95;
            this.label22.Text = "Iin_limit";
            // 
            // EN_STAT_checkbox
            // 
            this.EN_STAT_checkbox.AutoSize = true;
            this.EN_STAT_checkbox.Enabled = false;
            this.EN_STAT_checkbox.Location = new System.Drawing.Point(582, 635);
            this.EN_STAT_checkbox.Name = "EN_STAT_checkbox";
            this.EN_STAT_checkbox.Size = new System.Drawing.Size(75, 17);
            this.EN_STAT_checkbox.TabIndex = 96;
            this.EN_STAT_checkbox.Text = "EN_STAT";
            this.EN_STAT_checkbox.UseVisualStyleBackColor = true;
            // 
            // EN_TERM_checkBox
            // 
            this.EN_TERM_checkBox.AutoSize = true;
            this.EN_TERM_checkBox.Enabled = false;
            this.EN_TERM_checkBox.Location = new System.Drawing.Point(659, 634);
            this.EN_TERM_checkBox.Name = "EN_TERM_checkBox";
            this.EN_TERM_checkBox.Size = new System.Drawing.Size(78, 17);
            this.EN_TERM_checkBox.TabIndex = 97;
            this.EN_TERM_checkBox.Text = "EN_TERM";
            this.EN_TERM_checkBox.UseVisualStyleBackColor = true;
            // 
            // nCH_checkBox
            // 
            this.nCH_checkBox.AutoSize = true;
            this.nCH_checkBox.Enabled = false;
            this.nCH_checkBox.Location = new System.Drawing.Point(743, 634);
            this.nCH_checkBox.Name = "nCH_checkBox";
            this.nCH_checkBox.Size = new System.Drawing.Size(87, 17);
            this.nCH_checkBox.TabIndex = 98;
            this.nCH_checkBox.Text = "nCharge_EN";
            this.nCH_checkBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 722);
            this.Controls.Add(this.nCH_checkBox);
            this.Controls.Add(this.EN_TERM_checkBox);
            this.Controls.Add(this.EN_STAT_checkbox);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.Iin_limit_textBox);
            this.Controls.Add(this.Chr_rate_send_button);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.chg_rate_textBox);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.Chg_current_trackBar);
            this.Controls.Add(this.W_BAT_textBox);
            this.Controls.Add(this.W_USB_textBox);
            this.Controls.Add(this.W_BOP_textBox);
            this.Controls.Add(this.V_BAT_prog);
            this.Controls.Add(this.fault_textBox);
            this.Controls.Add(this.STAT_textBox);
            this.Controls.Add(this.TEMP_STK_label);
            this.Controls.Add(this.TEMP_STK_textBox);
            this.Controls.Add(this.PRESS_H2_textBox);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.DAC1_textBox);
            this.Controls.Add(this.VDROP_textBox);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.GREEN_LED_checkBox);
            this.Controls.Add(this.RED_LED_checkBox);
            this.Controls.Add(this.HYDRATE_checkBox);
            this.Controls.Add(this.V_BAT_MEAS_EN_checkBox);
            this.Controls.Add(this.DIVIDER_MODE_SEL_checkBox);
            this.Controls.Add(this.purge_duty_textBox);
            this.Controls.Add(this.inlet_duty_textBox);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox13);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.CARTRIDGE_PWR_checkBox);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.I_BOP_textBox);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.VBOP_textBox);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.I_USB_textBox);
            this.Controls.Add(this.I_USB);
            this.Controls.Add(this.Auto_Read_checkBox);
            this.Controls.Add(this.DCDC_IN_textBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.Read_ADC_button);
            this.Controls.Add(this.VUSB_textBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.batchg_r_button);
            this.Controls.Add(this.Reg4_textBox);
            this.Controls.Add(this.Reg3_textBox);
            this.Controls.Add(this.Reg2_textBox);
            this.Controls.Add(this.Reg1_textBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.read_gpio_button);
            this.Controls.Add(this.NCHRG_ENABLE_checkBox);
            this.Controls.Add(this.DCDC_ENABLE_checkBox);
            this.Controls.Add(this.ENABLE_BAT_checkBox);
            this.Controls.Add(this.ENABLE_STK_checkbox);
            this.Controls.Add(this.ENABLE_MAINS_checkBox);
            this.Controls.Add(this.USB_EN_CheckBox);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.txtSendData);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.I_STK_textBox);
            this.Controls.Add(this.V_STK_textBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.V_STK);
            this.Controls.Add(this.I_BAT_textBox);
            this.Controls.Add(this.V_BAT_textBox);
            this.Controls.Add(this.EXT_5V_textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.menuStrip2);
            this.Name = "Form1";
            this.Text = "v";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chg_current_trackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem deviceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox txtSendData;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.CheckBox USB_EN_CheckBox;
        private System.Windows.Forms.CheckBox ENABLE_MAINS_checkBox;
        private System.Windows.Forms.CheckBox ENABLE_STK_checkbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EXT_5V_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label V_STK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox V_BAT_textBox;
        private System.Windows.Forms.TextBox V_STK_textBox;
        private System.Windows.Forms.TextBox I_STK_textBox;
        private System.Windows.Forms.TextBox I_BAT_textBox;
        private System.Windows.Forms.CheckBox ENABLE_BAT_checkBox;
        private System.Windows.Forms.CheckBox DCDC_ENABLE_checkBox;
        private System.Windows.Forms.CheckBox NCHRG_ENABLE_checkBox;
        private System.Windows.Forms.Button read_gpio_button;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Reg1_textBox;
        private System.Windows.Forms.TextBox Reg2_textBox;
        private System.Windows.Forms.TextBox Reg3_textBox;
        private System.Windows.Forms.TextBox Reg4_textBox;
        private System.Windows.Forms.Button batchg_r_button;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox VUSB_textBox;
        private System.Windows.Forms.Button Read_ADC_button;
        private System.Windows.Forms.TextBox DCDC_IN_textBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox Auto_Read_checkBox;
        private System.Windows.Forms.TextBox I_USB_textBox;
        private System.Windows.Forms.Label I_USB;
        private System.Windows.Forms.TextBox I_BOP_textBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox VBOP_textBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.CheckBox CARTRIDGE_PWR_checkBox;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox inlet_duty_textBox;
        private System.Windows.Forms.TextBox purge_duty_textBox;
        private System.Windows.Forms.CheckBox DIVIDER_MODE_SEL_checkBox;
        private System.Windows.Forms.CheckBox V_BAT_MEAS_EN_checkBox;
        private System.Windows.Forms.CheckBox HYDRATE_checkBox;
        private System.Windows.Forms.CheckBox RED_LED_checkBox;
        private System.Windows.Forms.CheckBox GREEN_LED_checkBox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox VDROP_textBox;
        private System.Windows.Forms.TextBox DAC1_textBox;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox PRESS_H2_textBox;
        private System.Windows.Forms.TextBox TEMP_STK_textBox;
        private System.Windows.Forms.Label TEMP_STK_label;
        private System.Windows.Forms.TextBox STAT_textBox;
        private System.Windows.Forms.TextBox fault_textBox;
        private System.Windows.Forms.ProgressBar V_BAT_prog;
        private System.Windows.Forms.TextBox W_BOP_textBox;
        private System.Windows.Forms.TextBox W_USB_textBox;
        private System.Windows.Forms.TextBox W_BAT_textBox;
        private System.Windows.Forms.TrackBar Chg_current_trackBar;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox chg_rate_textBox;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button Chr_rate_send_button;
        private System.Windows.Forms.TextBox Iin_limit_textBox;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.CheckBox EN_STAT_checkbox;
        private System.Windows.Forms.CheckBox EN_TERM_checkBox;
        private System.Windows.Forms.CheckBox nCH_checkBox;
    }
}

