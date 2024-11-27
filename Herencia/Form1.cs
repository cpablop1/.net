namespace Herencia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Cliente cte = new Cliente("María", "Hernandez", "122", "Guatemala", "5555555", 90);

            cte.darDescripcion();
        }
    }
}
