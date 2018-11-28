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
    public partial class ShowTenantsDataForm : MetroFramework.Forms.MetroForm
    {
        RHDBDataContext DB = new RHDBDataContext();
        public ShowTenantsDataForm()
        {
            InitializeComponent();
        }

        private void ShowTenantsDataForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DB.Tenants;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SignInFormForAmin siffa = new SignInFormForAmin();
            siffa.Show();
            Dispose();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            Close();
            Dispose();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SearchByMobileNoTextBox_Click(object sender, EventArgs e)
        {

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (SearchByMobileNoTextBox.Text == "")
            {
                dataGridView1.DataSource = DB.Tenants;
                MessageBox.Show("No Data Found");
            }
            else
            {
                var s = from o in DB.Tenants
                        where o.Mobile_No == SearchByMobileNoTextBox.Text
                        select o;


                dataGridView1.DataSource = s;
                //if(SearchByMobileNoTextBox.Text != s.ToString())
                //{
                //    dataGridView1.DataSource = DB.Owners;
                //    MessageBox.Show("Wrong Input");
                //}
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            String id = SearchByMobileNoTextBox.Text;
            Tenant s = DB.Tenants.SingleOrDefault(x => x.Mobile_No == id);
            if (s != null)
            {
                DB.Tenants.DeleteOnSubmit(s);
                DB.SubmitChanges();
                ShowTenantsDataForm sodf = new ShowTenantsDataForm();
                sodf.Show();
                Close();
                Dispose();

            }
            else
            {
                MessageBox.Show("Data not found");
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            TenantUpdateForm ouf = new TenantUpdateForm();
            ouf.Show();
            Dispose();
        }
    }
}
