namespace SearchInAnArray
{
    public partial class Form1 : Form
    {
        private String[] nombres = { "Mar�a", "Pedro", "Mario", "Rafael"};
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            String buscar = txtBuscar.Text;
            bool encontrado = false;

            if (String.IsNullOrWhiteSpace(buscar))
            {
                MessageBox.Show("Ingrese el nombre para inicar b�squeda.", "Campo inv�lido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBuscar.Focus();
            }
            else
            {
                for(int item = 0; item < nombres.Length && encontrado == false; item++)
                {
                    if (buscar.Equals(nombres[item]))
                    {
                        encontrado = true;
                    }
                }

                if (encontrado)
                {
                    MessageBox.Show($"Nombre encontrado: {buscar}", "Operaci�n exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtBuscar.Focus();
                }
                else
                {
                    MessageBox.Show("Nombre no encontrada!", "Operaci�n finalizada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtBuscar.Focus();
                }
            }
        }
    }
}
