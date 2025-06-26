namespace rafael_costa_paf.Admin
{
    partial class GerirAeronaves
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GerirAeronaves));
            this.gv_avioes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_modelo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.num_capacidade = new System.Windows.Forms.NumericUpDown();
            this.btn_inserirAviao = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_inserirImagem = new System.Windows.Forms.Button();
            this.pb_aeronave = new System.Windows.Forms.PictureBox();
            this.btn_apagar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gv_avioes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_capacidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_aeronave)).BeginInit();
            this.SuspendLayout();
            // 
            // gv_avioes
            // 
            this.gv_avioes.AllowUserToAddRows = false;
            this.gv_avioes.AllowUserToDeleteRows = false;
            this.gv_avioes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gv_avioes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gv_avioes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(145)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(145)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_avioes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gv_avioes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gv_avioes.DefaultCellStyle = dataGridViewCellStyle2;
            this.gv_avioes.EnableHeadersVisualStyles = false;
            this.gv_avioes.Location = new System.Drawing.Point(12, 73);
            this.gv_avioes.MultiSelect = false;
            this.gv_avioes.Name = "gv_avioes";
            this.gv_avioes.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_avioes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gv_avioes.RowHeadersVisible = false;
            this.gv_avioes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv_avioes.Size = new System.Drawing.Size(1000, 269);
            this.gv_avioes.TabIndex = 5;
            this.gv_avioes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_avioes_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 51);
            this.label1.TabIndex = 4;
            this.label1.Text = "Gerir Aviões";
            // 
            // tb_modelo
            // 
            this.tb_modelo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tb_modelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_modelo.Location = new System.Drawing.Point(138, 391);
            this.tb_modelo.Name = "tb_modelo";
            this.tb_modelo.Size = new System.Drawing.Size(184, 26);
            this.tb_modelo.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(134, 368);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Modelo do Avião:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(344, 368);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Capacidade do Avião:";
            // 
            // num_capacidade
            // 
            this.num_capacidade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.num_capacidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_capacidade.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.num_capacidade.Location = new System.Drawing.Point(348, 392);
            this.num_capacidade.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.num_capacidade.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.num_capacidade.Name = "num_capacidade";
            this.num_capacidade.Size = new System.Drawing.Size(120, 26);
            this.num_capacidade.TabIndex = 19;
            this.num_capacidade.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // btn_inserirAviao
            // 
            this.btn_inserirAviao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_inserirAviao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(145)))));
            this.btn_inserirAviao.FlatAppearance.BorderSize = 0;
            this.btn_inserirAviao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_inserirAviao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inserirAviao.ForeColor = System.Drawing.Color.White;
            this.btn_inserirAviao.Location = new System.Drawing.Point(21, 451);
            this.btn_inserirAviao.Name = "btn_inserirAviao";
            this.btn_inserirAviao.Size = new System.Drawing.Size(146, 46);
            this.btn_inserirAviao.TabIndex = 20;
            this.btn_inserirAviao.Text = "Inserir Avião";
            this.btn_inserirAviao.UseVisualStyleBackColor = false;
            this.btn_inserirAviao.Click += new System.EventHandler(this.btn_inserirAviao_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_editar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(145)))));
            this.btn_editar.FlatAppearance.BorderSize = 0;
            this.btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editar.ForeColor = System.Drawing.Color.White;
            this.btn_editar.Location = new System.Drawing.Point(185, 451);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(146, 46);
            this.btn_editar.TabIndex = 22;
            this.btn_editar.Text = "Editar Avião";
            this.btn_editar.UseVisualStyleBackColor = false;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // tb_id
            // 
            this.tb_id.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tb_id.Enabled = false;
            this.tb_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_id.Location = new System.Drawing.Point(21, 391);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(87, 26);
            this.tb_id.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 368);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "ID:";
            // 
            // btn_limpar
            // 
            this.btn_limpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_limpar.FlatAppearance.BorderSize = 0;
            this.btn_limpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limpar.Image = global::rafael_costa_paf.Properties.Resources.broom;
            this.btn_limpar.Location = new System.Drawing.Point(348, 457);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(40, 36);
            this.btn_limpar.TabIndex = 25;
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // btn_inserirImagem
            // 
            this.btn_inserirImagem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_inserirImagem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(145)))));
            this.btn_inserirImagem.FlatAppearance.BorderSize = 0;
            this.btn_inserirImagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_inserirImagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inserirImagem.ForeColor = System.Drawing.Color.White;
            this.btn_inserirImagem.Location = new System.Drawing.Point(185, 513);
            this.btn_inserirImagem.Name = "btn_inserirImagem";
            this.btn_inserirImagem.Size = new System.Drawing.Size(146, 46);
            this.btn_inserirImagem.TabIndex = 26;
            this.btn_inserirImagem.Text = "Inserir Imagem";
            this.btn_inserirImagem.UseVisualStyleBackColor = false;
            this.btn_inserirImagem.Click += new System.EventHandler(this.btn_inserirImagem_Click);
            // 
            // pb_aeronave
            // 
            this.pb_aeronave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_aeronave.Location = new System.Drawing.Point(617, 457);
            this.pb_aeronave.Name = "pb_aeronave";
            this.pb_aeronave.Size = new System.Drawing.Size(351, 223);
            this.pb_aeronave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_aeronave.TabIndex = 27;
            this.pb_aeronave.TabStop = false;
            // 
            // btn_apagar
            // 
            this.btn_apagar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_apagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(145)))));
            this.btn_apagar.FlatAppearance.BorderSize = 0;
            this.btn_apagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_apagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_apagar.ForeColor = System.Drawing.Color.White;
            this.btn_apagar.Location = new System.Drawing.Point(21, 513);
            this.btn_apagar.Name = "btn_apagar";
            this.btn_apagar.Size = new System.Drawing.Size(146, 46);
            this.btn_apagar.TabIndex = 28;
            this.btn_apagar.Text = "Apagar Avião";
            this.btn_apagar.UseVisualStyleBackColor = false;
            this.btn_apagar.Click += new System.EventHandler(this.btn_apagar_Click);
            // 
            // GerirAeronaves
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.btn_apagar);
            this.Controls.Add(this.pb_aeronave);
            this.Controls.Add(this.btn_inserirImagem);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.btn_inserirAviao);
            this.Controls.Add(this.num_capacidade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_modelo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.gv_avioes);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GerirAeronaves";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GerirAeronaves";
            this.Load += new System.EventHandler(this.GerirAeronaves_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gv_avioes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_capacidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_aeronave)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gv_avioes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_modelo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown num_capacidade;
        private System.Windows.Forms.Button btn_inserirAviao;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button btn_inserirImagem;
        private System.Windows.Forms.PictureBox pb_aeronave;
        private System.Windows.Forms.Button btn_apagar;
    }
}