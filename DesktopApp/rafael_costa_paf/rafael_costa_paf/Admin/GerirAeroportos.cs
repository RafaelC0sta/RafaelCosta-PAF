using MySql.Data.MySqlClient;
using rafael_costa_paf.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace rafael_costa_paf.Admin
{
    public partial class GerirAeroportos : Form
    {
        public GerirAeroportos()
        {
            InitializeComponent();
        }

        private void GerirAeroportos_Load(object sender, EventArgs e)
        {
            carregarDados();
            pb_aeroporto.Image = Properties.Resources.semImagem;
            pb_aeroporto.Tag = "semImagem";
        }

        private void carregarDados()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(Geral.connectionString))
                {
                    string query = "select aeroporto_id as 'ID', aeroporto_nome as 'Aeroporto', cidade as 'Cidade', pais as 'País' from tbl_aeroportos";

                    con.Open();

                    MySqlCommand cmd = new MySqlCommand(query, con);

                    MySqlDataAdapter da = new MySqlDataAdapter();
                    da.SelectCommand = cmd;

                    DataTable dt = new DataTable();

                    da.Fill(dt);
                    gv_aeroportos.DataSource = dt;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao carregar dados\nPor favor contacte o administrador", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        string imagem;

        
        private void gv_aeroportos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = gv_aeroportos.Rows[e.RowIndex];
                imagem = row.Cells[0].Value.ToString();
                tb_id.Text = row.Cells[0].Value.ToString();
                tb_nomeAeroporto.Text = row.Cells[1].Value.ToString();
                tb_cidade.Text = row.Cells[2].Value.ToString();
                tb_pais.Text = row.Cells[3].Value.ToString();
                
                try
                {
                    using (MySqlConnection con = new MySqlConnection(Geral.connectionString))
                    {
                        string query = "select imagem from tbl_aeroportos where aeroporto_id = @id";
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
                                    pb_aeroporto.Image = img;
                                }
                            }
                            else
                            {
                                pb_aeroporto.Image = Resources.semImagem;
                                pb_aeroporto.Tag = "semImagem";
                            }
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Houve um erro a carregar imagem\nPor favor contacte um administrador", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    pb_aeroporto.Image = Resources.semImagem;
                    pb_aeroporto.Tag = "semImagem";
                }
            }
        }


        private void btn_inserirAeroporto_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_nomeAeroporto.Text == "" && tb_cidade.Text == "" && tb_pais.Text == "")
                {
                    MessageBox.Show("É necessário preencher todos os campos.");
                }
                else
                {
                    using (MySqlConnection con = new MySqlConnection(Geral.connectionString))
                    {
                        if (pb_aeroporto.Tag != null && pb_aeroporto.Tag.ToString() == "semImagem")
                            MessageBox.Show("Insira uma imagem!", "Imagem...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        else
                        {
                            MemoryStream ms = new MemoryStream();
                            pb_aeroporto.Image.Save(ms, pb_aeroporto.Image.RawFormat);
                            byte[] img = ms.ToArray();

                            string query = "insert into tbl_aeroportos (aeroporto_nome, cidade, pais, imagem) values (@nome, @cidade, @pais, @foto);";

                            con.Open();

                            MySqlCommand cmd = new MySqlCommand(query, con);

                            cmd.Parameters.AddWithValue("@nome", tb_nomeAeroporto.Text);
                            cmd.Parameters.AddWithValue("@cidade", tb_cidade.Text);
                            cmd.Parameters.AddWithValue("@pais", tb_pais.Text);

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
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao inserir aeroporto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            carregarDados();
            clearFields();
        }

        private void btn_escolherImagem_Click(object sender, EventArgs e)
        {
            pb_aeroporto.Image = null;

            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg; *.png; *.jpeg)|*.jpg; *.png; *.jpeg";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pb_aeroporto.Image = Image.FromFile(opf.FileName);
                pb_aeroporto.Tag = "comImagem";
            }
            else
                pb_aeroporto.Image = Image.FromFile("..\\..\\Resources\\semImagem.png"); 
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_id.Text == "")
                {
                    MessageBox.Show("É necessário preencher todos os campos!");
                }
                else
                {
                    using (MySqlConnection con = new MySqlConnection(Geral.connectionString))
                    {
                        string queryEditar = "update tbl_aeroportos set aeroporto_nome=@aeroporto_nome, cidade=@cidade, pais=@pais where aeroporto_id=@aeroporto_id";

                        con.Open();

                        MySqlCommand cmd = new MySqlCommand(queryEditar, con);

                        cmd.Parameters.AddWithValue("@aeroporto_nome", tb_nomeAeroporto.Text);
                        cmd.Parameters.AddWithValue("@cidade", tb_cidade.Text);
                        cmd.Parameters.AddWithValue("@pais", tb_pais.Text);
                        cmd.Parameters.AddWithValue("@aeroporto_id", tb_id.Text);

                        if (cmd.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Registo atualizado com sucesso!");
                            carregarDados();
                            clearFields();
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao editar aeroporto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_apagar_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_id.Text == "")
                {
                    MessageBox.Show("É necessário preencher todos os campos!");
                }
                else
                {
                    using (MySqlConnection con = new MySqlConnection(Geral.connectionString))
                    {
                        string queryEditar = "delete from tbl_aeroportos where aeroporto_id=@aeroporto_id";

                        con.Open();

                        MySqlCommand cmd = new MySqlCommand(queryEditar, con);

                        cmd.Parameters.AddWithValue("@aeroporto_id", tb_id.Text);

                        if (cmd.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Registo apagado com sucesso!");
                            carregarDados();
                            clearFields();
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao apagar aeroporto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void clearFields()
        {
            tb_id.Text = "";
            tb_nomeAeroporto.Text = "";
            tb_cidade.Text = "";
            tb_pais.Text = "";
            pb_aeroporto.Image = Resources.semImagem;
            pb_aeroporto.Tag = "semImagem";
        }
    }
}
