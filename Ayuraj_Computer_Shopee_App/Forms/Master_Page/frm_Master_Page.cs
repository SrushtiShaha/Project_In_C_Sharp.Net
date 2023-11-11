using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ayuraj_Computer_Shopee_App.Forms.Master_Page
{
    public partial class frm_Master_Page : Form
    {
        public frm_Master_Page()
        {
            InitializeComponent();
        }

        private void pb_Logout_Click(object sender, EventArgs e)
        {
            Login_Page.frm_Login Obj = new Login_Page.frm_Login();
            Obj.Show();
            this.Hide();
        }

        private void pb_Customer_Click_1(object sender, EventArgs e)
        {
            Customer.frm_Customer Obj = new Customer.frm_Customer();
            Obj.Show();
            this.Hide();
        }

        private void pb_Employee_Click(object sender, EventArgs e)
        {
            Forms.Employee.frm_Employee Obj = new Employee.frm_Employee();
            Obj.Show();
            this.Hide();
        }

        private void pb_Product_Click_1(object sender, EventArgs e)
        {
            Product.frm_Product Obj = new Product.frm_Product();
            Obj.Show();
            this.Hide();
        }
    }
}
