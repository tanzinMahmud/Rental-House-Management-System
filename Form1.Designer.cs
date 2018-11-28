namespace Reatal_House_Management_System
{
    partial class Form1
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
            this.UserNameBox = new MetroFramework.Controls.MetroTextBox();
            this.htmlLabel2 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.PasswordBox = new MetroFramework.Controls.MetroTextBox();
            this.SignInButton = new MetroFramework.Controls.MetroButton();
            this.CreateNewAccountButton = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // htmlLabel1
            // 
            this.htmlLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.htmlLabel1.AutoScroll = true;
            this.htmlLabel1.AutoScrollMinSize = new System.Drawing.Size(74, 26);
            this.htmlLabel1.AutoSize = false;
            this.htmlLabel1.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.htmlLabel1.Location = new System.Drawing.Point(228, 150);
            this.htmlLabel1.Name = "htmlLabel1";
            this.htmlLabel1.Size = new System.Drawing.Size(89, 28);
            this.htmlLabel1.TabIndex = 0;
            this.htmlLabel1.Text = "Mobile No.";
            // 
            // UserNameBox
            // 
            this.UserNameBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.UserNameBox.CustomButton.Image = null;
            this.UserNameBox.CustomButton.Location = new System.Drawing.Point(203, 2);
            this.UserNameBox.CustomButton.Name = "";
            this.UserNameBox.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.UserNameBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.UserNameBox.CustomButton.TabIndex = 1;
            this.UserNameBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.UserNameBox.CustomButton.UseSelectable = true;
            this.UserNameBox.CustomButton.Visible = false;
            this.UserNameBox.Lines = new string[0];
            this.UserNameBox.Location = new System.Drawing.Point(228, 184);
            this.UserNameBox.MaxLength = 32767;
            this.UserNameBox.Name = "UserNameBox";
            this.UserNameBox.PasswordChar = '\0';
            this.UserNameBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.UserNameBox.SelectedText = "";
            this.UserNameBox.SelectionLength = 0;
            this.UserNameBox.SelectionStart = 0;
            this.UserNameBox.ShortcutsEnabled = true;
            this.UserNameBox.Size = new System.Drawing.Size(231, 30);
            this.UserNameBox.TabIndex = 1;
            this.UserNameBox.UseSelectable = true;
            this.UserNameBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.UserNameBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.UserNameBox.Click += new System.EventHandler(this.UserNameBox_Click);
            // 
            // htmlLabel2
            // 
            this.htmlLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.htmlLabel2.AutoScroll = true;
            this.htmlLabel2.AutoScrollMinSize = new System.Drawing.Size(68, 26);
            this.htmlLabel2.AutoSize = false;
            this.htmlLabel2.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.htmlLabel2.Location = new System.Drawing.Point(228, 230);
            this.htmlLabel2.Name = "htmlLabel2";
            this.htmlLabel2.Size = new System.Drawing.Size(89, 29);
            this.htmlLabel2.TabIndex = 2;
            this.htmlLabel2.Text = "Password";
            this.htmlLabel2.Click += new System.EventHandler(this.htmlLabel2_Click);
            // 
            // PasswordBox
            // 
            this.PasswordBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.PasswordBox.CustomButton.Image = null;
            this.PasswordBox.CustomButton.Location = new System.Drawing.Point(203, 2);
            this.PasswordBox.CustomButton.Name = "";
            this.PasswordBox.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.PasswordBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PasswordBox.CustomButton.TabIndex = 1;
            this.PasswordBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PasswordBox.CustomButton.UseSelectable = true;
            this.PasswordBox.CustomButton.Visible = false;
            this.PasswordBox.Lines = new string[0];
            this.PasswordBox.Location = new System.Drawing.Point(228, 265);
            this.PasswordBox.MaxLength = 32767;
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.PasswordChar = '●';
            this.PasswordBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PasswordBox.SelectedText = "";
            this.PasswordBox.SelectionLength = 0;
            this.PasswordBox.SelectionStart = 0;
            this.PasswordBox.ShortcutsEnabled = true;
            this.PasswordBox.Size = new System.Drawing.Size(231, 30);
            this.PasswordBox.TabIndex = 3;
            this.PasswordBox.UseSelectable = true;
            this.PasswordBox.UseSystemPasswordChar = true;
            this.PasswordBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PasswordBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.PasswordBox.Click += new System.EventHandler(this.PasswordBox_Click);
            // 
            // SignInButton
            // 
            this.SignInButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SignInButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.SignInButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignInButton.ForeColor = System.Drawing.SystemColors.WindowText;
            this.SignInButton.Location = new System.Drawing.Point(228, 309);
            this.SignInButton.Name = "SignInButton";
            this.SignInButton.Size = new System.Drawing.Size(105, 38);
            this.SignInButton.TabIndex = 5;
            this.SignInButton.Text = "Sign In";
            this.SignInButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.SignInButton.UseSelectable = true;
            this.SignInButton.Click += new System.EventHandler(this.SignInButton_Click);
            // 
            // CreateNewAccountButton
            // 
            this.CreateNewAccountButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CreateNewAccountButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreateNewAccountButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CreateNewAccountButton.Location = new System.Drawing.Point(339, 309);
            this.CreateNewAccountButton.Name = "CreateNewAccountButton";
            this.CreateNewAccountButton.Size = new System.Drawing.Size(120, 38);
            this.CreateNewAccountButton.TabIndex = 7;
            this.CreateNewAccountButton.Text = "Create new account";
            this.CreateNewAccountButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.CreateNewAccountButton.UseSelectable = true;
            this.CreateNewAccountButton.Click += new System.EventHandler(this.CreateNewAccountButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 497);
            this.Controls.Add(this.CreateNewAccountButton);
            this.Controls.Add(this.SignInButton);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.htmlLabel2);
            this.Controls.Add(this.UserNameBox);
            this.Controls.Add(this.htmlLabel1);
            this.Name = "Form1";
            this.Text = "Rental House Management System";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel1;
        public MetroFramework.Controls.MetroTextBox UserNameBox;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel2;
        private MetroFramework.Controls.MetroTextBox PasswordBox;
        private MetroFramework.Controls.MetroButton SignInButton;
        private MetroFramework.Controls.MetroButton CreateNewAccountButton;
    }
}

