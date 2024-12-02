using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data;
using System.Data.SqlClient;

namespace Conexion_BD
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private SqlConnection conexion = new SqlConnection("Data Source=PABLO\\SQLEXPRESS;Initial Catalog=tienda;Integrated Security=True;TrustServerCertificate=True");
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnConectar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                conexion.Open();

                if (conexion.State == ConnectionState.Open)
                {
                    MessageBox.Show("La conexión ha sido exitosa.");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }
    }
}
