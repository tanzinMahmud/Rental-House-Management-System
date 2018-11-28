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
    public partial class CreateNewAdminForm : MetroFramework.Forms.MetroForm
    {
        public CreateNewAdminForm()
        {
            InitializeComponent();
        }

        private void CreateNewAdminForm_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            SignInFormForAmin siffa = new SignInFormForAmin();
            siffa.Show();
            Close();
            Dispose();
        }
    }
}
