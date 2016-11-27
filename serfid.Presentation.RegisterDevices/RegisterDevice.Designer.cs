namespace serfid.Presentation.RegisterDevices
{
    partial class RegisterDevice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterDevice));
            this.SerfidTitleBar = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.lbTag = new System.Windows.Forms.Label();
            this.tbUidTag = new System.Windows.Forms.TextBox();
            this.btnScanTag = new System.Windows.Forms.PictureBox();
            this.tbDeviceName = new System.Windows.Forms.TextBox();
            this.lbDeviceName = new System.Windows.Forms.Label();
            this.tbDetails = new System.Windows.Forms.TextBox();
            this.lblDetails = new System.Windows.Forms.Label();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.lbPrice = new System.Windows.Forms.Label();
            this.tbRating = new System.Windows.Forms.TextBox();
            this.lblRating = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.tbImageUrl = new System.Windows.Forms.TextBox();
            this.lbImageUrl = new System.Windows.Forms.Label();
            this.SerfidTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnScanTag)).BeginInit();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // SerfidTitleBar
            // 
            this.SerfidTitleBar.BackColor = System.Drawing.Color.White;
            this.SerfidTitleBar.Controls.Add(this.pictureBox1);
            this.SerfidTitleBar.Controls.Add(this.lbTitle);
            this.SerfidTitleBar.Controls.Add(this.btnClose);
            this.SerfidTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.SerfidTitleBar.Location = new System.Drawing.Point(0, 0);
            this.SerfidTitleBar.Name = "SerfidTitleBar";
            this.SerfidTitleBar.Size = new System.Drawing.Size(372, 26);
            this.SerfidTitleBar.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Image = global::serfid.Presentation.RegisterDevices.Properties.Resources.SerfidLogo16;
            this.pictureBox1.Location = new System.Drawing.Point(3, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(25, 5);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(139, 18);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "Serfid register device";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = global::serfid.Presentation.RegisterDevices.Properties.Resources.power16;
            this.btnClose.Location = new System.Drawing.Point(351, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(20, 20);
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lbTag
            // 
            this.lbTag.AutoSize = true;
            this.lbTag.Location = new System.Drawing.Point(15, 66);
            this.lbTag.Name = "lbTag";
            this.lbTag.Size = new System.Drawing.Size(104, 13);
            this.lbTag.TabIndex = 1;
            this.lbTag.Text = "Unique identifier tag:";
            // 
            // tbUidTag
            // 
            this.tbUidTag.Enabled = false;
            this.tbUidTag.Location = new System.Drawing.Point(140, 63);
            this.tbUidTag.Name = "tbUidTag";
            this.tbUidTag.ReadOnly = true;
            this.tbUidTag.Size = new System.Drawing.Size(187, 20);
            this.tbUidTag.TabIndex = 2;
            // 
            // btnScanTag
            // 
            this.btnScanTag.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnScanTag.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnScanTag.Image = global::serfid.Presentation.RegisterDevices.Properties.Resources.scan;
            this.btnScanTag.Location = new System.Drawing.Point(307, 63);
            this.btnScanTag.Name = "btnScanTag";
            this.btnScanTag.Size = new System.Drawing.Size(20, 20);
            this.btnScanTag.TabIndex = 3;
            this.btnScanTag.TabStop = false;
            this.btnScanTag.Click += new System.EventHandler(this.btnScanTag_Click);
            // 
            // tbDeviceName
            // 
            this.tbDeviceName.Location = new System.Drawing.Point(140, 94);
            this.tbDeviceName.Name = "tbDeviceName";
            this.tbDeviceName.Size = new System.Drawing.Size(187, 20);
            this.tbDeviceName.TabIndex = 1;
            // 
            // lbDeviceName
            // 
            this.lbDeviceName.AutoSize = true;
            this.lbDeviceName.Location = new System.Drawing.Point(46, 97);
            this.lbDeviceName.Name = "lbDeviceName";
            this.lbDeviceName.Size = new System.Drawing.Size(73, 13);
            this.lbDeviceName.TabIndex = 4;
            this.lbDeviceName.Text = "Device name:";
            // 
            // tbDetails
            // 
            this.tbDetails.Location = new System.Drawing.Point(140, 125);
            this.tbDetails.Name = "tbDetails";
            this.tbDetails.Size = new System.Drawing.Size(187, 20);
            this.tbDetails.TabIndex = 2;
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Location = new System.Drawing.Point(77, 128);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(42, 13);
            this.lblDetails.TabIndex = 6;
            this.lblDetails.Text = "Details:";
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(140, 160);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(187, 20);
            this.tbPrice.TabIndex = 3;
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Location = new System.Drawing.Point(85, 163);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(34, 13);
            this.lbPrice.TabIndex = 8;
            this.lbPrice.Text = "Price:";
            // 
            // tbRating
            // 
            this.tbRating.Location = new System.Drawing.Point(140, 196);
            this.tbRating.Name = "tbRating";
            this.tbRating.Size = new System.Drawing.Size(187, 20);
            this.tbRating.TabIndex = 4;
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.Location = new System.Drawing.Point(78, 199);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(41, 13);
            this.lblRating.TabIndex = 10;
            this.lblRating.Text = "Rating:";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(203, 8);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(289, 8);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlButtons
            // 
            this.pnlButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlButtons.Controls.Add(this.btnClear);
            this.pnlButtons.Controls.Add(this.btnSave);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtons.Location = new System.Drawing.Point(0, 265);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(372, 42);
            this.pnlButtons.TabIndex = 3;
            // 
            // tbImageUrl
            // 
            this.tbImageUrl.Location = new System.Drawing.Point(140, 229);
            this.tbImageUrl.Name = "tbImageUrl";
            this.tbImageUrl.Size = new System.Drawing.Size(187, 20);
            this.tbImageUrl.TabIndex = 11;
            // 
            // lbImageUrl
            // 
            this.lbImageUrl.AutoSize = true;
            this.lbImageUrl.Location = new System.Drawing.Point(78, 232);
            this.lbImageUrl.Name = "lbImageUrl";
            this.lbImageUrl.Size = new System.Drawing.Size(53, 13);
            this.lbImageUrl.TabIndex = 12;
            this.lbImageUrl.Text = "Image url:";
            // 
            // RegisterDevice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(372, 307);
            this.Controls.Add(this.tbImageUrl);
            this.Controls.Add(this.lbImageUrl);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.tbRating);
            this.Controls.Add(this.lblRating);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.tbDetails);
            this.Controls.Add(this.lblDetails);
            this.Controls.Add(this.tbDeviceName);
            this.Controls.Add(this.lbDeviceName);
            this.Controls.Add(this.btnScanTag);
            this.Controls.Add(this.tbUidTag);
            this.Controls.Add(this.lbTag);
            this.Controls.Add(this.SerfidTitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegisterDevice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Serfid register device";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RegisterDevice_FormClosed);
            this.SerfidTitleBar.ResumeLayout(false);
            this.SerfidTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnScanTag)).EndInit();
            this.pnlButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel SerfidTitleBar;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbTag;
        private System.Windows.Forms.TextBox tbUidTag;
        private System.Windows.Forms.PictureBox btnScanTag;
        private System.Windows.Forms.TextBox tbDeviceName;
        private System.Windows.Forms.Label lbDeviceName;
        private System.Windows.Forms.TextBox tbDetails;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.TextBox tbRating;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.TextBox tbImageUrl;
        private System.Windows.Forms.Label lbImageUrl;
    }
}

