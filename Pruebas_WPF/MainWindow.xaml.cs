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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Pruebas_WPF
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //public int MiProperty
        //{
        //    get { return (int)GetValue(MiDependencyProperty); }
        //    set { SetValue(MiDependencyProperty, value); }
        //}

        //public static readonly DependencyProperty MiDependencyProperty = 
        //    DependencyProperty.Register("MiProperty", typeof(int), typeof(MainWindow), new PropertyMetadata(0));

        public MainWindow()
        {
            InitializeComponent();
            MostrarNombre = new Avisos { Nombre = "Luis", Apellido = "Matamoros" };
            this.DataContext = MostrarNombre;
        }

        public Avisos MostrarNombre;
    }
}
