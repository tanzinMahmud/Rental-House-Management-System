namespace Reatal_House_Management_System
{
    partial class CreateNewAccountForm
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
            this.AsHouseOwnerButton = new MetroFramework.Controls.MetroButton();
            this.AsTenantButton = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AsTenantictureBox = new System.Windows.Forms.PictureBox();
            this.AsHouseOwnerPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AsTenantictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AsHouseOwnerPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // AsHouseOwnerButton
            // 
            this.AsHouseOwnerButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AsHouseOwnerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AsHouseOwnerButton.Location = new System.Drawing.Point(134, 268);
            this.AsHouseOwnerButton.Name = "AsHouseOwnerButton";
            this.AsHouseOwnerButton.Size = new System.Drawing.Size(126, 30);
            this.AsHouseOwnerButton.TabIndex = 1;
            this.AsHouseOwnerButton.Text = "As House Owner";
            this.AsHouseOwnerButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.AsHouseOwnerButton.UseSelectable = true;
            this.AsHouseOwnerButton.Click += new System.EventHandler(this.AsHouseOwnerButton_Click);
            // 
            // AsTenantButton
            // 
            this.AsTenantButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AsTenantButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AsTenantButton.Location = new System.Drawing.Point(362, 268);
            this.AsTenantButton.Name = "AsTenantButton";
            this.AsTenantButton.Size = new System.Drawing.Size(135, 30);
            this.AsTenantButton.TabIndex = 3;
            this.AsTenantButton.Text = "As Tenant";
            this.AsTenantButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.AsTenantButton.UseSelectable = true;
            this.AsTenantButton.Click += new System.EventHandler(this.AsTenantButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.BackgroundImage = global::Reatal_House_Management_System.Properties.Resources.BackButton21;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(23, 408);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 48);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // AsTenantictureBox
            // 
            this.AsTenantictureBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AsTenantictureBox.BackgroundImage = global::Reatal_House_Management_System.Properties.Resources.AsTenant;
            this.AsTenantictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AsTenantictureBox.Location = new System.Drawing.Point(386, 166);
            this.AsTenantictureBox.Name = "AsTenantictureBox";
            this.AsTenantictureBox.Size = new System.Drawing.Size(89, 80);
            this.AsTenantictureBox.TabIndex = 2;
            this.AsTenantictureBox.TabStop = false;
            // 
            // AsHouseOwnerPictureBox
            // 
            this.AsHouseOwnerPictureBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AsHouseOwnerPictureBox.BackgroundImage = global::Reatal_House_Management_System.Properties.Resources.AsHouseOwner;
            this.AsHouseOwnerPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AsHouseOwnerPictureBox.Location = new System.Drawing.Point(157, 166);
            this.AsHouseOwnerPictureBox.Name = "AsHouseOwnerPictureBox";
            this.AsHouseOwnerPictureBox.Size = new System.Drawing.Size(82, 80);
            this.AsHouseOwnerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AsHouseOwnerPictureBox.TabIndex = 0;
            this.AsHouseOwnerPictureBox.TabStop = false;
            // 
            // CreateNewAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 479);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.AsTenantButton);
            this.Controls.Add(this.AsTenantictureBox);
            this.Controls.Add(this.AsHouseOwnerButton);
            this.Controls.Add(this.AsHouseOwnerPictureBox);
            this.Name = "CreateNewAccountForm";
            this.Text = "Create new account";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CreateNewAccountForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AsTenantictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AsHouseOwnerPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox AsHouseOwnerPictureBox;
        private MetroFramework.Controls.MetroButton AsHouseOwnerButton;
        private System.Windows.Forms.PictureBox AsTenantictureBox;
        private MetroFramework.Controls.MetroButton AsTenantButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}