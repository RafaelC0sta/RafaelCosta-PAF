using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace rafael_costa_paf
{
    public partial class Login : Form
    {
        int tentativas = 3;

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(Geral.connectionString))
                {
                    string query = "select username, pass, nivel, user_id from tbl_users where username=@username and pass=@password";

                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@username", tb_utilizador.Text);
                    cmd.Parameters.AddWithValue("@password", tb_password.Text);

                    con.Open();

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string username = reader["username"].ToString();
                            string password = reader["pass"].ToString();
                            string nivel = reader["nivel"].ToString();
                            int userId = Convert.ToInt32(reader["user_id"]);

                            Geral.user_id = userId;
                            Geral.username = username;
                            Geral.nivel = nivel;

                            reader.Close();

                            if (password == username)
                            {
                                MessageBox.Show("Por motivos de segurança, deve alterar a sua palavra-passe.", "Alteração Obrigatória", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                new AlterarPassword(userId).ShowDialog();
                                return; // Este return sem nada, faz com que tudo o que esteja a baixo nao corra
                            }

                            MessageBox.Show("Início de sessão bem sucedido!\nBem vindo " + Geral.username + "!", "AirATEC", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            string queryLog = "INSERT INTO tbl_logs (user_fk) VALUES (@userId)";
                            using (MySqlCommand cmdLog = new MySqlCommand(queryLog, con))
                            {
                                cmdLog.Parameters.AddWithValue("@userId", userId);
                                cmdLog.ExecuteNonQuery();
                            }

                            if (nivel == "admin")
                            {
                                Geral.TrocarForm(this, new PaginaAdmin());
                            }
                            else if (nivel == "guest")
                            {
                                Geral.TrocarForm(this, new PaginaUser());
                            }
                        }
                        else
                        {
                            if (tentativas == 0)
                            {
                                MessageBox.Show("Excedeu o limite de tentativas.\nA fechar o programa", "AirATEC", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Dados de Login Incorretos\n" + tentativas + " tentativas restantes", "AirATEC", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                tentativas--;
                            }
                            return;
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao fazer login.\nPor favor contacte o administrador.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_ver_Click(object sender, EventArgs e)
        {
            if (tb_password.PasswordChar == '•')
            {
                btn_esconder.BringToFront();
                tb_password.PasswordChar = '\0';
            }
        }

        private void btn_esconder_Click(object sender, EventArgs e)
        {
            if (tb_password.PasswordChar == '\0')
            {
                btn_ver.BringToFront();
                tb_password.PasswordChar = '•';
            }
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void link_registar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Geral.TrocarForm(this, new Register());
        }
    }
}
