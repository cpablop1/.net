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

namespace Grid_ListBox
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, RoutedEventArgs e)
        {
            //string valor = txtAgregar.Text;

            //liElementos.Items.Add(valor);

            List<string> valores = new List<string>();

            valores.Add("Valor 1");
            valores.Add("Valor 2");
            valores.Add("Valor 3");
            valores.Add("Valor 4");

            liElementos.ItemsSource = valores;
        }

        private void btnMostrar_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(liElementos.SelectedItem.ToString());
        }
    }
}
