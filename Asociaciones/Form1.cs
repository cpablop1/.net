using System.Data;

namespace Asociaciones
{
    public partial class Form1 : Form
    {
        private Almacen almacen = new Almacen();
        private DataTable dt;
        public Form1()
        {
            InitializeComponent();

            dt = new DataTable();
            dt.Columns.Add("No");
            dt.Columns.Add("Cliente");
            dt.Columns.Add("Celular");
            dt.Columns.Add("Venta Total");
            dt.Columns.Add("Fecha");

            dgv.DataSource = dt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Codigo....
        }

        // Funcón para resetear campos de textos
        public void limparCampos()
        {
            txtNombres.Clear();
            txtApellidos.Clear();
            txtNumId.Clear();
            txtCelular.Clear();
            txtTotal.Clear();
        }

        public void cargarDatos()
        {
            Venta[] venta = almacen.getVentas();

            dt.Rows.Clear();

            foreach (var item in venta)
            {
                if (item != null)
                {
                    DataRow row = dt.NewRow();
                    row["No"] = item.getNumVenta();
                    row["Cliente"] = $"{item.getCliente().getNombres()} {item.getCliente().getApellidos()}";
                    row["Celular"] = item.getCliente().getCelular();
                    row["Venta Total"] = item.getTotalVenta();
                    row["Fecha"] = item.getFechaVenta().getFecha();

                    dt.Rows.Add(row);
                }
            }
        }

        private void btnCrearVenta_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtNombres.Text) ||
                string.IsNullOrWhiteSpace(txtApellidos.Text) ||
                string.IsNullOrWhiteSpace(txtNumId.Text) ||
                string.IsNullOrWhiteSpace(txtCelular.Text) ||
                string.IsNullOrWhiteSpace(txtTotal.Text))
            {
                MessageBox.Show("Complete los campos para continuar.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Cliente cte = new Cliente(txtNombres.Text, txtApellidos.Text,
                    txtNumId.Text, txtCelular.Text);

                DateTime fecha = DateTime.Today;

                int dia = fecha.Day;
                int mes = fecha.Month;
                int anio = fecha.Year;

                Fecha f = new Fecha(dia, mes, anio);

                almacen.crearVenta(int.Parse(txtTotal.Text), cte, f);

                limparCampos();

                Venta v = almacen.getUltimaVenta();

                //MessageBox.Show("El número de la venta es: " + (string)cargarDatos());
                cargarDatos();
            }
        }
    }
}
