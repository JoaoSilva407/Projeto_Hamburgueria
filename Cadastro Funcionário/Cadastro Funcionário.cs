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
    public partial class Cadastro_Funcionário : Form
    {
        public Cadastro_Funcionário()
        {
            InitializeComponent();
        }

        private void Cadastro_Funcionário_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Cadastro_Funcionário f = new Cadastro_Funcionário ();
            //FuncionarioBD BD = new FuncionarioBD();
            f.jnome = jnome;
            f.jcpf = jcpf;
            f.jtel = jtel;
            f.jcel = jcel;
            f.jemail = jemail;
            f.jdata = jdata;
            f.jsexo = jsexo;

            //BD.criar(f);

            jnome.Clear();
            jemail.Clear();
            
            jcpf.Clear();
            jdata.Clear();
            jtel.Clear();
            jcel.Clear();
            
        }

        private void excluir_Click(object sender, EventArgs e)
        {
            jnome.Clear();
            jemail.Clear();
            jcpf.Clear();
            jdata.Clear();
            jtel.Clear();
            jcel.Clear();
        }
    }
}
