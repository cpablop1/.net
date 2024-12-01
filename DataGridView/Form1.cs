namespace DataGridView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            dgvProductos.Rows.Add(txtCodigo.Text, txtProducto.Text, txtPrecio.Text);

            txtCodigo.Clear();
            txtProducto.Clear();
            txtPrecio.Clear();

            txtCodigo.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtCodigo.Focus();
        }
    }
}
