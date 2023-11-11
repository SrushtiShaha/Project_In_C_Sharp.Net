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

namespace Ayuraj_Computer_Shopee_App.Forms.Login_Page
{
    public partial class frm_Login : Form
    {
        public frm_Login()
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

        private void btn_Login_Submit_Click(object sender, EventArgs e)
        {
            if (tb_Username.Text != "" && tb_Password.Text != "")
            {
                Con_Open();

                int Cnt = 0;

                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Con;
                Cmd.CommandText = "Select Count(*) from Login_Details Where Username = @UNm And Password = @Pwd";

                Cmd.Parameters.Add("UNm", SqlDbType.VarChar).Value = tb_Username.Text;
                Cmd.Parameters.Add("Pwd", SqlDbType.VarChar).Value = tb_Password.Text;

                Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

                if (Cnt > 0)
                {
                    MessageBox.Show("Login Successful!!!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Master_Page.frm_Master_Page Obj = new Master_Page.frm_Master_Page();
                    Obj.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Incorrect Username Or Password.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                tb_Username.Clear();
                tb_Password.Clear();

                tb_Username.Focus();

                Con_Close();
            }
            else
            {
                MessageBox.Show("Enter All Fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
