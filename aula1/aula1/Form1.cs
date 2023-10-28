using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Bibliotecas
//nome do Projeto
namespace aula1
{
    //classe formulario 2 herda as caracteristicas do form
    public partial class FrmAula1 : Form
    {
        //construtor 
        public FrmAula1()
        {
            InitializeComponent();
        }
        // metodo click do botao calcular
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //ccriado a variavel 
            double valor1;
               double valor2;
            double soma;
            //convertendo o conteudo da caixa de texto para double
           
            if (!string.IsNullOrEmpty(Txtvalor1.Text)  && !string.IsNullOrEmpty(txtValor2.Text ))
            {
                valor1 = Convert.ToDouble(Txtvalor1.Text);
                valor2 = Convert.ToDouble(txtValor2.Text);
                soma = valor1 + valor2;
                //criando uma mensagem para o usuario com o resultado 
                MessageBox.Show("Resultado da soma : " + soma.ToString());
                lblResultado.Text = "Resultado da soma :" + soma.ToString();
            }
            else
            {
                MessageBox.Show("Há campos sem preencher");
            }
            }

        private void btnSub_Click(object sender, EventArgs e)
        {
            double v1, v2, sub;
            if (!string.IsNullOrEmpty(Txtvalor1.Text) && !string.IsNullOrEmpty(txtValor2.Text))
            {
                v1 = Convert.ToDouble(Txtvalor1.Text);
                v2 = Convert.ToDouble(txtValor2.Text);
                sub = v1 - v2;
                //criando uma mensagem para o usuario com o resultado 
                MessageBox.Show("Resultado da subtração : " + sub.ToString());
                lblResultado.Text = "Resultado da subtração :" + sub.ToString();
            }
            else
            {
                MessageBox.Show("Há campos sem preencher");
                Txtvalor1.Focus();
            }
        }
    }
}
