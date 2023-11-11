using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ayuraj_Computer_Shopee_App.Forms.Employee
{
    public partial class frm_Employee : Form
    {
        public frm_Employee()
        {
            InitializeComponent();
        }

        private void btn_Add_Employee_Click(object sender, EventArgs e)
        {
            frm_Add_Employee Obj = new frm_Add_Employee();
            Obj.Show();
            this.Hide();
        }

        private void btn_Search_Update_Employee_Click(object sender, EventArgs e)
        {
            frm_Search_Or_Update_Employee Obj = new frm_Search_Or_Update_Employee();
            Obj.Show();
            this.Hide();
        }

        private void btn_View_Employee_Click(object sender, EventArgs e)
        {
            frm_View_Employee_Details Obj = new frm_View_Employee_Details();
            Obj.Show();
            this.Hide();
        }

        private void pb_Back_Click(object sender, EventArgs e)
        {
            Forms.Master_Page.frm_Master_Page Obj = new Master_Page.frm_Master_Page();
            Obj.Show();
            this.Hide();
        }

        private void pb_Logout_Click(object sender, EventArgs e)
        {
            Forms.Login_Page.frm_Login Obj = new Login_Page.frm_Login();
            Obj.Show();
            this.Hide();
        }
    }
}
