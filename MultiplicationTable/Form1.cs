namespace MultiplicationTable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            String numeroIngresado = txtNumero.Text;
            int operacion = 0;
            liTabla.Items.Clear();

            if (string.IsNullOrWhiteSpace(numeroIngresado))
            {
                MessageBox.Show("Ingrese un número para continuar", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNumero.Focus();
            }
            else
            {
                int numero = 0;
                bool esNumero = int.TryParse(numeroIngresado, out numero);

                if (esNumero)
                {
                    for (int i = 1; i <= 10; i++)
                    {
                        operacion = numero * i;

                        liTabla.Items.Add($"{numero} X {i} = {operacion}");
                    }

                    txtNumero.Focus();
                }
                else
                {
                    MessageBox.Show("Ingrese un número válido.", "Campo inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNumero.Focus();
                }
            }
        }
    }
}
