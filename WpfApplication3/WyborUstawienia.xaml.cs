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

namespace WpfApplication3
{
    /// <summary>
    /// Interaction logic for WyborUstawienia.xaml
    /// </summary>
    public partial class WyborUstawienia : Window
    {
        public WyborUstawienia()
        {
            InitializeComponent();
        }

        private void buttonUstawienie4_4_2_Click(object sender, RoutedEventArgs e)
        {
            Ustawienie4_4_2 okno = new Ustawienie4_4_2();
            okno.ShowDialog();
        }

        private void buttonZamknij_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
