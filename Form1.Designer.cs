namespace WhiskingAnalysis
{
    partial class MainForm
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
            if(disposing && (components != null))
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
            this.LRSplitter = new System.Windows.Forms.SplitContainer();
            this.L_TBSplitter = new System.Windows.Forms.SplitContainer();
            this.R_TBSplitter = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.LRSplitter)).BeginInit();
            this.LRSplitter.Panel1.SuspendLayout();
            this.LRSplitter.Panel2.SuspendLayout();
            this.LRSplitter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.L_TBSplitter)).BeginInit();
            this.L_TBSplitter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.R_TBSplitter)).BeginInit();
            this.R_TBSplitter.SuspendLayout();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grabberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuLive = new System.Windows.Forms.ToolStripMenuItem();
            this.propertyPagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewImageInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.directAccessToSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.directAccessToAdjustmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sequencerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewSequenceItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseSequenceItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // LRSplitter
            // 
            this.LRSplitter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LRSplitter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LRSplitter.Location = new System.Drawing.Point(0, 0);
            this.LRSplitter.Name = "LRSplitter";
            // 
            // LRSplitter.Panel1
            // 
            this.LRSplitter.Panel1.Controls.Add(this.L_TBSplitter);
            // 
            // LRSplitter.Panel2
            // 
            this.LRSplitter.Panel2.Controls.Add(this.R_TBSplitter);
            this.LRSplitter.Size = new System.Drawing.Size(632, 446);
            this.LRSplitter.SplitterDistance = 326;
            this.LRSplitter.TabIndex = 0;
            // 
            // L_TBSplitter
            // 
            this.L_TBSplitter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.L_TBSplitter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.L_TBSplitter.Location = new System.Drawing.Point(0, 0);
            this.L_TBSplitter.Name = "L_TBSplitter";
            this.L_TBSplitter.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // L_TBSplitter.Panel1
            // 
            this.L_TBSplitter.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.L_TBSplitter.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.DemoGrabForm_Paint);
            this.L_TBSplitter.Size = new System.Drawing.Size(326, 446);
            this.L_TBSplitter.SplitterDistance = 213;
            this.L_TBSplitter.TabIndex = 0;
            // 
            // R_TBSplitter
            // 
            this.R_TBSplitter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.R_TBSplitter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.R_TBSplitter.Location = new System.Drawing.Point(0, 0);
            this.R_TBSplitter.Name = "R_TBSplitter";
            this.R_TBSplitter.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.R_TBSplitter.Size = new System.Drawing.Size(302, 446);
            this.R_TBSplitter.SplitterDistance = 212;
            this.R_TBSplitter.TabIndex = 0;
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.grabberToolStripMenuItem,
            this.sequencerToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(632, 24);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "MainMenu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.OnMenuExit);
            // 
            // grabberToolStripMenuItem
            // 
            this.grabberToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuLive,
            this.propertyPagesToolStripMenuItem,
            this.viewImageInformationToolStripMenuItem,
            this.directAccessToSettingsToolStripMenuItem,
            this.directAccessToAdjustmentsToolStripMenuItem});
            this.grabberToolStripMenuItem.Name = "grabberToolStripMenuItem";
            this.grabberToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.grabberToolStripMenuItem.Text = "Grabber";
            // 
            // MenuLive
            // 
            this.MenuLive.Checked = true;
            this.MenuLive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MenuLive.Name = "MenuLive";
            this.MenuLive.Size = new System.Drawing.Size(239, 22);
            this.MenuLive.Text = "Live";
            this.MenuLive.Click += new System.EventHandler(this.OnMenuLive);
            // 
            // propertyPagesToolStripMenuItem
            // 
            this.propertyPagesToolStripMenuItem.Name = "propertyPagesToolStripMenuItem";
            this.propertyPagesToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.propertyPagesToolStripMenuItem.Text = "Property Pages...";
            this.propertyPagesToolStripMenuItem.Click += new System.EventHandler(this.OnMenuPropertyPages);
            // 
            // viewImageInformationToolStripMenuItem
            // 
            this.viewImageInformationToolStripMenuItem.Name = "viewImageInformationToolStripMenuItem";
            this.viewImageInformationToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.viewImageInformationToolStripMenuItem.Text = "View Image Information...";
            this.viewImageInformationToolStripMenuItem.Click += new System.EventHandler(this.OnMenuImageInfo);
            // 
            // directAccessToSettingsToolStripMenuItem
            // 
            this.directAccessToSettingsToolStripMenuItem.Name = "directAccessToSettingsToolStripMenuItem";
            this.directAccessToSettingsToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.directAccessToSettingsToolStripMenuItem.Text = "Direct Access To Settings...";
            this.directAccessToSettingsToolStripMenuItem.Click += new System.EventHandler(this.OnMenuDirectSettings);
            // 
            // directAccessToAdjustmentsToolStripMenuItem
            // 
            this.directAccessToAdjustmentsToolStripMenuItem.Name = "directAccessToAdjustmentsToolStripMenuItem";
            this.directAccessToAdjustmentsToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.directAccessToAdjustmentsToolStripMenuItem.Text = "Direct Access To Adjustments...";
            this.directAccessToAdjustmentsToolStripMenuItem.Click += new System.EventHandler(this.OnMenuDirectAdjustments);
            // 
            // sequencerToolStripMenuItem
            // 
            this.sequencerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewSequenceItem,
            this.CloseSequenceItem});
            this.sequencerToolStripMenuItem.Name = "sequencerToolStripMenuItem";
            this.sequencerToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.sequencerToolStripMenuItem.Text = "Sequencer";
            // 
            // NewSequenceItem
            // 
            this.NewSequenceItem.Name = "NewSequenceItem";
            this.NewSequenceItem.Size = new System.Drawing.Size(168, 22);
            this.NewSequenceItem.Text = "New Sequence...";
            this.NewSequenceItem.Paint += new System.Windows.Forms.PaintEventHandler(this.OnUpdateMenuNewSequence);
            this.NewSequenceItem.Click += new System.EventHandler(this.OnMenuNewSequence);
            // 
            // CloseSequenceItem
            // 
            this.CloseSequenceItem.Name = "CloseSequenceItem";
            this.CloseSequenceItem.Size = new System.Drawing.Size(168, 22);
            this.CloseSequenceItem.Text = "Close Sequence";
            this.CloseSequenceItem.Paint += new System.Windows.Forms.PaintEventHandler(this.OnUpdateMenuCloseSequence);
            this.CloseSequenceItem.Click += new System.EventHandler(this.OnMenuCloseSequence);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 446);
            this.Controls.Add(this.MainMenu);
            this.Controls.Add(this.LRSplitter);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.MainMenu;
            this.Name = "MainForm";
            this.Text = "Whisking Analysis";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DemoGrabForm_FormClosed);
            this.Shown += new System.EventHandler(this.DemoGrabForm_Shown);
            this.LRSplitter.Panel1.ResumeLayout(false);
            this.LRSplitter.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LRSplitter)).EndInit();
            this.LRSplitter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.L_TBSplitter)).EndInit();
            this.L_TBSplitter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.R_TBSplitter)).EndInit();
            this.R_TBSplitter.ResumeLayout(false);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.SplitContainer LRSplitter;
        private System.Windows.Forms.SplitContainer L_TBSplitter;
        private System.Windows.Forms.SplitContainer R_TBSplitter;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grabberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuLive;
        private System.Windows.Forms.ToolStripMenuItem propertyPagesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewImageInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem directAccessToSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem directAccessToAdjustmentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sequencerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewSequenceItem;
        private System.Windows.Forms.ToolStripMenuItem CloseSequenceItem;
    }
}

