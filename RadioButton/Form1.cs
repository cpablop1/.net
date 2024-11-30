namespace RadioButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string compraText = txtCompra.Text;

            if (string.IsNullOrWhiteSpace(compraText))
            {
                MessageBox.Show("Ingrese el valor de la compra para continuar.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCompra.Focus();
            }
            else
            {
                double compra = 0;
                double descuento = 0;
                bool esValido = double.TryParse(compraText, out compra);

                if (esValido)
                {
                    if (rdDescuento10.Checked)
                    {
                        descuento = compra * 0.1;
                    }
                    else if (rdDescuento15.Checked)
                    {
                        descuento = compra * 0.15;
                    }
                    else if (rdDescuento20.Checked)
                    {
                        descuento = compra * 0.2;
                    }
                    else
                    {
                        MessageBox.Show("Seleccione el descuento a aplicar.", "Campo no seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    if (descuento != 0)
                    {
                        MessageBox.Show($"El total de la compra a pagar es: {compra - descuento}, se le aplicó un descuento de {descuento}", "Valor total de compra", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese un valor correcto de la compra.", "Valor incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCompra.Focus();
                }
            }
        }
    }
}
