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
            this.panButtons = new System.Windows.Forms.Panel();
            this.butOK = new System.Windows.Forms.Button();
            this.panCurrentlyPlaying = new System.Windows.Forms.Panel();
            this.trkTrack = new devoctomy.DoesNotWant.Usercontrols.Track();
            this.lblCurrentlyPlaying = new System.Windows.Forms.Label();
            this.ncdNotConnected = new devoctomy.DoesNotWant.Usercontrols.NotConnected();
            this.panFilters = new System.Windows.Forms.Panel();
            this.flpFilters = new System.Windows.Forms.FlowLayoutPanel();
            this.lblFilters = new System.Windows.Forms.Label();
            this.panButtons.SuspendLayout();
            this.panCurrentlyPlaying.SuspendLayout();
            this.panFilters.SuspendLayout();
            this.SuspendLayout();
            // 
            // panButtons
            // 
            this.panButtons.Controls.Add(this.butOK);
            this.panButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panButtons.Location = new System.Drawing.Point(16, 569);
            this.panButtons.Name = "panButtons";
            this.panButtons.Size = new System.Drawing.Size(665, 64);
            this.panButtons.TabIndex = 0;
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
            this.flpFilters.BackColor = System.Drawing.Color.White;
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
            this.panButtons.ResumeLayout(false);
            this.panCurrentlyPlaying.ResumeLayout(false);
            this.panFilters.ResumeLayout(false);
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
    }
}

