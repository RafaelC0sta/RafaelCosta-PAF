namespace rafael_costa_paf
{
    partial class GerirVoos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.gv_dadosVoos = new System.Windows.Forms.DataGridView();
            this.dt_dataPartida = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_numVoo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_aeroportoPartida = new System.Windows.Forms.ComboBox();
            this.cb_aeroportoDestino = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_precoVoo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_cidadeDestino = new System.Windows.Forms.ComboBox();
            this.btn_marcarVoo = new System.Windows.Forms.Button();
            this.cb_aeronave = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dt_dataChegada = new System.Windows.Forms.DateTimePicker();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gv_dadosVoos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gerir Voos";
            // 
            // gv_dadosVoos
            // 
            this.gv_dadosVoos.AllowUserToAddRows = false;
            this.gv_dadosVoos.AllowUserToDeleteRows = false;
            this.gv_dadosVoos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gv_dadosVoos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gv_dadosVoos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(145)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(145)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_dadosVoos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.gv_dadosVoos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gv_dadosVoos.DefaultCellStyle = dataGridViewCellStyle11;
            this.gv_dadosVoos.EnableHeadersVisualStyles = false;
            this.gv_dadosVoos.Location = new System.Drawing.Point(20, 73);
            this.gv_dadosVoos.MultiSelect = false;
            this.gv_dadosVoos.Name = "gv_dadosVoos";
            this.gv_dadosVoos.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_dadosVoos.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.gv_dadosVoos.RowHeadersVisible = false;
            this.gv_dadosVoos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv_dadosVoos.Size = new System.Drawing.Size(982, 269);
            this.gv_dadosVoos.TabIndex = 2;
            this.gv_dadosVoos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_dadosVoos_CellClick);
            // 
            // dt_dataPartida
            // 
            this.dt_dataPartida.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dt_dataPartida.CustomFormat = "dd/MM/yyyy";
            this.dt_dataPartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_dataPartida.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_dataPartida.Location = new System.Drawing.Point(20, 462);
            this.dt_dataPartida.MinDate = new System.DateTime(2025, 6, 6, 0, 0, 0, 0);
            this.dt_dataPartida.Name = "dt_dataPartida";
            this.dt_dataPartida.Size = new System.Drawing.Size(126, 26);
            this.dt_dataPartida.TabIndex = 3;
            this.dt_dataPartida.ValueChanged += new System.EventHandler(this.dt_dataPartida_ValueChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 375);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Número do Voo:";
            // 
            // tb_numVoo
            // 
            this.tb_numVoo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tb_numVoo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_numVoo.Location = new System.Drawing.Point(20, 398);
            this.tb_numVoo.MaxLength = 5;
            this.tb_numVoo.Name = "tb_numVoo";
            this.tb_numVoo.Size = new System.Drawing.Size(129, 26);
            this.tb_numVoo.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(168, 375);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Cidade de Destino:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(371, 377);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Aeroporto de Partida:";
            // 
            // cb_aeroportoPartida
            // 
            this.cb_aeroportoPartida.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cb_aeroportoPartida.BackColor = System.Drawing.Color.White;
            this.cb_aeroportoPartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_aeroportoPartida.FormattingEnabled = true;
            this.cb_aeroportoPartida.Location = new System.Drawing.Point(375, 398);
            this.cb_aeroportoPartida.Name = "cb_aeroportoPartida";
            this.cb_aeroportoPartida.Size = new System.Drawing.Size(179, 28);
            this.cb_aeroportoPartida.TabIndex = 13;
            this.cb_aeroportoPartida.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_aeroportoPartida_KeyPress);
            // 
            // cb_aeroportoDestino
            // 
            this.cb_aeroportoDestino.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cb_aeroportoDestino.BackColor = System.Drawing.Color.White;
            this.cb_aeroportoDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_aeroportoDestino.FormattingEnabled = true;
            this.cb_aeroportoDestino.Location = new System.Drawing.Point(577, 398);
            this.cb_aeroportoDestino.Name = "cb_aeroportoDestino";
            this.cb_aeroportoDestino.Size = new System.Drawing.Size(179, 28);
            this.cb_aeroportoDestino.TabIndex = 15;
            this.cb_aeroportoDestino.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_aeroportoDestino_KeyPress);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(573, 377);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Aeroporto de Destino:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 439);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Data de Partida:";
            // 
            // tb_precoVoo
            // 
            this.tb_precoVoo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tb_precoVoo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_precoVoo.Location = new System.Drawing.Point(543, 462);
            this.tb_precoVoo.Name = "tb_precoVoo";
            this.tb_precoVoo.Size = new System.Drawing.Size(129, 26);
            this.tb_precoVoo.TabIndex = 18;
            this.tb_precoVoo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_precoVoo_KeyPress);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(539, 439);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Valor do Voo:";
            // 
            // cb_cidadeDestino
            // 
            this.cb_cidadeDestino.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cb_cidadeDestino.BackColor = System.Drawing.Color.White;
            this.cb_cidadeDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_cidadeDestino.FormattingEnabled = true;
            this.cb_cidadeDestino.Location = new System.Drawing.Point(172, 398);
            this.cb_cidadeDestino.Name = "cb_cidadeDestino";
            this.cb_cidadeDestino.Size = new System.Drawing.Size(179, 28);
            this.cb_cidadeDestino.TabIndex = 19;
            this.cb_cidadeDestino.SelectedValueChanged += new System.EventHandler(this.cb_cidadeDestino_SelectedValueChanged);
            this.cb_cidadeDestino.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_cidadeDestino_KeyPress);
            // 
            // btn_marcarVoo
            // 
            this.btn_marcarVoo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_marcarVoo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(145)))));
            this.btn_marcarVoo.FlatAppearance.BorderSize = 0;
            this.btn_marcarVoo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_marcarVoo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_marcarVoo.ForeColor = System.Drawing.Color.White;
            this.btn_marcarVoo.Location = new System.Drawing.Point(20, 509);
            this.btn_marcarVoo.Name = "btn_marcarVoo";
            this.btn_marcarVoo.Size = new System.Drawing.Size(140, 54);
            this.btn_marcarVoo.TabIndex = 20;
            this.btn_marcarVoo.Text = "Marcar Voo";
            this.btn_marcarVoo.UseVisualStyleBackColor = false;
            this.btn_marcarVoo.Click += new System.EventHandler(this.btn_marcarVoo_Click);
            // 
            // cb_aeronave
            // 
            this.cb_aeronave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cb_aeronave.BackColor = System.Drawing.Color.White;
            this.cb_aeronave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_aeronave.FormattingEnabled = true;
            this.cb_aeronave.Location = new System.Drawing.Point(340, 462);
            this.cb_aeronave.Name = "cb_aeronave";
            this.cb_aeronave.Size = new System.Drawing.Size(179, 28);
            this.cb_aeronave.TabIndex = 22;
            this.cb_aeronave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_aeronave_KeyPress);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(336, 439);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "Aeronave:";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(169, 439);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 20);
            this.label9.TabIndex = 24;
            this.label9.Text = "Data de Chegada:";
            // 
            // dt_dataChegada
            // 
            this.dt_dataChegada.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dt_dataChegada.CustomFormat = "dd/MM/yyyy";
            this.dt_dataChegada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_dataChegada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_dataChegada.Location = new System.Drawing.Point(172, 462);
            this.dt_dataChegada.MinDate = new System.DateTime(2025, 6, 6, 0, 0, 0, 0);
            this.dt_dataChegada.Name = "dt_dataChegada";
            this.dt_dataChegada.Size = new System.Drawing.Size(140, 26);
            this.dt_dataChegada.TabIndex = 23;
            // 
            // btn_editar
            // 
            this.btn_editar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_editar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(145)))));
            this.btn_editar.FlatAppearance.BorderSize = 0;
            this.btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editar.ForeColor = System.Drawing.Color.White;
            this.btn_editar.Location = new System.Drawing.Point(173, 509);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(140, 54);
            this.btn_editar.TabIndex = 25;
            this.btn_editar.Text = "Editar Voo";
            this.btn_editar.UseVisualStyleBackColor = false;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_limpar
            // 
            this.btn_limpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_limpar.FlatAppearance.BorderSize = 0;
            this.btn_limpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limpar.Image = global::rafael_costa_paf.Properties.Resources.broom;
            this.btn_limpar.Location = new System.Drawing.Point(319, 519);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(40, 36);
            this.btn_limpar.TabIndex = 27;
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(672, 463);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 24);
            this.label10.TabIndex = 28;
            this.label10.Text = "€";
            // 
            // GerirVoos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dt_dataChegada);
            this.Controls.Add(this.cb_aeronave);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_marcarVoo);
            this.Controls.Add(this.cb_cidadeDestino);
            this.Controls.Add(this.tb_precoVoo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cb_aeroportoDestino);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cb_aeroportoPartida);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_numVoo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dt_dataPartida);
            this.Controls.Add(this.gv_dadosVoos);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GerirVoos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GerirVoos";
            this.Load += new System.EventHandler(this.GerirVoos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gv_dadosVoos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gv_dadosVoos;
        private System.Windows.Forms.DateTimePicker dt_dataPartida;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_numVoo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_aeroportoPartida;
        private System.Windows.Forms.ComboBox cb_aeroportoDestino;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_precoVoo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cb_cidadeDestino;
        private System.Windows.Forms.Button btn_marcarVoo;
        private System.Windows.Forms.ComboBox cb_aeronave;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dt_dataChegada;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Label label10;
    }
}