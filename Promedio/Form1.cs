namespace Promedio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            String nota1Texto = txtNota1.Text;
            String nota2Texto = txtNota2.Text;
            String nota3Texto = txtNota3.Text;

            if(string.IsNullOrWhiteSpace(nota1Texto) ||
                string.IsNullOrWhiteSpace(nota2Texto) ||
                string.IsNullOrWhiteSpace(nota3Texto))
            {
                MessageBox.Show("Porfavor ingrese valores en todos los campos.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int nota1, nota2, nota3;

                bool esNota1 = int.TryParse(nota1Texto, out nota1);
                bool esNota2 = int.TryParse(nota2Texto, out nota2);
                bool esNota3 = int.TryParse(nota3Texto, out nota3);

                if (!esNota1 || !esNota2 || !esNota3)
                {
                    MessageBox.Show("Porfavor ingrese notas válidas.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    float suma = nota1 + nota2 + nota3;

                    float promedio = suma / 3;

                    MessageBox.Show($"El promedio es: {promedio:F2}");
                }
            }

        }
    }
}
