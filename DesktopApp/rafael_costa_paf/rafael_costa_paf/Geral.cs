using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rafael_costa_paf
{
    internal class Geral
    {
        public static int user_id; // vai guardar o id da pessoa que deu login
        public static string username; // vai guardar o username da pessoa que deu login
        public static string nivel; // vai guardar o nivel do user, se é admin ou guest

        public static string imagem;

        public static string connectionString = ConfigurationManager.ConnectionStrings["connectionPaf"].ConnectionString;

        public static void TrocarForm(Form formFechar, Form formAbrir)
        {
            formFechar.Hide();
            formAbrir.ShowDialog();
            formFechar.Close();
        }

        public static void carregarDados(string query, DataGridView gridView)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                MySqlCommand cmd = new MySqlCommand(query, con);

                con.Open();

                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;

                DataTable dt = new DataTable();

                da.Fill(dt);
                gridView.DataSource = dt;
            }
        }
    }
}
