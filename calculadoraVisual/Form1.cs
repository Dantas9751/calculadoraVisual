using System;
using System.Windows.Forms;

namespace calculadoraVisual
{
    public partial class Form1 : Form
    {
        /*private double Valor
        {
            get { return valor; } 
            set { valor = value; }
        }*/
        private double valor { get; set; } 
        private double resultado { get; set; }
        private Operacoes? operacaoSelecionada { get; set; } = null;

        public Form1()
        {
            InitializeComponent();
            btnIgual.Enabled = false;
        }

        public enum Operacoes
        {
            adicao,
            subtracao,
            multiplicacao,
            divisao
        }

        private void btnNumero_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                txtVisor.Text += btn.Text;
            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if ((double.TryParse(txtVisor.Text, out double valorVisor) && valorVisor == resultado))
            {
                txtVisor.Clear();
            }
            else if (txtVisor.Text.Length > 0)
            {
                txtVisor.Text = txtVisor.Text.Substring(0, txtVisor.Text.Length - 1);
            }
            valorVisor = 0;
        }

        private void btnPonto_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text == string.Empty)
            {
                txtVisor.Text += "0,";
            }
            else if (!txtVisor.Text.Contains(","))
            {
                txtVisor.Text += ",";
            }

        }

        private void SetOperacao(Operacoes operacao)
        {
            if (operacaoSelecionada != null)
            {
                MessageBox.Show("Já existe uma operação selecionada. Por favor, complete a operação antes de selecionar outra.");
                return;
            }
            if (txtVisor.Text != "")
            {
                valor = Convert.ToDouble(txtVisor.Text);
                operacaoSelecionada = operacao;
                txtVisor.Clear();
                btnIgual.Enabled = true;
            }
            else
            {
                MessageBox.Show("Entrada inválida.");
            }
        }

        private void btnAdicao_Click(object sender, EventArgs e) => SetOperacao(Operacoes.adicao);
        private void btnSubtracao_Click(object sender, EventArgs e) => SetOperacao(Operacoes.subtracao);
        private void btnMultiplicacao_Click(object sender, EventArgs e) => SetOperacao(Operacoes.multiplicacao);
        private void btnDivisao_Click(object sender, EventArgs e) => SetOperacao(Operacoes.divisao);

        private void btnBinario_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtVisor.Text, out int n))
            {
                string binario = Convert.ToString(n, 2);
                txtVisor.Text = binario;
            }
            else
            {
                MessageBox.Show("Entrada inválida para conversão em binário.");
            }
        }

        private void btnFatorial_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtVisor.Text, out int n) && n < 26)
            {
                resultado = nFatorial(n);
                txtVisor.Text = resultado.ToString();
            }
            else
            {
                MessageBox.Show("Entrada inválida para fatorial.");
            }
        }

        private void btnSeno_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text != "")
            {
                double valor = Convert.ToDouble(txtVisor.Text);
                double valorRadiano = valor * (Math.PI / 180);
                resultado = Math.Sin(valorRadiano);
                txtVisor.Text = resultado.ToString();
            }
            else
            {
                MessageBox.Show("Entrada inválida para seno.");
            }
        }

        private void btnCosseno_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text != "")
            {
                double valor = Convert.ToDouble(txtVisor.Text);
                double valorRadiano = valor * (Math.PI / 180);
                resultado = Math.Cos(valorRadiano);
                txtVisor.Text = resultado.ToString();
            }
            else
            {
                MessageBox.Show("Entrada inválida para cosseno.");
            }
        }

        private void btnTangente_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text != "")
            {
                double valor = Convert.ToDouble(txtVisor.Text);
                double valorRadiano = valor * (Math.PI / 180);
                resultado = Math.Tan(valorRadiano);
                txtVisor.Text = resultado.ToString();
            }
            else
            {
                MessageBox.Show("Entrada inválida para tangente.");
            }
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            if (operacaoSelecionada == null)
            {
                MessageBox.Show("Nenhuma operação selecionada.");
                return;
            }

            if (txtVisor.Text != "")
            {
                double entrada = Convert.ToDouble(txtVisor.Text);
                switch (operacaoSelecionada)
                {
                    case Operacoes.adicao:
                        resultado = valor + entrada;
                        break;
                    case Operacoes.subtracao:
                        resultado = valor - entrada;
                        break;
                    case Operacoes.multiplicacao:
                        resultado = valor * entrada;
                        break;
                    case Operacoes.divisao:
                        if (entrada == 0) { MessageBox.Show("Divisão por zero não é permitida."); return; }
                        resultado = valor / entrada;
                        break;
                    default:
                        break;
                }
                txtVisor.Text = resultado.ToString();
                operacaoSelecionada = null;
                btnIgual.Enabled = false;
            }
        }

        private int nFatorial(int n)
        {
            if (n < 0)
            {
                throw new ArgumentException("O fatorial não está definido para números negativos.");
            }
            int a;
            if (n > 1)
            {
                a = n * nFatorial(n - 1);
            }
            else
            {
                a = 1;
            }
            return a;
        }
    }
}