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
    public partial class SignInFormForHouseOwner : MetroFramework.Forms.MetroForm
    {
        public SignInFormForHouseOwner()
        {
            InitializeComponent();
        }

        private void SignInFormForHouseOwner_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            Dispose();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            Dispose();
        }

        private void HouseInformationButton_Click(object sender, EventArgs e)
        {
            HouseInformationForm h = new HouseInformationForm();
            h.Show();
            Dispose();
        }

        private void AddTenantButton_Click(object sender, EventArgs e)
        {
            AddTenantForm a = new AddTenantForm();
            a.Show();
            Dispose();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            UpdateOwnerForm u = new UpdateOwnerForm();
            u.Show();
            Dispose();
        }
    }
}
