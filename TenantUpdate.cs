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
    public partial class TenantUpdate : MetroFramework.Forms.MetroForm
    {
        RHDBDataContext DB = new RHDBDataContext();
        public TenantUpdate()
        {
            InitializeComponent();
        }

        private void TenantUpdate_Load(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            string mo = MoTextBox.Text;
            string pa = PassTextBox.Text;

            Tenant o= DB.Tenants.SingleOrDefault(x => x.Mobile_No == mo && x.Password == pa);
            if (o != null)
            {
                NameTextBox.Text = o.Name;
                PasswordTextBox.Text = o.Password;
                metroTextBox1.Text = o.Mobile_No;
                AddressTextBox.Text = o.Address;
                
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            string mo = MoTextBox.Text;
            string pa = PassTextBox.Text;

            Tenant p = DB.Tenants.SingleOrDefault(x => x.Mobile_No == mo && x.Password == pa);
            if (p != null)
            {
                if (NameTextBox.Text != "" && PasswordTextBox.Text != "" && PasswordTextBox.Text != "" & metroTextBox1.Text != "" &&
                AddressTextBox.Text != "")
                {
                    if ((metroTextBox1.Text.All(char.IsDigit) && metroTextBox1.Text.Length == 11 && PasswordTextBox.Text.Length >= 8 && (metroTextBox1.Text.StartsWith("017") || metroTextBox1.Text.StartsWith("016") ||
                        metroTextBox1.Text.StartsWith("015") || metroTextBox1.Text.StartsWith("019") || metroTextBox1.Text.StartsWith("018"))))
                    {
                        p.Name = NameTextBox.Text;
                        p.Password = PasswordTextBox.Text;
                        p.Mobile_No = metroTextBox1.Text;
                        p.Address = AddressTextBox.Text;
                        MessageBox.Show("Updated");
                    }
                }
            }
        }
    }
}
