namespace SimpleFirstApp
{
    partial class mainfrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainfrm));
            this.panel = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.startbtn = new System.Windows.Forms.ToolStripButton();
            this.stepbtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.savebtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.state1 = new System.Windows.Forms.Button();
            this.state2 = new System.Windows.Forms.Button();
            this.state3 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.func_add = new System.Windows.Forms.Button();
            this.cell_next_on = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cell_on = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.function_list = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.enabledcolor = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblstep3 = new System.Windows.Forms.Label();
            this.lblstep2 = new System.Windows.Forms.Label();
            this.lblstep1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.savestate = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.refresh = new System.Windows.Forms.NumericUpDown();
            this.colordialog = new System.Windows.Forms.ColorDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.step_label = new System.Windows.Forms.ToolStripStatusLabel();
            this.func_remove = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.neighbours_count = new System.Windows.Forms.NumericUpDown();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            this.toolStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.savestate)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refresh)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.neighbours_count)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel.Location = new System.Drawing.Point(6, 6);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(500, 500);
            this.panel.TabIndex = 3;
            this.panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_MouseDown);
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            this.panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_MouseUp);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startbtn,
            this.stepbtn,
            this.toolStripSeparator2,
            this.savebtn,
            this.toolStripButton1,
            this.toolStripButton4,
            this.toolStripSeparator3,
            this.toolStripButton6,
            this.toolStripButton5,
            this.toolStripSeparator1,
            this.toolStripButton3,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(707, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // startbtn
            // 
            this.startbtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.startbtn.Image = ((System.Drawing.Image)(resources.GetObject("startbtn.Image")));
            this.startbtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.startbtn.Name = "startbtn";
            this.startbtn.Size = new System.Drawing.Size(35, 22);
            this.startbtn.Text = "Start";
            this.startbtn.Click += new System.EventHandler(this.startbtn_Click);
            // 
            // stepbtn
            // 
            this.stepbtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.stepbtn.Image = ((System.Drawing.Image)(resources.GetObject("stepbtn.Image")));
            this.stepbtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stepbtn.Name = "stepbtn";
            this.stepbtn.Size = new System.Drawing.Size(33, 22);
            this.stepbtn.Text = "Step";
            this.stepbtn.Click += new System.EventHandler(this.stepbtn_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // savebtn
            // 
            this.savebtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.savebtn.Image = ((System.Drawing.Image)(resources.GetObject("savebtn.Image")));
            this.savebtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(63, 22);
            this.savebtn.Text = "Save state";
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(50, 22);
            this.toolStripButton1.Text = "Random";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(39, 22);
            this.toolStripButton4.Text = "Reset";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(40, 22);
            this.toolStripButton3.Text = "About";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(29, 22);
            this.toolStripButton2.Text = "Exit";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // state1
            // 
            this.state1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.state1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.state1.Location = new System.Drawing.Point(45, 19);
            this.state1.Name = "state1";
            this.state1.Size = new System.Drawing.Size(100, 100);
            this.state1.TabIndex = 6;
            this.state1.UseVisualStyleBackColor = false;
            this.state1.Click += new System.EventHandler(this.state1_Click);
            this.state1.Paint += new System.Windows.Forms.PaintEventHandler(this.state1_Paint);
            // 
            // state2
            // 
            this.state2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.state2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.state2.Location = new System.Drawing.Point(45, 125);
            this.state2.Name = "state2";
            this.state2.Size = new System.Drawing.Size(100, 100);
            this.state2.TabIndex = 7;
            this.state2.UseVisualStyleBackColor = false;
            this.state2.Click += new System.EventHandler(this.state2_Click);
            this.state2.Paint += new System.Windows.Forms.PaintEventHandler(this.state2_Paint);
            // 
            // state3
            // 
            this.state3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.state3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.state3.Location = new System.Drawing.Point(45, 231);
            this.state3.Name = "state3";
            this.state3.Size = new System.Drawing.Size(100, 100);
            this.state3.TabIndex = 8;
            this.state3.UseVisualStyleBackColor = false;
            this.state3.Click += new System.EventHandler(this.state3_Click);
            this.state3.Paint += new System.Windows.Forms.PaintEventHandler(this.state3_Paint);
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabControl1.Location = new System.Drawing.Point(12, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(532, 554);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(524, 525);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Grid";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(524, 525);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Settings";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.neighbours_count);
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.func_remove);
            this.groupBox4.Controls.Add(this.func_add);
            this.groupBox4.Controls.Add(this.cell_next_on);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.cell_on);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.function_list);
            this.groupBox4.Location = new System.Drawing.Point(16, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(206, 377);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Function";
            // 
            // func_add
            // 
            this.func_add.Location = new System.Drawing.Point(38, 100);
            this.func_add.Name = "func_add";
            this.func_add.Size = new System.Drawing.Size(60, 26);
            this.func_add.TabIndex = 7;
            this.func_add.Text = "Add";
            this.func_add.UseVisualStyleBackColor = true;
            this.func_add.Click += new System.EventHandler(this.add_def_Click);
            // 
            // cell_next_on
            // 
            this.cell_next_on.AutoSize = true;
            this.cell_next_on.Checked = true;
            this.cell_next_on.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cell_next_on.Location = new System.Drawing.Point(129, 73);
            this.cell_next_on.Name = "cell_next_on";
            this.cell_next_on.Size = new System.Drawing.Size(32, 17);
            this.cell_next_on.TabIndex = 6;
            this.cell_next_on.Text = "1";
            this.cell_next_on.UseVisualStyleBackColor = true;
            this.cell_next_on.CheckedChanged += new System.EventHandler(this.cell_next_on_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Switch to";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Neighbours";
            // 
            // cell_on
            // 
            this.cell_on.AutoSize = true;
            this.cell_on.Location = new System.Drawing.Point(90, 73);
            this.cell_on.Name = "cell_on";
            this.cell_on.Size = new System.Drawing.Size(32, 17);
            this.cell_on.TabIndex = 2;
            this.cell_on.Text = "0";
            this.cell_on.UseVisualStyleBackColor = true;
            this.cell_on.CheckedChanged += new System.EventHandler(this.cell_on_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Cell was";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // function_list
            // 
            this.function_list.FormattingEnabled = true;
            this.function_list.Items.AddRange(new object[] {
            "2: 10",
            "3: 11"});
            this.function_list.Location = new System.Drawing.Point(38, 136);
            this.function_list.Name = "function_list";
            this.function_list.Size = new System.Drawing.Size(129, 160);
            this.function_list.TabIndex = 0;
            this.function_list.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.function_list_MeasureItem);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Cell color";
            // 
            // enabledcolor
            // 
            this.enabledcolor.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.enabledcolor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enabledcolor.Location = new System.Drawing.Point(9, 90);
            this.enabledcolor.Name = "enabledcolor";
            this.enabledcolor.Size = new System.Drawing.Size(16, 16);
            this.enabledcolor.TabIndex = 1;
            this.enabledcolor.UseVisualStyleBackColor = false;
            this.enabledcolor.Click += new System.EventHandler(this.enabledcolor_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(9, 67);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(73, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Show grid";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Click += new System.EventHandler(this.checkBox1_Click);
            this.checkBox1.EnabledChanged += new System.EventHandler(this.checkBox1_EnabledChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblstep3);
            this.groupBox2.Controls.Add(this.lblstep2);
            this.groupBox2.Controls.Add(this.lblstep1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.savestate);
            this.groupBox2.Controls.Add(this.state1);
            this.groupBox2.Controls.Add(this.state2);
            this.groupBox2.Controls.Add(this.state3);
            this.groupBox2.Location = new System.Drawing.Point(550, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(157, 390);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Step preview";
            // 
            // lblstep3
            // 
            this.lblstep3.AutoSize = true;
            this.lblstep3.Location = new System.Drawing.Point(14, 275);
            this.lblstep3.Name = "lblstep3";
            this.lblstep3.Size = new System.Drawing.Size(13, 13);
            this.lblstep3.TabIndex = 14;
            this.lblstep3.Text = "0";
            // 
            // lblstep2
            // 
            this.lblstep2.AutoSize = true;
            this.lblstep2.Location = new System.Drawing.Point(14, 169);
            this.lblstep2.Name = "lblstep2";
            this.lblstep2.Size = new System.Drawing.Size(13, 13);
            this.lblstep2.TabIndex = 13;
            this.lblstep2.Text = "0";
            // 
            // lblstep1
            // 
            this.lblstep1.AutoSize = true;
            this.lblstep1.Location = new System.Drawing.Point(14, 63);
            this.lblstep1.Name = "lblstep1";
            this.lblstep1.Size = new System.Drawing.Size(13, 13);
            this.lblstep1.TabIndex = 12;
            this.lblstep1.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 361);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "step";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 343);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Save state every:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // savestate
            // 
            this.savestate.Location = new System.Drawing.Point(6, 359);
            this.savestate.Name = "savestate";
            this.savestate.Size = new System.Drawing.Size(90, 20);
            this.savestate.TabIndex = 9;
            this.savestate.ValueChanged += new System.EventHandler(this.savestate_ValueChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.enabledcolor);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Controls.Add(this.refresh);
            this.groupBox3.Location = new System.Drawing.Point(552, 449);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(154, 129);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "View";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(100, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "ms";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Refresh";
            // 
            // refresh
            // 
            this.refresh.Location = new System.Drawing.Point(6, 32);
            this.refresh.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(88, 20);
            this.refresh.TabIndex = 0;
            this.refresh.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.refresh.ValueChanged += new System.EventHandler(this.refresh_ValueChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.step_label});
            this.statusStrip1.Location = new System.Drawing.Point(0, 587);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(707, 22);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(36, 17);
            this.toolStripStatusLabel1.Text = "Step: ";
            // 
            // step_label
            // 
            this.step_label.Name = "step_label";
            this.step_label.Size = new System.Drawing.Size(42, 17);
            this.step_label.Text = "kljlkjlkjlj";
            // 
            // func_remove
            // 
            this.func_remove.Location = new System.Drawing.Point(107, 100);
            this.func_remove.Name = "func_remove";
            this.func_remove.Size = new System.Drawing.Size(60, 26);
            this.func_remove.TabIndex = 11;
            this.func_remove.Text = "Remove";
            this.func_remove.UseVisualStyleBackColor = true;
            this.func_remove.Click += new System.EventHandler(this.func_remove_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(87, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(126, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "0";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Function file (*.txt)|*.txt|All files|*.*";
            this.openFileDialog1.Title = "Wybierz plik";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            this.saveFileDialog1.Filter = "Function file (*.txt)|*.txt|All files (*.*)|*.*";
            this.saveFileDialog1.Title = "Save function";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 305);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 26);
            this.button1.TabIndex = 8;
            this.button1.Text = "Save...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(107, 305);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 26);
            this.button2.TabIndex = 9;
            this.button2.Text = "Load...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // neighbours_count
            // 
            this.neighbours_count.Location = new System.Drawing.Point(90, 18);
            this.neighbours_count.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.neighbours_count.Name = "neighbours_count";
            this.neighbours_count.Size = new System.Drawing.Size(77, 20);
            this.neighbours_count.TabIndex = 14;
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(46, 22);
            this.toolStripButton5.Text = "Load...";
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(47, 22);
            this.toolStripButton6.Text = "Save...";
            this.toolStripButton6.Click += new System.EventHandler(this.toolStripButton6_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            this.openFileDialog2.Filter = "Grid file (*.txt)|*.txt";
            this.openFileDialog2.Title = "Load grid";
            this.openFileDialog2.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog2_FileOk);
            // 
            // saveFileDialog2
            // 
            this.saveFileDialog2.DefaultExt = "txt";
            this.saveFileDialog2.Filter = "Grid file (*.txt)|*.txt";
            this.saveFileDialog2.Title = "Save grid";
            this.saveFileDialog2.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog2_FileOk);
            // 
            // mainfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 609);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "mainfrm";
            this.Text = "Krowka v0.1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.mainfrm_FormClosed);
            this.Load += new System.EventHandler(this.mainfrm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.savestate)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refresh)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.neighbours_count)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton startbtn;
        private System.Windows.Forms.ToolStripButton stepbtn;
        private System.Windows.Forms.ToolStripButton savebtn;
        private System.Windows.Forms.Button state1;
        private System.Windows.Forms.Button state2;
        private System.Windows.Forms.Button state3;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown savestate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button enabledcolor;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown refresh;
        private System.Windows.Forms.ColorDialog colordialog;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel step_label;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox function_list;
        private System.Windows.Forms.CheckBox cell_next_on;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox cell_on;
        private System.Windows.Forms.Button func_add;
        private System.Windows.Forms.Label lblstep3;
        private System.Windows.Forms.Label lblstep2;
        private System.Windows.Forms.Label lblstep1;
        private System.Windows.Forms.Button func_remove;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown neighbours_count;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog2;
    }
}

