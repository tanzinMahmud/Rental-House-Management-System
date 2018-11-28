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
    public partial class AddTenantForm : MetroFramework.Forms.MetroForm
    {
        RHDBDataContext DB = new RHDBDataContext();
        public AddTenantForm()
        {
            InitializeComponent();
        }

        private void AddTenantForm_Load(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (NameTextBox.Text != "" && MobileNoTextBox.Text != "" && AddressTextBox.Text != "")
            {
                if (MobileNoTextBox.Text.All(char.IsDigit) && MobileNoTextBox.Text.Length == 11 && (MobileNoTextBox.Text.StartsWith("017") || MobileNoTextBox.Text.StartsWith("016") ||
                    MobileNoTextBox.Text.StartsWith("015") || MobileNoTextBox.Text.StartsWith("019") || MobileNoTextBox.Text.StartsWith("018")))
                {
                    var s = from ob in DB.Modifieds
                            where ob.Mobile_No == MobileNoTextBox.Text
                            select ob;
                    if (s != null)
                    {
                        OwnerTenant a = new OwnerTenant();
                        Tenant t = new Tenant();
                        Modified m = new Modified();
                        t.Name = NameTextBox.Text;
                        t.Mobile_No = MobileNoTextBox.Text;
                        t.Keyword = "T";

                        DB.Tenants.InsertOnSubmit(t);
                        DB.SubmitChanges();

                        m.Mobile_No = MobileNoTextBox.Text;
                        m.Keyword = "T";

                        DB.Modifieds.InsertOnSubmit(m);
                        DB.SubmitChanges();
                        a.Name = NameTextBox.Text;

                        a.Name = NameTextBox.Text;
                        a.Mobile_No = MobileNoTextBox.Text;
                        a.Address = AddressTextBox.Text;
                        DB.OwnerTenants.InsertOnSubmit(a);
                        DB.SubmitChanges();
                        MessageBox.Show("Added Successfully!");
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
            SignInFormForHouseOwner s = new SignInFormForHouseOwner();
            s.Show();
            Dispose();
        }

        private void AddressTextBox_Click(object sender, EventArgs e)
        {

        }
    }
}
