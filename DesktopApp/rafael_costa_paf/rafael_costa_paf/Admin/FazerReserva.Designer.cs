namespace rafael_costa_paf
{
    partial class FazerReserva
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
            this.label2 = new System.Windows.Forms.Label();
            this.gv_dadosReservas = new System.Windows.Forms.DataGridView();
            this.cb_utilizadores = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_voo = new System.Windows.Forms.ComboBox();
            this.cb_pagamento = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_reservar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.num_lugares = new System.Windows.Forms.NumericUpDown();
            this.check_lugares = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_apagar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gv_dadosReservas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_lugares)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 51);
            this.label2.TabIndex = 4;
            this.label2.Text = "Reservas";
            // 
            // gv_dadosReservas
            // 
            this.gv_dadosReservas.AllowUserToAddRows = false;
            this.gv_dadosReservas.AllowUserToDeleteRows = false;
            this.gv_dadosReservas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gv_dadosReservas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gv_dadosReservas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(145)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(145)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_dadosReservas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gv_dadosReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gv_dadosReservas.DefaultCellStyle = dataGridViewCellStyle2;
            this.gv_dadosReservas.EnableHeadersVisualStyles = false;
            this.gv_dadosReservas.Location = new System.Drawing.Point(20, 73);
            this.gv_dadosReservas.MultiSelect = false;
            this.gv_dadosReservas.Name = "gv_dadosReservas";
            this.gv_dadosReservas.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_dadosReservas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gv_dadosReservas.RowHeadersVisible = false;
            this.gv_dadosReservas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv_dadosReservas.Size = new System.Drawing.Size(982, 269);
            this.gv_dadosReservas.TabIndex = 5;
            this.gv_dadosReservas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_dadosReservas_CellClick);
            // 
            // cb_utilizadores
            // 
            this.cb_utilizadores.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cb_utilizadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_utilizadores.FormattingEnabled = true;
            this.cb_utilizadores.Location = new System.Drawing.Point(20, 393);
            this.cb_utilizadores.Name = "cb_utilizadores";
            this.cb_utilizadores.Size = new System.Drawing.Size(200, 28);
            this.cb_utilizadores.TabIndex = 6;
            this.cb_utilizadores.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_utilizadores_KeyPress);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 370);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Utilizador:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(252, 370);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Voo:";
            // 
            // cb_voo
            // 
            this.cb_voo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cb_voo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_voo.FormattingEnabled = true;
            this.cb_voo.Location = new System.Drawing.Point(256, 393);
            this.cb_voo.Name = "cb_voo";
            this.cb_voo.Size = new System.Drawing.Size(111, 28);
            this.cb_voo.TabIndex = 9;
            this.cb_voo.SelectedValueChanged += new System.EventHandler(this.cb_voo_SelectedValueChanged);
            this.cb_voo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_voo_KeyPress);
            // 
            // cb_pagamento
            // 
            this.cb_pagamento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cb_pagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_pagamento.FormattingEnabled = true;
            this.cb_pagamento.Items.AddRange(new object[] {
            "Cartão",
            "Dinheiro",
            "MB Way"});
            this.cb_pagamento.Location = new System.Drawing.Point(20, 460);
            this.cb_pagamento.Name = "cb_pagamento";
            this.cb_pagamento.Size = new System.Drawing.Size(167, 28);
            this.cb_pagamento.TabIndex = 13;
            this.cb_pagamento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_pagamento_KeyPress);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 437);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Pagamento:";
            // 
            // btn_reservar
            // 
            this.btn_reservar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_reservar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(145)))));
            this.btn_reservar.FlatAppearance.BorderSize = 0;
            this.btn_reservar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reservar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reservar.ForeColor = System.Drawing.Color.White;
            this.btn_reservar.Location = new System.Drawing.Point(21, 522);
            this.btn_reservar.Name = "btn_reservar";
            this.btn_reservar.Size = new System.Drawing.Size(140, 54);
            this.btn_reservar.TabIndex = 14;
            this.btn_reservar.Text = "Reservar";
            this.btn_reservar.UseVisualStyleBackColor = false;
            this.btn_reservar.Click += new System.EventHandler(this.btn_reservar_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(394, 370);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Selecione o Lugar:";
            // 
            // num_lugares
            // 
            this.num_lugares.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.num_lugares.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_lugares.Location = new System.Drawing.Point(222, 460);
            this.num_lugares.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_lugares.Name = "num_lugares";
            this.num_lugares.Size = new System.Drawing.Size(120, 26);
            this.num_lugares.TabIndex = 18;
            this.num_lugares.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_lugares.ValueChanged += new System.EventHandler(this.num_lugares_ValueChanged);
            // 
            // check_lugares
            // 
            this.check_lugares.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.check_lugares.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_lugares.FormattingEnabled = true;
            this.check_lugares.Location = new System.Drawing.Point(398, 393);
            this.check_lugares.Name = "check_lugares";
            this.check_lugares.Size = new System.Drawing.Size(147, 130);
            this.check_lugares.TabIndex = 19;
            this.check_lugares.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.check_lugares_ItemCheck);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(218, 437);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Número de lugares:";
            // 
            // btn_apagar
            // 
            this.btn_apagar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_apagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(145)))));
            this.btn_apagar.FlatAppearance.BorderSize = 0;
            this.btn_apagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_apagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_apagar.ForeColor = System.Drawing.Color.White;
            this.btn_apagar.Location = new System.Drawing.Point(191, 522);
            this.btn_apagar.Name = "btn_apagar";
            this.btn_apagar.Size = new System.Drawing.Size(140, 54);
            this.btn_apagar.TabIndex = 21;
            this.btn_apagar.Text = "Apagar";
            this.btn_apagar.UseVisualStyleBackColor = false;
            this.btn_apagar.Click += new System.EventHandler(this.btn_apagar_Click);
            // 
            // FazerReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1024, 780);
            this.Controls.Add(this.btn_apagar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.check_lugares);
            this.Controls.Add(this.num_lugares);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_reservar);
            this.Controls.Add(this.cb_pagamento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cb_voo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_utilizadores);
            this.Controls.Add(this.gv_dadosReservas);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FazerReserva";
            this.Text = "FazerReserva";
            this.Load += new System.EventHandler(this.FazerReserva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gv_dadosReservas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_lugares)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gv_dadosReservas;
        private System.Windows.Forms.ComboBox cb_utilizadores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_voo;
        private System.Windows.Forms.ComboBox cb_pagamento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_reservar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown num_lugares;
        private System.Windows.Forms.CheckedListBox check_lugares;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_apagar;
    }
}