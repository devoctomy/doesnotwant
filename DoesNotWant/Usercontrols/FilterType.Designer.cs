namespace devoctomy.DoesNotWant.Usercontrols
{
    partial class FilterType
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.butTrack = new System.Windows.Forms.Button();
            this.butArtist = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.butArtist, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.butTrack, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(16, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(493, 393);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // butTrack
            // 
            this.butTrack.Dock = System.Windows.Forms.DockStyle.Top;
            this.butTrack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butTrack.Image = global::devoctomy.DoesNotWant.Properties.Resources.Music_Notes_48_black;
            this.butTrack.Location = new System.Drawing.Point(3, 3);
            this.butTrack.Name = "butTrack";
            this.butTrack.Padding = new System.Windows.Forms.Padding(0, 0, 0, 32);
            this.butTrack.Size = new System.Drawing.Size(487, 182);
            this.butTrack.TabIndex = 1;
            this.butTrack.Text = "This track only";
            this.butTrack.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.butTrack.UseVisualStyleBackColor = true;
            this.butTrack.Click += new System.EventHandler(this.butTrack_Click);
            // 
            // butArtist
            // 
            this.butArtist.Dock = System.Windows.Forms.DockStyle.Top;
            this.butArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butArtist.Image = global::devoctomy.DoesNotWant.Properties.Resources.Boy_02_48_black;
            this.butArtist.Location = new System.Drawing.Point(3, 207);
            this.butArtist.Name = "butArtist";
            this.butArtist.Padding = new System.Windows.Forms.Padding(0, 0, 0, 32);
            this.butArtist.Size = new System.Drawing.Size(487, 183);
            this.butArtist.TabIndex = 2;
            this.butArtist.Text = "This artist, or an artist on this track";
            this.butArtist.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.butArtist.UseVisualStyleBackColor = true;
            this.butArtist.Click += new System.EventHandler(this.butArtist_Click);
            // 
            // FilterType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FilterType";
            this.Padding = new System.Windows.Forms.Padding(16);
            this.Size = new System.Drawing.Size(525, 425);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button butArtist;
        private System.Windows.Forms.Button butTrack;
    }
}
