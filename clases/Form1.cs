namespace clases
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AireAcondicionado aire1 = new AireAcondicionado();
            AireAcondicionado aire2 = new AireAcondicionado();

            aire1.marca = "xyz";
            aire1.modelo = "000111s0002d0";
            aire1.color = "Negro";
            aire1.btu = 12000;
            aire1.voltaje = 110;
            aire1.temperatura = 16;

            aire2.marca = "Samsung";
            aire2.modelo = "0000233a22s22as";
            aire2.color = "Gris";
            aire2.btu = 15000;
            aire2.voltaje = 220;
            aire2.temperatura = 20;

            MessageBox.Show(aire2.marca);
        }
    }
}
