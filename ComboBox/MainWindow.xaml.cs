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

namespace ComboBox
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<string> cursos = new List<string>();

            cursos.Add("C#");
            cursos.Add("C++");
            cursos.Add("Python");
            cursos.Add("Javascript");

            cmbLista.ItemsSource = cursos;
        }

        private void btnMostrar_Click(object sender, RoutedEventArgs e)
        {
            string mostar = cmbLista.SelectedItem.ToString();

            MessageBox.Show($"El curso seleccionado es: {mostar}");
        }
    }
}
