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

namespace TextBox_Button
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

        private void btnSumar_Click(object sender, RoutedEventArgs e)
        {
            int numero1 = int.Parse(txtNum1.Text);
            int numero2 = int.Parse(txtNum2.Text);

            int suma = numero1 + numero2;

            MessageBox.Show($"La suma de dos números es: {suma}", "Operación exitosa", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
