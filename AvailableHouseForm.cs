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
    public partial class AvailableHouseForm : MetroFramework.Forms.MetroForm
    {
        RHDBDataContext DB = new RHDBDataContext();
        public AvailableHouseForm()
        {
            InitializeComponent();
        }

        private void AvailableHouseForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SignInFormForTenant sifft = new SignInFormForTenant();
            sifft.Show();
            Dispose();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            Dispose();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = true;
            DataTable dt = new DataTable();
            if (metroComboBox1.Text == "")
            {
                //dataGridView1.DataSource = DB.Tenants;
                MessageBox.Show("Wrong Search Keyword!");
            }
            else
            {
                /*var s = from o in DB.Owners
                        where o.Area == metroComboBox1.Text
                        select o;*/
                string a = metroComboBox1.Text;
                Owner o = DB.Owners.SingleOrDefault(x=> x.Area==a);
                if(o!=null)
                {
                    dataGridView1.DataSource = DB.Owners.Select(x => new
                    { Name = x.Name, MobilesNo = x.Mobile_No, Area=x.Area, TotalFloor=x.Total_Floor, TotalFlat=x.Total_Flat,TotalRent=x.Flat_Rent }).ToList();
                    /* DataTable temp = dt.DefaultView.ToTable(true, "Name","Mobile No","Area","Total Floor","Total Flat","Flat Rent");
                    dataGridView1.DataSource = temp;*/
                }


                //dataGridView1.DataSource = s;
                //if(SearchByMobileNoTextBox.Text != s.ToString())
                //{
                //    dataGridView1.DataSource = DB.Owners;
                //    MessageBox.Show("Wrong Input");
                //}
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
