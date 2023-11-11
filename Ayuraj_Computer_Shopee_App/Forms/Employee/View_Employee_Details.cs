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
    public partial class frm_View_Employee_Details : Form
    {
        public frm_View_Employee_Details()
        {
            InitializeComponent();
        }

        private void frm_View_Employee_Details_Load(object sender, EventArgs e)
        {
            Class_Files.Connection.BindDataGrid(dgv_Employee_Details, "Select * From Employee_Details");
        }

        private void pb_Back_Click(object sender, EventArgs e)
        {
            frm_Employee Obj = new frm_Employee();
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
