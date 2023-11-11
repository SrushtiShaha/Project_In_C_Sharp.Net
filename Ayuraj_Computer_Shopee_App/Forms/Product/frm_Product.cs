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
    public partial class frm_Product : Form
    {
        public frm_Product()
        {
            InitializeComponent();
        }

        private void btn_Add_Product_Click(object sender, EventArgs e)
        {
            frm_Add_New_Product Obj = new frm_Add_New_Product();
            Obj.Show();
            this.Hide();
        }

        private void btn_Search_Update_Product_Click(object sender, EventArgs e)
        {
            frm_Search_Or_Update_Product_Details Obj = new frm_Search_Or_Update_Product_Details();
            Obj.Show();
            this.Hide();
        }

        private void pb_Back_Click(object sender, EventArgs e)
        {
            Master_Page.frm_Master_Page Obj = new Master_Page.frm_Master_Page();
            Obj.Show();
            this.Hide();
        }

        private void btn_View_Product_Click(object sender, EventArgs e)
        {
            frm_View_Product_Details Obj = new frm_View_Product_Details();
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
