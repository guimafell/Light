namespace Light_Of_Colors_A_Clara_Solução_Para_Sua_Casa
{
    partial class Cliente
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
            this.PAGO = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TELEFONE = new System.Windows.Forms.TextBox();
            this.SETOR = new System.Windows.Forms.ComboBox();
            this.PERFIL = new System.Windows.Forms.ComboBox();
            this.CONTA = new System.Windows.Forms.TextBox();
            this.N_RUA = new System.Windows.Forms.TextBox();
            this.N_CASA = new System.Windows.Forms.TextBox();
            this.NOME = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PAGO
            // 
            this.PAGO.FormattingEnabled = true;
            this.PAGO.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.PAGO.Location = new System.Drawing.Point(129, 310);
            this.PAGO.Name = "PAGO";
            this.PAGO.Size = new System.Drawing.Size(85, 21);
            this.PAGO.TabIndex = 67;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(12, 314);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 17);
            this.label11.TabIndex = 66;
            this.label11.Text = "Pago*";
            // 
            // TELEFONE
            // 
            this.TELEFONE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TELEFONE.Location = new System.Drawing.Point(129, 193);
            this.TELEFONE.Margin = new System.Windows.Forms.Padding(4);
            this.TELEFONE.Name = "TELEFONE";
            this.TELEFONE.Size = new System.Drawing.Size(159, 13);
            this.TELEFONE.TabIndex = 65;
            // 
            // SETOR
            // 
            this.SETOR.FormattingEnabled = true;
            this.SETOR.Items.AddRange(new object[] {
            "Setor 1",
            "Setor 2",
            "Setor 3",
            "Setor 4"});
            this.SETOR.Location = new System.Drawing.Point(127, 42);
            this.SETOR.Name = "SETOR";
            this.SETOR.Size = new System.Drawing.Size(143, 21);
            this.SETOR.TabIndex = 64;
            // 
            // PERFIL
            // 
            this.PERFIL.FormattingEnabled = true;
            this.PERFIL.Items.AddRange(new object[] {
            "Cliente ",
            "Funcionário"});
            this.PERFIL.Location = new System.Drawing.Point(129, 228);
            this.PERFIL.Name = "PERFIL";
            this.PERFIL.Size = new System.Drawing.Size(141, 21);
            this.PERFIL.TabIndex = 63;
            // 
            // CONTA
            // 
            this.CONTA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CONTA.Location = new System.Drawing.Point(129, 277);
            this.CONTA.Margin = new System.Windows.Forms.Padding(4);
            this.CONTA.Name = "CONTA";
            this.CONTA.Size = new System.Drawing.Size(132, 13);
            this.CONTA.TabIndex = 62;
            // 
            // N_RUA
            // 
            this.N_RUA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.N_RUA.Location = new System.Drawing.Point(129, 117);
            this.N_RUA.Margin = new System.Windows.Forms.Padding(4);
            this.N_RUA.Name = "N_RUA";
            this.N_RUA.Size = new System.Drawing.Size(132, 13);
            this.N_RUA.TabIndex = 61;
            // 
            // N_CASA
            // 
            this.N_CASA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.N_CASA.Location = new System.Drawing.Point(129, 78);
            this.N_CASA.Margin = new System.Windows.Forms.Padding(4);
            this.N_CASA.Name = "N_CASA";
            this.N_CASA.Size = new System.Drawing.Size(132, 13);
            this.N_CASA.TabIndex = 60;
            // 
            // NOME
            // 
            this.NOME.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NOME.Location = new System.Drawing.Point(129, 159);
            this.NOME.Margin = new System.Windows.Forms.Padding(4);
            this.NOME.Name = "NOME";
            this.NOME.Size = new System.Drawing.Size(262, 13);
            this.NOME.TabIndex = 57;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(13, 275);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 17);
            this.label9.TabIndex = 55;
            this.label9.Text = "Conta*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(13, 117);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 17);
            this.label10.TabIndex = 54;
            this.label10.Text = "Nome da Rua*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(10, 45);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 17);
            this.label7.TabIndex = 53;
            this.label7.Text = "Setor*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(11, 78);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 17);
            this.label8.TabIndex = 52;
            this.label8.Text = "N° da casa*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(13, 189);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 51;
            this.label5.Text = "Telefone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(13, 232);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 17);
            this.label6.TabIndex = 50;
            this.label6.Text = "Perfil*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(13, 157);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 47;
            this.label2.Text = "Nome*";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(543, 382);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 38);
            this.button1.TabIndex = 68;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(454, 382);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 38);
            this.button2.TabIndex = 70;
            this.button2.Text = "Voltar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(638, 432);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PAGO);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.TELEFONE);
            this.Controls.Add(this.SETOR);
            this.Controls.Add(this.PERFIL);
            this.Controls.Add(this.CONTA);
            this.Controls.Add(this.N_RUA);
            this.Controls.Add(this.N_CASA);
            this.Controls.Add(this.NOME);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.IsMdiContainer = true;
            this.Name = "Cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.Cliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox PAGO;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TELEFONE;
        private System.Windows.Forms.ComboBox SETOR;
        private System.Windows.Forms.ComboBox PERFIL;
        private System.Windows.Forms.TextBox CONTA;
        private System.Windows.Forms.TextBox N_RUA;
        private System.Windows.Forms.TextBox N_CASA;
        private System.Windows.Forms.TextBox NOME;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}