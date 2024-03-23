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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace lab02
{
    /// <summary>
    /// Lógica de interacción para login.xaml
    /// </summary>
    public partial class login : Window
    {
        public login()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            menu menu1 = new menu();
            menu1.ShowDialog();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            
            string usuario = "luis";
            string contraseña = "1234";

            
            string usuarioIngresado = txtUser.Text;
            string contraseñaIngresada = txtpassword.Text;

            
            if (usuarioIngresado == usuario && contraseñaIngresada == contraseña)
            {
                MessageBox.Show("¡Inicio de sesión exitoso!", "Éxito", MessageBoxButton.OK, MessageBoxImage.Information);
                menu menu1 = new menu();
                menu1.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            
        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Estas seguro de salir", "MENSAJE", MessageBoxButton.OK, MessageBoxImage.Information);

            // Cierra la ventana actual para regresar a la pantalla anterior
            this.Close();
        }
    }
}
