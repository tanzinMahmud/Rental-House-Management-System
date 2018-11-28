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
    public partial class UpdateHouseInformationForm : MetroFramework.Forms.MetroForm
    {
        RHDBDataContext DB = new RHDBDataContext();
        public UpdateHouseInformationForm()
        {
            InitializeComponent();
        }

        private void UpdateHouseInformationForm_Load(object sender, EventArgs e)
        {

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            String id = SearchByMobileNoTextBox.Text;
            OwnerTenant s = DB.OwnerTenants.SingleOrDefault(x => x.Mobile_No == id);
            if (s != null)
            {
                NameTextBox.Text = s.Name;
                MobileNoTextBox.Text = s.Mobile_No;
                AddressTextBox.Text = s.Address;
            }
            else
            {
                MessageBox.Show("Not found");
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (NameTextBox.Text != "" && MobileNoTextBox.Text != "" && AddressTextBox.Text != "")
            {
                if (MobileNoTextBox.Text.All(char.IsDigit) && MobileNoTextBox.Text.Length == 11 && (MobileNoTextBox.Text.StartsWith("017") || MobileNoTextBox.Text.StartsWith("016") ||
                    MobileNoTextBox.Text.StartsWith("015") || MobileNoTextBox.Text.StartsWith("019") || MobileNoTextBox.Text.StartsWith("018")))
                {
                    String id = SearchByMobileNoTextBox.Text;
                    OwnerTenant s = DB.OwnerTenants.SingleOrDefault(x => x.Mobile_No == id);
                    if (s != null)
                    {
                        s.Name = NameTextBox.Text;
                        s.Mobile_No = MobileNoTextBox.Text;
                        s.Address = AddressTextBox.Text;

                        DB.SubmitChanges();
                    }
                    String sid = SearchByMobileNoTextBox.Text;
                    Tenant ts = DB.Tenants.SingleOrDefault(x => x.Mobile_No == sid);
                    if (ts != null)
                    {

                        ts.Name = NameTextBox.Text;
                        ts.Mobile_No = MobileNoTextBox.Text;
                        ts.Address = AddressTextBox.Text;

                        DB.SubmitChanges();
                        MessageBox.Show("Update Successful!");
                    }
                    else
                    {
                        MessageBox.Show("Not found");
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
            HouseInformationForm h = new HouseInformationForm();
            h.Show();
            Dispose();
        }
    }
}
