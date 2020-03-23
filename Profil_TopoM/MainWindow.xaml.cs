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

namespace Profil_TopoM
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonPopUpLogout_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void buttonopenmenu_Click(object sender, RoutedEventArgs e)
        {
            buttonopenmenu.Visibility = Visibility.Collapsed;
            Buttonclosemenu.Visibility = Visibility.Visible;
        }

        private void Buttonclosemenu_Click(object sender, RoutedEventArgs e)
        {
            buttonopenmenu.Visibility = Visibility.Visible;
            Buttonclosemenu.Visibility = Visibility.Collapsed;
        }

        private void paramBtn_Click(object sender, RoutedEventArgs e)
        {
            Parametrage param = new Parametrage();
            selectionGrid.Children.Add(param);
        }

        private void textBlock1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Parametrage param = new Parametrage();
            selectionGrid.Children.Add(param);
        }

        private void homeBtn_Click(object sender, RoutedEventArgs e)
        {
            selectionGrid.Children.Clear();
        }

        private void textBlock_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            selectionGrid.Children.Clear();
        }

        private void dossierBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void textBlock2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void textBlock3_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void aideBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void quitBtn_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void textBlock4_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }
    }
}