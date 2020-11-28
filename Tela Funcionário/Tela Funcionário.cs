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
    public partial class Funcionário : Form
    {
        public Funcionário()
        {
            InitializeComponent();
        }

        private void visualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tela_Realizar_Pedido TRP = new Tela_Realizar_Pedido();
            TRP.ShowDialog();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tela_Visualizar_Venda TVV = new Tela_Visualizar_Venda();
            TVV.ShowDialog();
        }

        private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Tela_Cadastro_Cliente TCC = new Tela_Cadastro_Cliente();
            TCC.ShowDialog();
        }

        private void pesquisarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pesquisar_Funcionário PF = new Pesquisar_Funcionário();
            PF.ShowDialog();
        }

        private void áreaFuncionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaVoltarParaGerente TVPG = new TelaVoltarParaGerente();
            TVPG.ShowDialog();
        }
    }
}
