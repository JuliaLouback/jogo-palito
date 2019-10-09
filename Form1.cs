using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jogoPalito
{
    public partial class Form1 : Form
    {
        int quantidade; // inicializa a variavel
        int valorRetirar; // variavel passada como parametro para indicar quantos palitos o usuario retirou
        int numeroRetirada; // numero que sera retirado 
        bool primeira; // variavel que recebe apenas true ou false - verifica se é a primeira jogada do jogo

        public Form1()
        {
            InitializeComponent();
            valor.Visible = false; // o maskedTextBox fica invisivel
            retirar.Visible = false; // o botao fica invisivel
            label2.Visible = false; // o label fica invisivel
        }

        private void Jogar_Click(object sender, EventArgs e)
        {
            quantPalito.Enabled = false; // o numericUpDown fica desabilitado
            jogar.Enabled = false; // o botao fica desabilitado
            label2.Visible = true; // o label fica visivel
            valor.Visible = true; // o maskedTextBox fica visivel
            retirar.Visible = true; // o botao fica visivel

            quantidade = (int)quantPalito.Value; // a variavel quantidade recebe o valor do numericUpDown
            valorRetirar = 0;

            primeira = true;
            richTextBox1.AppendText("Eu começo!!\n"); 
  
            retirarPalito(quantidade, valorRetirar, primeira); // chama o método e passa a quantidade escolhida como parametro
        }

        private void retirarPalito(int quantidadeP, int valorRetirar, bool primeira)
        {

            if (quantidadeP % 4 == 0) // se a quantidade escolhida for divida por 4 e o resto da divisão for igual zero
            {
                int numeroApagar = 3;
                quantidadeP = quantidadeP - numeroApagar; // o valor de palitos inseridos pelo usuario é diminuido da quantidade
                richTextBox1.AppendText("Retiro: " + numeroApagar + " Palitos\nSua vez..\nRestam " + quantidadeP.ToString() + " Palitos\n"); 
                quantidade = quantidadeP; // a variavel quantidade recebe seu novo valor
            }
            else{

                if (primeira == true) // verifica se é a primeira jogada
                {
                    if (quantidadeP == 30 || quantidadeP == 26 || quantidadeP == 22) // diminui a quantidade necessária para que o usuario fique em uma posição perdedora
                    {
                        numeroRetirada = 1; // recebe o número de peças a ser retirada
                    }
                    else if (quantidadeP == 21 || quantidadeP == 25 || quantidadeP == 29)
                    {
                        numeroRetirada = 3;
                    }
                    else if (quantidadeP == 23 || quantidadeP == 27)
                    {
                        numeroRetirada = 2;
                    }
                }
                else
                {
                    numeroRetirada = 4 - valorRetirar; // a variavel recebe a subtração entre numero quatro e o número de palitos a serem removidos na jogada do usuario
                }
                // se a quantidade escolhida for divida por 4 e o resto da divisão for diferente zero
                quantidadeP = quantidadeP - numeroRetirada; // é subtraido o novo valor da variavel quantidade
                richTextBox1.AppendText("Retiro " + numeroRetirada + " Palitos\nSua vez..\nRestam " + quantidadeP.ToString() + " Palitos\n");
                quantidade = quantidadeP; // a variavel quantidade recebe seu novo valor
            }
            this.valor.ResetText(); // o campo maskedTextBox é limpo
            this.valor.Focus(); //  o campo maskedTextBox é automaticamente selecionado
            if (quantidadeP == 1) // se a quantidade de palitos for igual a zero
            {
                MessageBox.Show("Você perdeu...","kkkkk Muito Fácil!!!",MessageBoxButtons.OK); // o computador vence
                DialogResult dialogo = MessageBox.Show("Quer jogar de novo?","Desafio",MessageBoxButtons.YesNo); // mostra a messagem com botão sim e não e armazena o valor escolhido

                if (dialogo == DialogResult.Yes) // se o botao clicado for igual a Sim
                {
                    quantPalito.Enabled = true;
                    jogar.Enabled = true;
                    valor.Visible = false;
                    retirar.Visible = false;
                    label2.Visible = false;

                    quantidade = 0; // a quantidade de palitos é zerada
                    richTextBox1.Clear(); // o richTextBox é limpo
                } else
                {
                    Close();  // fecha a aplicação
                }
            }
        }

     
        private void Retirar_Click(object sender, EventArgs e)
        {
            primeira = false; // a primeira jogada é falsa
            if (valor.Text == "") // se o valor do maskedTextBox estiver vazio
            {
                MessageBox.Show("Preenchimento obrigatório da quantidade de palitos a remover", "Atenção", MessageBoxButtons.OK);
                this.valor.ResetText(); 
                this.valor.Focus();
            }
            else { 
                int teste = Convert.ToInt32(valor.Text); // converte para inteiro o valor do maskedTextBox

                if (teste <= 0 || teste > 3) // se o valor for maior de 3 ou menor que zero
                {
                    MessageBox.Show("São permitidos retirar 1 a 3 palitos por jogada", "", MessageBoxButtons.OK);
                    this.valor.ResetText();
                    this.valor.Focus();
                }
                else
                {
                    quantidade = quantidade - teste; // retira o valor inserido do maskedTextBox da quantidade 
                    richTextBox1.AppendText("Você retirou " + teste + " Palitos\nRestam " + quantidade.ToString() + " Palitos\n");
                    if (quantidade == 1) // se a quantidade for igual a zero
                    {
                        MessageBox.Show("Eu Perdi!", "Impossível!!!", MessageBoxButtons.OK); // o jogador ganha
                        DialogResult dialogo = MessageBox.Show("Quer jogar de novo?", "Desafio", MessageBoxButtons.YesNo);

                        if (dialogo == DialogResult.Yes)
                        {
                            quantPalito.Enabled = true;
                            jogar.Enabled = true;
                            valor.Visible = false;
                            retirar.Visible = false;
                            label2.Visible = false;

                            quantidade = 0;
                            richTextBox1.Clear();
                        }
                        else
                        {
                            Close();
                        }
                    }
                    else
                    {
                        retirarPalito(quantidade, teste,primeira); // chama o metedo retirar palitos e passa o novo valor da quantidade, o numero de palitos para retirar e que a primeira jogada é falsa
                    }
                }
            }
        }
    }
}
