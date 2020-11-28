namespace Projeto_Hamburgueria___POO
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.sair = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.jTProdutos = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cadastrar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Estoque = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.MaskedTextBox();
            this.jTProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // sair
            // 
            this.sair.BackColor = System.Drawing.Color.Yellow;
            this.sair.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.sair.FlatAppearance.BorderSize = 9;
            this.sair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.sair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sair.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.sair.ForeColor = System.Drawing.Color.Black;
            this.sair.Location = new System.Drawing.Point(438, 378);
            this.sair.Name = "sair";
            this.sair.Size = new System.Drawing.Size(147, 32);
            this.sair.TabIndex = 53;
            this.sair.Text = "Sair";
            this.sair.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.sair.UseVisualStyleBackColor = false;
            this.sair.Click += new System.EventHandler(this.sair_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Perpetua", 15.75F, System.Drawing.FontStyle.Bold);
            this.label16.ForeColor = System.Drawing.Color.DarkRed;
            this.label16.Location = new System.Drawing.Point(441, 191);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(66, 24);
            this.label16.TabIndex = 51;
            this.label16.Text = "Preço:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Perpetua", 15.75F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.Color.DarkRed;
            this.label15.Location = new System.Drawing.Point(260, 194);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(121, 24);
            this.label15.TabIndex = 50;
            this.label15.Text = "Quantidade:";
            // 
            // txtDesc
            // 
            this.txtDesc.Font = new System.Drawing.Font("Calibri", 10F);
            this.txtDesc.Location = new System.Drawing.Point(109, 218);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(131, 24);
            this.txtDesc.TabIndex = 49;
            // 
            // jTProdutos
            // 
            this.jTProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.jTProdutos.BackColor = System.Drawing.Color.Maroon;
            this.jTProdutos.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.jTProdutos.ColumnCount = 4;
            this.jTProdutos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.jTProdutos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.jTProdutos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.jTProdutos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 122F));
            this.jTProdutos.Controls.Add(this.label3, 1, 0);
            this.jTProdutos.Controls.Add(this.label2, 0, 0);
            this.jTProdutos.Controls.Add(this.label4, 2, 0);
            this.jTProdutos.Controls.Add(this.label5, 3, 0);
            this.jTProdutos.Location = new System.Drawing.Point(100, 251);
            this.jTProdutos.Name = "jTProdutos";
            this.jTProdutos.RowCount = 5;
            this.jTProdutos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.jTProdutos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.jTProdutos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.jTProdutos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.jTProdutos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.jTProdutos.Size = new System.Drawing.Size(520, 100);
            this.jTProdutos.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(136, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Descrição";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(6, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(266, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Quantidade";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(396, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Preço";
            // 
            // cadastrar
            // 
            this.cadastrar.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.cadastrar.FlatAppearance.BorderSize = 10;
            this.cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cadastrar.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastrar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.cadastrar.Location = new System.Drawing.Point(122, 376);
            this.cadastrar.Name = "cadastrar";
            this.cadastrar.Size = new System.Drawing.Size(141, 32);
            this.cadastrar.TabIndex = 47;
            this.cadastrar.Text = "Cadastrar";
            this.cadastrar.UseVisualStyleBackColor = true;
            this.cadastrar.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(81, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(194, 132);
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // Estoque
            // 
            this.Estoque.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Estoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Estoque.Font = new System.Drawing.Font("Calisto MT", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Estoque.ForeColor = System.Drawing.Color.Maroon;
            this.Estoque.Location = new System.Drawing.Point(264, 40);
            this.Estoque.Name = "Estoque";
            this.Estoque.Size = new System.Drawing.Size(455, 132);
            this.Estoque.TabIndex = 44;
            this.Estoque.Text = " Cadastrar Produto ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(106, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 24);
            this.label1.TabIndex = 54;
            this.label1.Text = "Descrição";
            // 
            // txtQtd
            // 
            this.txtQtd.Font = new System.Drawing.Font("Calibri", 10F);
            this.txtQtd.Location = new System.Drawing.Point(264, 218);
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(147, 24);
            this.txtQtd.TabIndex = 55;
            // 
            // txtPreco
            // 
            this.txtPreco.Font = new System.Drawing.Font("Calibri", 10F);
            this.txtPreco.Location = new System.Drawing.Point(445, 218);
            this.txtPreco.Mask = "                                                                                 " +
    "                                              $";
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.PasswordChar = '$';
            this.txtPreco.Size = new System.Drawing.Size(160, 24);
            this.txtPreco.TabIndex = 56;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.txtQtd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sair);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.jTProdutos);
            this.Controls.Add(this.cadastrar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Estoque);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.Text = "Estoque";
            this.jTProdutos.ResumeLayout(false);
            this.jTProdutos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sair;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TableLayoutPanel jTProdutos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button cadastrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Estoque;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQtd;
        private System.Windows.Forms.MaskedTextBox txtPreco;
    }
}