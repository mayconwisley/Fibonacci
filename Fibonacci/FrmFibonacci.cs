using System;
using System.Windows.Forms;

namespace Fibonacci
{
    public partial class FrmFibonacci : Form
    {

        public FrmFibonacci()
        {
            InitializeComponent();
        }

        CalculoFibonacci calculoFibonacci;
        ValidarNumero validarNumero;

        private void Resultado(Int64 sequencia)
        {
            calculoFibonacci = new CalculoFibonacci();

            for (Int64 i = 0; i < sequencia; i++)
            {
                LstBResultado.Items.Add(calculoFibonacci.FibonacciNormal(sequencia).ToString("#,##0"));
            }

        }

        private void Calculo()
        {
            Int64 sequencia = Int64.Parse(TxtNumSequencia.Text.Trim());
            LstBResultado.Items.Clear();
            Resultado(sequencia);

        }
        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            Calculo();
        }

        private void TxtNumSequencia_TextChanged(object sender, EventArgs e)
        {
            validarNumero = new ValidarNumero();
            TxtNumSequencia.Text = validarNumero.Validar(TxtNumSequencia.Text.Trim());
            TxtNumSequencia.Select(TxtNumSequencia.Text.Length, 0);
        }

        private void TxtNumSequencia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                Calculo();
            }
        }

        private void FrmFibonacci_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Tirar o som da tecla enter
            if (e.KeyChar == 13)
            {
                this.ProcessTabKey(true);
                e.Handled = true;
            }
        }
    }
}
