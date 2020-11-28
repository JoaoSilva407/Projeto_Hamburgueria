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
    public partial class Tela_Realizar_Pedido : Form
    {
        public Tela_Realizar_Pedido()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {


        }

        private void Tela_Realizar_Pedido_Load(object sender, EventArgs e)
        {

        }
        Double valor2;
        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                valor2 = Double.Parse(textBox3.Text);

                textBox3.Text = valor2.ToString("C");
            }
            catch (Exception)
            {

            }
        }

        Double valor3;
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                valor3 = Double.Parse(textBox3.Text);

                textBox3.Text = valor3.ToString("C");
            }
            catch (Exception)
            {

            }
        }

        Double precofinal;
        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                precofinal = Double.Parse(textBox1.Text);

                textBox1.Text = precofinal.ToString("C");
            }
            catch (Exception)
            {

            }
        }
    }
}




       


        
