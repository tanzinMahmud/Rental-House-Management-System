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
    public partial class AsTenantForm : MetroFramework.Forms.MetroForm
    {
        RHDBDataContext DB = new RHDBDataContext();
        public AsTenantForm()
        {
            InitializeComponent();
        }

        private void AsTenantForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            CreateNewAccountForm cnaf = new CreateNewAccountForm();
            cnaf.Show();
            Dispose();
        }

        private void CreateAccountButton_Click(object sender, EventArgs e)
        {
            if (NameTextBox.Text != "" && PasswordTextBox.Text != "" && MobileNoTextBox.Text != "" && AddressTextBox.Text != "")
            {
                if (MobileNoTextBox.Text.All(char.IsDigit) && MobileNoTextBox.Text.Length == 11 && PasswordTextBox.Text.Length >= 8 && (MobileNoTextBox.Text.StartsWith("017") || MobileNoTextBox.Text.StartsWith("016") ||
                    MobileNoTextBox.Text.StartsWith("015") || MobileNoTextBox.Text.StartsWith("019") || MobileNoTextBox.Text.StartsWith("018"))) 
                {
                    var s = from ob in DB.Modifieds
                            where ob.Mobile_No == MobileNoTextBox.Text
                            select ob;
                    if (s != null)
                    {
                        Tenant t = new Tenant();
                        Modified m = new Modified();
                        t.Name = NameTextBox.Text;
                        t.Password = PasswordTextBox.Text;
                        t.Mobile_No = MobileNoTextBox.Text;
                        t.Address = AddressTextBox.Text;
                        t.Keyword = "T";

                        DB.Tenants.InsertOnSubmit(t);
                        DB.SubmitChanges();

                        m.Mobile_No = MobileNoTextBox.Text;
                        m.Password = PasswordTextBox.Text;
                        m.Keyword = "T";

                        DB.Modifieds.InsertOnSubmit(m);
                        DB.SubmitChanges();
                        CreateAccountAfterForm caaf = new CreateAccountAfterForm();
                        caaf.Show();
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
    }
}
