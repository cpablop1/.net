namespace EvenOrOdd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            String numeroText = txtNumero.Text;

            if(string.IsNullOrWhiteSpace(numeroText) )
            {
                MessageBox.Show("Ingrese un n�mero.", "Campa vac�o", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int numero;

                bool esNumero = int.TryParse(numeroText, out numero);

                if (!esNumero)
                {
                    MessageBox.Show("Ingrese un valor v�lido.", "Valor inv�lido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    bool esPar = ((numero % 2) == 0);

                    if (esPar)
                    {
                        MessageBox.Show("El n�mero es par.", "Operaci�n exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("El n�mero es impar.", "Operaci�n exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
    }
}
