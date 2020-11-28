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
    public partial class Pesquisar_Funcionário : Form
    {
        public Pesquisar_Funcionário()
        {
            InitializeComponent();
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Att_Click(object sender, EventArgs e)
        {
            //Con.Open();
            //SqlCommand cmd = Con.CreateCommand();
            //cmd.CommandType = CommandType.Text;
            //cmd.CommandTexte = "Atualizar '"+Jnome.Text+"''"+Jtel.Text+"''"+Jcel.Text+"''"+Jcpf.Text+"''"+Jdata.Text+"''"+Jemail.Text+"''"+Jsexo.Text+"'" ;
            //cmd.ExecuteNonQuery();
            //Con.Close();
            // MessageBox.Show("Atualizado com Sucesso");

        }

        private void remover_Click(object sender, EventArgs e)
        {
            //Con.Open();
            //SqlCommand cmd = Con.CreateCommand();
            //cmd.CommandType = CommandType.Text;
            //cmd.CommandTexte = "Deletar '"+Jnome.Text+"'";
            //cmd.ExecuteNonQuery();
            //Con.Close();
           // MessageBox.Show("Removido com Sucesso");
        }

        private void sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
