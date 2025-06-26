using iTextSharp.text;
using iTextSharp.text.pdf;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rafael_costa_paf
{
    public partial class PaginaUser : Form
    {
        string numeroVoo;
        int reserva_id;

        public PaginaUser()
        {
            InitializeComponent();
        }

        private void PaginaUser_Load(object sender, EventArgs e)
        {
            carregarDados();
        }

        private void carregarDados()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(Geral.connectionString))
                {
                    string query = "select r.reserva_id as `ID`, u.nomecompleto as `Nome`, v.numero_voo as `Número do Voo`, l.numero_lugar as `Lugar`, r.data_reserva as `Data da Reserva`, r.pagamento as `Método de Pagamento` from tbl_reservas as r join tbl_users as u on r.user_fk = u.user_id join tbl_voos as v on r.voo_fk = v.voo_id join tbl_lugares as l on r.lugar = l.lugar_id where u.user_id = @id;";

                    MySqlCommand cmd = new MySqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@id", Geral.user_id);

                    con.Open();

                    MySqlDataAdapter da = new MySqlDataAdapter();
                    da.SelectCommand = cmd;

                    DataTable dt = new DataTable();

                    da.Fill(dt);
                    gv_verReservas.DataSource = dt;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao carregar dados\nPor favor contacte o administrador", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_maisDetalhes_Click(object sender, EventArgs e)
        {
            if (numeroVoo != null)
            {
                new DetalhesVoo(numeroVoo).ShowDialog();
            }
            else
            {
                MessageBox.Show("Por favor, selecione um registo\nÉ necessário carregar numa linha");
            }
        }

        private void gv_verReservas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = gv_verReservas.Rows[e.RowIndex];
                numeroVoo = row.Cells[2].Value.ToString();
                reserva_id = Convert.ToInt16(row.Cells[0].Value);
            }
        }

        private void btn_downloadPdf_Click(object sender, EventArgs e)
        {
            if (reserva_id != 0)
            {
                try
                {
                    SaveFileDialog saveFile = new SaveFileDialog();
                    saveFile.Filter = "Ficheiros PDF (*.pdf)|*.pdf";
                    saveFile.Title = "Guardar PDF";
                    saveFile.FileName = "detalhesVoo_" + numeroVoo + ".pdf";

                    string query = @"SELECT r.reserva_id, v.numero_voo, v.cidade_destino, ap1.aeroporto_nome AS aeroporto_partida, ap2.aeroporto_nome AS aeroporto_destino, v.data_partida, v.data_chegada, v.preco_voo, a.modelo, l.numero_lugar, p.metodo_pagamento, p.valor, p.data_pagamento FROM tbl_reservas r LEFT JOIN tbl_voos v ON r.voo_fk = v.voo_id LEFT JOIN tbl_aeronaves a ON v.aeronave_fk = a.aeronave_id LEFT JOIN tbl_aeroportos ap1 ON v.aeroporto_partida = ap1.aeroporto_id LEFT JOIN tbl_aeroportos ap2 ON v.aeroporto_destino = ap2.aeroporto_id LEFT JOIN tbl_pagamentos p ON r.reserva_id = p.reserva_fk JOIN tbl_lugares l ON r.lugar = l.lugar_id where r.reserva_id=@reservaId;";

                    if (saveFile.ShowDialog() == DialogResult.OK)
                    {
                        using (MySqlConnection con = new MySqlConnection(Geral.connectionString))
                        {
                            con.Open();

                            using (MySqlCommand cmd = new MySqlCommand(query, con))
                            {
                                cmd.Parameters.AddWithValue("@reservaId", reserva_id);

                                using (MySqlDataReader reader = cmd.ExecuteReader())
                                {
                                    if (reader.Read())
                                    {
                                        string path = saveFile.FileName;

                                        using (FileStream stream = new FileStream(path, FileMode.Create))
                                        {
                                            Document pdfDoc = new Document(PageSize.A5);
                                            PdfWriter.GetInstance(pdfDoc, stream);
                                            pdfDoc.Open();

                                            pdfDoc.Add(new Paragraph("=================================================\n==========       \t              Dados do Voo      \t           ==========\n=================================================\n"));
                                            pdfDoc.Add(new Paragraph("\nNúmero do Voo: " + reader["numero_voo"].ToString()));
                                            pdfDoc.Add(new Paragraph("Cidade de Destino: " + reader["cidade_destino"].ToString()));
                                            pdfDoc.Add(new Paragraph("Aeroporto de Partida: " + reader["aeroporto_partida"].ToString()));
                                            pdfDoc.Add(new Paragraph("Aeroporto de Destino: " + reader["aeroporto_destino"].ToString()));
                                            pdfDoc.Add(new Paragraph("Data de Partida: " + Convert.ToDateTime(reader["data_partida"]).ToShortDateString()));
                                            pdfDoc.Add(new Paragraph("Data de Chegada: " + Convert.ToDateTime(reader["data_chegada"]).ToShortDateString()));
                                            pdfDoc.Add(new Paragraph("Lugar: " + reader["numero_lugar"].ToString()));
                                            pdfDoc.Add(new Paragraph("Valor do Voo: " + reader["preco_voo"].ToString() + "€"));
                                            pdfDoc.Add(new Paragraph("Modelo do Avião: " + reader["modelo"].ToString()));

                                            pdfDoc.Add(new Paragraph("\nDados de Pagamento"));
                                            pdfDoc.Add(new Paragraph("Método de Pagamento: " + reader["metodo_pagamento"].ToString()));
                                            pdfDoc.Add(new Paragraph("Valor Pago: " + reader["valor"].ToString() + "€"));
                                            pdfDoc.Add(new Paragraph("Data de Pagamento: " + Convert.ToDateTime(reader["data_pagamento"]).ToShortDateString()));

                                            pdfDoc.Add(new Paragraph("\n=================================================\nEste documento foi emitido pela empresa AirAtec na data de: " + DateTime.Now));

                                            System.Drawing.Image img = Properties.Resources.airatec;
                                            using (MemoryStream ms = new MemoryStream())
                                            {
                                                img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                                                iTextSharp.text.Image pdfImage = iTextSharp.text.Image.GetInstance(ms.ToArray());
                                                pdfImage.ScaleToFit(100f, 100f);
                                                pdfImage.Alignment = Element.ALIGN_CENTER;

                                                pdfDoc.Add(pdfImage);
                                            }

                                            pdfDoc.Close();
                                            stream.Close();
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Erro ao gerar pdf.\nPor favor contacte o administrador\nErro: ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione um registo\nÉ necessário carregar numa linha");
            }
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Geral.user_id = 0;
            Geral.username = "";
            Geral.nivel = "";
            Geral.TrocarForm(this, new Login());
        }
    }
}
