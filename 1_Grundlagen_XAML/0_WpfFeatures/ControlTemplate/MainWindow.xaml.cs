namespace ControlTemplate
{
    using System.Windows;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CustomButtonClicked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Custom Button clicked!");
        }
    }
}
