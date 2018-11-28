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
    public partial class SignInFormForAmin : MetroFramework.Forms.MetroForm
    {
        public SignInFormForAmin()
        {
            InitializeComponent();
        }

        private void SignInForm_Load(object sender, EventArgs e)
        {

        }

        private void AddAdminButton_Click(object sender, EventArgs e)
        {
            AddAdminForm aaf = new AddAdminForm();
            aaf.Show();
            Dispose();
        }

        private void ShowOwnersDataButton_Click(object sender, EventArgs e)
        {
            ShowOwnersDataForm sodf = new ShowOwnersDataForm();
            sodf.Show();
            Close();
            Dispose();
        }

        private void ShowTenantsDataButton_Click(object sender, EventArgs e)
        {
            ShowTenantsDataForm stdf = new ShowTenantsDataForm();
            stdf.Show();
            Close();
            Dispose();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            Dispose();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            Close();
            Dispose();

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            ShowAdminForm s = new ShowAdminForm();
            s.Show();
            Dispose();
        }
    }
}
