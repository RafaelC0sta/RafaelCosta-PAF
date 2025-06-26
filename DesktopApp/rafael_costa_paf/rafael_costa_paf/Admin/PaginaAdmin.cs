using MySql.Data.MySqlClient;
using rafael_costa_paf.Admin;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace rafael_costa_paf
{
    public partial class PaginaAdmin : Form
    {
        GerirUtilizadores frmGerirUti = new GerirUtilizadores();
        GerirVoos frmGerirVoos = new GerirVoos();
        FazerReserva frmFazerReserva = new FazerReserva();
        GerirAeroportos frmGerirAeroportos = new GerirAeroportos();
        GerirAeronaves frmGerirAvioes = new GerirAeronaves();

        private Form formAtual;

        public PaginaAdmin()
        {
            InitializeComponent();
        }

        private void PaginaAdmin_Load(object sender, EventArgs e)
        {

        }

        private void AbrirFormPanel(Form formulario)
        {
            if (formAtual != null)
            {
                formAtual.Hide();
            }

            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            panel_Meio.Controls.Add(formulario);
            formulario.Show();

            formAtual = formulario;
        }

        private void btn_gerirUtilizadores_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(frmGerirUti);
        }

        private void btnGerirVoos_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(frmGerirVoos);
        }
        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_logout_Click(object sender, EventArgs e)
        {
            Geral.user_id = 0;
            Geral.username = "";
            Geral.nivel = "";
            Geral.TrocarForm(this, new Login());
        }

        private void btn_fazerReserva_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(frmFazerReserva);
        }

        private void btnGerirAeroportos_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(frmGerirAeroportos);
        }

        private void btn_gerirAvioes_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(frmGerirAvioes);
        }
    }
}
