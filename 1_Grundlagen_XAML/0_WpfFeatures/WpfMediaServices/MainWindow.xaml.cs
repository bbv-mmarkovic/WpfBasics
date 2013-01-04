namespace WpfMediaServices
{
    using System;
    using System.Windows;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void PlayMovieClicked(object sender, RoutedEventArgs e)
        {
            try
            {
                mediaPlayer.Source = new Uri(this.txtMoviePath.Text);
                mediaPlayer.Play();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
