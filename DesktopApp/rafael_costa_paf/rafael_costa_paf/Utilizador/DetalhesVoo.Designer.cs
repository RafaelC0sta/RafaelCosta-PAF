namespace rafael_costa_paf
{
    partial class DetalhesVoo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetalhesVoo));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_numeroVoo = new System.Windows.Forms.TextBox();
            this.tb_cidadeDestino = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_aeroportoPartida = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_aeroportoDestino = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_dataPartida = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_precoVoo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_modeloAviao = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(145)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btn_close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(734, 50);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Detalhes do Voo";
            // 
            // btn_close
            // 
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.Color.White;
            this.btn_close.Location = new System.Drawing.Point(686, 8);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(40, 35);
            this.btn_close.TabIndex = 1;
            this.btn_close.Text = "X";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Número do Voo:";
            // 
            // tb_numeroVoo
            // 
            this.tb_numeroVoo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_numeroVoo.Location = new System.Drawing.Point(72, 103);
            this.tb_numeroVoo.Name = "tb_numeroVoo";
            this.tb_numeroVoo.Size = new System.Drawing.Size(141, 26);
            this.tb_numeroVoo.TabIndex = 2;
            this.tb_numeroVoo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_numeroVoo_KeyPress);
            // 
            // tb_cidadeDestino
            // 
            this.tb_cidadeDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_cidadeDestino.Location = new System.Drawing.Point(257, 103);
            this.tb_cidadeDestino.Name = "tb_cidadeDestino";
            this.tb_cidadeDestino.Size = new System.Drawing.Size(180, 26);
            this.tb_cidadeDestino.TabIndex = 4;
            this.tb_cidadeDestino.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_cidadeDestino_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(253, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cidade de Destino:";
            // 
            // tb_aeroportoPartida
            // 
            this.tb_aeroportoPartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_aeroportoPartida.Location = new System.Drawing.Point(478, 103);
            this.tb_aeroportoPartida.Name = "tb_aeroportoPartida";
            this.tb_aeroportoPartida.Size = new System.Drawing.Size(188, 26);
            this.tb_aeroportoPartida.TabIndex = 6;
            this.tb_aeroportoPartida.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_aeroportoPartida_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(474, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Aeroporto de Partida:";
            // 
            // tb_aeroportoDestino
            // 
            this.tb_aeroportoDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_aeroportoDestino.Location = new System.Drawing.Point(72, 173);
            this.tb_aeroportoDestino.Name = "tb_aeroportoDestino";
            this.tb_aeroportoDestino.Size = new System.Drawing.Size(188, 26);
            this.tb_aeroportoDestino.TabIndex = 8;
            this.tb_aeroportoDestino.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_aeroportoDestino_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(68, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Aeroporto de Destino:";
            // 
            // tb_dataPartida
            // 
            this.tb_dataPartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_dataPartida.Location = new System.Drawing.Point(277, 173);
            this.tb_dataPartida.Name = "tb_dataPartida";
            this.tb_dataPartida.Size = new System.Drawing.Size(188, 26);
            this.tb_dataPartida.TabIndex = 10;
            this.tb_dataPartida.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_dataPartida_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(273, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Data de Partida:";
            // 
            // tb_precoVoo
            // 
            this.tb_precoVoo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_precoVoo.Location = new System.Drawing.Point(478, 173);
            this.tb_precoVoo.Name = "tb_precoVoo";
            this.tb_precoVoo.Size = new System.Drawing.Size(188, 26);
            this.tb_precoVoo.TabIndex = 12;
            this.tb_precoVoo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_precoVoo_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(474, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Preço do Voo:";
            // 
            // tb_modeloAviao
            // 
            this.tb_modeloAviao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_modeloAviao.Location = new System.Drawing.Point(72, 237);
            this.tb_modeloAviao.Name = "tb_modeloAviao";
            this.tb_modeloAviao.Size = new System.Drawing.Size(188, 26);
            this.tb_modeloAviao.TabIndex = 14;
            this.tb_modeloAviao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_modeloAviao_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(68, 214);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Modelo do Avião:";
            // 
            // DetalhesVoo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(734, 491);
            this.Controls.Add(this.tb_modeloAviao);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tb_precoVoo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_dataPartida);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_aeroportoDestino);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_aeroportoPartida);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_cidadeDestino);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_numeroVoo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DetalhesVoo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DetalhesVoo";
            this.Load += new System.EventHandler(this.DetalhesVoo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_numeroVoo;
        private System.Windows.Forms.TextBox tb_cidadeDestino;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_aeroportoPartida;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_aeroportoDestino;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_dataPartida;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_precoVoo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_modeloAviao;
        private System.Windows.Forms.Label label8;
    }
}