namespace Reatal_House_Management_System
{
    partial class ForgotPasswordForm
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
            this.htmlLabel1 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.EnterMobileNoTextBox = new MetroFramework.Controls.MetroTextBox();
            this.SendCodeButton = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // htmlLabel1
            // 
            this.htmlLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.htmlLabel1.AutoScroll = true;
            this.htmlLabel1.AutoScrollMinSize = new System.Drawing.Size(108, 26);
            this.htmlLabel1.AutoSize = false;
            this.htmlLabel1.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.htmlLabel1.Location = new System.Drawing.Point(217, 154);
            this.htmlLabel1.Name = "htmlLabel1";
            this.htmlLabel1.Size = new System.Drawing.Size(129, 32);
            this.htmlLabel1.TabIndex = 0;
            this.htmlLabel1.Text = "Enter mobile no.";
            // 
            // EnterMobileNoTextBox
            // 
            this.EnterMobileNoTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.EnterMobileNoTextBox.CustomButton.Image = null;
            this.EnterMobileNoTextBox.CustomButton.Location = new System.Drawing.Point(190, 1);
            this.EnterMobileNoTextBox.CustomButton.Name = "";
            this.EnterMobileNoTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.EnterMobileNoTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.EnterMobileNoTextBox.CustomButton.TabIndex = 1;
            this.EnterMobileNoTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.EnterMobileNoTextBox.CustomButton.UseSelectable = true;
            this.EnterMobileNoTextBox.CustomButton.Visible = false;
            this.EnterMobileNoTextBox.Lines = new string[0];
            this.EnterMobileNoTextBox.Location = new System.Drawing.Point(217, 192);
            this.EnterMobileNoTextBox.MaxLength = 32767;
            this.EnterMobileNoTextBox.Name = "EnterMobileNoTextBox";
            this.EnterMobileNoTextBox.PasswordChar = '\0';
            this.EnterMobileNoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.EnterMobileNoTextBox.SelectedText = "";
            this.EnterMobileNoTextBox.SelectionLength = 0;
            this.EnterMobileNoTextBox.SelectionStart = 0;
            this.EnterMobileNoTextBox.ShortcutsEnabled = true;
            this.EnterMobileNoTextBox.Size = new System.Drawing.Size(212, 23);
            this.EnterMobileNoTextBox.TabIndex = 1;
            this.EnterMobileNoTextBox.UseSelectable = true;
            this.EnterMobileNoTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.EnterMobileNoTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // SendCodeButton
            // 
            this.SendCodeButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SendCodeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SendCodeButton.Location = new System.Drawing.Point(217, 232);
            this.SendCodeButton.Name = "SendCodeButton";
            this.SendCodeButton.Size = new System.Drawing.Size(129, 23);
            this.SendCodeButton.TabIndex = 2;
            this.SendCodeButton.Text = "Send code";
            this.SendCodeButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.SendCodeButton.UseSelectable = true;
            this.SendCodeButton.Click += new System.EventHandler(this.SendCodeButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.BackgroundImage = global::Reatal_House_Management_System.Properties.Resources.BackButton21;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(23, 415);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 48);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ForgotPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 486);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SendCodeButton);
            this.Controls.Add(this.EnterMobileNoTextBox);
            this.Controls.Add(this.htmlLabel1);
            this.Name = "ForgotPasswordForm";
            this.Text = "Reset password";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ForgotPasswordForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel1;
        private MetroFramework.Controls.MetroTextBox EnterMobileNoTextBox;
        private MetroFramework.Controls.MetroButton SendCodeButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}