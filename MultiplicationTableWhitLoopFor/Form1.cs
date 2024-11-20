namespace MultiplicationTableWhitLoopFor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 10; i++)
            {
                liTable.Items.Add($"--------- TABLA DEL {i} ---------");

                for(int j = 1; j <= 10; j++)
                {
                    int operation = i * j;

                    liTable.Items.Add($"{i} X {j} = {operation}");
                }

                liTable.Items.Add("");
            }
        }
    }
}
