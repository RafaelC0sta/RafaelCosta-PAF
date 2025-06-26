using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace rafael_costa_paf
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void link_registar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Geral.TrocarForm(this, new Login());
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                string email = tb_email.Text;

                if (tb_nomeCompleto.Text == "" || tb_email.Text == "" || tb_username.Text == "" || tb_password.Text == "")
                {
                    MessageBox.Show("Precisa preencher todos os campos!");
                }
                else
                {
                    // este if verifica se o email tem arroba, e se existe ponto depois do arroba
                    if (email.Contains("@") && email.Contains(".") && email.IndexOf("@") < email.LastIndexOf("."))
                    {
                        try
                        {
                            using (MySqlConnection con = new MySqlConnection(Geral.connectionString))
                            {
                                string query = "insert into tbl_users (nomecompleto, email, username, pass, nivel) values (@nomeCompleto, @email, @username, @password, \"guest\");";

                                MySqlCommand cmd = new MySqlCommand(query, con);

                                cmd.Parameters.AddWithValue("@nomeCompleto", tb_nomeCompleto.Text);
                                cmd.Parameters.AddWithValue("@email", tb_email.Text);
                                cmd.Parameters.AddWithValue("@username", tb_username.Text);
                                cmd.Parameters.AddWithValue("@password", tb_password.Text);

                                con.Open();

                                int linhaCriada = cmd.ExecuteNonQuery();

                                if (linhaCriada > 0)
                                {
                                    MessageBox.Show("Conta criada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    Geral.TrocarForm(this, new Login());
                                }
                                else
                                {
                                    MessageBox.Show("Não foi possível criar a conta!", "Insucesso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        catch (MySqlException)
                        {
                            MessageBox.Show("Já existe um utilizador essas credenciais", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Email inválido, é necessário '@' ou '.'", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao criar conta.\nPor favor contacte o administrador.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
