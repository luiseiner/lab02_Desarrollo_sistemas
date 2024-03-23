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
    /// Lógica de interacción para salidas.xaml
    /// </summary>
    public partial class salidas : Window
    {
        public salidas(string tipoDocumento, string numeroDocumento, string placa, string turno, string nombreConductor,
                            string nombreCliente, string fechaHora, string pesoIngreso)
        {
            InitializeComponent();

            // Asignar los datos a los elementos de la interfaz de usuario
            txtDatos.Text = $"Tipo de Documento: {tipoDocumento}\n" +
                            $"Número de Documento: {numeroDocumento}\n" +
                            $"Placa: {placa}\n" +
                            $"Turno: {turno}\n" +
                            $"Nombre del Conductor: {nombreConductor}\n" +
                            $"Nombre del Cliente: {nombreCliente}\n" +
                            $"Fecha y Hora: {fechaHora}\n" +
                            $"Peso de Ingreso: {pesoIngreso}";
        }

        private void btnaceptar_Click(object sender, RoutedEventArgs e)
        {
            operaciones ope = new operaciones();
            ope.ShowDialog();
        }

        private void btnsalir_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Estas seguro de salir", "MENSAJE", MessageBoxButton.OK, MessageBoxImage.Information);


            this.Close();
        }
    }

}
