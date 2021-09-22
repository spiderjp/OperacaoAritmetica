using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OperacaoAritmetica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double value1 = Convert.ToDouble(valor1.Text);
            double value2 = Convert.ToDouble(valor2.Text);

            if (op_soma.Checked)
            {

                double result = value1 + value2;
                resultado.Text = "Resultado: " + result;
            }
            else if (op_sub.Checked)
            {

                double result = value1 - value2;
                resultado.Text = "Resultado: " + result;
            }
            else if (op_mult.Checked)
            {

                double result = value1 * value2;
                resultado.Text = "Resultado: " + result;
            }
            else if (op_div.Checked)
            {

                double result = value1 / value2;
                resultado.Text = "Resultado: " + result;
            }
            else if (op_med.Checked)
            {

                double result = (value1 + value2) / 2;
                resultado.Text = "Resultado: " + result;
            }
            else if (op_quad.Checked) {

                double result = value1*value1;
                resultado.Text = "Resultado: " + result;
            } else
            {

                resultado.Text = "Por favor, preencha os campos com os valores e escolha a operação aritmética desejada.";
            }
        }

        private void Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            double value1 = Convert.ToDouble(valor1.Text);
            double value2 = Convert.ToDouble(valor2.Text);

            if (op_soma.Checked)
            {

                double result = value1 + value2;
                resultado.Text = "Resultado: " + result;
            }
            else if (op_sub.Checked)
            {

                double result = value1 - value2;
                resultado.Text = "Resultado: " + result;
            }
            else if (op_mult.Checked)
            {

                double result = value1 * value2;
                resultado.Text = "Resultado: " + result;
            }
            else if (op_div.Checked)
            {

                double result = value1 / value2;
                resultado.Text = "Resultado: " + result;
            }
            else if (op_med.Checked)
            {

                double result = (value1 + value2) / 2;
                resultado.Text = "Resultado: " + result;
            }
            else if (op_quad.Checked)
            {

                double result = value1 * value1;
                resultado.Text = "Resultado: " + result;
            }
            else
            {

                resultado.Text = "Por favor, preencha os campos com os valores e escolha a operação aritmética desejada.";
            }
        }

        private void Sobre_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome: João Pedro Ferreira de Souza Batista" + "\r\n" + "RGM: 2316257-1");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            

        }
    }
}
