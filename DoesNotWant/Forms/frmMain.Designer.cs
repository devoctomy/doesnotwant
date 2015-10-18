namespace devoctomy.DoesNotWant.Forms
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panButtons = new System.Windows.Forms.Panel();
            this.butExit = new System.Windows.Forms.Button();
            this.butOK = new System.Windows.Forms.Button();
            this.panCurrentlyPlaying = new System.Windows.Forms.Panel();
            this.trkTrack = new devoctomy.DoesNotWant.Usercontrols.Track();
            this.lblCurrentlyPlaying = new System.Windows.Forms.Label();
            this.ncdNotConnected = new devoctomy.DoesNotWant.Usercontrols.NotConnected();
            this.panFilters = new System.Windows.Forms.Panel();
            this.flpFilters = new System.Windows.Forms.FlowLayoutPanel();
            this.lblFilters = new System.Windows.Forms.Label();
            this.ninMain = new System.Windows.Forms.NotifyIcon(this.components);
            this.cmsMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createFilterFromCurrentlyPlayingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panButtons.SuspendLayout();
            this.panCurrentlyPlaying.SuspendLayout();
            this.panFilters.SuspendLayout();
            this.cmsMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panButtons
            // 
            this.panButtons.Controls.Add(this.butExit);
            this.panButtons.Controls.Add(this.butOK);
            this.panButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panButtons.Location = new System.Drawing.Point(16, 569);
            this.panButtons.Name = "panButtons";
            this.panButtons.Size = new System.Drawing.Size(665, 64);
            this.panButtons.TabIndex = 0;
            // 
            // butExit
            // 
            this.butExit.Dock = System.Windows.Forms.DockStyle.Left;
            this.butExit.Location = new System.Drawing.Point(0, 0);
            this.butExit.Name = "butExit";
            this.butExit.Size = new System.Drawing.Size(154, 64);
            this.butExit.TabIndex = 1;
            this.butExit.Text = "Exit";
            this.butExit.UseVisualStyleBackColor = true;
            this.butExit.Click += new System.EventHandler(this.butExit_Click);
            // 
            // butOK
            // 
            this.butOK.Dock = System.Windows.Forms.DockStyle.Right;
            this.butOK.Location = new System.Drawing.Point(511, 0);
            this.butOK.Name = "butOK";
            this.butOK.Size = new System.Drawing.Size(154, 64);
            this.butOK.TabIndex = 0;
            this.butOK.Text = "OK";
            this.butOK.UseVisualStyleBackColor = true;
            this.butOK.Click += new System.EventHandler(this.butOK_Click);
            // 
            // panCurrentlyPlaying
            // 
            this.panCurrentlyPlaying.Controls.Add(this.trkTrack);
            this.panCurrentlyPlaying.Controls.Add(this.lblCurrentlyPlaying);
            this.panCurrentlyPlaying.Dock = System.Windows.Forms.DockStyle.Top;
            this.panCurrentlyPlaying.Location = new System.Drawing.Point(16, 16);
            this.panCurrentlyPlaying.Name = "panCurrentlyPlaying";
            this.panCurrentlyPlaying.Size = new System.Drawing.Size(665, 139);
            this.panCurrentlyPlaying.TabIndex = 1;
            // 
            // trkTrack
            // 
            this.trkTrack.CurrentTrack = null;
            this.trkTrack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trkTrack.Location = new System.Drawing.Point(0, 32);
            this.trkTrack.Name = "trkTrack";
            this.trkTrack.Size = new System.Drawing.Size(665, 107);
            this.trkTrack.TabIndex = 0;
            this.trkTrack.FilterClicked += new System.EventHandler<System.EventArgs>(this.trkTrack_FilterClicked);
            // 
            // lblCurrentlyPlaying
            // 
            this.lblCurrentlyPlaying.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCurrentlyPlaying.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentlyPlaying.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblCurrentlyPlaying.Location = new System.Drawing.Point(0, 0);
            this.lblCurrentlyPlaying.Name = "lblCurrentlyPlaying";
            this.lblCurrentlyPlaying.Size = new System.Drawing.Size(665, 32);
            this.lblCurrentlyPlaying.TabIndex = 1;
            this.lblCurrentlyPlaying.Text = "CURRENTLY PLAYING";
            this.lblCurrentlyPlaying.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ncdNotConnected
            // 
            this.ncdNotConnected.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ncdNotConnected.Location = new System.Drawing.Point(16, 155);
            this.ncdNotConnected.Name = "ncdNotConnected";
            this.ncdNotConnected.Size = new System.Drawing.Size(665, 414);
            this.ncdNotConnected.TabIndex = 2;
            // 
            // panFilters
            // 
            this.panFilters.Controls.Add(this.flpFilters);
            this.panFilters.Controls.Add(this.lblFilters);
            this.panFilters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panFilters.Location = new System.Drawing.Point(16, 155);
            this.panFilters.Name = "panFilters";
            this.panFilters.Size = new System.Drawing.Size(665, 414);
            this.panFilters.TabIndex = 3;
            // 
            // flpFilters
            // 
            this.flpFilters.AutoScroll = true;
            this.flpFilters.BackColor = System.Drawing.SystemColors.Control;
            this.flpFilters.BackgroundImage = global::devoctomy.DoesNotWant.Properties.Resources.Dirt_Filter_256_white;
            this.flpFilters.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.flpFilters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpFilters.Location = new System.Drawing.Point(0, 32);
            this.flpFilters.Name = "flpFilters";
            this.flpFilters.Size = new System.Drawing.Size(665, 382);
            this.flpFilters.TabIndex = 3;
            // 
            // lblFilters
            // 
            this.lblFilters.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFilters.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilters.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblFilters.Location = new System.Drawing.Point(0, 0);
            this.lblFilters.Name = "lblFilters";
            this.lblFilters.Size = new System.Drawing.Size(665, 32);
            this.lblFilters.TabIndex = 2;
            this.lblFilters.Text = "FILTERS";
            this.lblFilters.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ninMain
            // 
            this.ninMain.ContextMenuStrip = this.cmsMain;
            this.ninMain.Icon = ((System.Drawing.Icon)(resources.GetObject("ninMain.Icon")));
            this.ninMain.Text = "DoesNotWant";
            this.ninMain.Visible = true;
            this.ninMain.DoubleClick += new System.EventHandler(this.ninMain_DoubleClick_1);
            // 
            // cmsMain
            // 
            this.cmsMain.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.createFilterFromCurrentlyPlayingToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.cmsMain.Name = "cmsMain";
            this.cmsMain.Size = new System.Drawing.Size(388, 100);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(387, 30);
            this.showToolStripMenuItem.Text = "Show";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // createFilterFromCurrentlyPlayingToolStripMenuItem
            // 
            this.createFilterFromCurrentlyPlayingToolStripMenuItem.Name = "createFilterFromCurrentlyPlayingToolStripMenuItem";
            this.createFilterFromCurrentlyPlayingToolStripMenuItem.Size = new System.Drawing.Size(387, 30);
            this.createFilterFromCurrentlyPlayingToolStripMenuItem.Text = "Create Filter From Currently Playing...";
            this.createFilterFromCurrentlyPlayingToolStripMenuItem.Click += new System.EventHandler(this.createFilterFromCurrentlyPlayingToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(384, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(387, 30);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 649);
            this.Controls.Add(this.panFilters);
            this.Controls.Add(this.ncdNotConnected);
            this.Controls.Add(this.panCurrentlyPlaying);
            this.Controls.Add(this.panButtons);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Padding = new System.Windows.Forms.Padding(16);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DoesNotWant";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.panButtons.ResumeLayout(false);
            this.panCurrentlyPlaying.ResumeLayout(false);
            this.panFilters.ResumeLayout(false);
            this.cmsMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panButtons;
        private System.Windows.Forms.Button butOK;
        private System.Windows.Forms.Panel panCurrentlyPlaying;
        private devoctomy.DoesNotWant.Usercontrols.NotConnected ncdNotConnected;
        private Usercontrols.Track trkTrack;
        private System.Windows.Forms.Label lblCurrentlyPlaying;
        private System.Windows.Forms.Panel panFilters;
        private System.Windows.Forms.Label lblFilters;
        private System.Windows.Forms.FlowLayoutPanel flpFilters;
        private System.Windows.Forms.NotifyIcon ninMain;
        private System.Windows.Forms.ContextMenuStrip cmsMain;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createFilterFromCurrentlyPlayingToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button butExit;
    }
}

