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

namespace RadioButton_With_WPF
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

        private void btnSeleccionar_Click(object sender, RoutedEventArgs e)
        {
            string curso = "";

            if(rbPython.IsChecked == true)
            {
                curso = "Python";
            }

            if(rbJavascript.IsChecked == true)
            {
                curso = "Javascript";
            }

            if(rbSqlServer.IsChecked == true)
            {
                curso = "SQL Server";
            }

            MessageBox.Show($"Has eligido el curso de: {curso}", "Curso seleccionado", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
