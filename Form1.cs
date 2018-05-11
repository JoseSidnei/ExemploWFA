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
    public partial class Exemplo01 : Form
    {
        public Exemplo01()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Olá Mundo");
            MessageBox.Show("A soma é: " + (2 + 2));
        }

        private void btnConcatenar_Click(object sender, EventArgs e)
        {
            string nomeDoUsuario = txtNome.Text;
            string sobrenomeDoUsuario = txtSobrenome.Text;
            MessageBox.Show(nomeDoUsuario + "" + sobrenomeDoUsuario);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double nota1 = 0, nota2 = 0, nota3 = 0, nota4 = 0; 
            try
            {
                nota1 = Convert.ToDouble(txtNota1.Text);
            }
            catch
            {
                MessageBox.Show("Nota 1 deve conter somente números reais");
                txtNota1.Focus();
                return;
            }
            
            try
            {
                nota2 = Convert.ToDouble(txtNota2.Text);
            }
            catch
            {
                MessageBox.Show("Nota 2 deve conter somente números reais");
                txtNota2.Focus();
                return;
            }

            try
            {
                nota3 = Convert.ToDouble(txtNota1.Text);
            }
            catch
            {
                MessageBox.Show("Nota 3 deve conter somente números reais");
                txtNota3.Focus();
                return;
            }

            try
            {
                nota4 = Convert.ToDouble(txtNota1.Text);
            }
            catch
            {
                MessageBox.Show("Nota 4 deve conter somente números reais");
                txtNota4.Focus();
                return;
            }
               
            double media = ( nota1 + nota2 + nota3 + nota4) / 4;
            string textao = string.Format("Nota 1: {0}\r\nNota 2: {1}\r\nNota 3: {2}\r\nNota 4: {3}\r\n\nMédia: {4}", 
                                           nota1, nota2, nota3, nota4, media);

            txtResultado.Text = textao;
//          MessageBox.Show
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int idade = Convert.ToInt32(txtIdade.Text);
                if (idade < 0)
                {
                    MessageBox.Show("Idade não pode ser menor que 0");
                    txtIdade.Focus();
                    return;

                }

                if (idade > 150)
                {
                    MessageBox.Show("Idade não pode ser maior que 150");
                    txtIdade.Focus();
                    return;
                }

            }
            catch
            {
                MessageBox.Show("Idade deve conter smente números inteiros");
                txtIdade.Focus();
            }

        }

       
    }
}
