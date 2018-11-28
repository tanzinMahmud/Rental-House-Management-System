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
    public partial class AsHouseOwnerForm : MetroFramework.Forms.MetroForm
    {
        RHDBDataContext DB = new RHDBDataContext();
        public AsHouseOwnerForm()
        {
            InitializeComponent();
        }

        private void AsHouseOwnerForm_Load(object sender, EventArgs e)
        {

        }

        private void htmlToolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void htmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            CreateNewAccountForm cnaf = new CreateNewAccountForm();
            cnaf.Show();
            Close();
            Dispose();
        }

        private void CreateAccountButton_Click(object sender, EventArgs e)
        {
            
            if (NameTextBox.Text != "" && PasswordTextBox.Text != "" && PasswordTextBox.Text != "" & MobileNoTextBox.Text != "" &&
                AddressTextBox.Text != "" && AreaComboBox.Text != "" && TotalFloorTextBox.Text != "" && TotalFlatTextBox.Text != "" &&
                FlatRentTextBox.Text != "")
            {
                if ((MobileNoTextBox.Text.All(char.IsDigit) && MobileNoTextBox.Text.Length == 11&& PasswordTextBox.Text.Length >= 8 && TotalFloorTextBox.Text.All(char.IsDigit)&& TotalFlatTextBox.Text.All(char.IsDigit)&& FlatRentTextBox.Text.All(char.IsDigit)) && (MobileNoTextBox.Text.StartsWith("017") || MobileNoTextBox.Text.StartsWith("016") ||
                    MobileNoTextBox.Text.StartsWith("015") || MobileNoTextBox.Text.StartsWith("019") || MobileNoTextBox.Text.StartsWith("018")))
                {
                    var s = from ob in DB.Modifieds
                            where ob.Mobile_No == MobileNoTextBox.Text
                            select ob;
                    if (s != null)
                    {
                        Owner o = new Owner();
                        Modified m = new Modified();

                        o.Name = NameTextBox.Text;
                        o.Password = PasswordTextBox.Text;
                        o.Mobile_No = MobileNoTextBox.Text;
                        o.House_Address = AddressTextBox.Text;
                        o.Area = AreaComboBox.Text;
                        o.Total_Floor = TotalFloorTextBox.Text;
                        o.Total_Flat = TotalFlatTextBox.Text;
                        o.Flat_Rent = FlatRentTextBox.Text;
                        o.Keyword = "O";

                        DB.Owners.InsertOnSubmit(o);
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

        private void NameTextBox_Click(object sender, EventArgs e)
        {

        }
    }
}
