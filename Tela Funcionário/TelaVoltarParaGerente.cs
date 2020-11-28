using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Hamburgueria___POO
{
    public partial class TelaVoltarParaGerente : Form
    {
        public TelaVoltarParaGerente()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if ((txtLogin.Text == "Gerente") &&
                (txtSenha.Text == "12345"))
            {

                Tela_Gerente tg = new Tela_Gerente();
                tg.Show();
                this.Visible = false;

            }
            else { MessageBox.Show("Login ou senha invalidos"); }
        }
    }
}
