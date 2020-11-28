namespace Projeto_Hamburgueria___POO
{
    partial class Pesquisar_Funcionário
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pesquisar_Funcionário));
            this.Att = new System.Windows.Forms.Button();
            this.remover = new System.Windows.Forms.Button();
            this.Estoque = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.jTable = new System.Windows.Forms.TableLayoutPanel();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Jemail = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.Jnome = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sair = new System.Windows.Forms.Button();
            this.Jcpf = new System.Windows.Forms.MaskedTextBox();
            this.Jdata = new System.Windows.Forms.MaskedTextBox();
            this.Jsexo = new System.Windows.Forms.ComboBox();
            this.Jtel = new System.Windows.Forms.MaskedTextBox();
            this.Jcel = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.jTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // Att
            // 
            this.Att.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Att.AutoSize = true;
            this.Att.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Att.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.Att.FlatAppearance.BorderSize = 10;
            this.Att.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Att.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Att.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Att.Location = new System.Drawing.Point(104, 397);
            this.Att.Name = "Att";
            this.Att.Size = new System.Drawing.Size(105, 31);
            this.Att.TabIndex = 11;
            this.Att.Text = "Atualizar";
            this.Att.UseVisualStyleBackColor = true;
            this.Att.Click += new System.EventHandler(this.Att_Click);
            // 
            // remover
            // 
            this.remover.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.remover.AutoSize = true;
            this.remover.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.remover.BackColor = System.Drawing.Color.Yellow;
            this.remover.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.remover.FlatAppearance.BorderSize = 9;
            this.remover.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.remover.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.remover.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.remover.ForeColor = System.Drawing.Color.Red;
            this.remover.Location = new System.Drawing.Point(380, 397);
            this.remover.Name = "remover";
            this.remover.Size = new System.Drawing.Size(108, 32);
            this.remover.TabIndex = 10;
            this.remover.Text = "Remover";
            this.remover.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.remover.UseVisualStyleBackColor = false;
            this.remover.Click += new System.EventHandler(this.remover_Click);
            // 
            // Estoque
            // 
            this.Estoque.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Estoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Estoque.Font = new System.Drawing.Font("Calisto MT", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Estoque.ForeColor = System.Drawing.Color.Maroon;
            this.Estoque.Location = new System.Drawing.Point(242, 9);
            this.Estoque.Name = "Estoque";
            this.Estoque.Size = new System.Drawing.Size(455, 132);
            this.Estoque.TabIndex = 12;
            this.Estoque.Text = "Pesquisar Funconário";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(82, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 132);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // jTable
            // 
            this.jTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.jTable.BackColor = System.Drawing.Color.Maroon;
            this.jTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.jTable.ColumnCount = 9;
            this.jTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.jTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.jTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.jTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.jTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.jTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.jTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.jTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.jTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.jTable.Controls.Add(this.label13, 8, 0);
            this.jTable.Controls.Add(this.label12, 7, 0);
            this.jTable.Controls.Add(this.label11, 6, 0);
            this.jTable.Controls.Add(this.label10, 5, 0);
            this.jTable.Controls.Add(this.label9, 4, 0);
            this.jTable.Controls.Add(this.label8, 3, 0);
            this.jTable.Controls.Add(this.label7, 0, 4);
            this.jTable.Controls.Add(this.label5, 0, 0);
            this.jTable.Controls.Add(this.label6, 2, 0);
            this.jTable.Controls.Add(this.label4, 1, 0);
            this.jTable.Location = new System.Drawing.Point(84, 278);
            this.jTable.Name = "jTable";
            this.jTable.RowCount = 5;
            this.jTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.jTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.jTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.jTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.jTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.jTable.Size = new System.Drawing.Size(691, 96);
            this.jTable.TabIndex = 14;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label13.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label13.Location = new System.Drawing.Point(518, 3);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 20);
            this.label13.TabIndex = 16;
            this.label13.Text = "Sexo";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label12.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label12.Location = new System.Drawing.Point(465, 3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 20);
            this.label12.TabIndex = 15;
            this.label12.Text = "Data";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label11.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label11.Location = new System.Drawing.Point(416, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 20);
            this.label11.TabIndex = 15;
            this.label11.Text = "CPF";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label10.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label10.Location = new System.Drawing.Point(355, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 20);
            this.label10.TabIndex = 14;
            this.label10.Text = "Cargo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label9.Location = new System.Drawing.Point(293, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 20);
            this.label9.TabIndex = 14;
            this.label9.Text = "E-mail";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Location = new System.Drawing.Point(226, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Celular";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(6, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Telefone";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(6, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(146, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Telefone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(86, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nome";
            // 
            // Jemail
            // 
            this.Jemail.Font = new System.Drawing.Font("Calibri", 10F);
            this.Jemail.Location = new System.Drawing.Point(521, 176);
            this.Jemail.Name = "Jemail";
            this.Jemail.Size = new System.Drawing.Size(132, 24);
            this.Jemail.TabIndex = 39;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Perpetua", 15.75F, System.Drawing.FontStyle.Bold);
            this.label17.Location = new System.Drawing.Point(521, 152);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(67, 24);
            this.label17.TabIndex = 38;
            this.label17.Text = "E-mail";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Perpetua", 15.75F, System.Drawing.FontStyle.Bold);
            this.label16.Location = new System.Drawing.Point(377, 152);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(76, 24);
            this.label16.TabIndex = 36;
            this.label16.Text = "Celular";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Perpetua", 15.75F, System.Drawing.FontStyle.Bold);
            this.label15.Location = new System.Drawing.Point(220, 152);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(88, 24);
            this.label15.TabIndex = 33;
            this.label15.Text = "Telefone";
            // 
            // Jnome
            // 
            this.Jnome.Font = new System.Drawing.Font("Calibri", 10F);
            this.Jnome.Location = new System.Drawing.Point(82, 178);
            this.Jnome.Name = "Jnome";
            this.Jnome.Size = new System.Drawing.Size(128, 24);
            this.Jnome.TabIndex = 32;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Perpetua", 15.75F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(78, 152);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 24);
            this.label14.TabIndex = 31;
            this.label14.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Perpetua", 15.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(376, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 24);
            this.label3.TabIndex = 28;
            this.label3.Text = "Sexo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Perpetua", 15.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(230, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 24);
            this.label2.TabIndex = 27;
            this.label2.Text = "Data";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(78, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 24);
            this.label1.TabIndex = 26;
            this.label1.Text = "CPF";
            // 
            // sair
            // 
            this.sair.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.sair.BackColor = System.Drawing.Color.Yellow;
            this.sair.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.sair.FlatAppearance.BorderSize = 9;
            this.sair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.sair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sair.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.sair.ForeColor = System.Drawing.Color.Black;
            this.sair.Location = new System.Drawing.Point(651, 397);
            this.sair.Name = "sair";
            this.sair.Size = new System.Drawing.Size(106, 32);
            this.sair.TabIndex = 42;
            this.sair.Text = "Sair";
            this.sair.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.sair.UseVisualStyleBackColor = false;
            this.sair.Click += new System.EventHandler(this.sair_Click);
            // 
            // Jcpf
            // 
            this.Jcpf.Font = new System.Drawing.Font("Calibri", 10F);
            this.Jcpf.Location = new System.Drawing.Point(82, 228);
            this.Jcpf.Mask = "000,000,000-00";
            this.Jcpf.Name = "Jcpf";
            this.Jcpf.Size = new System.Drawing.Size(128, 24);
            this.Jcpf.TabIndex = 43;
            this.Jcpf.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox3_MaskInputRejected);
            // 
            // Jdata
            // 
            this.Jdata.Font = new System.Drawing.Font("Calibri", 10F);
            this.Jdata.Location = new System.Drawing.Point(224, 228);
            this.Jdata.Mask = "00/00/0000";
            this.Jdata.Name = "Jdata";
            this.Jdata.Size = new System.Drawing.Size(127, 24);
            this.Jdata.TabIndex = 44;
            this.Jdata.ValidatingType = typeof(System.DateTime);
            // 
            // Jsexo
            // 
            this.Jsexo.Font = new System.Drawing.Font("Calibri", 10F);
            this.Jsexo.FormattingEnabled = true;
            this.Jsexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.Jsexo.Location = new System.Drawing.Point(377, 228);
            this.Jsexo.Name = "Jsexo";
            this.Jsexo.Size = new System.Drawing.Size(128, 23);
            this.Jsexo.TabIndex = 45;
            // 
            // Jtel
            // 
            this.Jtel.Font = new System.Drawing.Font("Calibri", 10F);
            this.Jtel.Location = new System.Drawing.Point(224, 179);
            this.Jtel.Mask = "(99) 0000-0000";
            this.Jtel.Name = "Jtel";
            this.Jtel.Size = new System.Drawing.Size(127, 24);
            this.Jtel.TabIndex = 46;
            // 
            // Jcel
            // 
            this.Jcel.Font = new System.Drawing.Font("Calibri", 10F);
            this.Jcel.Location = new System.Drawing.Point(377, 177);
            this.Jcel.Mask = "(99) 00000-0000";
            this.Jcel.Name = "Jcel";
            this.Jcel.Size = new System.Drawing.Size(128, 24);
            this.Jcel.TabIndex = 47;
            // 
            // Pesquisar_Funcionário
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Jcel);
            this.Controls.Add(this.Jtel);
            this.Controls.Add(this.Jsexo);
            this.Controls.Add(this.Jdata);
            this.Controls.Add(this.Jcpf);
            this.Controls.Add(this.sair);
            this.Controls.Add(this.Jemail);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.Jnome);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.jTable);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Estoque);
            this.Controls.Add(this.Att);
            this.Controls.Add(this.remover);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Pesquisar_Funcionário";
            this.Text = "Pesquisar";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.jTable.ResumeLayout(false);
            this.jTable.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Att;
        private System.Windows.Forms.Button remover;
        private System.Windows.Forms.Label Estoque;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel jTable;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Jemail;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox Jnome;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button sair;
        private System.Windows.Forms.MaskedTextBox Jcpf;
        private System.Windows.Forms.MaskedTextBox Jdata;
        private System.Windows.Forms.ComboBox Jsexo;
        private System.Windows.Forms.MaskedTextBox Jtel;
        private System.Windows.Forms.MaskedTextBox Jcel;
    }
}