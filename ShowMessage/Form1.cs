namespace ShowMessage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            var numeroIngresado = txtNumero;
            liMensaje.Items.Clear();

            if (string.IsNullOrWhiteSpace(numeroIngresado.Text))
            {
                MessageBox.Show("Ingrese un número para continuar.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numeroIngresado.Focus();
            }
            else
            {
                int numero = 0;
                bool esNumero = int.TryParse(numeroIngresado.Text, out numero);

                if (esNumero)
                {
                    while (numero > 0)
                    {
                        liMensaje.Items.Add($"Mensaje {numero} con el bucle while");
                        numero--;
                    }

                    numeroIngresado.Focus();
                }
                else
                {
                    MessageBox.Show("Ingrese un número, eje 1, 2, 3...", "Valor incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    numeroIngresado.Focus();
                }
            }
        }
    }
}
