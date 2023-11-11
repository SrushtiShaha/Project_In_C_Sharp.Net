using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Ayuraj_Computer_Shopee_App.Class_Files
{
    class Connection
    {
        public static SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-B27E96R;Initial Catalog=Ayuraj_Computer_Shopee_App_Database;Integrated Security=True");

        public static void Con_Open()
        {
            if (Con.State != ConnectionState.Open)
            {
                Con.Open();
            }
        }

        public static void Con_Close()
        {
            if (Con.State != ConnectionState.Closed)
            {
                Con.Close();
            }
        }

        public static int Auto_Incr(String Q1, string Q2)
        {
            Con_Open();

            int Cnt = 0;

            SqlCommand Cmd = new SqlCommand(Q1,Con);

            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            if (Cnt > 0)
            {
                Cmd.Dispose();
                Cmd.Connection = Con;
                Cmd.CommandText = Q2;

                Cnt = Cnt + 1;
            }
            else
            {
                Cnt = 1;
            }

            return Cnt;

            Con_Close();
        }

        public static void BindDataGrid(DataGridView Dgv, String Query)
        {
            Con_Open();

            SqlDataAdapter Da = new SqlDataAdapter(Query, Con);
            DataTable Dt = new DataTable();

            Da.Fill(Dt);

            Dgv.DataSource = Dt;

            Con_Close();
        }
        public static DataTable GettableData(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, Con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static void FillCombo(ComboBox cmb, string sql, string dismemb)
        {
            DataTable dt = GettableData(sql);

            ///cmb.ValueMember = val;
            cmb.DisplayMember = dismemb;
            cmb.DataSource = dt;
        }
    }
}
