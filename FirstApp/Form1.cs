namespace FirstApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BntVerMensaje_Click(object sender, EventArgs e)
        {
            var mensaje = txtMensaje.Text;
            MessageBox.Show("El valor de variable es: " + mensaje);
        }
    }
}
