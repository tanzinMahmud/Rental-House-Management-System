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
    public partial class UpdateOwnerForm : MetroFramework.Forms.MetroForm
    {
        RHDBDataContext DB = new RHDBDataContext();
        Form1 f = new Form1();
        public UpdateOwnerForm()
        {
            InitializeComponent();
        }

        private void UpdateOwnerForm_Load(object sender, EventArgs e)
        {
            //String id = UserNameBox.Text;
            //Admin s = DB.Admins.SingleOrDefault(x => x.Mobile_No == id);
            //if (s != null)
            //{
            //    NameTextBox.Text = s.Name;
            //    PasswordTextBox.Text = s.Password;
            //    MobileNoTextBox.Text = s.Mobile_No;
            //}
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            string mo = SearchTextBox.Text;
            string pa = Password2TextBox.Text;

            Owner p = DB.Owners.SingleOrDefault(x => x.Mobile_No == mo && x.Password == pa);
            if (p != null)
            {
                if (NameTextBox.Text != "" && PasswordTextBox.Text != "" && PasswordTextBox.Text != "" & MobileNoTextBox.Text != "" &&
                HouseAddressTextBox.Text != "" && TotalFloorTextBox.Text != "" && TotalFlatTextBox.Text != "" &&
                FlatRentTextBox.Text != "")
                {
                    if ((MobileNoTextBox.Text.All(char.IsDigit) && MobileNoTextBox.Text.Length == 11 && PasswordTextBox.Text.Length >= 8 && TotalFloorTextBox.Text.All(char.IsDigit) && TotalFlatTextBox.Text.All(char.IsDigit) && FlatRentTextBox.Text.All(char.IsDigit)) && (MobileNoTextBox.Text.StartsWith("017") || MobileNoTextBox.Text.StartsWith("016") ||
                        MobileNoTextBox.Text.StartsWith("015") || MobileNoTextBox.Text.StartsWith("019") || MobileNoTextBox.Text.StartsWith("018")))
                    {
                        p.Name = NameTextBox.Text;
                        p.Password = PasswordTextBox.Text;
                        p.Mobile_No = MobileNoTextBox.Text;
                        p.House_Address = HouseAddressTextBox.Text;
                        p.Total_Floor = TotalFloorTextBox.Text;
                        p.Total_Flat = TotalFlatTextBox.Text;
                        p.Flat_Rent = FlatRentTextBox.Text;
                        MessageBox.Show("Updated");
                    }
                }
            }
                
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string mo = SearchTextBox.Text;
            string pa = Password2TextBox.Text;

           Owner o = DB.Owners.SingleOrDefault(x=> x.Mobile_No==mo && x.Password==pa);
            if (o != null)
            {
                NameTextBox.Text = o.Name;
                PasswordTextBox.Text = o.Password;
                MobileNoTextBox.Text = o.Mobile_No;
                HouseAddressTextBox.Text = o.House_Address;
                TotalFloorTextBox.Text = o.Total_Floor;
                TotalFlatTextBox.Text = o.Total_Flat;
                FlatRentTextBox.Text = o.Flat_Rent;
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SignInFormForHouseOwner s = new SignInFormForHouseOwner();
            s.Show();
            Dispose();
        }
    }
}
