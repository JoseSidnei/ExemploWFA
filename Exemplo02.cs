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
    public partial class Exemplo02 : Form
    {
        public Exemplo02()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void btCadastrar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            int quantidadedeHoras = Convert.ToInt32(txtQuantidadeDeHoras.Text);
            double valorHora = Convert.ToDouble(txtValorHora.Text);

            string unidadeFederativa = cbUFederacao.SelectedItem.ToString();
            string cidade = rbMacho.Text.Trim();
            string bairro = txtBairro.Text.Trim();
            string logradouro = txtLogradouro.Text.Trim();
            string complemento = txtComplemento.Text.Trim();
            string numero = txtNumero.Text.Trim();
            bool ehFemea = rbFemea.Checked;
            string dataDeNascimento = dtpDataDeNascimento.Text;
            double salario = quantidadedeHoras * valorHora;

            if (salario < 1000)
            {
                MessageBox.Show("Professor de LOL");
            }
            else if (salario < 10000)
            {
                MessageBox.Show("Professor de Fortnit");
            }
            else if (salario < 100000)
            {
                MessageBox.Show("Professor de Dota 2");
            }
            else if (salario < 500000)
            {
                MessageBox.Show("Mestre Junior de Tibia");
            }
            else
            {
                MessageBox.Show("Mestre Pleno");
            }
            
        
        }

       
    }
}
