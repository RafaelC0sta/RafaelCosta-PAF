using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace rafael_costa_paf_asp
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(Geral.connectionString))
                {
                    string query = "select * from tbl_users where username=@username and pass=@password";

                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@username", tb_username.Text);
                    cmd.Parameters.AddWithValue("@password", tb_password.Text);

                    con.Open();
                    
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Geral.user_id = Convert.ToInt16(reader["user_id"]);
                            Geral.username = reader["username"].ToString();
                            Geral.nomeCompleto = reader["nomecompleto"].ToString();

                            reader.Close();

                            string queryLog = "INSERT INTO tbl_logs (user_fk) VALUES (@userId)";
                            using (MySqlCommand cmdLog = new MySqlCommand(queryLog, con))
                            {
                                cmdLog.Parameters.AddWithValue("@userId", Geral.user_id);
                                cmdLog.ExecuteNonQuery();
                            }

                            Session["login"] = Geral.username;
                            Response.Redirect("index.aspx");
                        }
                        else
                        {
                            lbl_loginEstado.ForeColor = Color.Red;
                            lbl_loginEstado.Text = "Dados de login errados!";
                        }
                    }
                }
            }
            catch (Exception)
            {
                lbl_loginEstado.Text = "Não foi possível fazer login";
            }
        }
    }
}