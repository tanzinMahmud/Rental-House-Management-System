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
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        RHDBDataContext DB = new RHDBDataContext();
        public string u;
        public Form1()
        {
            InitializeComponent();
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void htmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void CreateNewAccountButton_Click(object sender, EventArgs e)
        {      
            CreateNewAccountForm cnaf = new CreateNewAccountForm();
            cnaf.Show();
            Close();
            Dispose();
        }

        private void ForgotPasswordButton_Click(object sender, EventArgs e)
        {
            ForgotPasswordForm fpf = new ForgotPasswordForm();
            fpf.Show();
            Close();
            Dispose();
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            if (UserNameBox.Text != "" && PasswordBox.Text != "" && UserNameBox.Text.Length == 11 && PasswordBox.Text.Length>=8&&UserNameBox.Text.All(char.IsDigit)&& (UserNameBox.Text.StartsWith("017") || UserNameBox.Text.StartsWith("016") ||
                    UserNameBox.Text.StartsWith("015") || UserNameBox.Text.StartsWith("019") || UserNameBox.Text.StartsWith("018")))
            {
                String uname = UserNameBox.Text;
                String pass = PasswordBox.Text;
                try
                {
                    Owner s = DB.Owners.SingleOrDefault(x => x.Mobile_No == uname && x.Password == pass);
                    if (s != null)
                    {
                        SignInFormForHouseOwner o = new SignInFormForHouseOwner();
                        o.Show();

                        Dispose();
                    }
                    /*else
                        MessageBox.Show("Wrong Mobile No or Password!");*/
                }
                catch (Exception)
                {

                }
                try
                {
                    Tenant t = DB.Tenants.SingleOrDefault(x => x.Mobile_No == uname && x.Password == pass);
                    if (t != null)
                    {
                        SignInFormForTenant te = new SignInFormForTenant();
                        te.Show();

                        Dispose();
                    }
                    /* else
                         MessageBox.Show("Wrong Mobile No or Password!");*/
                }
                catch (Exception)
                {

                }
                try
                {
                    Admin a = DB.Admins.SingleOrDefault(x => x.Mobile_No == uname && x.Password == pass);
                    if (a != null)
                    {
                        SignInFormForAmin ai = new SignInFormForAmin();
                        ai.Show();

                        Dispose();
                    }

                }
                catch (Exception)
                {

                }
            }
            else
            {
                MessageBox.Show("Invalid input");
            }
            u = UserNameBox.Text;

        }
        private void PasswordBox_Click(object sender, EventArgs e)
        {

        }

        private void UserNameBox_Click(object sender, EventArgs e)
        {

        }
    }
}
