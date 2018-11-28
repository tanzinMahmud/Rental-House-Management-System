using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reatal_House_Management_System
{
    public partial class UpdateAdminForm : MetroFramework.Forms.MetroForm
    {
        RHDBDataContext DB = new RHDBDataContext();
        public UpdateAdminForm()
        {
            InitializeComponent();
        }

        private void UpdateAdminForm_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (SearchTextBox.Text != "")
            {
                String id = SearchTextBox.Text;
                Admin s = DB.Admins.SingleOrDefault(x => x.Mobile_No == id);
                if (s != null)
                {
                    NameTextBox.Text = s.Name;
                    PasswordTextBox.Text = s.Password;
                    MobileNoTextBox.Text = s.Mobile_No;
                }
            }
            else
            {
                MessageBox.Show("Not found!");
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            if (NameTextBox.Text != "" && PasswordTextBox.Text != "" & MobileNoTextBox.Text != "")
            {
                if ((MobileNoTextBox.Text.All(char.IsDigit) && MobileNoTextBox.Text.Length == 11 && PasswordTextBox.Text.Length >= 8 && (MobileNoTextBox.Text.StartsWith("017") || MobileNoTextBox.Text.StartsWith("016") ||
                    MobileNoTextBox.Text.StartsWith("015") || MobileNoTextBox.Text.StartsWith("019") || MobileNoTextBox.Text.StartsWith("018"))))
                {
                    String id = SearchTextBox.Text;
                    Admin s = DB.Admins.SingleOrDefault(x => x.Mobile_No == id);
                    if (s != null)
                    {
                        s.Name = NameTextBox.Text;
                        s.Password = PasswordTextBox.Text;
                        s.Mobile_No = MobileNoTextBox.Text;

                        DB.SubmitChanges();
                        MessageBox.Show("Updated Successful!");
                    }
                }
                else
                {
                    MessageBox.Show("Please input every field correctly");
                }
            }
            else
            {
                MessageBox.Show("Please input every field");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ShowAdminForm s = new ShowAdminForm();
            s.Show();
            Dispose();
        }
    }
}
