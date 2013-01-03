namespace DataTemplateSample
{
    using System.Collections.Generic;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new List<PersonViewModel>
                                   {
                                       new PersonViewModel
                                           {
                                               FirstName = "Sam1",
                                               LastName = "Sampleman"
                                           },
                                        new PersonViewModel
                                            {
                                                FirstName = "Max2",
                                                LastName = "Muster"
                                            },
                                       new PersonViewModel
                                           {
                                               FirstName = "Sam3",
                                               LastName = "Sampleman"
                                           },
                                        new PersonViewModel
                                            {
                                                FirstName = "Max4",
                                                LastName = "Muster"
                                            },
                                       new PersonViewModel
                                           {
                                               FirstName = "Sam5",
                                               LastName = "Sampleman"
                                           },
                                        new PersonViewModel
                                            {
                                                FirstName = "Max6",
                                                LastName = "Muster"
                                            },
                                       new PersonViewModel
                                           {
                                               FirstName = "Sam7",
                                               LastName = "Sampleman"
                                           },
                                        new PersonViewModel
                                            {
                                                FirstName = "Max8",
                                                LastName = "Muster"
                                            },
                                       new PersonViewModel
                                           {
                                               FirstName = "Sam9",
                                               LastName = "Sampleman"
                                           },
                                        new PersonViewModel
                                            {
                                                FirstName = "Max0",
                                                LastName = "Muster"
                                            },
                                   };
        }
    }
}
