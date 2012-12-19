namespace RoutedEvents
{
    using System;
    using System.Windows;
    using System.Windows.Controls;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CommonClickHandler(object sender, MyButtonSimpleEventArgs e)
        {
            var source = (Button)e.Source;
            MessageBox.Show("The button " + source.Content + " raised the event (" + DateTime.Now + ").");
        }

        private void Yes_Click(object sender, RoutedEventArgs e)
        {
            OutputLabel.Content = "Yes clicked (" + DateTime.Now + ")";
        }

        private void No_Click(object sender, RoutedEventArgs e)
        {
            OutputLabel.Content = "No clicked (" + DateTime.Now + ")";
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            OutputLabel.Content = "Cancel clicked (" + DateTime.Now + ")";
        }
    }
}
