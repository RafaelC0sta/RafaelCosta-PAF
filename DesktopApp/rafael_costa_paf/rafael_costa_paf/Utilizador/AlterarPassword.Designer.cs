namespace rafael_costa_paf
{
    partial class AlterarPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlterarPassword));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_sair = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_novaPassword = new System.Windows.Forms.TextBox();
            this.tb_confirmarPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_mudarPassword = new System.Windows.Forms.Button();
            this.btn_ver1 = new System.Windows.Forms.Button();
            this.btn_ver2 = new System.Windows.Forms.Button();
            this.btn_esconder = new System.Windows.Forms.Button();
            this.btn_esconder2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Altere a sua password";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(145)))));
            this.panel1.Controls.Add(this.btn_sair);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(576, 41);
            this.panel1.TabIndex = 1;
            // 
            // btn_sair
            // 
            this.btn_sair.FlatAppearance.BorderSize = 0;
            this.btn_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sair.ForeColor = System.Drawing.Color.White;
            this.btn_sair.Location = new System.Drawing.Point(531, 4);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(42, 34);
            this.btn_sair.TabIndex = 0;
            this.btn_sair.Text = "X";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(215, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nova Password:";
            // 
            // tb_novaPassword
            // 
            this.tb_novaPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_novaPassword.Location = new System.Drawing.Point(158, 147);
            this.tb_novaPassword.Name = "tb_novaPassword";
            this.tb_novaPassword.PasswordChar = '•';
            this.tb_novaPassword.Size = new System.Drawing.Size(260, 29);
            this.tb_novaPassword.TabIndex = 3;
            // 
            // tb_confirmarPassword
            // 
            this.tb_confirmarPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_confirmarPassword.Location = new System.Drawing.Point(158, 216);
            this.tb_confirmarPassword.Name = "tb_confirmarPassword";
            this.tb_confirmarPassword.PasswordChar = '•';
            this.tb_confirmarPassword.Size = new System.Drawing.Size(260, 29);
            this.tb_confirmarPassword.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(197, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Confirmar Password:";
            // 
            // btn_mudarPassword
            // 
            this.btn_mudarPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(145)))));
            this.btn_mudarPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mudarPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mudarPassword.ForeColor = System.Drawing.Color.White;
            this.btn_mudarPassword.Location = new System.Drawing.Point(179, 267);
            this.btn_mudarPassword.Name = "btn_mudarPassword";
            this.btn_mudarPassword.Size = new System.Drawing.Size(219, 47);
            this.btn_mudarPassword.TabIndex = 6;
            this.btn_mudarPassword.Text = "Alterar Password";
            this.btn_mudarPassword.UseVisualStyleBackColor = false;
            this.btn_mudarPassword.Click += new System.EventHandler(this.btn_mudarPassword_Click);
            // 
            // btn_ver1
            // 
            this.btn_ver1.BackColor = System.Drawing.Color.White;
            this.btn_ver1.FlatAppearance.BorderSize = 0;
            this.btn_ver1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ver1.Image = ((System.Drawing.Image)(resources.GetObject("btn_ver1.Image")));
            this.btn_ver1.Location = new System.Drawing.Point(387, 148);
            this.btn_ver1.Name = "btn_ver1";
            this.btn_ver1.Size = new System.Drawing.Size(28, 25);
            this.btn_ver1.TabIndex = 7;
            this.btn_ver1.UseVisualStyleBackColor = false;
            this.btn_ver1.Click += new System.EventHandler(this.btn_ver1_Click_1);
            // 
            // btn_ver2
            // 
            this.btn_ver2.BackColor = System.Drawing.Color.White;
            this.btn_ver2.FlatAppearance.BorderSize = 0;
            this.btn_ver2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ver2.Image = ((System.Drawing.Image)(resources.GetObject("btn_ver2.Image")));
            this.btn_ver2.Location = new System.Drawing.Point(387, 218);
            this.btn_ver2.Name = "btn_ver2";
            this.btn_ver2.Size = new System.Drawing.Size(28, 25);
            this.btn_ver2.TabIndex = 8;
            this.btn_ver2.UseVisualStyleBackColor = false;
            this.btn_ver2.Click += new System.EventHandler(this.btn_ver2_Click_1);
            // 
            // btn_esconder
            // 
            this.btn_esconder.BackColor = System.Drawing.Color.White;
            this.btn_esconder.FlatAppearance.BorderSize = 0;
            this.btn_esconder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_esconder.Image = ((System.Drawing.Image)(resources.GetObject("btn_esconder.Image")));
            this.btn_esconder.Location = new System.Drawing.Point(387, 148);
            this.btn_esconder.Name = "btn_esconder";
            this.btn_esconder.Size = new System.Drawing.Size(28, 24);
            this.btn_esconder.TabIndex = 9;
            this.btn_esconder.UseVisualStyleBackColor = false;
            this.btn_esconder.Click += new System.EventHandler(this.btn_esconder_Click);
            // 
            // btn_esconder2
            // 
            this.btn_esconder2.BackColor = System.Drawing.Color.White;
            this.btn_esconder2.FlatAppearance.BorderSize = 0;
            this.btn_esconder2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_esconder2.Image = ((System.Drawing.Image)(resources.GetObject("btn_esconder2.Image")));
            this.btn_esconder2.Location = new System.Drawing.Point(387, 217);
            this.btn_esconder2.Name = "btn_esconder2";
            this.btn_esconder2.Size = new System.Drawing.Size(28, 26);
            this.btn_esconder2.TabIndex = 10;
            this.btn_esconder2.UseVisualStyleBackColor = false;
            this.btn_esconder2.Click += new System.EventHandler(this.btn_esconder2_Click_1);
            // 
            // AlterarPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(576, 354);
            this.Controls.Add(this.btn_ver2);
            this.Controls.Add(this.btn_esconder2);
            this.Controls.Add(this.btn_ver1);
            this.Controls.Add(this.btn_esconder);
            this.Controls.Add(this.btn_mudarPassword);
            this.Controls.Add(this.tb_confirmarPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_novaPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AlterarPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AlterarPassword";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_novaPassword;
        private System.Windows.Forms.TextBox tb_confirmarPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_mudarPassword;
        private System.Windows.Forms.Button btn_ver1;
        private System.Windows.Forms.Button btn_ver2;
        private System.Windows.Forms.Button btn_esconder;
        private System.Windows.Forms.Button btn_esconder2;
    }
}