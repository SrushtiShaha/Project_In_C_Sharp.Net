using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ayuraj_Computer_Shopee_App.Forms.Product
{
    public partial class frm_View_Product_Details : Form
    {
        public frm_View_Product_Details()
        {
            InitializeComponent();
        }

        private void frm_View_Product_Details_Load(object sender, EventArgs e)
        {
            Class_Files.Connection.BindDataGrid(dgv_Product_Details, "Select * from Product_Details");
        }

        private void pb_Back_Click(object sender, EventArgs e)
        {
            frm_Product Obj = new frm_Product();
            Obj.Show();
            this.Hide();
        }

        private void pb_Logout_Click(object sender, EventArgs e)
        {
            Login_Page.frm_Login Obj = new Login_Page.frm_Login();
            Obj.Show();
            this.Hide();
        }
    }
}
