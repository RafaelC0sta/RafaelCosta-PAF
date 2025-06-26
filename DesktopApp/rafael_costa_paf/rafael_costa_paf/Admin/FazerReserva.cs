using iTextSharp.text;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rafael_costa_paf
{
    public partial class FazerReserva : Form
    {
        public FazerReserva()
        {
            InitializeComponent();
        }

        private void FazerReserva_Load(object sender, EventArgs e)
        {
            carregarDados();
            carregarComboBoxUsers();
            carregarComboBoxVoos();
            num_lugares.Enabled = false;
            check_lugares.Enabled = false;
        }

        private void carregarDados()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(Geral.connectionString))
                {
                    string query = "select r.reserva_id as `ID`, u.nomecompleto as `Nome`, v.numero_voo as `Número do Voo`, l.numero_lugar as `Lugar`, r.data_reserva as `Data da Reserva`, r.pagamento as `Pagamento` from tbl_reservas as r join tbl_users as u on r.user_fk = u.user_id join tbl_voos as v on r.voo_fk = v.voo_id join tbl_lugares as l on r.lugar = l.lugar_id order by r.reserva_id asc;";

                    MySqlCommand cmd = new MySqlCommand(query, con);

                    con.Open();

                    MySqlDataAdapter da = new MySqlDataAdapter();
                    da.SelectCommand = cmd;

                    DataTable dt = new DataTable();

                    da.Fill(dt);
                    gv_dadosReservas.DataSource = dt;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao carregar dados\nPor favor contacte o administrador", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void carregarComboBoxUsers()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(Geral.connectionString))
                {
                    string query = "select nomecompleto from tbl_users";

                    MySqlCommand cmd = new MySqlCommand(query, con);

                    con.Open();

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cb_utilizadores.Items.Add(reader["nomecompleto"].ToString());
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao carregar dados\nPor favor contacte o administrador", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cb_utilizadores_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void carregarComboBoxVoos()
        {
            try
            {
                cb_voo.Items.Clear();
                using (MySqlConnection con = new MySqlConnection(Geral.connectionString))
                {
                    string query = "select v.numero_voo from tbl_voos v join tbl_lugares l ON v.voo_id = l.voo_fk where l.estado = 'livre' group by v.voo_id having count(l.lugar_id) > 0;";

                    MySqlCommand cmd = new MySqlCommand(query, con);

                    con.Open();

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cb_voo.Items.Add(reader["numero_voo"].ToString());
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao carregar dados\nPor favor contacte o administrador", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cb_voo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }


        private void cb_pagamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void carregarLugares()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(Geral.connectionString))
                {
                    string query = "select * from tbl_lugares where estado = 'livre' and voo_fk = (select voo_id from tbl_voos where numero_voo = @numeroVoo);";

                    MySqlCommand cmd = new MySqlCommand(query, con);


                    if (cb_voo.SelectedItem == null)
                    {
                        return;
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@numeroVoo", cb_voo.SelectedItem);
                    }

                    con.Open();

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            check_lugares.Items.Add(reader["numero_lugar"].ToString());
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao carregar dados\nPor favor contacte o administrador", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cb_voo_SelectedValueChanged(object sender, EventArgs e)
        {
            num_lugares.Enabled = true;
            check_lugares.Enabled = true;
            check_lugares.Items.Clear();
            carregarLugares();
            num_lugares.Maximum = check_lugares.Items.Count;
        }

        private void btn_reservar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cb_voo.SelectedItem == null || cb_pagamento.SelectedItem == null || cb_utilizadores.SelectedItem == null)
                {
                    MessageBox.Show("É necessário preencher todos os campos!");
                }
                else
                {
                    if (check_lugares.CheckedItems.Count == 0)
                        return;

                    using (MySqlConnection con = new MySqlConnection(Geral.connectionString))
                    {
                        con.Open();

                        // 1. Obter user_id e voo_id
                        string nomeCompleto = cb_utilizadores.SelectedItem.ToString();
                        string numeroVoo = cb_voo.SelectedItem.ToString();
                        string metodoPagamento = cb_pagamento.SelectedItem.ToString();

                        // Buscar user_id
                        MySqlCommand cmdUser = new MySqlCommand("SELECT user_id FROM tbl_users WHERE nomecompleto = @nome", con);
                        cmdUser.Parameters.AddWithValue("@nome", nomeCompleto);
                        int userId = Convert.ToInt32(cmdUser.ExecuteScalar());

                        // Buscar voo_id e preço
                        MySqlCommand cmdVoo = new MySqlCommand("SELECT voo_id, preco_voo FROM tbl_voos WHERE numero_voo = @numero", con);
                        cmdVoo.Parameters.AddWithValue("@numero", numeroVoo);
                        MySqlDataReader reader = cmdVoo.ExecuteReader();
                        int vooId = 0;
                        decimal preco = 0;
                        if (reader.Read())
                        {
                            vooId = reader.GetInt32("voo_id");
                            preco = reader.GetDecimal("preco_voo");
                        }
                        reader.Close();

                        // 2. Para cada lugar selecionado, fazer uma reserva
                        foreach (var lugarSelecionado in check_lugares.CheckedItems)
                        {
                            string numeroLugar = lugarSelecionado.ToString();

                            // Buscar lugar_id
                            MySqlCommand cmdLugar = new MySqlCommand("SELECT lugar_id FROM tbl_lugares WHERE numero_lugar = @lugar AND voo_fk = @voo", con);
                            cmdLugar.Parameters.AddWithValue("@lugar", numeroLugar);
                            cmdLugar.Parameters.AddWithValue("@voo", vooId);
                            int lugarId = Convert.ToInt32(cmdLugar.ExecuteScalar());

                            // Inserir na tabela de reservas
                            MySqlCommand cmdInsertReserva = new MySqlCommand(
                                "INSERT INTO tbl_reservas (user_fk, voo_fk, lugar, data_reserva, pagamento) VALUES (@user, @voo, @lugar, CURRENT_DATE(), @pagamento);", con);
                            cmdInsertReserva.Parameters.AddWithValue("@user", userId);
                            cmdInsertReserva.Parameters.AddWithValue("@voo", vooId);
                            cmdInsertReserva.Parameters.AddWithValue("@lugar", lugarId);
                            cmdInsertReserva.Parameters.AddWithValue("@pagamento", metodoPagamento);
                            cmdInsertReserva.ExecuteNonQuery();

                            long reservaId = cmdInsertReserva.LastInsertedId;

                            // Atualizar o lugar para 'ocupado'
                            MySqlCommand cmdUpdateLugar = new MySqlCommand(
                                "UPDATE tbl_lugares SET estado = 'ocupado', user_fk = @user WHERE lugar_id = @lugarId", con);
                            cmdUpdateLugar.Parameters.AddWithValue("@user", userId);
                            cmdUpdateLugar.Parameters.AddWithValue("@lugarId", lugarId);
                            cmdUpdateLugar.ExecuteNonQuery();

                            // Inserir o pagamento
                            MySqlCommand cmdPagamento = new MySqlCommand(
                                "INSERT INTO tbl_pagamentos (reserva_fk, metodo_pagamento, valor, data_pagamento, user_fk) VALUES (@reserva, @metodo, @valor, CURRENT_DATE(), @user)", con);
                            cmdPagamento.Parameters.AddWithValue("@reserva", reservaId);
                            cmdPagamento.Parameters.AddWithValue("@metodo", metodoPagamento);
                            cmdPagamento.Parameters.AddWithValue("@valor", preco);
                            cmdPagamento.Parameters.AddWithValue("@user", userId);
                            cmdPagamento.ExecuteNonQuery();
                        }

                        MessageBox.Show("Reservas feitas com sucesso!");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao fazer reserva.\nPor favor contacte o administrador", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            // Limpar e recarregar
            carregarDados();
            cb_pagamento.SelectedItem = null;
            cb_utilizadores.SelectedItem = null;
            cb_voo.SelectedItem = null;
            num_lugares.Value = num_lugares.Minimum;
            check_lugares.Items.Clear();
        }

        private void check_lugares_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                int totalSelecionados = check_lugares.CheckedItems.Count + 1;

                if (totalSelecionados > num_lugares.Value)
                {
                    e.NewValue = CheckState.Unchecked;
                    MessageBox.Show("Número máximo de lugares selecionado.");
                }
            }
        }

        private void num_lugares_ValueChanged(object sender, EventArgs e)
        {
            int maximoPermitido = (int)num_lugares.Value;

            while (check_lugares.CheckedItems.Count > maximoPermitido)
            {
                int index = check_lugares.CheckedIndices[check_lugares.CheckedItems.Count - 1];
                check_lugares.SetItemChecked(index, false);
            }
        }

        int reservaId;

        private void gv_dadosReservas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = gv_dadosReservas.Rows[e.RowIndex];
            reservaId = Convert.ToInt16(row.Cells[0].Value);
        }

        private void btn_apagar_Click(object sender, EventArgs e)
        {
            try
            {
                if (reservaId == 0)
                {
                    MessageBox.Show("É necessário preencher todos os campos!");
                }
                else
                {
                    using (MySqlConnection con = new MySqlConnection(Geral.connectionString))
                    {
                        con.Open();

                        int lugarId = 0;
                        MySqlCommand cmdLugar = new MySqlCommand("select lugar from tbl_reservas where reserva_id = @id", con);
                        cmdLugar.Parameters.AddWithValue("@id", reservaId);
                        var resultadoLugar = cmdLugar.ExecuteScalar();

                        if (resultadoLugar != null)
                        {
                            lugarId = Convert.ToInt16(resultadoLugar);
                        }

                        string deletePagamentos = "delete from tbl_pagamentos where reserva_fk = @id";

                        MySqlCommand cmdPagamentos = new MySqlCommand(deletePagamentos, con);
                        cmdPagamentos.Parameters.AddWithValue("@id", reservaId);
                        cmdPagamentos.ExecuteNonQuery();

                        string queryEditar = "delete from tbl_reservas where reserva_id = @id";

                        MySqlCommand cmd = new MySqlCommand(queryEditar, con);

                        cmd.Parameters.AddWithValue("@id", reservaId);

                        if (cmd.ExecuteNonQuery() == 1)
                        {
                            MySqlCommand cmdUpdateLugar = new MySqlCommand("update tbl_lugares set estado='livre', user_fk = NULL where lugar_id = @lugarId", con);
                            cmdUpdateLugar.Parameters.AddWithValue("@lugarId", lugarId);
                            cmdUpdateLugar.ExecuteNonQuery();

                            MessageBox.Show("Registo apagado com sucesso!");
                            carregarDados();
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Houve um erro ao apagar esta reserva.\nPor favor contacte um administrador", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
