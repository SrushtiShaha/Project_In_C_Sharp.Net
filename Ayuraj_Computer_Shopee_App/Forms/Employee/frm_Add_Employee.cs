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

namespace Ayuraj_Computer_Shopee_App.Forms.Employee
{
    public partial class frm_Add_Employee : Form
    {
        public frm_Add_Employee()
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

        private void frm_Add_Employee_Load(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        void Clear_Controls()
        {
            tb_Employee_ID.Text = Convert.ToString(Class_Files.Connection.Auto_Incr("Select Count(*) from Employee_Details", "Select Max(Employee_ID) from Employee_Details"));

            tb_Emp_Name.Clear();
            tb_Emp_Mobile_No.Clear();
            tb_Emp_Address.Clear();
            tb_Email_ID.Clear();
            tb_Adhar_No.Clear();
            tb_Job_Role.Clear();
            tb_Qualification.Clear();
            tb_Salary.Clear();
        }

        private void pb_Back_Click(object sender, EventArgs e)
        {
            frm_Employee Obj = new frm_Employee();
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
        private void btn_Save_Click(object sender, EventArgs e)
        {
            Class_Files.Connection.Con_Open();

            if(tb_Employee_ID.Text != "" && tb_Emp_Name.Text != "" && tb_Emp_Mobile_No.Text != "" && tb_Emp_Address.Text != "" && tb_Email_ID.Text != "" && tb_Adhar_No.Text != "" && tb_Job_Role.Text != "" && tb_Qualification.Text != "" && tb_Salary.Text != "")
            {
                String Query = "Insert Into Employee_Details (Employee_ID, Employee_Name, Mobile_No, Address, Email_ID, Adhar_No, Joining_Date, Job_Role, Qualification, Salary) " +
                    "Values('"+tb_Employee_ID.Text+"','" + tb_Emp_Name.Text + "', '" + tb_Emp_Mobile_No.Text + "', '" + tb_Emp_Address.Text + "', '" + tb_Email_ID.Text + "', '" + tb_Adhar_No.Text + "', '" + dtp_Joining_Date.Text + "', '" + tb_Job_Role.Text + "', '" + tb_Qualification.Text + "', '" + tb_Salary.Text + "')";

                SqlCommand Cmd = new SqlCommand(Query, Class_Files.Connection.Con);

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

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }
    }
}
