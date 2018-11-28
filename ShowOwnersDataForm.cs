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
    public partial class ShowOwnersDataForm : MetroFramework.Forms.MetroForm
    {
        RHDBDataContext DB = new RHDBDataContext();
        public ShowOwnersDataForm()
        {
            InitializeComponent();
        }

        private void ShowOwnersDataForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DB.Owners;
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            Close();
            Dispose();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SignInFormForAmin siffa = new SignInFormForAmin();
            siffa.Show();
            Close();
            Dispose();
        }

        private void metroListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

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
                dataGridView1.DataSource = DB.Owners;
                MessageBox.Show("No Data Found");
            }
            else
            {
                 var s = from o in DB.Owners
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
            Owner s = DB.Owners.SingleOrDefault(x => x.Mobile_No == id);
            if (s != null)
            {
                DB.Owners.DeleteOnSubmit(s);
                DB.SubmitChanges();
                ShowOwnersDataForm sodf = new ShowOwnersDataForm();
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

            OwnerUpdateForm ouf = new OwnerUpdateForm();
            ouf.Show();
            Dispose();
        }
    }
    
}
