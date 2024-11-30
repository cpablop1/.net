namespace Checkbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnComprobar_Click(object sender, EventArgs e)
        {
            int totalPreguntas = 0;
            double puntos = 0;

            if(chPolimorfismo.Checked == true)
            {
                totalPreguntas += 1;
                puntos += 2.5;
            }

            if(chHerencia.Checked == true)
            {
                totalPreguntas += 1;
                puntos += 2.5;
            }

            if(chClases.Checked == true)
            {
                totalPreguntas += 1;
                puntos += 2.5;
            }

            if(chAtributos.Checked == true)
            {
                totalPreguntas += 1;
                puntos += 2.5;
            }

            MessageBox.Show($"Has obtenido {puntos} puntos de {totalPreguntas}/4 preguntas.");
        }
    }
}
