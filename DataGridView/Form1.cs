namespace DataGridView
{
    public partial class Form1 : Form
    {
        private double total = 0;
        private int totalProductos = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            total = 0;
            totalProductos = 0;

            dgvProductos.Rows.Add(txtCodigo.Text, txtProducto.Text, txtPrecio.Text);

            txtCodigo.Clear();
            txtProducto.Clear();
            txtPrecio.Clear();

            txtCodigo.Focus();

            for (int i = 0; i < dgvProductos.Rows.Count - 1; i++)
            {
                total = total + double.Parse(dgvProductos.Rows[i].Cells[2].Value.ToString());
            }

            txtTotalCompra.Text = total.ToString();
            txtTotalProductos.Text = "" + (dgvProductos.Rows.Count - 1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtCodigo.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            total = 0;
            totalProductos = 0;
            try
            {
                dgvProductos.Rows.RemoveAt(dgvProductos.CurrentCell.RowIndex);

                for (int i = 0; i < dgvProductos.Rows.Count - 1; i++)
                {
                    total = total + double.Parse(dgvProductos.Rows[i].Cells[2].Value.ToString());
                }

                txtTotalCompra.Text = total.ToString();
                txtTotalProductos.Text = "" + (dgvProductos.Rows.Count - 1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de eliminación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            txtTotalCompra.Enabled = true;
            txtTotalProductos.Enabled = true;
        }
    }
}
