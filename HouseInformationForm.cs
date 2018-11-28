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
    public partial class HouseInformationForm : MetroFramework.Forms.MetroForm
    {
        RHDBDataContext DB = new RHDBDataContext();
        public HouseInformationForm()
        {
            InitializeComponent();
        }

        private void HouseInformationForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DB.OwnerTenants;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SignInFormForHouseOwner s = new SignInFormForHouseOwner();
            s.Show();
            Dispose();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            Dispose();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (SearchTextBox.Text == "")
            {
                dataGridView1.DataSource = DB.OwnerTenants;
                MessageBox.Show("No Data Found");
            }
            else
            {
                var s = from o in DB.OwnerTenants
                        where o.Mobile_No == SearchTextBox.Text
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
            String id = SearchTextBox.Text;
            OwnerTenant s = DB.OwnerTenants.SingleOrDefault(x => x.Mobile_No == id);
            if (s != null)
            {
                DB.OwnerTenants.DeleteOnSubmit(s);
                DB.SubmitChanges();
                HouseInformationForm sodf = new HouseInformationForm();
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
            UpdateHouseInformationForm u = new UpdateHouseInformationForm();
            u.Show();
            Dispose();
        }
    }
}
