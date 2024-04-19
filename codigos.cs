using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!ValidarNotas())
                return;

            // converte as notas para números
            double nota1 = Convert.ToDouble(textBox1.Text);
            double nota2 = Convert.ToDouble(textBox2.Text);
            double nota3 = Convert.ToDouble(textBox3.Text);

            // Calcula a média
            double media = (nota1 + nota2 + nota3) / 3;

            // reprovado/aprovado ou recuperação 
            if (media >= 7.0)
                label1.Text = "Aprovado";
            else if (media < 4.0)
                label1.Text = "Reprovado";
            else
                label1.Text = "Em recuperação";
        }

        private bool ValidarNotas()
        {
            // vê se as notas foram colocadas certa
            bool notasValidas = true;

            if (!double.TryParse(textBox1.Text, out double nota1))
            {
                label1.Text = "Nota 1 inválida";
                notasValidas = false;
            }

            if (!double.TryParse(textBox2.Text, out double nota2))
            {
                label1.Text = "Nota 2 inválida";
                notasValidas = false;
            }

            if (!double.TryParse(textBox3.Text, out double nota3))
            {
                label1.Text = "Nota 3 inválida";
                notasValidas = false;
            }

            return notasValidas;
        }
    }
    }
