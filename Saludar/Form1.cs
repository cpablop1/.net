namespace Saludar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Esta funci�n ejecuta las instrucciones para saludar
        public void saludar()
        {
            MessageBox.Show("Hola soy un programa, haciendo uso de funciones en C#");
        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {
            saludar();
        }
    }
}
