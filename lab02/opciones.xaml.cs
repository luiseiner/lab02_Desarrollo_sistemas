﻿using System;
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
    /// Lógica de interacción para opciones.xaml
    /// </summary>
    public partial class opciones : Window
    {
        public opciones()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            operaciones ope = new operaciones();
            ope.ShowDialog();
        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}