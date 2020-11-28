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
    public partial class Tela_Visualizar_Venda : Form
    {
        public Tela_Visualizar_Venda()
        {
            InitializeComponent();
        }

        Double valor;


        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                valor = Double.Parse(textBox3.Text);

                textBox3.Text = valor.ToString("C");
            }
            catch (Exception)
            {

            }
        }
    }
    }


