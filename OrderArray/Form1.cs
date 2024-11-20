namespace OrderArray
{
    public partial class Form1 : Form
    {
        private int[] numeros = { 8, 10, 5, 23, 2, 15, 18 };
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (int items in numeros)
            {
                liTable1.Items.Add(items);
            }
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            Array.Sort(numeros);
            liTable2.Items.Clear();

            foreach (int item in numeros)
            {
                liTable2.Items.Add(item);
            }
        }
    }
}
