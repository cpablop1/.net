namespace Suma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void sumar(int num1, int num2)
        {
            int suma = num1 + num2;

            MessageBox.Show($"La suma es: {suma}");
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            String numero1 = txtNumero1.Text;
            String numero2 = txtNumero2.Text;

            if (string.IsNullOrWhiteSpace(numero1) || string.IsNullOrWhiteSpace(numero2))
            {
                MessageBox.Show("Complete los campos para continuar", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int num1 = 0;
                int num2 = 0;

                bool Esnum1 = int.TryParse(numero1, out num1);
                bool Esnum2 = int.TryParse(numero2, out num2);

                if (Esnum1 && Esnum2)
                {
                    sumar(num1, num2);
                }
                else
                {
                    MessageBox.Show("Ingrese valores válidos.", "Campos incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
