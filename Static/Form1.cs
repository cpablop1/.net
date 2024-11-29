namespace Static
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show($"El sultado de la potenciación: {Matematicas.potenciacion(5,3)}");
        }
    }
}
