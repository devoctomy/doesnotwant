namespace devoctomy.DoesNotWant.Usercontrols
{
    partial class Track
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblArtistName = new System.Windows.Forms.Label();
            this.lblTrackTitle = new System.Windows.Forms.Label();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.butFilter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblArtistName
            // 
            this.lblArtistName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblArtistName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtistName.Location = new System.Drawing.Point(256, 0);
            this.lblArtistName.Name = "lblArtistName";
            this.lblArtistName.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.lblArtistName.Size = new System.Drawing.Size(551, 45);
            this.lblArtistName.TabIndex = 1;
            this.lblArtistName.Text = "Artist Name";
            this.lblArtistName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTrackTitle
            // 
            this.lblTrackTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTrackTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrackTitle.Location = new System.Drawing.Point(256, 45);
            this.lblTrackTitle.Name = "lblTrackTitle";
            this.lblTrackTitle.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.lblTrackTitle.Size = new System.Drawing.Size(551, 45);
            this.lblTrackTitle.TabIndex = 2;
            this.lblTrackTitle.Text = "Track Title";
            this.lblTrackTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picImage
            // 
            this.picImage.Dock = System.Windows.Forms.DockStyle.Left;
            this.picImage.Location = new System.Drawing.Point(0, 0);
            this.picImage.Name = "picImage";
            this.picImage.Padding = new System.Windows.Forms.Padding(16);
            this.picImage.Size = new System.Drawing.Size(256, 256);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImage.TabIndex = 0;
            this.picImage.TabStop = false;
            // 
            // butFilter
            // 
            this.butFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butFilter.Dock = System.Windows.Forms.DockStyle.Right;
            this.butFilter.Image = global::devoctomy.DoesNotWant.Properties.Resources.Dirt_Filter_32_black;
            this.butFilter.Location = new System.Drawing.Point(807, 0);
            this.butFilter.Name = "butFilter";
            this.butFilter.Size = new System.Drawing.Size(101, 256);
            this.butFilter.TabIndex = 3;
            this.butFilter.UseVisualStyleBackColor = true;
            this.butFilter.Click += new System.EventHandler(this.butFilter_Click);
            // 
            // Track
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblTrackTitle);
            this.Controls.Add(this.lblArtistName);
            this.Controls.Add(this.picImage);
            this.Controls.Add(this.butFilter);
            this.Name = "Track";
            this.Size = new System.Drawing.Size(908, 256);
            this.Resize += new System.EventHandler(this.Track_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.Label lblArtistName;
        private System.Windows.Forms.Label lblTrackTitle;
        private System.Windows.Forms.Button butFilter;
    }
}
