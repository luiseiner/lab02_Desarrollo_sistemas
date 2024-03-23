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

namespace lab02
{
    /// <summary>
    /// Lógica de interacción para menu.xaml
    /// </summary>
    public partial class menu : Window
    {
        public menu()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            opciones ope = new opciones();
            ope.ShowDialog();
        }

        private void btnMant_Click(object sender, RoutedEventArgs e)
        {
            mantenimiento man = new mantenimiento();
            man.ShowDialog();
        }

        private void btnReportes_Click(object sender, RoutedEventArgs e)
        {
            Reportes repo = new Reportes();
            repo.ShowDialog();
        }
    }
}
