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
        private PanelDB pnlGraphics;
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        /// 
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainfrm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnChangeWorldSize = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.worldY = new System.Windows.Forms.NumericUpDown();
            this.worldX = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.refresh = new System.Windows.Forms.NumericUpDown();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.startbtn = new System.Windows.Forms.ToolStripButton();
            this.stepbtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.savebtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.group_local_obs = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.obs_speed = new System.Windows.Forms.NumericUpDown();
            this.lbl_direction = new System.Windows.Forms.Label();
            this.btn_show_obs = new System.Windows.Forms.Button();
            this.local_obs_move_group = new System.Windows.Forms.GroupBox();
            this.dir_panel = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.obs_color = new System.Windows.Forms.Button();
            this.lbl_obs = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_localobs = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.state_chck_tofile = new System.Windows.Forms.CheckBox();
            this.lblstep3 = new System.Windows.Forms.Label();
            this.lblstep2 = new System.Windows.Forms.Label();
            this.lblstep1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.savestate = new System.Windows.Forms.NumericUpDown();
            this.state1 = new System.Windows.Forms.Button();
            this.state2 = new System.Windows.Forms.Button();
            this.state3 = new System.Windows.Forms.Button();
            this.panel = new SimpleFirstApp.PanelDB();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.group_function_entry = new System.Windows.Forms.GroupBox();
            this.function_entry_neigbour = new System.Windows.Forms.TextBox();
            this.function_entry_btn_insert = new System.Windows.Forms.Button();
            this.function_entry_was = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.function_entry_change_to = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.function_entry_list = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.n2_btn_set = new System.Windows.Forms.Button();
            this.n2_group = new System.Windows.Forms.GroupBox();
            this.n2_load_btn = new System.Windows.Forms.Button();
            this.n2_save_btn = new System.Windows.Forms.Button();
            this.n2_grid = new System.Windows.Forms.DataGridView();
            this.symbol_menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.n2_window_y = new System.Windows.Forms.NumericUpDown();
            this.n2_window_x = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.function_arguments_size = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.function_parametrs = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.func_remove = new System.Windows.Forms.Button();
            this.function_list = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.abc_del_symbol = new System.Windows.Forms.Button();
            this.abc_add_symbol = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.abc_btn_color = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.abc_symbol = new System.Windows.Forms.TextBox();
            this.abc_color_grid = new System.Windows.Forms.DataGridView();
            this.abc_col_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abc_col_symbol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abc_col_color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colordialog = new System.Windows.Forms.ColorDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.step_label = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_stat_cursor = new System.Windows.Forms.ToolStripStatusLabel();
            this.extra_status_lbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.playToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stepToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randomizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.grid_info_tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.worldY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.worldX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refresh)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.group_local_obs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obs_speed)).BeginInit();
            this.local_obs_move_group.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.savestate)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.group_function_entry.SuspendLayout();
            this.n2_group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.n2_grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.n2_window_y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.n2_window_x)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.function_arguments_size)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.abc_color_grid)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabControl1.Location = new System.Drawing.Point(12, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(780, 627);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnChangeWorldSize);
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Controls.Add(this.worldY);
            this.tabPage1.Controls.Add(this.worldX);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.refresh);
            this.tabPage1.Controls.Add(this.toolStrip1);
            this.tabPage1.Controls.Add(this.group_local_obs);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.panel);
            this.tabPage1.Controls.Add(this.checkBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(772, 598);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Grid";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Enter += new System.EventHandler(this.tabPage1_Enter);
            this.tabPage1.Leave += new System.EventHandler(this.tabPage1_Leave);
            // 
            // btnChangeWorldSize
            // 
            this.btnChangeWorldSize.Location = new System.Drawing.Point(185, 558);
            this.btnChangeWorldSize.Name = "btnChangeWorldSize";
            this.btnChangeWorldSize.Size = new System.Drawing.Size(75, 23);
            this.btnChangeWorldSize.TabIndex = 24;
            this.btnChangeWorldSize.Text = "Change";
            this.btnChangeWorldSize.UseVisualStyleBackColor = true;
            this.btnChangeWorldSize.Click += new System.EventHandler(this.btnChangeWorldSize_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 566);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(56, 13);
            this.label19.TabIndex = 23;
            this.label19.Text = "World size";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(117, 563);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(12, 13);
            this.label18.TabIndex = 22;
            this.label18.Text = "x";
            this.label18.Paint += new System.Windows.Forms.PaintEventHandler(this.x);
            // 
            // worldY
            // 
            this.worldY.Enabled = false;
            this.worldY.Location = new System.Drawing.Point(135, 561);
            this.worldY.Maximum = new decimal(new int[] {
            168,
            0,
            0,
            0});
            this.worldY.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.worldY.Name = "worldY";
            this.worldY.Size = new System.Drawing.Size(44, 20);
            this.worldY.TabIndex = 21;
            this.worldY.Value = new decimal(new int[] {
            101,
            0,
            0,
            0});
            // 
            // worldX
            // 
            this.worldX.Location = new System.Drawing.Point(68, 561);
            this.worldX.Maximum = new decimal(new int[] {
            168,
            0,
            0,
            0});
            this.worldX.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.worldX.Name = "worldX";
            this.worldX.Size = new System.Drawing.Size(43, 20);
            this.worldX.TabIndex = 20;
            this.worldX.Value = new decimal(new int[] {
            101,
            0,
            0,
            0});
            this.worldX.ValueChanged += new System.EventHandler(this.worldX_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(453, 532);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "ms";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(344, 532);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Refresh";
            // 
            // refresh
            // 
            this.refresh.Location = new System.Drawing.Point(394, 530);
            this.refresh.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.refresh.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(53, 20);
            this.refresh.TabIndex = 17;
            this.refresh.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.refresh.ValueChanged += new System.EventHandler(this.refresh_ValueChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startbtn,
            this.stepbtn,
            this.toolStripSeparator2,
            this.savebtn,
            this.toolStripButton1,
            this.toolStripButton4});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(6, 514);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(229, 25);
            this.toolStrip1.TabIndex = 11;
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
            // group_local_obs
            // 
            this.group_local_obs.Controls.Add(this.label13);
            this.group_local_obs.Controls.Add(this.numericUpDown1);
            this.group_local_obs.Controls.Add(this.label12);
            this.group_local_obs.Controls.Add(this.obs_speed);
            this.group_local_obs.Controls.Add(this.lbl_direction);
            this.group_local_obs.Controls.Add(this.btn_show_obs);
            this.group_local_obs.Controls.Add(this.local_obs_move_group);
            this.group_local_obs.Controls.Add(this.label11);
            this.group_local_obs.Controls.Add(this.obs_color);
            this.group_local_obs.Controls.Add(this.lbl_obs);
            this.group_local_obs.Controls.Add(this.label5);
            this.group_local_obs.Controls.Add(this.btn_localobs);
            this.group_local_obs.Location = new System.Drawing.Point(522, 399);
            this.group_local_obs.Name = "group_local_obs";
            this.group_local_obs.Size = new System.Drawing.Size(240, 193);
            this.group_local_obs.TabIndex = 11;
            this.group_local_obs.TabStop = false;
            this.group_local_obs.Text = "Local observer";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(140, 125);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(91, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "Information speed";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(187, 141);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(47, 20);
            this.numericUpDown1.TabIndex = 23;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(139, 71);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Speed";
            // 
            // obs_speed
            // 
            this.obs_speed.Location = new System.Drawing.Point(187, 64);
            this.obs_speed.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.obs_speed.Name = "obs_speed";
            this.obs_speed.Size = new System.Drawing.Size(47, 20);
            this.obs_speed.TabIndex = 21;
            this.obs_speed.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbl_direction
            // 
            this.lbl_direction.AutoSize = true;
            this.lbl_direction.Location = new System.Drawing.Point(140, 48);
            this.lbl_direction.Name = "lbl_direction";
            this.lbl_direction.Size = new System.Drawing.Size(24, 13);
            this.lbl_direction.TabIndex = 20;
            this.lbl_direction.Text = "0x0";
            // 
            // btn_show_obs
            // 
            this.btn_show_obs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_show_obs.Location = new System.Drawing.Point(142, 19);
            this.btn_show_obs.Name = "btn_show_obs";
            this.btn_show_obs.Size = new System.Drawing.Size(91, 23);
            this.btn_show_obs.TabIndex = 19;
            this.btn_show_obs.Text = "Show";
            this.toolTip1.SetToolTip(this.btn_show_obs, "Click on button, and then click on grid to set observer\r\nTo set god click again o" +
                    "n the button");
            this.btn_show_obs.UseVisualStyleBackColor = true;
            this.btn_show_obs.Click += new System.EventHandler(this.btn_show_obs_Click);
            // 
            // local_obs_move_group
            // 
            this.local_obs_move_group.Controls.Add(this.dir_panel);
            this.local_obs_move_group.Location = new System.Drawing.Point(9, 48);
            this.local_obs_move_group.Name = "local_obs_move_group";
            this.local_obs_move_group.Size = new System.Drawing.Size(125, 113);
            this.local_obs_move_group.TabIndex = 18;
            this.local_obs_move_group.TabStop = false;
            this.local_obs_move_group.Text = "Running";
            // 
            // dir_panel
            // 
            this.dir_panel.BackColor = System.Drawing.SystemColors.Window;
            this.dir_panel.Location = new System.Drawing.Point(15, 16);
            this.dir_panel.Name = "dir_panel";
            this.dir_panel.Size = new System.Drawing.Size(91, 91);
            this.dir_panel.TabIndex = 0;
            this.toolTip1.SetToolTip(this.dir_panel, "Click to set direction");
            this.dir_panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dir_panel_MouseDown);
            this.dir_panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dir_panel_MouseMove);
            this.dir_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.dir_panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dir_panel_MouseUp);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(140, 96);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Color";
            // 
            // obs_color
            // 
            this.obs_color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.obs_color.Location = new System.Drawing.Point(187, 92);
            this.obs_color.Name = "obs_color";
            this.obs_color.Size = new System.Drawing.Size(20, 20);
            this.obs_color.TabIndex = 7;
            this.obs_color.UseVisualStyleBackColor = true;
            this.obs_color.Click += new System.EventHandler(this.obs_color_Click);
            // 
            // lbl_obs
            // 
            this.lbl_obs.AutoSize = true;
            this.lbl_obs.Location = new System.Drawing.Point(90, 169);
            this.lbl_obs.Name = "lbl_obs";
            this.lbl_obs.Size = new System.Drawing.Size(25, 13);
            this.lbl_obs.TabIndex = 6;
            this.lbl_obs.Text = "god";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Local observer: ";
            // 
            // btn_localobs
            // 
            this.btn_localobs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_localobs.Location = new System.Drawing.Point(5, 19);
            this.btn_localobs.Name = "btn_localobs";
            this.btn_localobs.Size = new System.Drawing.Size(91, 23);
            this.btn_localobs.TabIndex = 4;
            this.btn_localobs.Text = "Set";
            this.toolTip1.SetToolTip(this.btn_localobs, "Click on button, and then click on grid to set observer\r\nTo set god click again o" +
                    "n the button");
            this.btn_localobs.UseVisualStyleBackColor = true;
            this.btn_localobs.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.state_chck_tofile);
            this.groupBox2.Controls.Add(this.lblstep3);
            this.groupBox2.Controls.Add(this.lblstep2);
            this.groupBox2.Controls.Add(this.lblstep1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.savestate);
            this.groupBox2.Controls.Add(this.state1);
            this.groupBox2.Controls.Add(this.state2);
            this.groupBox2.Controls.Add(this.state3);
            this.groupBox2.Location = new System.Drawing.Point(522, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(240, 387);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Step preview";
            // 
            // state_chck_tofile
            // 
            this.state_chck_tofile.AutoSize = true;
            this.state_chck_tofile.Location = new System.Drawing.Point(143, 359);
            this.state_chck_tofile.Name = "state_chck_tofile";
            this.state_chck_tofile.Size = new System.Drawing.Size(79, 17);
            this.state_chck_tofile.TabIndex = 15;
            this.state_chck_tofile.Text = "Save to file";
            this.state_chck_tofile.UseVisualStyleBackColor = true;
            this.state_chck_tofile.CheckStateChanged += new System.EventHandler(this.state_chck_tofile_CheckStateChanged);
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
            // 
            // savestate
            // 
            this.savestate.Location = new System.Drawing.Point(6, 359);
            this.savestate.Name = "savestate";
            this.savestate.Size = new System.Drawing.Size(90, 20);
            this.savestate.TabIndex = 9;
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
            // panel
            // 
            this.panel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.Location = new System.Drawing.Point(6, 6);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(505, 505);
            this.panel.TabIndex = 3;
            this.toolTip1.SetToolTip(this.panel, "Left button - put selected symbol\r\nRight button - choose symbol");
            this.panel.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.panel_PreviewKeyDown);
            this.panel.Click += new System.EventHandler(this.panel_Click);
            this.panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_MouseDown);
            this.panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_MouseMove);
            this.panel.ContextMenuStripChanged += new System.EventHandler(this.panel_ContextMenuStripChanged);
            this.panel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel_MouseClick);
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            this.panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_MouseUp);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(9, 540);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(73, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Show grid";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Click += new System.EventHandler(this.checkBox1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.group_function_entry);
            this.tabPage2.Controls.Add(this.n2_btn_set);
            this.tabPage2.Controls.Add(this.n2_group);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(772, 598);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Function";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // group_function_entry
            // 
            this.group_function_entry.Controls.Add(this.function_entry_neigbour);
            this.group_function_entry.Controls.Add(this.function_entry_btn_insert);
            this.group_function_entry.Controls.Add(this.function_entry_was);
            this.group_function_entry.Controls.Add(this.label15);
            this.group_function_entry.Controls.Add(this.function_entry_change_to);
            this.group_function_entry.Controls.Add(this.label14);
            this.group_function_entry.Controls.Add(this.function_entry_list);
            this.group_function_entry.Controls.Add(this.label10);
            this.group_function_entry.Location = new System.Drawing.Point(6, 6);
            this.group_function_entry.Name = "group_function_entry";
            this.group_function_entry.Size = new System.Drawing.Size(256, 230);
            this.group_function_entry.TabIndex = 4;
            this.group_function_entry.TabStop = false;
            this.group_function_entry.Text = "Function entry";
            // 
            // function_entry_neigbour
            // 
            this.function_entry_neigbour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.function_entry_neigbour.Location = new System.Drawing.Point(67, 26);
            this.function_entry_neigbour.Multiline = true;
            this.function_entry_neigbour.Name = "function_entry_neigbour";
            this.function_entry_neigbour.Size = new System.Drawing.Size(121, 20);
            this.function_entry_neigbour.TabIndex = 14;
            this.function_entry_neigbour.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // function_entry_btn_insert
            // 
            this.function_entry_btn_insert.Location = new System.Drawing.Point(7, 188);
            this.function_entry_btn_insert.Name = "function_entry_btn_insert";
            this.function_entry_btn_insert.Size = new System.Drawing.Size(103, 30);
            this.function_entry_btn_insert.TabIndex = 12;
            this.function_entry_btn_insert.Text = "Insert";
            this.function_entry_btn_insert.UseVisualStyleBackColor = true;
            this.function_entry_btn_insert.Click += new System.EventHandler(this.function_entry_btn_insert_Click);
            // 
            // function_entry_was
            // 
            this.function_entry_was.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.function_entry_was.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.function_entry_was.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.function_entry_was.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.function_entry_was.FormattingEnabled = true;
            this.function_entry_was.Location = new System.Drawing.Point(67, 49);
            this.function_entry_was.Name = "function_entry_was";
            this.function_entry_was.Size = new System.Drawing.Size(121, 21);
            this.function_entry_was.TabIndex = 11;
            this.function_entry_was.SelectionChangeCommitted += new System.EventHandler(this.function_entry_was_SelectionChangeCommitted);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 84);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(55, 13);
            this.label15.TabIndex = 10;
            this.label15.Text = "change to";
            // 
            // function_entry_change_to
            // 
            this.function_entry_change_to.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.function_entry_change_to.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.function_entry_change_to.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.function_entry_change_to.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.function_entry_change_to.FormattingEnabled = true;
            this.function_entry_change_to.Location = new System.Drawing.Point(67, 76);
            this.function_entry_change_to.Name = "function_entry_change_to";
            this.function_entry_change_to.Size = new System.Drawing.Size(121, 21);
            this.function_entry_change_to.TabIndex = 9;
            this.function_entry_change_to.SelectionChangeCommitted += new System.EventHandler(this.function_entry_change_to_SelectionChangeCommitted);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 57);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 13);
            this.label14.TabIndex = 8;
            this.label14.Text = "was:";
            // 
            // function_entry_list
            // 
            this.function_entry_list.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.function_entry_list.FormattingEnabled = true;
            this.function_entry_list.HorizontalScrollbar = true;
            this.function_entry_list.Location = new System.Drawing.Point(6, 115);
            this.function_entry_list.Name = "function_entry_list";
            this.function_entry_list.Size = new System.Drawing.Size(244, 67);
            this.function_entry_list.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Neigbours";
            // 
            // n2_btn_set
            // 
            this.n2_btn_set.Location = new System.Drawing.Point(6, 557);
            this.n2_btn_set.Name = "n2_btn_set";
            this.n2_btn_set.Size = new System.Drawing.Size(75, 23);
            this.n2_btn_set.TabIndex = 9;
            this.n2_btn_set.Text = "Set it";
            this.n2_btn_set.UseVisualStyleBackColor = true;
            this.n2_btn_set.Click += new System.EventHandler(this.n2_btn_set_Click);
            // 
            // n2_group
            // 
            this.n2_group.Controls.Add(this.n2_load_btn);
            this.n2_group.Controls.Add(this.n2_save_btn);
            this.n2_group.Controls.Add(this.n2_grid);
            this.n2_group.Controls.Add(this.n2_window_y);
            this.n2_group.Controls.Add(this.n2_window_x);
            this.n2_group.Controls.Add(this.label9);
            this.n2_group.Controls.Add(this.label8);
            this.n2_group.Cursor = System.Windows.Forms.Cursors.Default;
            this.n2_group.Location = new System.Drawing.Point(268, 6);
            this.n2_group.Name = "n2_group";
            this.n2_group.Size = new System.Drawing.Size(498, 545);
            this.n2_group.TabIndex = 3;
            this.n2_group.TabStop = false;
            this.n2_group.Text = "Neighbours";
            this.n2_group.Enter += new System.EventHandler(this.n2_group_Enter);
            // 
            // n2_load_btn
            // 
            this.n2_load_btn.Location = new System.Drawing.Point(87, 499);
            this.n2_load_btn.Name = "n2_load_btn";
            this.n2_load_btn.Size = new System.Drawing.Size(75, 23);
            this.n2_load_btn.TabIndex = 9;
            this.n2_load_btn.Text = "Load";
            this.n2_load_btn.UseVisualStyleBackColor = true;
            this.n2_load_btn.Click += new System.EventHandler(this.n2_load_btn_Click);
            // 
            // n2_save_btn
            // 
            this.n2_save_btn.Location = new System.Drawing.Point(6, 499);
            this.n2_save_btn.Name = "n2_save_btn";
            this.n2_save_btn.Size = new System.Drawing.Size(75, 23);
            this.n2_save_btn.TabIndex = 8;
            this.n2_save_btn.Text = "Save";
            this.n2_save_btn.UseVisualStyleBackColor = true;
            this.n2_save_btn.Click += new System.EventHandler(this.n2_save_btn_Click);
            // 
            // n2_grid
            // 
            this.n2_grid.AllowDrop = true;
            this.n2_grid.AllowUserToAddRows = false;
            this.n2_grid.AllowUserToDeleteRows = false;
            this.n2_grid.AllowUserToResizeColumns = false;
            this.n2_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.n2_grid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.n2_grid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.n2_grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.n2_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.n2_grid.ColumnHeadersVisible = false;
            this.n2_grid.ContextMenuStrip = this.symbol_menu;
            this.n2_grid.Location = new System.Drawing.Point(9, 52);
            this.n2_grid.Name = "n2_grid";
            this.n2_grid.RowHeadersVisible = false;
            this.n2_grid.Size = new System.Drawing.Size(474, 417);
            this.n2_grid.TabIndex = 7;
            this.n2_grid.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.n2_grid_CellLeave);
            this.n2_grid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.n2_grid_CellClick);
            this.n2_grid.Leave += new System.EventHandler(this.n2_grid_Leave);
            this.n2_grid.ContextMenuStripChanged += new System.EventHandler(this.n2_grid_ContextMenuStripChanged);
            this.n2_grid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.n2_grid_CellLeave);
            // 
            // symbol_menu
            // 
            this.symbol_menu.MaximumSize = new System.Drawing.Size(0, 500);
            this.symbol_menu.Name = "symbol_menu";
            this.symbol_menu.Size = new System.Drawing.Size(61, 4);
            this.symbol_menu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.symbol_menu_ItemClicked);
            // 
            // n2_window_y
            // 
            this.n2_window_y.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.n2_window_y.Location = new System.Drawing.Point(156, 26);
            this.n2_window_y.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.n2_window_y.Name = "n2_window_y";
            this.n2_window_y.Size = new System.Drawing.Size(45, 20);
            this.n2_window_y.TabIndex = 6;
            this.n2_window_y.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.n2_window_y.ValueChanged += new System.EventHandler(this.n2_window_y_ValueChanged);
            // 
            // n2_window_x
            // 
            this.n2_window_x.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.n2_window_x.Location = new System.Drawing.Point(82, 26);
            this.n2_window_x.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.n2_window_x.Name = "n2_window_x";
            this.n2_window_x.Size = new System.Drawing.Size(50, 20);
            this.n2_window_x.TabIndex = 5;
            this.n2_window_x.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.n2_window_x.ValueChanged += new System.EventHandler(this.n2_window_x_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(138, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(12, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "x";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Window size:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.function_arguments_size);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.function_parametrs);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.func_remove);
            this.groupBox4.Controls.Add(this.function_list);
            this.groupBox4.Location = new System.Drawing.Point(6, 242);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(256, 309);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Function";
            // 
            // function_arguments_size
            // 
            this.function_arguments_size.Location = new System.Drawing.Point(105, 228);
            this.function_arguments_size.Maximum = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.function_arguments_size.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.function_arguments_size.Name = "function_arguments_size";
            this.function_arguments_size.Size = new System.Drawing.Size(45, 20);
            this.function_arguments_size.TabIndex = 15;
            this.function_arguments_size.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.function_arguments_size.ValueChanged += new System.EventHandler(this.function_arguments_size_ValueChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 230);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(93, 13);
            this.label17.TabIndex = 14;
            this.label17.Text = "Function variables";
            // 
            // function_parametrs
            // 
            this.function_parametrs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.function_parametrs.Location = new System.Drawing.Point(6, 32);
            this.function_parametrs.Name = "function_parametrs";
            this.function_parametrs.Size = new System.Drawing.Size(244, 20);
            this.function_parametrs.TabIndex = 13;
            this.function_parametrs.Leave += new System.EventHandler(this.function_parametrs_Leave);
            this.function_parametrs.TextChanged += new System.EventHandler(this.function_parametrs_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(3, 16);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(63, 13);
            this.label16.TabIndex = 12;
            this.label16.Text = "Paramtrs list";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(152, 263);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Load";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(81, 263);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // func_remove
            // 
            this.func_remove.Location = new System.Drawing.Point(10, 263);
            this.func_remove.Name = "func_remove";
            this.func_remove.Size = new System.Drawing.Size(65, 23);
            this.func_remove.TabIndex = 11;
            this.func_remove.Text = "Remove";
            this.func_remove.UseVisualStyleBackColor = true;
            this.func_remove.Click += new System.EventHandler(this.func_remove_Click);
            // 
            // function_list
            // 
            this.function_list.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.function_list.FormattingEnabled = true;
            this.function_list.HorizontalScrollbar = true;
            this.function_list.Location = new System.Drawing.Point(6, 58);
            this.function_list.Name = "function_list";
            this.function_list.Size = new System.Drawing.Size(243, 158);
            this.function_list.TabIndex = 0;
            this.function_list.SelectedIndexChanged += new System.EventHandler(this.function_list_Click);
            this.function_list.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.function_list_MeasureItem);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(772, 598);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Other";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.abc_del_symbol);
            this.groupBox1.Controls.Add(this.abc_add_symbol);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.abc_btn_color);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.abc_symbol);
            this.groupBox1.Controls.Add(this.abc_color_grid);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 579);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alphabet";
            // 
            // abc_del_symbol
            // 
            this.abc_del_symbol.Enabled = false;
            this.abc_del_symbol.Location = new System.Drawing.Point(133, 95);
            this.abc_del_symbol.Name = "abc_del_symbol";
            this.abc_del_symbol.Size = new System.Drawing.Size(74, 23);
            this.abc_del_symbol.TabIndex = 6;
            this.abc_del_symbol.Text = "Remove";
            this.abc_del_symbol.UseVisualStyleBackColor = true;
            this.abc_del_symbol.Click += new System.EventHandler(this.abc_del_symbol_Click);
            // 
            // abc_add_symbol
            // 
            this.abc_add_symbol.Location = new System.Drawing.Point(6, 95);
            this.abc_add_symbol.Name = "abc_add_symbol";
            this.abc_add_symbol.Size = new System.Drawing.Size(78, 23);
            this.abc_add_symbol.TabIndex = 5;
            this.abc_add_symbol.Text = "Add";
            this.abc_add_symbol.UseVisualStyleBackColor = true;
            this.abc_add_symbol.Click += new System.EventHandler(this.abc_add_symbol_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Color: ";
            // 
            // abc_btn_color
            // 
            this.abc_btn_color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.abc_btn_color.Location = new System.Drawing.Point(56, 57);
            this.abc_btn_color.Name = "abc_btn_color";
            this.abc_btn_color.Size = new System.Drawing.Size(20, 20);
            this.abc_btn_color.TabIndex = 3;
            this.abc_btn_color.UseVisualStyleBackColor = true;
            this.abc_btn_color.Click += new System.EventHandler(this.abc_btn_color_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Symbol:";
            // 
            // abc_symbol
            // 
            this.abc_symbol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.abc_symbol.Location = new System.Drawing.Point(56, 31);
            this.abc_symbol.MaxLength = 2;
            this.abc_symbol.Name = "abc_symbol";
            this.abc_symbol.Size = new System.Drawing.Size(48, 20);
            this.abc_symbol.TabIndex = 1;
            // 
            // abc_color_grid
            // 
            this.abc_color_grid.AllowUserToAddRows = false;
            this.abc_color_grid.AllowUserToResizeColumns = false;
            this.abc_color_grid.AllowUserToResizeRows = false;
            this.abc_color_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.abc_color_grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.abc_col_int,
            this.abc_col_symbol,
            this.abc_col_color});
            this.abc_color_grid.Location = new System.Drawing.Point(6, 134);
            this.abc_color_grid.MultiSelect = false;
            this.abc_color_grid.Name = "abc_color_grid";
            this.abc_color_grid.RowHeadersVisible = false;
            this.abc_color_grid.RowTemplate.Height = 18;
            this.abc_color_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.abc_color_grid.Size = new System.Drawing.Size(201, 439);
            this.abc_color_grid.TabIndex = 0;
            this.abc_color_grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.abc_color_grid_CellClick);
            // 
            // abc_col_int
            // 
            this.abc_col_int.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.abc_col_int.HeaderText = "Number";
            this.abc_col_int.Name = "abc_col_int";
            this.abc_col_int.Width = 73;
            // 
            // abc_col_symbol
            // 
            this.abc_col_symbol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.abc_col_symbol.HeaderText = "Symbol";
            this.abc_col_symbol.Name = "abc_col_symbol";
            this.abc_col_symbol.Width = 70;
            // 
            // abc_col_color
            // 
            this.abc_col_color.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.abc_col_color.HeaderText = "Color";
            this.abc_col_color.Name = "abc_col_color";
            this.abc_col_color.Width = 60;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.step_label,
            this.toolStripStatusLabel2,
            this.lbl_stat_cursor,
            this.extra_status_lbl});
            this.statusStrip1.Location = new System.Drawing.Point(0, 658);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(799, 22);
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
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(43, 17);
            this.toolStripStatusLabel2.Text = "Cursor:";
            this.toolStripStatusLabel2.Click += new System.EventHandler(this.toolStripStatusLabel2_Click);
            // 
            // lbl_stat_cursor
            // 
            this.lbl_stat_cursor.Name = "lbl_stat_cursor";
            this.lbl_stat_cursor.Size = new System.Drawing.Size(25, 17);
            this.lbl_stat_cursor.Text = "0x0";
            // 
            // extra_status_lbl
            // 
            this.extra_status_lbl.Name = "extra_status_lbl";
            this.extra_status_lbl.Size = new System.Drawing.Size(109, 17);
            this.extra_status_lbl.Text = "toolStripStatusLabel3";
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
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.gameToolStripMenuItem1,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(799, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.gameToolStripMenuItem.Text = "World";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.toolStripButton6_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(110, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // gameToolStripMenuItem1
            // 
            this.gameToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playToolStripMenuItem,
            this.pauseToolStripMenuItem,
            this.stepToolStripMenuItem,
            this.toolStripMenuItem2,
            this.resetToolStripMenuItem,
            this.randomizeToolStripMenuItem});
            this.gameToolStripMenuItem1.Name = "gameToolStripMenuItem1";
            this.gameToolStripMenuItem1.Size = new System.Drawing.Size(46, 20);
            this.gameToolStripMenuItem1.Text = "Game";
            // 
            // playToolStripMenuItem
            // 
            this.playToolStripMenuItem.Name = "playToolStripMenuItem";
            this.playToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.playToolStripMenuItem.Text = "Play";
            this.playToolStripMenuItem.Click += new System.EventHandler(this.startbtn_Click);
            // 
            // pauseToolStripMenuItem
            // 
            this.pauseToolStripMenuItem.Name = "pauseToolStripMenuItem";
            this.pauseToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.pauseToolStripMenuItem.Text = "Pause";
            this.pauseToolStripMenuItem.Click += new System.EventHandler(this.startbtn_Click);
            // 
            // stepToolStripMenuItem
            // 
            this.stepToolStripMenuItem.Name = "stepToolStripMenuItem";
            this.stepToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.stepToolStripMenuItem.Text = "Step";
            this.stepToolStripMenuItem.Click += new System.EventHandler(this.stepbtn_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(134, 6);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.resetToolStripMenuItem.Text = "Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // randomizeToolStripMenuItem
            // 
            this.randomizeToolStripMenuItem.Name = "randomizeToolStripMenuItem";
            this.randomizeToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.randomizeToolStripMenuItem.Text = "Randomize";
            this.randomizeToolStripMenuItem.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.aboutToolStripMenuItem1});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(111, 6);
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(114, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // grid_info_tooltip
            // 
            this.grid_info_tooltip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // mainfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 680);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(807, 707);
            this.Name = "mainfrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Krowka v0.1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.mainfrm_FormClosed);
            this.Resize += new System.EventHandler(this.mainfrm_Resize);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mainfrm_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.mainfrm_KeyUp);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mainfrm_MouseMove);
            this.Load += new System.EventHandler(this.mainfrm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.worldY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.worldX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refresh)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.group_local_obs.ResumeLayout(false);
            this.group_local_obs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obs_speed)).EndInit();
            this.local_obs_move_group.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.savestate)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.group_function_entry.ResumeLayout(false);
            this.group_function_entry.PerformLayout();
            this.n2_group.ResumeLayout(false);
            this.n2_group.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.n2_grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.n2_window_y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.n2_window_x)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.function_arguments_size)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.abc_color_grid)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox group_local_obs;
        private System.Windows.Forms.ColorDialog colordialog;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel step_label;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ListBox function_list;
        private System.Windows.Forms.Button func_remove;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog2;
        private System.Windows.Forms.Button btn_localobs;
        private System.Windows.Forms.Label lbl_obs;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem playToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pauseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stepToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randomizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button obs_color;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblstep3;
        private System.Windows.Forms.Label lblstep2;
        private System.Windows.Forms.Label lblstep1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.NumericUpDown savestate;
        private System.Windows.Forms.Button state1;
        private System.Windows.Forms.Button state2;
        private System.Windows.Forms.Button state3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton startbtn;
        private System.Windows.Forms.ToolStripButton stepbtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton savebtn;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.Button btn_show_obs;
        private System.Windows.Forms.GroupBox local_obs_move_group;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel lbl_stat_cursor;
        private System.Windows.Forms.Panel dir_panel;
        private System.Windows.Forms.Label lbl_direction;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown obs_speed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown refresh;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.GroupBox n2_group;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox group_function_entry;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button function_entry_btn_insert;
        private System.Windows.Forms.ComboBox function_entry_was;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox function_entry_change_to;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ListBox function_entry_list;
        private System.Windows.Forms.TextBox function_parametrs;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox function_entry_neigbour;
        private System.Windows.Forms.NumericUpDown n2_window_y;
        private System.Windows.Forms.NumericUpDown n2_window_x;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button abc_del_symbol;
        private System.Windows.Forms.Button abc_add_symbol;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button abc_btn_color;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox abc_symbol;
        private System.Windows.Forms.DataGridView abc_color_grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn abc_col_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn abc_col_symbol;
        private System.Windows.Forms.DataGridViewTextBoxColumn abc_col_color;
        private System.Windows.Forms.DataGridView n2_grid;
        private System.Windows.Forms.Button n2_btn_set;
        private System.Windows.Forms.ContextMenuStrip symbol_menu;
        private System.Windows.Forms.ToolStripStatusLabel extra_status_lbl;
        private System.Windows.Forms.NumericUpDown function_arguments_size;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button n2_load_btn;
        private System.Windows.Forms.Button n2_save_btn;
        private PanelDB panel;
        private System.Windows.Forms.CheckBox state_chck_tofile;
        private System.Windows.Forms.ToolTip grid_info_tooltip;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.NumericUpDown worldY;
        private System.Windows.Forms.NumericUpDown worldX;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnChangeWorldSize;
    }
}

