namespace devoctomy.DoesNotWant.Forms
{
    partial class frmCreateFilter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreateFilter));
            this.panButtons = new System.Windows.Forms.Panel();
            this.butOK = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.butCancel = new System.Windows.Forms.Button();
            this.panButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // panButtons
            // 
            this.panButtons.Controls.Add(this.butOK);
            this.panButtons.Controls.Add(this.panel1);
            this.panButtons.Controls.Add(this.butCancel);
            this.panButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panButtons.Location = new System.Drawing.Point(16, 454);
            this.panButtons.Name = "panButtons";
            this.panButtons.Size = new System.Drawing.Size(665, 64);
            this.panButtons.TabIndex = 1;
            // 
            // butOK
            // 
            this.butOK.Dock = System.Windows.Forms.DockStyle.Right;
            this.butOK.Enabled = false;
            this.butOK.Location = new System.Drawing.Point(341, 0);
            this.butOK.Name = "butOK";
            this.butOK.Size = new System.Drawing.Size(154, 64);
            this.butOK.TabIndex = 2;
            this.butOK.Text = "OK";
            this.butOK.UseVisualStyleBackColor = true;
            this.butOK.Click += new System.EventHandler(this.butOK_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(495, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(16, 64);
            this.panel1.TabIndex = 1;
            // 
            // butCancel
            // 
            this.butCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.butCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.butCancel.Location = new System.Drawing.Point(511, 0);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(154, 64);
            this.butCancel.TabIndex = 0;
            this.butCancel.Text = "Cancel";
            this.butCancel.UseVisualStyleBackColor = true;
            // 
            // frmCreateFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.butCancel;
            this.ClientSize = new System.Drawing.Size(697, 534);
            this.Controls.Add(this.panButtons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCreateFilter";
            this.Padding = new System.Windows.Forms.Padding(16);
            this.Text = "DoesNotWant - Create Filter";
            this.panButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panButtons;
        private System.Windows.Forms.Button butCancel;
        private System.Windows.Forms.Button butOK;
        private System.Windows.Forms.Panel panel1;
    }
}