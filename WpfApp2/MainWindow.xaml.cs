using System;
using System.Windows;
using System.Windows.Data;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

      
        private void ODP1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Odp 1", "Jaka odp?", MessageBoxButton.OK, MessageBoxImage.Exclamation);
        }

        private void ODP2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Odp 2", "Jaka odp?", MessageBoxButton.OK, MessageBoxImage.Exclamation);
        }

        private void ODP3(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Odp 3", "Jaka odp?", MessageBoxButton.OK, MessageBoxImage.Exclamation);
        }

        private void Run_Click(object sender, RoutedEventArgs e)
        {

        }

        private void UpdateeCMB(object sender, EventArgs e)
        {
            if (cb1.Text == "6") MessageBox.Show("OOO to 4 !", "Uwaga", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
