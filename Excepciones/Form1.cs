namespace Excepciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int[] numeros = { 10, 5, 7, 8 };

            try // En caso de que todo vaya bien, se ejecuta las instrcciones dentro del try
            {
                // Código que se ejecuta
                MessageBox.Show("" + numeros[3]);
            }
            catch(Exception ex) // En caso de error se ejecuta las instrucciones dentro del catch
            {
                MessageBox.Show("" + ex.Message);
            }
            finally // Independiente del resultado, siemprese se ejecutaran las instrucciones dentro del finally
            {
                MessageBox.Show("" + numeros[0]);
            }
        }
    }
}
