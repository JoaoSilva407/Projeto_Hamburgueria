namespace Projeto_Hamburgueria___POO
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.Estoque = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.excluir = new System.Windows.Forms.Button();
            this.alterar = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Jpreco = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.Jnome = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.sair = new System.Windows.Forms.Button();
            this.Jquant = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Estoque
            // 
            this.Estoque.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Estoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Estoque.Font = new System.Drawing.Font("Calisto MT", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Estoque.ForeColor = System.Drawing.Color.Maroon;
            this.Estoque.Location = new System.Drawing.Point(280, 54);
            this.Estoque.Name = "Estoque";
            this.Estoque.Size = new System.Drawing.Size(455, 132);
            this.Estoque.TabIndex = 0;
            this.Estoque.Text = "Visualizar Estoque";
            this.Estoque.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(97, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(194, 132);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
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
            this.excluir.Location = new System.Drawing.Point(334, 390);
            this.excluir.Name = "excluir";
            this.excluir.Size = new System.Drawing.Size(106, 32);
            this.excluir.TabIndex = 6;
            this.excluir.Text = "Excluir";
            this.excluir.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.excluir.UseVisualStyleBackColor = false;
            this.excluir.Click += new System.EventHandler(this.excluir_Click);
            // 
            // alterar
            // 
            this.alterar.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.alterar.FlatAppearance.BorderSize = 10;
            this.alterar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.alterar.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alterar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.alterar.Location = new System.Drawing.Point(138, 390);
            this.alterar.Name = "alterar";
            this.alterar.Size = new System.Drawing.Size(106, 32);
            this.alterar.TabIndex = 7;
            this.alterar.Text = "Alterar";
            this.alterar.UseVisualStyleBackColor = true;
            this.alterar.Click += new System.EventHandler(this.button3_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Maroon;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 122F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 3, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(116, 265);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(520, 100);
            this.tableLayoutPanel1.TabIndex = 8;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint_1);
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
            this.label2.Click += new System.EventHandler(this.label2_Click);
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
            // Jpreco
            // 
            this.Jpreco.Font = new System.Drawing.Font("Calibri", 10F);
            this.Jpreco.Location = new System.Drawing.Point(428, 226);
            this.Jpreco.Name = "Jpreco";
            this.Jpreco.Size = new System.Drawing.Size(136, 24);
            this.Jpreco.TabIndex = 42;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Perpetua", 15.75F, System.Drawing.FontStyle.Bold);
            this.label16.ForeColor = System.Drawing.Color.DarkRed;
            this.label16.Location = new System.Drawing.Point(455, 199);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(66, 24);
            this.label16.TabIndex = 41;
            this.label16.Text = "Preço:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Perpetua", 15.75F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.Color.DarkRed;
            this.label15.Location = new System.Drawing.Point(266, 199);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(121, 24);
            this.label15.TabIndex = 40;
            this.label15.Text = "Quantidade:";
            // 
            // Jnome
            // 
            this.Jnome.Font = new System.Drawing.Font("Calibri", 10F);
            this.Jnome.Location = new System.Drawing.Point(116, 226);
            this.Jnome.Name = "Jnome";
            this.Jnome.Size = new System.Drawing.Size(127, 24);
            this.Jnome.TabIndex = 39;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Perpetua", 15.75F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.DarkRed;
            this.label14.Location = new System.Drawing.Point(123, 202);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(104, 24);
            this.label14.TabIndex = 38;
            this.label14.Text = "Descrição:";
            this.label14.Click += new System.EventHandler(this.label14_Click);
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
            this.sair.Location = new System.Drawing.Point(567, 392);
            this.sair.Name = "sair";
            this.sair.Size = new System.Drawing.Size(106, 32);
            this.sair.TabIndex = 43;
            this.sair.Text = "Sair";
            this.sair.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.sair.UseVisualStyleBackColor = false;
            this.sair.Click += new System.EventHandler(this.sair_Click);
            // 
            // Jquant
            // 
            this.Jquant.Font = new System.Drawing.Font("Calibri", 10F);
            this.Jquant.Location = new System.Drawing.Point(270, 226);
            this.Jquant.Name = "Jquant";
            this.Jquant.Size = new System.Drawing.Size(127, 24);
            this.Jquant.TabIndex = 44;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Jquant);
            this.Controls.Add(this.sair);
            this.Controls.Add(this.Jpreco);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.Jnome);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.alterar);
            this.Controls.Add(this.excluir);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Estoque);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Estoque";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Estoque;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button excluir;
        private System.Windows.Forms.Button alterar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Jpreco;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox Jnome;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button sair;
        private System.Windows.Forms.TextBox Jquant;
    }
}