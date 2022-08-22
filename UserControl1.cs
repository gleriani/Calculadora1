using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora1
{
    public partial class UserControl1: UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Valor_1, Valor_2, Resultado;

            Valor_1 = Convert.ToInt16(textBox1.Text);
            Valor_2 = Convert.ToInt16(textBox2.Text);
            Resultado = Valor_1 + Valor_2;

            label4.Text = Convert.ToString(Resultado);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int Valor_1, Valor_2, Resultado;

            Valor_1 = Convert.ToInt16(textBox1.Text);
            Valor_2 = Convert.ToInt16(textBox2.Text);
            Resultado = Valor_1 - Valor_2;

            label4.Text = Convert.ToString(Resultado);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int Valor_1, Valor_2, Resultado;

            Valor_1 = Convert.ToInt16(textBox1.Text);
            Valor_2 = Convert.ToInt16(textBox2.Text);
            Resultado = Valor_1 * Valor_2;

            label4.Text = Convert.ToString(Resultado);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            float Valor_1, Valor_2, Resultado;

            Valor_1 = Convert.ToInt16(textBox1.Text);
            Valor_2 = Convert.ToInt16(textBox2.Text);
            Resultado = Valor_1 / Valor_2;

            label4.Text = Convert.ToString(Resultado);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            label4.Text = (" ");
        }
    }
}
