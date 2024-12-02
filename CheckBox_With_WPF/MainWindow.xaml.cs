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

namespace CheckBox_With_WPF
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

        private void btnMostrar_Click(object sender, RoutedEventArgs e)
        {
            List<string> cursos = new List<string>();
            string resultado = "";

            if (chbC.IsChecked == true)
            {
                cursos.Add("C#");
            }

            if (chbPython.IsChecked == true)
            {
                cursos.Add("Python");
            }

            if (chbJavascript.IsChecked == true)
            {
                cursos.Add("Javascript");
            }

            if (chbPHP.IsChecked == true)
            {
                cursos.Add("PHP");
            }

            foreach (var curso in cursos)
            {
                resultado += $"{curso}, ";
            }

            MessageBox.Show($"Los cursos eligidos son: {resultado}", "Cursos seleccionados", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
