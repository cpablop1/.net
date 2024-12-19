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
using System.Windows.Shapes;
using Conexion_BD.Datos;
using Conexion_BD.Logica;

namespace Conexion_BD.Presentacion
{
    /// <summary>
    /// Lógica de interacción para WfpConsultarCliente.xaml
    /// </summary>
    public partial class WfpConsultarCliente : Window
    {
        public WfpConsultarCliente()
        {
            InitializeComponent();
        }

        private void btnConsultarCliente_Click(object sender, RoutedEventArgs e)
        {
           LCliente lc = new LCliente();

            try
            {
                DCliente dcte = lc.getDatosCliente(txtIdentificacion.Text);

                txtIdCliente.Text = dcte.ID.ToString();
                txtNombres.Text = dcte.NOMBRES;
                txtApellidos.Text = dcte.APELLIDOS;
                txtDireccion.Text = dcte.DIRECCION;
                txtTelefono.Text = dcte.TELEFONO;
                txtCalificacion.Text = dcte.CALIFICACION;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
