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
    public partial class CreateNewAccountForm : MetroFramework.Forms.MetroForm
    {
        public CreateNewAccountForm()
        {
            InitializeComponent();
        }

        private void CreateNewAccountForm_Load(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            Dispose();
        }

        private void AsHouseOwnerButton_Click(object sender, EventArgs e)
        {
            AsHouseOwnerForm ahof = new AsHouseOwnerForm();
            ahof.Show();
            Close();
            Dispose();
        }

        private void AsTenantButton_Click(object sender, EventArgs e)
        {
            AsTenantForm atf = new AsTenantForm();
            atf.Show();
            Close();
            Dispose();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            Close();
            Dispose();
        }
    }
}
