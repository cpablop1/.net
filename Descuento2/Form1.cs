using System.Numerics;

namespace Descuento2
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
            txtTotalNeto.Enabled = false;
        }

        public double calcularDescuento(double tc)
        {
            double descuento = 0;

            if (tc > 100 && tc <= 200)
            {
                descuento = tc * 0.05;
            }
            if (tc > 200 && tc <= 300)
            {
                descuento = tc * 0.1;
            }
            if (tc > 300)
            {
                descuento = tc * 0.2;
            }

            return descuento;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            String totalCompra = txtTotalCompra.Text;

            if (string.IsNullOrWhiteSpace(totalCompra))
            {
                MessageBox.Show("Ingrese el total de la compra.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTotalCompra.Focus();
            }
            else
            {
                double tc = 0;
                bool validar = double.TryParse(totalCompra, out tc);
                double descuento = 0;

                if (validar)
                {
                    descuento = calcularDescuento(tc);

                    txtDescuento.Text = descuento.ToString();
                    txtTotalNeto.Text = (tc - descuento).ToString();
                }
                else
                {
                    MessageBox.Show("Ingrese el total de la compra.", "Datos incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTotalCompra.Focus();
                }
            }
        }
    }
}
