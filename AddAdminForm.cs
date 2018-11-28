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
    public partial class AddAdminForm : MetroFramework.Forms.MetroForm
    {
        RHDBDataContext DB = new RHDBDataContext();
        public AddAdminForm()
        {
            InitializeComponent();
        }

        private void AddAdminForm_Load(object sender, EventArgs e)
        {

        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            if (NameTextBox.Text != "" && PasswordTextBox.Text != "" && MobileNoTextBox.Text != "")
            {
                if (MobileNoTextBox.Text.All(char.IsDigit) && MobileNoTextBox.Text.Length == 11 && PasswordTextBox.Text.Length >= 8 && (MobileNoTextBox.Text.StartsWith("017") || MobileNoTextBox.Text.StartsWith("016") ||
                    MobileNoTextBox.Text.StartsWith("015") || MobileNoTextBox.Text.StartsWith("019") || MobileNoTextBox.Text.StartsWith("018")))
                {
                    var s = from ob in DB.Modifieds
                            where ob.Mobile_No == MobileNoTextBox.Text
                            select ob;
                    if (s != null)
                    {
                        Admin a = new Admin();
                        Modified m = new Modified();
                        a.Name = NameTextBox.Text;
                        a.Password = PasswordTextBox.Text;
                        a.Mobile_No = MobileNoTextBox.Text;
                        a.Keyword = "A";

                        DB.Admins.InsertOnSubmit(a);
                        DB.SubmitChanges();

                        m.Mobile_No = MobileNoTextBox.Text;
                        m.Password = PasswordTextBox.Text;
                        m.Keyword = "A";

                        DB.Modifieds.InsertOnSubmit(m);
                        DB.SubmitChanges();

                        CreateNewAdminForm cnaf = new CreateNewAdminForm();
                        cnaf.Show();
                        Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Your mobile number has already been recorded in database, try with another mobile no");
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
            SignInFormForAmin siffa = new SignInFormForAmin();
            siffa.Show();
            Dispose();
        }
    }
}
