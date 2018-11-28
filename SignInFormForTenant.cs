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
    public partial class SignInFormForTenant : MetroFramework.Forms.MetroForm
    {
        public SignInFormForTenant()
        {
            InitializeComponent();
        }

        private void SignInFormForTenant_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            Dispose();
        }

        private void AhButton_Click(object sender, EventArgs e)
        {
            AvailableHouseForm ahf = new AvailableHouseForm();
            ahf.Show();
            Dispose();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            Dispose();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            TenantUpdate t = new TenantUpdate();
            t.Show();
            Dispose();
        }
    }
}
