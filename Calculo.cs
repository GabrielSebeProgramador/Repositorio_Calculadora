using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_completo_
{
    public partial class frmCalculo : Form
    {
        // Variáveis com Escopo global:

        double valorAnterior = 0, valorVisor = 0;
        string operacao = "";
        bool primeiraOperacao = true, botaoIgual = false, ApagarResultado = false;


        public frmCalculo()
        {
            InitializeComponent();
        }

        //  Função responsável por capturar o botão selecionado
        private void ClicouBotao_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text == "0" || botaoIgual == true)
            {
                txtResultado.Clear();
                botaoIgual = false;
            }

            if (ApagarResultado == true)
            {
                txtHistorico.Clear();
                txtHistorico.Text += valorAnterior;
                ApagarResultado = false;
            }

            Button botaoselecionado = (Button)sender;

            switch (botaoselecionado.Name)
            {
                case "btn1":
                    txtResultado.Text += "1";
                    break;
                case "btn2":
                    txtResultado.Text += "2";
                    break;
                case "btn3":
                    txtResultado.Text += "3";
                    break;
                case "btn4":
                    txtResultado.Text += "4";
                    break;
                case "btn5":
                    txtResultado.Text += "5";
                    break;
                case "btn6":
                    txtResultado.Text += "6";
                    break;
                case "btn7":
                    txtResultado.Text += "7";
                    break;
                case "btn8":
                    txtResultado.Text += "8";
                    break;
                case "btn9":
                    txtResultado.Text += "9";
                    break;
                case "btn0":
                    txtResultado.Text += "0";
                    break;
                case "btnVirgula":
                    if (txtResultado.Text == "")
                    {
                        txtResultado.Text += "0,";
                    }
                    else
                    {
                        txtResultado.Text += ",";
                    }
                    break;
                default:
                    break;
            }
        }

        //  Função responsável por limpar as configurações da calculadora:
        private void limpar()
        {
            txtResultado.Text = "0";
            txtHistorico.Clear();
            botaoIgual = false;
            primeiraOperacao = true;
            operacao = "";
            valorAnterior = 0;
            valorVisor = 0;
            ApagarResultado = false;

        }

        //  Função responsável por excluir um caractere do Visor:
        private void backspace()
        {
            if (txtResultado.Text == "")
            {
                //  Não irá fazer nada.
            }
            else if (txtResultado.Text == "0")
            {
                //  Não irá fazer nada.
            }
            else
            {
                txtResultado.Text = txtResultado.Text.Remove(txtResultado.Text.Length - 1);
            }
        }

        private void FunçãoSoma()
        {
            if (primeiraOperacao)
            {
                operacao = "+";

                valorAnterior = Convert.ToDouble(txtResultado.Text);

                if (botaoIgual == false)
                {
                    txtHistorico.Text += txtResultado.Text;
                }

                txtResultado.Clear();

                primeiraOperacao = false;
            }
            else
            {
                operacao = "+";

                valorVisor = Convert.ToDouble(txtResultado.Text);

                txtHistorico.Text += operacao + txtResultado.Text;
                txtResultado.Text = Convert.ToString(Calculo());
                txtHistorico.Text += "=" + txtResultado.Text;


                valorAnterior = Convert.ToDouble(txtResultado.Text);
                botaoIgual = true;
                ApagarResultado = true;
            }
        }

        private void FunçãoSubtrair()
        {
            if (primeiraOperacao)
            {
                operacao = "-";

                valorAnterior = Convert.ToDouble(Calculo());

                if (botaoIgual == false)
                {
                    txtHistorico.Text += txtResultado.Text;
                }

                txtResultado.Clear();

                primeiraOperacao = false;
            }
            else
            {
                operacao = "-";

                valorVisor = Convert.ToDouble(txtResultado.Text);

                txtHistorico.Text += operacao + txtResultado.Text;
                txtResultado.Text = Convert.ToString(Calculo());
                txtHistorico.Text += "=" + txtResultado.Text;


                valorAnterior = Convert.ToDouble(txtResultado.Text);

                botaoIgual = true;
                ApagarResultado = true;
            }
        }

        private void FunçãoMulti()
        {
            if (primeiraOperacao)
            {
                operacao = "x";

                valorAnterior = Convert.ToDouble(txtResultado.Text);

                if (botaoIgual == false)
                {
                    txtHistorico.Text += txtResultado.Text;
                }

                txtResultado.Clear();

                primeiraOperacao = false;
            }
            else
            {
                operacao = "x";

                valorVisor = Convert.ToDouble(txtResultado.Text);

                txtHistorico.Text += operacao + txtResultado.Text;
                txtResultado.Text = Convert.ToString(Calculo());
                txtHistorico.Text += "=" + txtResultado.Text;


                valorAnterior = Convert.ToDouble(txtResultado.Text);

                botaoIgual = true;
                ApagarResultado = true;
            }
        }

        private void FunçãoDiv()
        {
            if (primeiraOperacao)
            {
                operacao = "÷";

                valorAnterior = Convert.ToDouble(txtResultado.Text);

                if (botaoIgual == false)
                {
                    txtHistorico.Text += txtResultado.Text;
                }

                txtResultado.Clear();

                primeiraOperacao = false;
            }
            else
            {
                operacao = "÷";

                valorVisor = Convert.ToDouble(txtResultado.Text);

                txtHistorico.Text += operacao + txtResultado.Text;
                txtResultado.Text = Convert.ToString(Calculo());
                txtHistorico.Text += "=" + txtResultado.Text;


                valorAnterior = Convert.ToDouble(txtResultado.Text);

                botaoIgual = true;
                ApagarResultado = true;
            }
        }

        private void FunçãoRaiz()
        {
            ApagarResultado = true;

            if (ApagarResultado == true)
            {
                txtHistorico.Clear();
                ApagarResultado = false;
            }

            operacao = "√";

            valorVisor = Convert.ToDouble(txtResultado.Text);
            txtHistorico.Text += operacao + txtResultado.Text;
            txtResultado.Text = Convert.ToString(Calculo());
            txtHistorico.Text += "=" + txtResultado.Text;


            valorAnterior = Convert.ToDouble(txtResultado.Text);

            primeiraOperacao = false;
            botaoIgual = true;
            ApagarResultado = true;
        }

        private void FunçãoIgual()
        {
            ApagarResultado = true;

            if (ApagarResultado == true)
            {
                txtHistorico.Clear();
                ApagarResultado = false;
            }

            txtHistorico.Text += valorAnterior;

            valorVisor = Convert.ToDouble(txtResultado.Text);

            txtHistorico.Text += operacao + txtResultado.Text;

            txtResultado.Text = Convert.ToString(Calculo());

            txtHistorico.Text += "=" + txtResultado.Text;

            valorAnterior = Convert.ToDouble(txtResultado.Text);

            botaoIgual = true;
            primeiraOperacao = true;
            ApagarResultado = true;
        }

        private double Calculo() // Método para identificar a operação!
        {
            switch (operacao)
            {
                case "+":
                    valorAnterior = valorAnterior + valorVisor;
                    break;
                case "-":
                    valorAnterior = valorAnterior - valorVisor;
                    break;
                case "x":
                    valorAnterior = valorAnterior * valorVisor;
                    break;
                case "÷":
                    valorAnterior = valorAnterior / valorVisor;
                    break;
                case "√":
                    double valorRaiz = valorVisor;

                    for (int i = 0; i < 10; i++)
                    {
                        valorRaiz = (valorRaiz / 2) + valorVisor / (2 * valorRaiz);
                    }

                    valorAnterior = valorRaiz;
                    // Ou use a clsse Math:
                    /*

                    valorAnterior = Math.Sqrt(valorVisor)

                    */
                    break;
                default:
                    break;
            }
            return valorAnterior;
        }
    }
}