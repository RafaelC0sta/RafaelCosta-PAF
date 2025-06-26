using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace rafael_costa_paf
{
    public partial class AlterarPassword : Form
    {
        private int userId;

        public AlterarPassword(int user_id)
        {
            InitializeComponent();
            this.userId = user_id;
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_mudarPassword_Click(object sender, EventArgs e)
        {
            try
            {
                string novaPassword = tb_novaPassword.Text;
                string confirmarPassword = tb_confirmarPassword.Text;

                if (string.IsNullOrWhiteSpace(novaPassword) || string.IsNullOrWhiteSpace(confirmarPassword))
                {
                    MessageBox.Show("Preencha todos os campos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (novaPassword != confirmarPassword)
                {
                    MessageBox.Show("As palavras-passe não coincidem.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (MySqlConnection con = new MySqlConnection(Geral.connectionString))
                {
                    con.Open();

                    string query = "UPDATE tbl_users SET pass=@novaPassword WHERE user_id = @userId";

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@novaPassword", novaPassword);
                        cmd.Parameters.AddWithValue("@userId", userId);

                        int rows = cmd.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            MessageBox.Show("Palavra-passe alterada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Erro ao alterar a palavra-passe.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao mudar a palavra-passe\nPor favor contacte um administrador.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btn_ver1_Click_1(object sender, EventArgs e)
        {
            if (tb_novaPassword.PasswordChar == '•')
            {
                btn_esconder.BringToFront();
                tb_novaPassword.PasswordChar = '\0';
            }
        }

        private void btn_ver2_Click_1(object sender, EventArgs e)
        {
            if (tb_confirmarPassword.PasswordChar == '•')
            {
                btn_esconder2.BringToFront();
                tb_confirmarPassword.PasswordChar = '\0';
            }
        }

        private void btn_esconder_Click(object sender, EventArgs e)
        {
            if (tb_novaPassword.PasswordChar == '\0')
            {
                btn_ver1.BringToFront();
                tb_novaPassword.PasswordChar = '•';
            }
        }

        private void btn_esconder2_Click_1(object sender, EventArgs e)
        {
            if (tb_confirmarPassword.PasswordChar == '\0')
            {
                btn_ver2.BringToFront();
                tb_confirmarPassword.PasswordChar = '•';
            }
        }
    }
}
