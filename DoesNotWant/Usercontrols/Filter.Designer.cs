namespace devoctomy.DoesNotWant.Usercontrols
{
    partial class Filter
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
            this.lblFilterType = new System.Windows.Forms.Label();
            this.lblFilterField = new System.Windows.Forms.Label();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.butUnFilter = new System.Windows.Forms.Button();
            this.lblFilterValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFilterType
            // 
            this.lblFilterType.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFilterType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilterType.Location = new System.Drawing.Point(256, 0);
            this.lblFilterType.Name = "lblFilterType";
            this.lblFilterType.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.lblFilterType.Size = new System.Drawing.Size(551, 32);
            this.lblFilterType.TabIndex = 1;
            this.lblFilterType.Text = "Filter Type";
            this.lblFilterType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFilterField
            // 
            this.lblFilterField.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFilterField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilterField.Location = new System.Drawing.Point(256, 32);
            this.lblFilterField.Name = "lblFilterField";
            this.lblFilterField.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.lblFilterField.Size = new System.Drawing.Size(551, 32);
            this.lblFilterField.TabIndex = 2;
            this.lblFilterField.Text = "Field";
            this.lblFilterField.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // butUnFilter
            // 
            this.butUnFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butUnFilter.Dock = System.Windows.Forms.DockStyle.Right;
            this.butUnFilter.Image = global::devoctomy.DoesNotWant.Properties.Resources.Like___01_32;
            this.butUnFilter.Location = new System.Drawing.Point(807, 0);
            this.butUnFilter.Name = "butUnFilter";
            this.butUnFilter.Size = new System.Drawing.Size(101, 256);
            this.butUnFilter.TabIndex = 3;
            this.butUnFilter.UseVisualStyleBackColor = true;
            this.butUnFilter.Click += new System.EventHandler(this.butUnFilter_Click);
            // 
            // lblFilterValue
            // 
            this.lblFilterValue.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFilterValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilterValue.Location = new System.Drawing.Point(256, 64);
            this.lblFilterValue.Name = "lblFilterValue";
            this.lblFilterValue.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.lblFilterValue.Size = new System.Drawing.Size(551, 32);
            this.lblFilterValue.TabIndex = 4;
            this.lblFilterValue.Text = "Value";
            this.lblFilterValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Filter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblFilterValue);
            this.Controls.Add(this.lblFilterField);
            this.Controls.Add(this.lblFilterType);
            this.Controls.Add(this.picImage);
            this.Controls.Add(this.butUnFilter);
            this.Name = "Filter";
            this.Size = new System.Drawing.Size(908, 256);
            this.Resize += new System.EventHandler(this.Filter_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblFilterType;
        private System.Windows.Forms.Label lblFilterField;
        private System.Windows.Forms.Button butUnFilter;
        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.Label lblFilterValue;
    }
}
