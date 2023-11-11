using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ayuraj_Computer_Shopee_App.Forms.Customer
{
    public partial class frm_View_Customer_Details : Form
    {
        public frm_View_Customer_Details()
        {
            InitializeComponent();
        }

        private void pb_Back_Click(object sender, EventArgs e)
        {
            Customer.frm_Customer Obj = new frm_Customer();
            Obj.Show();
            this.Hide();
        }

        private void pb_Logout_Click(object sender, EventArgs e)
        {
            Login_Page.frm_Login Obj = new Login_Page.frm_Login();
            Obj.Show();
            this.Hide();
        }

        private void frm_View_Customer_Details_Load(object sender, EventArgs e)
        {
            Class_Files.Connection.BindDataGrid(dgv_Customer_Personal_Details, "Select * from Customer_Personal_Details");
        }

        private void dgv_Customer_Personal_Details_MouseClick(object sender, MouseEventArgs e)
        {
            Class_Files.Connection.BindDataGrid(dgv_Customer_Purchase_Details, "Select * from Customer_Purchase_Details where Customer_ID = '" + dgv_Customer_Personal_Details.SelectedRows[0].Cells["Customer_ID"].Value.ToString() + "'");
            ///If condition
        }

        private void dgv_Customer_Personal_Details_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
