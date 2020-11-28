namespace Projeto_Hamburgueria___POO
{
    partial class Cadastro_Funcionário
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro_Funcionário));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.jsexo = new System.Windows.Forms.ComboBox();
            this.jdata = new System.Windows.Forms.MaskedTextBox();
            this.jcpf = new System.Windows.Forms.MaskedTextBox();
            this.jnome = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.jemail = new System.Windows.Forms.TextBox();
            this.jcel = new System.Windows.Forms.MaskedTextBox();
            this.jtel = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.salvar = new System.Windows.Forms.Button();
            this.excluir = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dados Pessoais";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.jsexo);
            this.panel1.Controls.Add(this.jdata);
            this.panel1.Controls.Add(this.jcpf);
            this.panel1.Controls.Add(this.jnome);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(785, 152);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // jsexo
            // 
            this.jsexo.Font = new System.Drawing.Font("Calibri", 10F);
            this.jsexo.FormattingEnabled = true;
            this.jsexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.jsexo.Location = new System.Drawing.Point(451, 115);
            this.jsexo.Name = "jsexo";
            this.jsexo.Size = new System.Drawing.Size(313, 23);
            this.jsexo.TabIndex = 9;
            // 
            // jdata
            // 
            this.jdata.Font = new System.Drawing.Font("Calibri", 10F);
            this.jdata.Location = new System.Drawing.Point(451, 47);
            this.jdata.Mask = "00/00/0000";
            this.jdata.Name = "jdata";
            this.jdata.Size = new System.Drawing.Size(313, 24);
            this.jdata.TabIndex = 8;
            this.jdata.ValidatingType = typeof(System.DateTime);
            // 
            // jcpf
            // 
            this.jcpf.Font = new System.Drawing.Font("Calibri", 10F);
            this.jcpf.Location = new System.Drawing.Point(15, 116);
            this.jcpf.Mask = "000,000,000-00";
            this.jcpf.Name = "jcpf";
            this.jcpf.Size = new System.Drawing.Size(321, 24);
            this.jcpf.TabIndex = 7;
            // 
            // jnome
            // 
            this.jnome.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jnome.Location = new System.Drawing.Point(15, 48);
            this.jnome.Name = "jnome";
            this.jnome.Size = new System.Drawing.Size(321, 24);
            this.jnome.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Perpetua", 15.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(448, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "Sexo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Perpetua", 15.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(448, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Data";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Perpetua", 15.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(12, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "CPF";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Perpetua", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(12, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(13, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 24);
            this.label6.TabIndex = 2;
            this.label6.Text = "Contato";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.jemail);
            this.panel2.Controls.Add(this.jcel);
            this.panel2.Controls.Add(this.jtel);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Location = new System.Drawing.Point(12, 240);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(785, 148);
            this.panel2.TabIndex = 3;
            // 
            // jemail
            // 
            this.jemail.Font = new System.Drawing.Font("Calibri", 10F);
            this.jemail.Location = new System.Drawing.Point(15, 107);
            this.jemail.Name = "jemail";
            this.jemail.Size = new System.Drawing.Size(321, 24);
            this.jemail.TabIndex = 7;
            // 
            // jcel
            // 
            this.jcel.Font = new System.Drawing.Font("Calibri", 10F);
            this.jcel.Location = new System.Drawing.Point(451, 49);
            this.jcel.Mask = "(99) 00000-0000";
            this.jcel.Name = "jcel";
            this.jcel.Size = new System.Drawing.Size(313, 24);
            this.jcel.TabIndex = 6;
            // 
            // jtel
            // 
            this.jtel.Font = new System.Drawing.Font("Calibri", 10F);
            this.jtel.Location = new System.Drawing.Point(15, 40);
            this.jtel.Mask = "(99) 0000-0000";
            this.jtel.Name = "jtel";
            this.jtel.Size = new System.Drawing.Size(321, 24);
            this.jtel.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Perpetua", 15.75F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.DarkRed;
            this.label8.Location = new System.Drawing.Point(448, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 24);
            this.label8.TabIndex = 4;
            this.label8.Text = "Celular";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Perpetua", 15.75F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.DarkRed;
            this.label9.Location = new System.Drawing.Point(14, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 24);
            this.label9.TabIndex = 3;
            this.label9.Text = "E-mail";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Perpetua", 15.75F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.DarkRed;
            this.label10.Location = new System.Drawing.Point(12, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 24);
            this.label10.TabIndex = 2;
            this.label10.Text = "Telefone";
            // 
            // salvar
            // 
            this.salvar.BackColor = System.Drawing.Color.Yellow;
            this.salvar.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.salvar.FlatAppearance.BorderSize = 9;
            this.salvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.salvar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.salvar.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.salvar.ForeColor = System.Drawing.Color.Green;
            this.salvar.Location = new System.Drawing.Point(120, 406);
            this.salvar.Name = "salvar";
            this.salvar.Size = new System.Drawing.Size(106, 32);
            this.salvar.TabIndex = 13;
            this.salvar.Text = "Salvar";
            this.salvar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.salvar.UseVisualStyleBackColor = false;
            this.salvar.Click += new System.EventHandler(this.button1_Click);
            // 
            // excluir
            // 
            this.excluir.BackColor = System.Drawing.Color.Yellow;
            this.excluir.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.excluir.FlatAppearance.BorderSize = 9;
            this.excluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.excluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.excluir.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.excluir.ForeColor = System.Drawing.Color.Red;
            this.excluir.Location = new System.Drawing.Point(539, 406);
            this.excluir.Name = "excluir";
            this.excluir.Size = new System.Drawing.Size(106, 32);
            this.excluir.TabIndex = 14;
            this.excluir.Text = "Excluir";
            this.excluir.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.excluir.UseVisualStyleBackColor = false;
            this.excluir.Click += new System.EventHandler(this.excluir_Click);
            // 
            // Cadastro_Funcionário
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.excluir);
            this.Controls.Add(this.salvar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Cadastro_Funcionário";
            this.Text = "Cadastro Funcionário";
            this.Load += new System.EventHandler(this.Cadastro_Funcionário_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox jnome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button salvar;
        private System.Windows.Forms.ComboBox jsexo;
        private System.Windows.Forms.MaskedTextBox jdata;
        private System.Windows.Forms.MaskedTextBox jcpf;
        private System.Windows.Forms.MaskedTextBox jcel;
        private System.Windows.Forms.MaskedTextBox jtel;
        private System.Windows.Forms.TextBox jemail;
        private System.Windows.Forms.Button excluir;
    }
}