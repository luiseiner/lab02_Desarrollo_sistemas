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
    /// Lógica de interacción para operaciones.xaml
    /// </summary>
    public partial class operaciones : Window
    {
        public operaciones()
        {
            InitializeComponent();
        }

        private void btnaceptar_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Se ingreso correctamente", "MENSAJE", MessageBoxButton.OK, MessageBoxImage.Information);
          

            string tipoDocumento = TipoDocumentoTextBox.Text;
            string numeroDocumento = NumeroDocumentoTextBox.Text;
            string placa = PlacaTextBox.Text;
            string turno = TurnoTextBox.Text;
            string nombreConductor = NombreConductorTextBox.Text;
            string nombreCliente = NombreClienteTextBox.Text;
            string fechaHora = FechaHoraDatePicker.SelectedDate.ToString();
            string pesoIngreso = PesoIngresoTextBox.Text;

            
            salidas mostrarDatosWindow = new salidas(
                tipoDocumento, numeroDocumento, placa, turno, nombreConductor,
                nombreCliente, fechaHora, pesoIngreso);
            mostrarDatosWindow.ShowDialog();
            
        }

        private void btnsalir_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Estas seguro de salir", "MENSAJE", MessageBoxButton.OK, MessageBoxImage.Information);

            
            this.Close();
        }
    }
}
