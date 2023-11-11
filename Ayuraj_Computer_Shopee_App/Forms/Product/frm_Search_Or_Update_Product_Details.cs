using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ayuraj_Computer_Shopee_App.Forms.Product
{
    public partial class frm_Search_Or_Update_Product_Details : Form
    {
        public frm_Search_Or_Update_Product_Details()
        {
            InitializeComponent();
        }

        void Clear_Controls()
        {
            tb_Product_Id.Clear();
            tb_Product_Name.Clear();
            tb_Product_Quantity.Clear();
            tb_Purchase_Price.Clear();
            tb_Sales_Price.Clear();
            cmb_Category_Name.Text = "";
            dtp_Import_Date.Value = DateTime.Now;
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

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();

            tb_Product_Id.Enabled = true;
        }

        private void btn_Search_Click(object sender, EventArgs e)
        { 
            Class_Files.Connection.Con_Open();

            if (tb_Product_Id.Text != "")
            {
                tb_Product_Id.Enabled = false;

                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Class_Files.Connection.Con;
                Cmd.CommandText = "Select * From Product_Details Where Product_Id = @Prod_ID";

                Cmd.Parameters.Add("Prod_ID", SqlDbType.Int).Value = tb_Product_Id.Text;

                SqlDataReader Dr = Cmd.ExecuteReader();

                if (Dr.Read())
                {
                    cmb_Category_Name.Text = Dr.GetString(Dr.GetOrdinal("Category_Name"));
                    tb_Product_Name.Text = Dr.GetString(Dr.GetOrdinal("Product_Name"));
                    tb_Product_Quantity.Text = (Dr["Product_Quantity"].ToString());
                    tb_Purchase_Price.Text = (Dr["Purchase_Price"].ToString());
                    tb_Sales_Price.Text = (Dr["Sales_Price"].ToString());
                    dtp_Import_Date.Text = (Dr["Import_Date"].ToString());
                }
                else
                {
                    MessageBox.Show("No Product Found With Given Product ID", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tb_Product_Id.Clear();
                    tb_Product_Id.Focus();
                }
            }
            else
            {
                MessageBox.Show("First Enter Product ID.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            Class_Files.Connection.Con_Close();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            Class_Files.Connection.Con_Open();

            if (tb_Sales_Price.Text != "")
            {
                String Query = "Update Product_Details SET Sales_Price = '"+tb_Sales_Price.Text+"' where Product_Id = '"+tb_Product_Id.Text+"'";

                SqlCommand Cmd = new SqlCommand(Query,Class_Files.Connection.Con);

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Record Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                Clear_Controls();
            }
            else
            {
                MessageBox.Show("First Enter A Roll No.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            Class_Files.Connection.Con_Close();

            tb_Product_Id.Enabled = true;
        }

        private void frm_Search_Or_Update_Product_Details_Load(object sender, EventArgs e)
        {
            tb_Product_Name.Focus();
        }
    }
}
