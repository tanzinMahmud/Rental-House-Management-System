using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reatal_House_Management_System
{
    public partial class ForgotPasswordForm : MetroFramework.Forms.MetroForm
    {
        public ForgotPasswordForm()
        {
            InitializeComponent();
        }

        private void ForgotPasswordForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            Close();
            Dispose();
        }

        private void SendCodeButton_Click(object sender, EventArgs e)
        {
            try
            {
                WebClient client = new WebClient();
                Stream s = client.OpenRead("");
                StreamReader reader = new StreamReader(s);
                string result = reader.ReadToEnd();
            }
            catch(Exception ex)
            {

            }
            SendCodeForm scf = new SendCodeForm();
            scf.Show();
            Close();
            Dispose();
        }
    }
}
