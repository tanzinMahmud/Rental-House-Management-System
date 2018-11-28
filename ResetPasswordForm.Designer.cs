namespace Reatal_House_Management_System
{
    partial class ResetPasswordForm
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
            this.BackToSignInButton = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // htmlLabel1
            // 
            this.htmlLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.htmlLabel1.AutoScroll = true;
            this.htmlLabel1.AutoScrollMinSize = new System.Drawing.Size(141, 26);
            this.htmlLabel1.AutoSize = false;
            this.htmlLabel1.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.htmlLabel1.Location = new System.Drawing.Point(181, 127);
            this.htmlLabel1.Name = "htmlLabel1";
            this.htmlLabel1.Size = new System.Drawing.Size(203, 28);
            this.htmlLabel1.TabIndex = 0;
            this.htmlLabel1.Text = "Reset SUCCESSFUL!";
            // 
            // BackToSignInButton
            // 
            this.BackToSignInButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BackToSignInButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackToSignInButton.Location = new System.Drawing.Point(201, 175);
            this.BackToSignInButton.Name = "BackToSignInButton";
            this.BackToSignInButton.Size = new System.Drawing.Size(161, 23);
            this.BackToSignInButton.TabIndex = 1;
            this.BackToSignInButton.Text = "Back to Sign in ";
            this.BackToSignInButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.BackToSignInButton.UseSelectable = true;
            this.BackToSignInButton.Click += new System.EventHandler(this.BackToSignInButton_Click);
            // 
            // ResetPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 452);
            this.Controls.Add(this.BackToSignInButton);
            this.Controls.Add(this.htmlLabel1);
            this.Name = "ResetPasswordForm";
            this.Text = "Reset password";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ResetPasswordForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel1;
        private MetroFramework.Controls.MetroButton BackToSignInButton;
    }
}