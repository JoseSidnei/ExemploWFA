using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemploWFA
{
    public partial class Exemplo03 : Form
    {
        int quantidade1 = 0, quantidade2 = 0, quantidade3 = 0;
        double valor1 = 0, valor2 = 0, valor3 = 0, total = 0;
        

        public Exemplo03()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            ArmazenarInformacoes();
            if (rbSomar.Checked)
            {
                Somar();
            }
            else if (rbMedia.Checked)
            {
                Media();
            } 
            else if (rbMenor.Checked)
            {
                Menor();
            } 
            else if (rbMaior.Checked)
            {
                Maior();
            }
            else
            {
                MessageBox.Show("Nenhuma das opções selecionadas");
            }
        }

        private void ArmazenarInformacoes()
        {
            quantidade1 = Convert.ToInt32(nudQuantidade1.Value);
            valor1 = Convert.ToDouble(mtbValor1.Text);

            quantidade2 = Convert.ToInt32(nudQuantidade2.Value);
            valor2 = Convert.ToDouble(mtbValor2.Text);

            quantidade3 = Convert.ToInt32(nudQuantidade3.Value);
            valor3 = Convert.ToDouble(mtbValor3.Text);

        }

        public void Somar()
        {           
            total = (quantidade1 * valor1) + (quantidade2 * valor2) + (quantidade3 * valor3);
            MessageBox.Show("Soma: " + total);
             
        }

        public void Media()
        {            
            double media = total / 3;
            MessageBox.Show("Media: " + media);
        }

        public void Menor()
        {
            double menorValor = int.MaxValue;
            if (menorValor > valor1)
            {
                menorValor = valor1;
            }
            if (menorValor > valor2)
            {
                menorValor = valor2;
            }
            if (menorValor > valor3)
            {
                menorValor = valor3;
            }
            MessageBox.Show("Menor Valor: " + menorValor);
        }

        public void Maior()
        {
            double maiorValor = int.MinValue;
            if (maiorValor < valor1)
            {
                maiorValor = valor1;
            }
            if (maiorValor < valor2)
            {
                maiorValor = valor2;
            }
            if (maiorValor < valor3)
            {
                maiorValor = valor3;
            }
            MessageBox.Show("Maior valor: " + maiorValor);
        }
    }
}
