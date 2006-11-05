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
            this.savebtn = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveStateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restoreStateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.state1 = new System.Windows.Forms.Button();
            this.state2 = new System.Windows.Forms.Button();
            this.state3 = new System.Windows.Forms.Button();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel.Location = new System.Drawing.Point(12, 55);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(300, 300);
            this.panel.TabIndex = 3;
            this.panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_MouseDown);
            this.panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_MouseMove);
            this.panel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel_MouseClick);
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            this.panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_MouseUp);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startbtn,
            this.stepbtn,
            this.savebtn,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(473, 25);
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
            // 
            // savebtn
            // 
            this.savebtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.savebtn.Image = ((System.Drawing.Image)(resources.GetObject("savebtn.Image")));
            this.savebtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(63, 22);
            this.savebtn.Text = "Save state";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(473, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveStateToolStripMenuItem,
            this.restoreStateToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveStateToolStripMenuItem
            // 
            this.saveStateToolStripMenuItem.Name = "saveStateToolStripMenuItem";
            this.saveStateToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.saveStateToolStripMenuItem.Text = "Save state";
            // 
            // restoreStateToolStripMenuItem
            // 
            this.restoreStateToolStripMenuItem.Name = "restoreStateToolStripMenuItem";
            this.restoreStateToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.restoreStateToolStripMenuItem.Text = "Restore state";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(148, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(126, 22);
            this.aboutToolStripMenuItem1.Text = "About...";
            // 
            // state1
            // 
            this.state1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.state1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.state1.Location = new System.Drawing.Point(338, 53);
            this.state1.Name = "state1";
            this.state1.Size = new System.Drawing.Size(100, 100);
            this.state1.TabIndex = 6;
            this.state1.UseVisualStyleBackColor = false;
            // 
            // state2
            // 
            this.state2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.state2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.state2.Location = new System.Drawing.Point(338, 159);
            this.state2.Name = "state2";
            this.state2.Size = new System.Drawing.Size(100, 100);
            this.state2.TabIndex = 7;
            this.state2.UseVisualStyleBackColor = false;
            // 
            // state3
            // 
            this.state3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.state3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.state3.Location = new System.Drawing.Point(338, 265);
            this.state3.Name = "state3";
            this.state3.Size = new System.Drawing.Size(100, 100);
            this.state3.TabIndex = 8;
            this.state3.UseVisualStyleBackColor = false;
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
            // mainfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 367);
            this.Controls.Add(this.state3);
            this.Controls.Add(this.state2);
            this.Controls.Add(this.state1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainfrm";
            this.Text = "Krowka v0.1";
            this.Load += new System.EventHandler(this.mainfrm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton startbtn;
        private System.Windows.Forms.ToolStripButton stepbtn;
        private System.Windows.Forms.ToolStripButton savebtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveStateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restoreStateToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.Button state1;
        private System.Windows.Forms.Button state2;
        private System.Windows.Forms.Button state3;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}

