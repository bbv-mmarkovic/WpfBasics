namespace Commands
{
    using System.Windows;
    using System.Windows.Input;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ICommand MyCommand { get; private set; }

        public MainWindow()
        {
            this.MyCommand = new ShowInputCommand();
            this.DataContext = this;

            InitializeComponent();
        }
    }
}
