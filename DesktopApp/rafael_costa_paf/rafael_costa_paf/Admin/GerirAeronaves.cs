using MySql.Data.MySqlClient;
using rafael_costa_paf.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rafael_costa_paf.Admin
{
    public partial class GerirAeronaves : Form
    {
        public GerirAeronaves()
        {
            InitializeComponent();
        }

        string queryCarregar = "select aeronave_id as 'ID', modelo as 'Modelo', capacidade as 'Capacidade' from tbl_aeronaves";

        private void GerirAeronaves_Load(object sender, EventArgs e)
        {
            Geral.carregarDados(queryCarregar, gv_avioes);
            tb_id.Enabled = false;
            pb_aeronave.Image = Resources.semImagem;
            pb_aeronave.Tag = "semImagem";
        }

        private void clearFields()
        {
            tb_id.Text = "";
            tb_modelo.Text = "";
            num_capacidade.Value = 2;
            pb_aeronave.Image = Resources.semImagem;
            pb_aeronave.Tag = "semImagem";
        }

        private void btn_inserirAviao_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_modelo.Text == "")
                {
                    MessageBox.Show("É necessário preencher todos os campos.");
                }
                else
                {
                    using (MySqlConnection con = new MySqlConnection(Geral.connectionString))
                    {
                        bool isNullOrEmpty = pb_aeronave == null || pb_aeronave.Image == null;

                        if (pb_aeronave.Tag != null && pb_aeronave.Tag.ToString() == "semImagem")
                            MessageBox.Show("Insira uma imagem!", "Imagem...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        else
                        {
                            MemoryStream ms = new MemoryStream();
                            pb_aeronave.Image.Save(ms, pb_aeronave.Image.RawFormat);
                            byte[] img = ms.ToArray();

                            string query = "insert into tbl_aeronaves (modelo, capacidade, imagem) values (@modelo, @capacidade, @foto);";

                            con.Open();

                            MySqlCommand cmd = new MySqlCommand(query, con);

                            cmd.Parameters.AddWithValue("@modelo", tb_modelo.Text);
                            cmd.Parameters.AddWithValue("@capacidade", num_capacidade.Value);

                            cmd.Parameters.Add("@foto", MySqlDbType.MediumBlob);
                            cmd.Parameters["@foto"].Value = img;

                            if (cmd.ExecuteNonQuery() == 1)
                            {
                                MessageBox.Show("Registo inserido com sucesso!", "Registos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                con.Close();
                            }
                            else
                            {
                                MessageBox.Show("Algo aconteceu com a inseração de registo. Tente novamente!", "Erro...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                Geral.carregarDados(queryCarregar, gv_avioes);
                clearFields();
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao inserir aeronave\nPor favor contacte um administrador.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        string imagem;
        private void gv_avioes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = gv_avioes.Rows[e.RowIndex];
                tb_id.Text = row.Cells[0].Value.ToString();
                tb_modelo.Text = row.Cells[1].Value.ToString();
                num_capacidade.Value = Convert.ToInt16(row.Cells[2].Value);
                imagem = row.Cells[0].Value.ToString();

                try
                {
                    using (MySqlConnection con = new MySqlConnection(Geral.connectionString))
                    {
                        string query = "select imagem from tbl_aeronaves where aeronave_id = @id";
                        con.Open();

                        MySqlCommand cmd = new MySqlCommand(query, con);

                        cmd.Parameters.AddWithValue("@id", imagem);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                byte[] imgBytes = (byte[])reader["imagem"];
                                using (MemoryStream ms = new MemoryStream(imgBytes))
                                {
                                    Image img = Image.FromStream(ms);
                                    pb_aeronave.Image = img;
                                }
                            }
                            else
                            {
                                pb_aeronave.Image = Resources.semImagem;
                                pb_aeronave.Tag = "semImagem";
                            }
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Houve um erro a carregar imagem\nPor favor contacte um administrador", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    pb_aeronave.Image = Resources.semImagem;
                    pb_aeronave.Tag = "semImagem";
                }
            } 
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_id.Text == "")
                {
                    MessageBox.Show("É necessário preencher todos os campos.");
                }
                else
                {
                    using (MySqlConnection con = new MySqlConnection(Geral.connectionString))
                    {
                        string queryUpdate = "update tbl_aeronaves set modelo=@modelo, capacidade=@capacidade where aeronave_id=@id";

                        con.Open();
                        MySqlCommand cmd = new MySqlCommand(queryUpdate, con);

                        cmd.Parameters.AddWithValue("@modelo", tb_modelo.Text);
                        cmd.Parameters.AddWithValue("@capacidade", num_capacidade.Value);
                        cmd.Parameters.AddWithValue("@id", tb_id.Text);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Avião atualizado com sucesso!");
                        clearFields();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao editar aeronave.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Geral.carregarDados(queryCarregar, gv_avioes);
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void btn_inserirImagem_Click(object sender, EventArgs e)
        {
            try
            {
                pb_aeronave.Image = null;

                OpenFileDialog opf = new OpenFileDialog();
                opf.Title = "Escolha a imagem";
                opf.Filter = "Choose Image(*.jpg; *.png; *.jpeg)|*.jpg; *.png; *.jpeg";
                if (opf.ShowDialog() == DialogResult.OK)
                {
                    pb_aeronave.Image = Image.FromFile(opf.FileName);
                    pb_aeronave.Tag = "comImagem";
                }
                else
                    pb_aeronave.Image = Image.FromFile("..\\..\\Resources\\semImagem.png");
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao inserir imagem.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_apagar_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_id.Text == "")
                {
                    MessageBox.Show("É necessário preencher todos os campos");
                }
                else
                {
                    using (MySqlConnection con = new MySqlConnection(Geral.connectionString))
                    {
                        con.Open();

                        string queryDelete = "delete from tbl_aeronaves where aeronave_id=@id";

                        MySqlCommand cmd = new MySqlCommand(queryDelete, con);
                        cmd.Parameters.AddWithValue("@id", tb_id.Text);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Registo apagado com sucesso!");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao apagar registo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Geral.carregarDados(queryCarregar, gv_avioes);
            clearFields();
        }
    }
}
