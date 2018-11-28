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
    public partial class TenantUpdateForm : MetroFramework.Forms.MetroForm
    {
        RHDBDataContext DB = new RHDBDataContext();
        public TenantUpdateForm()
        {
            InitializeComponent();
        }

        private void TenantUpdateForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ShowTenantsDataForm stdf = new ShowTenantsDataForm();
            stdf.Show();
            Dispose();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (NameTextBox.Text != "" && PasswordTextBox.Text != "" && MobileNoTextBox.Text != "" && AddressTextBox.Text != "")
            {
                if (MobileNoTextBox.Text.Length == 11 && MobileNoTextBox.Text.All(char.IsDigit) && PasswordTextBox.Text.Length >= 8 && (MobileNoTextBox.Text.StartsWith("016") || MobileNoTextBox.Text.StartsWith("017") || MobileNoTextBox.Text.StartsWith("018") ||
                MobileNoTextBox.Text.StartsWith("019") || MobileNoTextBox.Text.StartsWith("015"))){
                    String id = UpdaterMoTextBox.Text;
                    Tenant s = DB.Tenants.SingleOrDefault(x => x.Mobile_No == id);
                    if (s != null)
                    {

                        s.Name = NameTextBox.Text;
                        s.Password = PasswordTextBox.Text;
                        s.Mobile_No = MobileNoTextBox.Text;
                        s.Address = AddressTextBox.Text;

                        //s.Flat_Rent=aho.
                        DB.SubmitChanges();

                        ShowTenantsDataForm sodf = new ShowTenantsDataForm();
                        sodf.Show();
                        Close();
                        Dispose();
                        MessageBox.Show("Update Successful!");
                    }
                }
                else
                {
                    MessageBox.Show("Please input all field correctly");
                }
            }
            else
            {
                MessageBox.Show("Please input all field");
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (UpdaterMoTextBox.Text != ""&&UpdaterMoTextBox.Text.Length==11&&UpdaterMoTextBox.Text.All(char.IsDigit))
            {
                String id = UpdaterMoTextBox.Text;
                Tenant s = DB.Tenants.SingleOrDefault(x => x.Mobile_No == id);
                if (s != null)
                {
                    NameTextBox.Text = s.Name;
                    PasswordTextBox.Text = s.Password;
                    MobileNoTextBox.Text = s.Mobile_No;
                    AddressTextBox.Text = s.Address;
                }
            }
            else
            {
                MessageBox.Show("Not found");
            }
        }
    }
}
