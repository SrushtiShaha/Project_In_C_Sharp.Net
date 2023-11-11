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
    public partial class frm_Add_New_Product : Form
    {
        public frm_Add_New_Product()
        {
            InitializeComponent();
        }

        void Clear_Controls()
        {
            tb_Product_Id.Text = Convert.ToString(Class_Files.Connection.Auto_Incr("Select Count(*) from Product_Details", "Select Max(Product_Id) from Product_Details"));

            tb_Product_Name.Clear();
            tb_Product_Quantity.Clear();
            tb_Purchase_Price.Clear();
            tb_Sales_Price.Clear();
            tb_Category_Name.Clear();
            dtp_Import_Date.Value = DateTime.Now;
        }

        private void frm_Add_New_Product_Load(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Class_Files.Connection.Con_Open();

            if (tb_Product_Id.Text != "" && tb_Category_Name.Text != "" && tb_Product_Name.Text != "" && tb_Product_Quantity.Text != "" && tb_Purchase_Price.Text != "" && tb_Sales_Price.Text != "")
            {
                String Query = "Insert Into Product_Details (Product_Id, Category_Name, Product_Name, Product_Quantity, Purchase_Price, Sales_Price, Import_Date) " +
                    "Values('"+tb_Product_Id.Text+"','"+tb_Category_Name.Text+"', '"+tb_Product_Name.Text+"', '"+ tb_Product_Quantity.Text + "', '"+ tb_Purchase_Price.Text + "', '"+ tb_Sales_Price.Text + "', '"+ dtp_Import_Date.Text+ "')";

                SqlCommand Cmd = new SqlCommand(Query,Class_Files.Connection.Con);

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Record Inserted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                Clear_Controls();
            }
            else
            {
                MessageBox.Show("First Fill All The Fields", "Incomplete Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Class_Files.Connection.Con_Close();
        }

        private void pb_Back_Click(object sender, EventArgs e)
        {
            Product.frm_Product Obj = new frm_Product();
            Obj.Show();
            this.Hide();
        }

        private void pb_Logout_Click(object sender, EventArgs e)
        {
            Login_Page.frm_Login Obj = new Login_Page.frm_Login();
            Obj.Show();
            this.Hide();
        }

        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void Only_Text(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
            }
        }
    }
}
