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
    public partial class ShowAdminForm : MetroFramework.Forms.MetroForm
    {
        RHDBDataContext DB = new RHDBDataContext();
        public ShowAdminForm()
        {
            InitializeComponent();
        }

        private void ShowAdminForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DB.Admins;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            
        }

        private void SearchButton_Click_1(object sender, EventArgs e)
        {
            if (SearchTextBox.Text == "")
            {
                dataGridView1.DataSource = DB.Admins;
                MessageBox.Show("No Data Found");
            }
            else
            {
                var s = from o in DB.Admins
                        where o.Mobile_No == SearchTextBox.Text
                        select o;
                
                dataGridView1.DataSource = s;
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            String id = SearchTextBox.Text;
            Admin s = DB.Admins.SingleOrDefault(x => x.Mobile_No == id);
            if (s != null)
            {
                DB.Admins.DeleteOnSubmit(s);
                DB.SubmitChanges();
                ShowAdminForm se = new ShowAdminForm();
                se.Show();
                Dispose();
            }
            else
            {
                MessageBox.Show("Data not found");
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            UpdateAdminForm u = new UpdateAdminForm();
            u.Show();
            Dispose();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SignInFormForAmin s = new SignInFormForAmin();
            s.Show();
            Dispose();
        }
    }
}
