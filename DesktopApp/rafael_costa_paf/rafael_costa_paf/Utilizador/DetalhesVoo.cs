using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rafael_costa_paf
{
    public partial class DetalhesVoo : Form
    {
        private string numVoo;

        public DetalhesVoo(string numVoo)
        {
            this.numVoo = numVoo;
            InitializeComponent();
        }

        private void DetalhesVoo_Load(object sender, EventArgs e)
        {
            //tb_numeroVoo.Text = numVoo;
            carregarDados();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void carregarDados()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(Geral.connectionString))
                {
                    con.Open();

                    string query = "select tv.voo_id, tv.numero_voo, tv.cidade_destino, ta1.aeroporto_nome as aeroporto_partida, ta2.aeroporto_nome as aeroporto_destino, tv.data_partida, tv.preco_voo, tav.modelo from tbl_voos as tv join tbl_aeroportos as ta1 on tv.aeroporto_partida = ta1.aeroporto_id join tbl_aeroportos as ta2 on tv.aeroporto_destino = ta2.aeroporto_id join tbl_aeronaves as tav on tv.aeronave_fk = tav.aeronave_id where tv.numero_voo = @numVoo;";

                    MySqlCommand cmd = new MySqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@numVoo", numVoo);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            tb_numeroVoo.Text = reader["numero_voo"].ToString();
                            tb_cidadeDestino.Text = reader["cidade_destino"].ToString();
                            tb_aeroportoPartida.Text = reader["aeroporto_partida"].ToString();
                            tb_aeroportoDestino.Text = reader["aeroporto_destino"].ToString();
                            tb_dataPartida.Text = reader["data_partida"].ToString();
                            tb_precoVoo.Text = reader["preco_voo"].ToString() + "€";
                            tb_modeloAviao.Text = reader["modelo"].ToString();
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao carregar dados.\nPor favor contacte um administrador.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tb_numeroVoo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void tb_cidadeDestino_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void tb_aeroportoPartida_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void tb_aeroportoDestino_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void tb_dataPartida_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void tb_precoVoo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void tb_modeloAviao_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
