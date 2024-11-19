namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtDescuento.Enabled = false;
            txtValorCD.Enabled = false;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            String valorCompraTexto = txtValorC.Text;

            if(string.IsNullOrWhiteSpace(valorCompraTexto))
            {
                MessageBox.Show("Ingrese una cantidad para continuar.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                double valorCompra = 0;
                double descuento = 0;
                double valorCD = 0;

                bool esValor = double.TryParse(valorCompraTexto, out valorCompra);

                if (esValor)
                {
                    if (valorCompra > 100)
                    {
                        descuento = valorCompra * 0.05;
                    }
                    else if (valorCompra >= 150)
                    {
                        descuento = valorCompra * 0.1;
                    }
                    else if (valorCompra >= 200)
                    {
                        descuento = valorCompra * 0.15;
                    }

                    valorCD = valorCompra - descuento;
                    txtDescuento.Text = descuento.ToString();
                    txtValorCD.Text = valorCD.ToString();

                }
                else
                {
                    MessageBox.Show("Ingrese el valor de compra válida: eje 3.50 ...", "Valor inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
