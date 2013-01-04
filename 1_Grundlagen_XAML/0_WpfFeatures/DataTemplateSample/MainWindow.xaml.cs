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
            this.DataContext = new List<Person>
                                   {
                                       new Person
                                           {
                                               FirstName = "Sam1",
                                               LastName = "Sampleman"
                                           },
                                        new Person
                                            {
                                                FirstName = "Max2",
                                                LastName = "Muster"
                                            },
                                       new Person
                                           {
                                               FirstName = "Sam3",
                                               LastName = "Sampleman"
                                           },
                                        new Person
                                            {
                                                FirstName = "Max4",
                                                LastName = "Muster"
                                            },
                                       new Person
                                           {
                                               FirstName = "Sam5",
                                               LastName = "Sampleman"
                                           },
                                        new Person
                                            {
                                                FirstName = "Max6",
                                                LastName = "Muster"
                                            },
                                       new Person
                                           {
                                               FirstName = "Sam7",
                                               LastName = "Sampleman"
                                           },
                                        new Person
                                            {
                                                FirstName = "Max8",
                                                LastName = "Muster"
                                            },
                                       new Person
                                           {
                                               FirstName = "Sam9",
                                               LastName = "Sampleman"
                                           },
                                        new Person
                                            {
                                                FirstName = "Max0",
                                                LastName = "Muster"
                                            },
                                   };
        }
    }
}
