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

namespace Ayuraj_Computer_Shopee_App.Forms.Customer
{
    public partial class frm_Add_Customer_Details : Form
    {
        double Total_Bill = 0;
        public frm_Add_Customer_Details()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-B27E96R;Initial Catalog=Ayuraj_Computer_Shopee_App_Database;Integrated Security=True");

        void Con_Open()
        {
            if (Con.State != ConnectionState.Open)
            {
                Con.Open();
            }
        }

        void Con_Close()
        {
            if (Con.State != ConnectionState.Closed)
            {
                Con.Close();
            }
        }

        private void frm_Add_Customer_Details_Load(object sender, EventArgs e)
        {
            Clear_Controls();

            tb_Customer_ID.Text = Convert.ToString(Class_Files.Connection.Auto_Incr("Select Count(*) from Customer_Personal_Details", "Select Max(Customer_ID) from Customer_Personal_Details"));

            Class_Files.Connection.FillCombo(cmb_Product_Name, "Select * from Product_Details", "Product_Name");
        }

        void Clear_Controls()
        {
            tb_Customer_ID.Text = Convert.ToString(Class_Files.Connection.Auto_Incr("Select Count(*) from Customer_Personal_Details", "Select Max(Customer_ID) from Customer_Personal_Details"));
            tb_Customer_ID.Text = Convert.ToString(Class_Files.Connection.Auto_Incr("Select Count(*) from Customer_Purchase_Details", "Select Max(Customer_ID) from Customer_Purchase_Details"));

            tb_Cust_Name.Clear();
            tb_Cust_Mobile_No.Clear();
            dtp_Bill_Date.Value = DateTime.Now;
            cmb_Product_Name.SelectedIndex = -1;
            tb_Price.Clear();
            tb_Quantity.Clear();
            tb_Total_Price.Clear();
            tb_Total_Bill.Text = "0";
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

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Class_Files.Connection.Con_Open();

            if (dgv_Customer_Details.Rows.Count > 0)
            {
                String Query = "Insert Into Customer_Personal_Details (Customer_ID, Customer_Name, Mobile_No, Bill_Date) Values('"+tb_Customer_ID.Text+"','"+tb_Cust_Name.Text+"', '"+tb_Cust_Mobile_No.Text+"', '"+dtp_Bill_Date.Text+"')";

                SqlCommand Cmd = new SqlCommand(Query, Class_Files.Connection.Con);

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Record Inserted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                Clear_Controls();
            }
            else
            {
                MessageBox.Show("First Fill All The Fields", "Incomplete Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            tb_Customer_ID.Text = Convert.ToString(Class_Files.Connection.Auto_Incr("Select Count(*) from Customer_Personal_Details", "Select Max(Customer_ID) from Customer_Personal_Details"));

            Class_Files.Connection.Con_Close();

            dgv_Customer_Details.DataSource = null;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Class_Files.Connection.Con_Open();

            if (cmb_Product_Name.Text != "" && tb_Price.Text != "" && tb_Quantity.Text != "" && tb_Total_Price.Text != "" && tb_Total_Bill.Text != "")
            {
                String Query = "Insert Into Customer_Purchase_Details (Customer_ID, Product_Name, Price, Quantity, Total_Price, Total_Bill) " +
                    "Values('"+tb_Customer_ID.Text+"','" + cmb_Product_Name.Text + "', '" + tb_Price.Text + "', '" + tb_Quantity.Text + "', '" + tb_Total_Price.Text + "', '" + tb_Total_Bill.Text + "')";

                SqlCommand Cmd = new SqlCommand(Query, Class_Files.Connection.Con);

                Total_Bill = Convert.ToDouble(Total_Bill) + Convert.ToDouble(tb_Total_Price.Text);
                tb_Total_Bill.Text = Convert.ToString(Total_Bill);

                Cmd.ExecuteNonQuery();

                Class_Files.Connection.BindDataGrid(dgv_Customer_Details, "Select Product_Name, Price, Quantity, Total_Price from Customer_Purchase_Details where Customer_ID = '" + tb_Customer_ID.Text + "'");
                MessageBox.Show("Purchase Details Inserted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("First Fill Purchase Details", "Incomplete Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            cmb_Product_Name.SelectedIndex = -1;
            tb_Price.Clear();
            tb_Quantity.Clear();
            tb_Total_Price.Clear();

            Class_Files.Connection.Con_Close();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void tb_Cust_Mobile_No_TextChanged(object sender, EventArgs e)
        {
            if(tb_Cust_Name.Text != "" && tb_Cust_Mobile_No.Text != "")
            {
                cmb_Product_Name.Enabled = true;
                tb_Price.Enabled = true;
                tb_Quantity.Enabled = true;
                tb_Total_Price.Enabled = true;
                tb_Total_Bill.Enabled = true;
            }
        }

        private void cmb_Product_Name_TextChanged(object sender, EventArgs e)
        {
            DataRowView row = (DataRowView)cmb_Product_Name.SelectedItem;
            if (row != null)
            {
                tb_Price.Text = " " + row[5];
            }
        }

        private void tb_Quantity_TextChanged(object sender, EventArgs e)
        {
            if (tb_Quantity.Text != "")
            {
                double Ans = Convert.ToDouble(tb_Price.Text) * Convert.ToDouble(tb_Quantity.Text);
                tb_Total_Price.Text = Convert.ToString(Ans);
            }
        }
    }
}
