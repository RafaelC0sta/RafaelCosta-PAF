namespace rafael_costa_paf.Admin
{
    partial class GerirAeroportos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GerirAeroportos));
            this.gv_aeroportos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_nomeAeroporto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_cidade = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_pais = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_inserirAeroporto = new System.Windows.Forms.Button();
            this.btn_escolherImagem = new System.Windows.Forms.Button();
            this.pb_aeroporto = new System.Windows.Forms.PictureBox();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_apagar = new System.Windows.Forms.Button();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_limpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gv_aeroportos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_aeroporto)).BeginInit();
            this.SuspendLayout();
            // 
            // gv_aeroportos
            // 
            this.gv_aeroportos.AllowUserToAddRows = false;
            this.gv_aeroportos.AllowUserToDeleteRows = false;
            this.gv_aeroportos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gv_aeroportos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gv_aeroportos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(145)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(145)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_aeroportos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gv_aeroportos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gv_aeroportos.DefaultCellStyle = dataGridViewCellStyle2;
            this.gv_aeroportos.EnableHeadersVisualStyles = false;
            this.gv_aeroportos.Location = new System.Drawing.Point(12, 73);
            this.gv_aeroportos.MultiSelect = false;
            this.gv_aeroportos.Name = "gv_aeroportos";
            this.gv_aeroportos.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_aeroportos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gv_aeroportos.RowHeadersVisible = false;
            this.gv_aeroportos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv_aeroportos.Size = new System.Drawing.Size(1000, 269);
            this.gv_aeroportos.TabIndex = 3;
            this.gv_aeroportos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_aeroportos_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 51);
            this.label1.TabIndex = 2;
            this.label1.Text = "Gerir Aeroportos";
            // 
            // tb_nomeAeroporto
            // 
            this.tb_nomeAeroporto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tb_nomeAeroporto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_nomeAeroporto.Location = new System.Drawing.Point(125, 387);
            this.tb_nomeAeroporto.Name = "tb_nomeAeroporto";
            this.tb_nomeAeroporto.Size = new System.Drawing.Size(184, 26);
            this.tb_nomeAeroporto.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(121, 364);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Nome do Aeroporto:";
            // 
            // tb_cidade
            // 
            this.tb_cidade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tb_cidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_cidade.Location = new System.Drawing.Point(327, 387);
            this.tb_cidade.Name = "tb_cidade";
            this.tb_cidade.Size = new System.Drawing.Size(184, 26);
            this.tb_cidade.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(323, 364);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Cidade:";
            // 
            // tb_pais
            // 
            this.tb_pais.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tb_pais.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_pais.Location = new System.Drawing.Point(525, 387);
            this.tb_pais.Name = "tb_pais";
            this.tb_pais.Size = new System.Drawing.Size(184, 26);
            this.tb_pais.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(521, 364);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "País:";
            // 
            // btn_inserirAeroporto
            // 
            this.btn_inserirAeroporto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_inserirAeroporto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(145)))));
            this.btn_inserirAeroporto.FlatAppearance.BorderSize = 0;
            this.btn_inserirAeroporto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_inserirAeroporto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inserirAeroporto.ForeColor = System.Drawing.Color.White;
            this.btn_inserirAeroporto.Location = new System.Drawing.Point(21, 451);
            this.btn_inserirAeroporto.Name = "btn_inserirAeroporto";
            this.btn_inserirAeroporto.Size = new System.Drawing.Size(146, 46);
            this.btn_inserirAeroporto.TabIndex = 20;
            this.btn_inserirAeroporto.Text = "Inserir Aeroporto";
            this.btn_inserirAeroporto.UseVisualStyleBackColor = false;
            this.btn_inserirAeroporto.Click += new System.EventHandler(this.btn_inserirAeroporto_Click);
            // 
            // btn_escolherImagem
            // 
            this.btn_escolherImagem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_escolherImagem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(145)))));
            this.btn_escolherImagem.FlatAppearance.BorderSize = 0;
            this.btn_escolherImagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_escolherImagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_escolherImagem.ForeColor = System.Drawing.Color.White;
            this.btn_escolherImagem.Location = new System.Drawing.Point(185, 513);
            this.btn_escolherImagem.Name = "btn_escolherImagem";
            this.btn_escolherImagem.Size = new System.Drawing.Size(146, 46);
            this.btn_escolherImagem.TabIndex = 21;
            this.btn_escolherImagem.Text = "Inserir Imagem";
            this.btn_escolherImagem.UseVisualStyleBackColor = false;
            this.btn_escolherImagem.Click += new System.EventHandler(this.btn_escolherImagem_Click);
            // 
            // pb_aeroporto
            // 
            this.pb_aeroporto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_aeroporto.Location = new System.Drawing.Point(617, 457);
            this.pb_aeroporto.Name = "pb_aeroporto";
            this.pb_aeroporto.Size = new System.Drawing.Size(351, 223);
            this.pb_aeroporto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_aeroporto.TabIndex = 22;
            this.pb_aeroporto.TabStop = false;
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
            this.btn_editar.TabIndex = 23;
            this.btn_editar.Text = "Editar Aeroporto";
            this.btn_editar.UseVisualStyleBackColor = false;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
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
            this.btn_apagar.TabIndex = 24;
            this.btn_apagar.Text = "Apagar Aeroporto";
            this.btn_apagar.UseVisualStyleBackColor = false;
            this.btn_apagar.Click += new System.EventHandler(this.btn_apagar_Click);
            // 
            // tb_id
            // 
            this.tb_id.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tb_id.Enabled = false;
            this.tb_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_id.Location = new System.Drawing.Point(21, 387);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(84, 26);
            this.tb_id.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 364);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "ID:";
            // 
            // btn_limpar
            // 
            this.btn_limpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_limpar.FlatAppearance.BorderSize = 0;
            this.btn_limpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limpar.Image = global::rafael_costa_paf.Properties.Resources.broom;
            this.btn_limpar.Location = new System.Drawing.Point(346, 457);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(40, 36);
            this.btn_limpar.TabIndex = 27;
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // GerirAeroportos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.btn_apagar);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.pb_aeroporto);
            this.Controls.Add(this.btn_escolherImagem);
            this.Controls.Add(this.btn_inserirAeroporto);
            this.Controls.Add(this.tb_pais);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_cidade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_nomeAeroporto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.gv_aeroportos);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GerirAeroportos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GerirAeroportos";
            this.Load += new System.EventHandler(this.GerirAeroportos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gv_aeroportos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_aeroporto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gv_aeroportos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_nomeAeroporto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_cidade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_pais;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_inserirAeroporto;
        private System.Windows.Forms.Button btn_escolherImagem;
        private System.Windows.Forms.PictureBox pb_aeroporto;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_apagar;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_limpar;
    }
}