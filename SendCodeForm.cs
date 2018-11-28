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
    public partial class SendCodeForm : MetroFramework.Forms.MetroForm
    {
        public SendCodeForm()
        {
            InitializeComponent();
        }

        private void SendCodeForm_Load(object sender, EventArgs e)
        {

        }

        private void ResetdPasswordButton_Click(object sender, EventArgs e)
        {
            ResetPasswordForm rpf = new ResetPasswordForm();
            rpf.Show();
            Close();
            Dispose();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ForgotPasswordForm fpf = new ForgotPasswordForm();
            fpf.Show();
            Close();
            Dispose();
        }
    }
}
