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
    public partial class frm_Search_Or_Update_Employee : Form
    {
        public frm_Search_Or_Update_Employee()
        {
            InitializeComponent();
        }

        private void frm_Search_Or_Update_Employee_Load(object sender, EventArgs e)
        {
            tb_Employee_ID.Focus();
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

        void Clear_Controls()
        {
            tb_Employee_ID.Clear();
            tb_Emp_Name.Clear();
            tb_Emp_Mobile_No.Clear();
            tb_Emp_Address.Clear();
            tb_Email_ID.Clear();
            tb_Adhar_No.Clear();
            tb_Job_Role.Clear();
            tb_Qualification.Clear();
            tb_Salary.Clear();

            tb_Employee_ID.Enabled = true;
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
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

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Class_Files.Connection.Con_Open();

            if (tb_Employee_ID.Text != "")
            {
                tb_Employee_ID.Enabled = false;

                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Class_Files.Connection.Con;
                Cmd.CommandText = "Select * From Employee_Details Where Employee_ID = @Emp_ID";

                Cmd.Parameters.Add("Emp_ID", SqlDbType.Int).Value = tb_Employee_ID.Text;

                SqlDataReader Dr = Cmd.ExecuteReader();

                if (Dr.Read())
                {
                    tb_Emp_Name.Text = Dr.GetString(Dr.GetOrdinal("Employee_Name"));
                    tb_Emp_Mobile_No.Text = (Dr["Mobile_No"].ToString());
                    tb_Emp_Address.Text = Dr.GetString(Dr.GetOrdinal("Address"));
                    tb_Email_ID.Text = Dr.GetString(Dr.GetOrdinal("Email_ID"));
                    tb_Adhar_No.Text = (Dr["Adhar_No"].ToString());
                    dtp_Joining_Date.Text = (Dr["Joining_Date"].ToString());
                    tb_Job_Role.Text = Dr.GetString(Dr.GetOrdinal("Job_Role"));
                    tb_Qualification.Text = Dr.GetString(Dr.GetOrdinal("Qualification"));
                    tb_Salary.Text = (Dr["Salary"].ToString());
                }
                else
                {
                    MessageBox.Show("No Employee Found With Given Employee ID", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tb_Employee_ID.Clear();
                    tb_Employee_ID.Focus();
                    tb_Employee_ID.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("First Enter Employee ID.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            Class_Files.Connection.Con_Close();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            Class_Files.Connection.Con_Open();

            if (tb_Emp_Mobile_No.Text != "" && tb_Emp_Address.Text != "" && tb_Email_ID.Text != "" && tb_Job_Role.Text != "" && tb_Qualification.Text != "" && tb_Salary.Text != "")
            {
                String Query = "Update Employee_Details SET Mobile_No = '" + tb_Emp_Mobile_No.Text + "', Address = '"+ tb_Emp_Address.Text +"', Email_ID = '"+ tb_Email_ID.Text +"', Job_Role = '"+ tb_Job_Role.Text +"', Qualification = '"+ tb_Qualification.Text +"', Salary = '"+ tb_Salary.Text +"' where Employee_ID = '" + tb_Employee_ID.Text + "'";

                SqlCommand Cmd = new SqlCommand(Query, Class_Files.Connection.Con);

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Record Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                Clear_Controls();
            }
            else
            {
                MessageBox.Show("First Enter A Roll No.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            Class_Files.Connection.Con_Close();

            tb_Email_ID.Enabled = true;
        }
    }
}
