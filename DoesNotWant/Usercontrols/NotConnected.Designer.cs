namespace devoctomy.DoesNotWant.Usercontrols
{
    partial class NotConnected
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
            this.picDisconnected = new System.Windows.Forms.PictureBox();
            this.panDisconnected = new System.Windows.Forms.Panel();
            this.lblDisconnected = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picDisconnected)).BeginInit();
            this.panDisconnected.SuspendLayout();
            this.SuspendLayout();
            // 
            // picDisconnected
            // 
            this.picDisconnected.Dock = System.Windows.Forms.DockStyle.Top;
            this.picDisconnected.Image = global::devoctomy.DoesNotWant.Properties.Resources.Connector_02_256_black;
            this.picDisconnected.Location = new System.Drawing.Point(0, 0);
            this.picDisconnected.Name = "picDisconnected";
            this.picDisconnected.Size = new System.Drawing.Size(345, 279);
            this.picDisconnected.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picDisconnected.TabIndex = 0;
            this.picDisconnected.TabStop = false;
            // 
            // panDisconnected
            // 
            this.panDisconnected.Controls.Add(this.lblDisconnected);
            this.panDisconnected.Controls.Add(this.picDisconnected);
            this.panDisconnected.Location = new System.Drawing.Point(232, 42);
            this.panDisconnected.Name = "panDisconnected";
            this.panDisconnected.Size = new System.Drawing.Size(345, 374);
            this.panDisconnected.TabIndex = 1;
            // 
            // lblDisconnected
            // 
            this.lblDisconnected.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDisconnected.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisconnected.Location = new System.Drawing.Point(0, 279);
            this.lblDisconnected.Name = "lblDisconnected";
            this.lblDisconnected.Size = new System.Drawing.Size(345, 95);
            this.lblDisconnected.TabIndex = 1;
            this.lblDisconnected.Text = "Disconnected!\r\nSpotify is not running\r\n";
            this.lblDisconnected.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NotConnected
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panDisconnected);
            this.Name = "NotConnected";
            this.Size = new System.Drawing.Size(887, 472);
            this.Resize += new System.EventHandler(this.NotConnected_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.picDisconnected)).EndInit();
            this.panDisconnected.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picDisconnected;
        private System.Windows.Forms.Panel panDisconnected;
        private System.Windows.Forms.Label lblDisconnected;
    }
}
