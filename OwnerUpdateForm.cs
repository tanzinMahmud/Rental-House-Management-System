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
    public partial class OwnerUpdateForm : MetroFramework.Forms.MetroForm
    {
        RHDBDataContext DB = new RHDBDataContext();
        public OwnerUpdateForm()
        {
            InitializeComponent();
        }

        private void OwnerUpdateForm_Load(object sender, EventArgs e)
        {

        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (NameTextBox.Text != "" && PTextBox.Text != "" && PTextBox.Text != "" & MoTextBox.Text != "" &&
                HouseAddressTextBox.Text != "" && TfloorTextBox.Text != "" && TotalFlatTextBox.Text != "" &&
                FlatRentTextBox.Text != "")
            {
                if ((MoTextBox.Text.All(char.IsDigit) && MoTextBox.Text.Length == 11 && PTextBox.Text.Length >= 8 && TfloorTextBox.Text.All(char.IsDigit) && TotalFlatTextBox.Text.All(char.IsDigit) && FlatRentTextBox.Text.All(char.IsDigit)) && (MoTextBox.Text.StartsWith("017") || MoTextBox.Text.StartsWith("016") ||
                    MoTextBox.Text.StartsWith("015") || MoTextBox.Text.StartsWith("019") || MoTextBox.Text.StartsWith("018")))
                {
                    String id = UTextBox.Text;
                    Owner s = DB.Owners.SingleOrDefault(x => x.Mobile_No == id);
                    if (s != null)
                    {
                        s.Name = NameTextBox.Text;
                        s.Password = PTextBox.Text;
                        s.Mobile_No = MoTextBox.Text;
                        s.Total_Floor = TfloorTextBox.Text;
                        s.Total_Flat = TotalFlatTextBox.Text;
                        DB.SubmitChanges();

                        ShowOwnersDataForm sodf = new ShowOwnersDataForm();
                        sodf.Show();
                        Close();
                        Dispose();
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
            ShowOwnersDataForm sodf = new ShowOwnersDataForm();
            sodf.Show();
            Dispose();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (UTextBox.Text != "")
            {
                String id = UTextBox.Text;
                Owner s = DB.Owners.SingleOrDefault(x => x.Mobile_No == id);
                if (s != null)
                {
                    NameTextBox.Text = s.Name;
                    PTextBox.Text = s.Password;
                    MoTextBox.Text = s.Mobile_No;
                    HouseAddressTextBox.Text = s.House_Address;
                    TfloorTextBox.Text = s.Total_Floor;
                    TotalFlatTextBox.Text = s.Total_Flat;
                    FlatRentTextBox.Text = s.Flat_Rent;
                }
            }
            else
            {
                MessageBox.Show("Not found!");
            }
        }
    }
}
