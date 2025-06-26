using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace rafael_costa_paf
{
    public partial class GerirVoos : Form
    {

        private int vooId;

        public GerirVoos()
        {
            InitializeComponent();
        }

        private void GerirVoos_Load(object sender, EventArgs e)
        {
            clearFields();
            carregarDados();
            carregarCbCidade();
            carregarCbAeronave();
            dt_dataPartida.MinDate = DateTime.Today;
            dt_dataChegada.MinDate = DateTime.Today;
            dt_dataChegada.MaxDate = dt_dataPartida.Value.AddDays(1);
            cb_aeroportoPartida.Enabled = false;
            cb_aeroportoDestino.Enabled = false;
        }

        private void carregarDados()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(Geral.connectionString))
                {
                    string query = "select tv.voo_id as ID, tv.numero_voo as 'Número do Voo', tv.cidade_destino as 'Cidade de Destino', concat(ta1.aeroporto_nome, ' - ', ta1.cidade, ', ', ta1.pais) as 'Aeroporto de Partida', concat(ta2.aeroporto_nome, ' - ', ta2.cidade, ', ', ta2.pais) as 'Aeroporto de Chegada', tv.data_partida as 'Data de Partida', tv.data_chegada as 'Data de Chegada', tv.preco_voo as 'Preço do Voo', tav.modelo as 'Modelo do Avião' from tbl_voos as tv right join tbl_aeroportos as ta1 on tv.aeroporto_partida = ta1.aeroporto_id join tbl_aeroportos as ta2 on tv.aeroporto_destino = ta2.aeroporto_id join tbl_aeronaves as tav on tv.aeronave_fk = tav.aeronave_id order by ID;";

                    MySqlCommand cmd = new MySqlCommand(query, con);

                    con.Open();

                    MySqlDataAdapter da = new MySqlDataAdapter();
                    da.SelectCommand = cmd;

                    DataTable dt = new DataTable();

                    da.Fill(dt);
                    gv_dadosVoos.DataSource = dt;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao carregar dados\nPor favor contacte o administrador", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void carregarAeroportoPartida()
        {
            try
            {
                if (cb_cidadeDestino.SelectedItem == null)
                    return;

                string cidadeSelecionada = cb_cidadeDestino.SelectedItem.ToString();

                cb_aeroportoPartida.Items.Clear();

                using (MySqlConnection con = new MySqlConnection(Geral.connectionString))
                {
                    string query = "SELECT CONCAT(aeroporto_nome, ' - ', cidade, ', ', pais) AS nome_completo " +
                                   "FROM tbl_aeroportos " +
                                   "WHERE concat(cidade, ', ', pais) <> @cidade " +
                                   "ORDER BY aeroporto_nome;";

                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@cidade", cidadeSelecionada);

                    con.Open();

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cb_aeroportoPartida.Items.Add(reader["nome_completo"].ToString());
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao carregar dados\nPor favor contacte o administrador", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void carregarAeroportoDestino()
        {
            try
            {
                if (cb_cidadeDestino.SelectedItem == null)
                    return;

                string cidadeSelecionada = cb_cidadeDestino.SelectedItem.ToString();

                cb_aeroportoDestino.Items.Clear();

                using (MySqlConnection con = new MySqlConnection(Geral.connectionString))
                {
                    string query = "SELECT CONCAT(aeroporto_nome, ' - ', cidade, ', ', pais) AS nome_completo " +
                                   "FROM tbl_aeroportos " +
                                   "WHERE concat(cidade, ', ', pais) = @cidade " +
                                   "ORDER BY aeroporto_nome;";

                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@cidade", cidadeSelecionada);

                    con.Open();

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cb_aeroportoDestino.Items.Add(reader["nome_completo"].ToString());
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao carregar dados\nPor favor contacte o administrador", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void carregarCbCidade()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(Geral.connectionString))
                {
                    string query = "select CONCAT(cidade, ', ', pais) as cidade from tbl_aeroportos order by cidade;";

                    MySqlCommand cmd = new MySqlCommand(query, con);

                    con.Open();

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cb_cidadeDestino.Items.Add(reader["cidade"].ToString());
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao carregar dados\nPor favor contacte o administrador", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void carregarCbAeronave()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(Geral.connectionString))
                {
                    string query = "select modelo from tbl_aeronaves";

                    MySqlCommand cmd = new MySqlCommand(query, con);

                    con.Open();

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cb_aeronave.Items.Add(reader["modelo"].ToString());
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao carregar dados\nPor favor contacte o administrador", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tb_precoVoo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cb_aeroportoPartida_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cb_cidadeDestino_SelectedValueChanged(object sender, EventArgs e)
        {
            cb_aeroportoPartida.Enabled = true;
            cb_aeroportoDestino.Enabled = true;
            carregarAeroportoPartida();
            carregarAeroportoDestino();
        }

        private void btn_marcarVoo_Click(object sender, EventArgs e)
        {
            if (cb_cidadeDestino.SelectedItem == null)
                return;

            try
            {
                using (MySqlConnection con = new MySqlConnection(Geral.connectionString))
                {
                    string query = "insert into tbl_voos (numero_voo, cidade_destino, aeroporto_partida, aeroporto_destino, data_partida, data_chegada, preco_voo, aeronave_fk) values (@numeroVoo, @cidade, (select aeroporto_id from tbl_aeroportos where concat(aeroporto_nome, ' - ', cidade, ', ', pais) = @aeroporto_partida), (select aeroporto_id from tbl_aeroportos where concat(aeroporto_nome, ' - ', cidade, ', ', pais) = @aeroporto_destino), @datapartida, @datachegada, @precoVoo, (select aeronave_id from tbl_aeronaves where modelo=@aeronave))";

                    con.Open();

                    MySqlCommand cmd = new MySqlCommand(query, con);

                    if (cb_aeroportoPartida.SelectedItem != null && cb_cidadeDestino.SelectedItem != null)
                    {
                        cmd.Parameters.AddWithValue("@numeroVoo", tb_numVoo.Text);
                        cmd.Parameters.AddWithValue("@cidade", cb_cidadeDestino.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@aeroporto_partida", cb_aeroportoPartida.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@aeroporto_destino", cb_aeroportoDestino.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@datapartida", dt_dataPartida.Value);
                        cmd.Parameters.AddWithValue("@datachegada", dt_dataChegada.Value);
                        cmd.Parameters.AddWithValue("@precoVoo", tb_precoVoo.Text);
                        cmd.Parameters.AddWithValue("@aeronave", cb_aeronave.SelectedItem.ToString());
                    }
                    else
                    {
                        MessageBox.Show("Preencha todos os campos!");
                    }


                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Voo inserido com sucesso!");

                    // inserir automaticamente os lugares no voo
                    long vooId = cmd.LastInsertedId;
                    int capacidade = obterCapacidade(cb_aeronave.SelectedItem.ToString());

                    string[] letras = { "A", "B", "C", "D", "E", "F", "G", "H" };
                    int lugaresPorLetra = 3;
                    int total = capacidade;
                    int lugaresCriados = 0;

                    for (int l = 0; l < letras.Length && lugaresCriados < capacidade; l++)
                    {
                        for (int n = 1; n <= lugaresPorLetra && lugaresCriados < capacidade; n++)
                        {
                            if (lugaresCriados >= total)
                                break;

                            string assento = letras[l] + n.ToString();
                            string insertLugar = "INSERT INTO tbl_lugares (voo_fk, numero_lugar, estado) VALUES (@voo, @lugar, 'livre')";
                            MySqlCommand insertCmd = new MySqlCommand(insertLugar, con);
                            insertCmd.Parameters.AddWithValue("@voo", vooId);
                            insertCmd.Parameters.AddWithValue("@lugar", assento);
                            insertCmd.ExecuteNonQuery();

                            lugaresCriados++;
                        }

                        if (lugaresCriados >= total)
                            break;
                    }
                    clearFields();
                }

            }
            catch (MySqlException)
            {
                MessageBox.Show("Ja existem um voo com esse numero!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            carregarDados();
            
        }

        private int obterCapacidade(string aeronave)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(Geral.connectionString))
                {
                    string query = "select capacidade from tbl_aeronaves where modelo = @aeronave";

                    con.Open();

                    MySqlCommand cmd = new MySqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@aeronave", aeronave);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        return Convert.ToInt16(reader["capacidade"]);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao obter capacidade.\nPor favor contacte o administrador", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return 0;
        }

        private void dt_dataPartida_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (dt_dataChegada.Value != null && dt_dataPartida.Value.Date < dt_dataChegada.Value.Date)
                {
                    dt_dataPartida.MinDate = DateTime.Today;
                    dt_dataChegada.MinDate = dt_dataPartida.Value.Date;
                    dt_dataChegada.MaxDate = dt_dataPartida.Value.AddDays(1);
                }
                else
                {
                    dt_dataChegada.MaxDate = dt_dataPartida.Value.AddDays(1);
                    dt_dataChegada.MinDate = dt_dataPartida.Value.Date;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Erro ao marcar data.\nPor favor contacte o administrador", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cb_cidadeDestino_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cb_aeroportoDestino_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cb_aeronave_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(Geral.connectionString))
                {
                    string queryEditar = "update tbl_voos set numero_voo=@num_voo, cidade_destino=@cidade_destino, aeroporto_partida=(select aeroporto_id from tbl_aeroportos where concat(aeroporto_nome, ' - ', cidade, ', ', pais) = @aeroporto_partida), aeroporto_destino=(select aeroporto_id from tbl_aeroportos where concat(aeroporto_nome, ' - ', cidade, ', ', pais) = @aeroporto_destino), data_partida=@dt_partida, data_chegada=@dt_chegada, preco_voo=@preco_voo, aeronave_fk=(select aeronave_id from tbl_aeronaves where modelo=@aeronave_id) where voo_id=@id";

                    con.Open();

                    MySqlCommand cmd = new MySqlCommand(queryEditar, con);
                    cmd.Parameters.AddWithValue("@num_voo", tb_numVoo.Text);
                    cmd.Parameters.AddWithValue("@cidade_destino", cb_cidadeDestino.SelectedItem);
                    if (cb_aeroportoPartida.SelectedItem != null && cb_aeroportoDestino.SelectedItem != null)
                    {
                        cmd.Parameters.AddWithValue("@aeroporto_partida", cb_aeroportoPartida.SelectedItem);
                        cmd.Parameters.AddWithValue("@aeroporto_destino", cb_aeroportoDestino.SelectedItem);
                    }
                    cmd.Parameters.AddWithValue("@dt_partida", dt_dataPartida.Value);
                    cmd.Parameters.AddWithValue("@dt_chegada", dt_dataChegada.Value);
                    cmd.Parameters.AddWithValue("@preco_voo", tb_precoVoo.Text);
                    cmd.Parameters.AddWithValue("@aeronave_id", cb_aeronave.SelectedItem);
                    cmd.Parameters.AddWithValue("@id", vooId);

                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Voo atualizado com sucesso!");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao editar voo.\nPor favor contacte um administrador", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            carregarDados();
            clearFields();
        }

        private void gv_dadosVoos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = gv_dadosVoos.Rows[e.RowIndex];
                    vooId = Convert.ToInt16(row.Cells[0].Value);
                    tb_numVoo.Text = row.Cells[1].Value.ToString();
                    cb_cidadeDestino.SelectedItem = row.Cells[2].Value.ToString();
                    cb_aeroportoPartida.SelectedItem = row.Cells[3].Value.ToString();
                    cb_aeroportoDestino.SelectedItem = row.Cells[4].Value.ToString();
                    tb_precoVoo.Text = row.Cells[7].Value.ToString();
                    cb_aeronave.SelectedItem = row.Cells[8].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void clearFields()
        {
            tb_numVoo.Text = "";
            cb_cidadeDestino.SelectedItem = null;
            cb_aeroportoPartida.SelectedItem = null;
            cb_aeroportoDestino.SelectedItem = null;
            tb_precoVoo.Text = "";
            cb_aeronave.SelectedItem = null;
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            clearFields();
        }

    }
}
