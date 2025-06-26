using iTextSharp.text;
using iTextSharp.text.pdf;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.util;
using System.Web;
using System.Web.DynamicData;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace rafael_costa_paf_asp
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["login"] == null)
                Response.Redirect("login.aspx");

            if (!IsPostBack)
                carregarDados();
        }

        private void carregarDados()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(Geral.connectionString))
                {
                    string query = "select r.reserva_id as Reserva, u.nomecompleto as `Nome`, v.numero_voo as `Número do Voo`, l.numero_lugar as `Lugar`, DATE_FORMAT(r.data_reserva, '%d/%m/%Y') as `Data da Reserva`\r\n, r.pagamento as `Pagamento` from tbl_reservas as r join tbl_users as u on r.user_fk = u.user_id join tbl_voos as v on r.voo_fk = v.voo_id join tbl_lugares as l on r.lugar = l.lugar_id where r.user_fk = @user_id order by r.reserva_id asc;";

                    con.Open();

                    MySqlCommand cmd = new MySqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@user_id", Geral.user_id);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataSet ds = new DataSet();

                    adapter.Fill(ds);
                    gv_dadosReservas.DataSource = ds;
                    gv_dadosReservas.DataBind();
                }
            }
            catch (Exception)
            {
                lbl_erro.Text = "Erro ao carregar dados";
            }
        }

        protected void btn_logout_Click(object sender, EventArgs e)
        {
            Session["login"] = null;
            Response.Redirect("login.aspx");
        }

        protected void gv_dadosReservas_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            try
            {
                if (e.CommandName == "Exportar")
                {
                    string reserva_id = e.CommandArgument.ToString();

                    string query = @"SELECT r.reserva_id, v.numero_voo, v.cidade_destino, ap1.aeroporto_nome AS aeroporto_partida, ap2.aeroporto_nome AS aeroporto_destino, v.data_partida, v.data_chegada, v.preco_voo, a.modelo, l.numero_lugar, p.metodo_pagamento, p.valor, p.data_pagamento FROM tbl_reservas r LEFT JOIN tbl_voos v ON r.voo_fk = v.voo_id LEFT JOIN tbl_aeronaves a ON v.aeronave_fk = a.aeronave_id LEFT JOIN tbl_aeroportos ap1 ON v.aeroporto_partida = ap1.aeroporto_id LEFT JOIN tbl_aeroportos ap2 ON v.aeroporto_destino = ap2.aeroporto_id LEFT JOIN tbl_pagamentos p ON r.reserva_id = p.reserva_fk JOIN tbl_lugares l ON r.lugar = l.lugar_id where r.reserva_id=@reservaId;";

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
                                    using (MemoryStream stream = new MemoryStream())
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

                                        pdfDoc.Close();

                                        byte[] bytes = stream.ToArray();
                                        Response.Clear();
                                        Response.ContentType = "application/pdf";
                                        Response.AddHeader("Content-Disposition", "attachment; filename=detalhesVoo_" + reader["numero_voo"].ToString() + ".pdf");
                                        Response.OutputStream.Write(bytes, 0, bytes.Length);
                                        Response.Flush();
                                        Response.End();

                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                lbl_erro.Text = "Houve um erro a exportar para pdf";
            }
        }
    }
}