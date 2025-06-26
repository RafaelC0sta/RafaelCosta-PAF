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
    public partial class GerirUtilizadores : Form
    {
        public GerirUtilizadores()
        {
            InitializeComponent();
        }

        private void GerirUtilizadores_Load(object sender, EventArgs e)
        {
            carregarDados();
        }

        private void carregarDados()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(Geral.connectionString))
                {
                    string query = "select user_id as ID, nomecompleto as Nome, email as Email, username as Username, nivel as Nível from tbl_users";

                    MySqlCommand cmd = new MySqlCommand(query, con);

                    con.Open();

                    MySqlDataAdapter da = new MySqlDataAdapter();
                    da.SelectCommand = cmd;

                    DataTable dt = new DataTable();

                    da.Fill(dt);
                    gv_dadosUsers.DataSource = dt;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao carregar dados\nPor favor contacte o administrador", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gv_dadosUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = gv_dadosUsers.Rows[e.RowIndex];
                tb_id.Text = row.Cells[0].Value.ToString();
                tb_nomeCompleto.Text = row.Cells[1].Value.ToString();
                tb_email.Text = row.Cells[2].Value.ToString();
                tb_username.Text = row.Cells[3].Value.ToString();
                cb_nivel.SelectedItem = row.Cells[4].Value.ToString();
            }
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            try
            {
                string email = tb_email.Text;

                if (tb_nomeCompleto.Text != "" && email != "" && tb_username.Text != "" && cb_nivel.SelectedItem != null)
                {
                    if (email.Contains("@") && email.Contains(".") && email.IndexOf("@") < email.LastIndexOf("."))
                    {
                        try
                        {
                            using (MySqlConnection con = new MySqlConnection(Geral.connectionString))
                            {
                                string query = "INSERT INTO tbl_users (nomecompleto, email, username, nivel, pass) VALUES (@nomecompleto, @email, @username, @nivel, @username);";

                                MySqlCommand cmd = new MySqlCommand(query, con);

                                con.Open();
                                cmd.Parameters.AddWithValue("@nomecompleto", tb_nomeCompleto.Text);
                                cmd.Parameters.AddWithValue("@email", tb_email.Text);
                                cmd.Parameters.AddWithValue("@username", tb_username.Text);
                                cmd.Parameters.AddWithValue("@nivel", cb_nivel.SelectedItem);

                                cmd.ExecuteNonQuery();
                            }
                            MessageBox.Show("Ao momento da criação deste utilizador, a password é igual ao username.\nAo iniciar sessão pela primeira vez, o utilizador mudará a password.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                else
                {
                    MessageBox.Show("É necessário preencher todos os campos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao criar utilizador.\nPor favor contacte o administrador", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            clear();
            carregarDados();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_id.Text == "")
                {
                    MessageBox.Show("Nenhum registo selecionado!");
                }
                else
                {
                    string email = tb_email.Text;

                    if (email.Contains("@") && email.Contains(".") && email.IndexOf("@") < email.LastIndexOf("."))
                    {
                        using (MySqlConnection con = new MySqlConnection(Geral.connectionString))
                        {
                            string query = "UPDATE tbl_users SET nomecompleto=@nomecompleto, email=@email, username=@username, nivel=@nivel WHERE user_id=@id;";

                            MySqlCommand cmd = new MySqlCommand(query, con);

                            con.Open();
                            cmd.Parameters.AddWithValue("@id", tb_id.Text);
                            cmd.Parameters.AddWithValue("@nomecompleto", tb_nomeCompleto.Text);
                            cmd.Parameters.AddWithValue("@email", tb_email.Text);
                            cmd.Parameters.AddWithValue("@username", tb_username.Text);
                            cmd.Parameters.AddWithValue("@nivel", cb_nivel.SelectedItem);

                            cmd.ExecuteNonQuery();
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
                MessageBox.Show("Erro ao editar utilizador.\nPor favor contacte o administrador", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            clear();
            carregarDados();
        }

        private void btn_apagar_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(Geral.connectionString))
                {
                    string query = "DELETE FROM tbl_users WHERE user_id=@id;";

                    MySqlCommand cmd = new MySqlCommand(query, con);

                    con.Open();
                    cmd.Parameters.AddWithValue("@id", tb_id.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Registo apagado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                clear();
                carregarDados();
            } 
            catch(Exception)
            {
                MessageBox.Show("Não foi possivel apagar este utiliador\nContacte um administrador", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cb_nivel_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void clear()
        {
            tb_id.Text = "";
            tb_nomeCompleto.Text = "";
            tb_username.Text = "";
            tb_email.Text = "";
            cb_nivel.SelectedItem = "guest";
        }
    }
}
