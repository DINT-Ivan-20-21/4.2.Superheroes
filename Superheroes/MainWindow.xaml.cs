using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Superheroes
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MainWindowViewModel viewModel;

        public MainWindow()
        {
            viewModel = new MainWindowViewModel();
            InitializeComponent();
            DataContext = viewModel;
        }
        private void FlechaMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            viewModel.ActualizaIndice((sender as Image).Tag.ToString());
        }

        private void AceptarCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            viewModel.AñadirSuperheroe();
            MessageBox.Show("Persona añadida con éxito", "PersonaMVVM", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void AceptarCommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = viewModel.ComprobarAñadirSuperheroe();
        }

        private void LimpiarCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            viewModel.LimpiarSuperheroe();
        }

        private void LimpiarCommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = viewModel.ComprobarLimpiarSuperheroe();
        }
    }
}
