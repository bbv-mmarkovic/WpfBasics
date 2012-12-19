using System.Windows;

namespace WhichValueWins
{
    using System;
    using System.Windows.Controls;
    using System.Windows.Data;
    using System.Windows.Media.Animation;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        private bool anim1applied = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ApplyAddAnimationClick(object sender, RoutedEventArgs e)
        {
            var currentLeft = Canvas.GetLeft(this.myEllipse);
            if (double.IsNaN(currentLeft))
            {
                MessageBox.Show(
                    "Ensure a value first! (Set local value or apply style)",
                    "No current value!",
                    MessageBoxButton.OK,
                    MessageBoxImage.Warning);
                return;
            }

            var anim = this.Resources[Constants.DoubleAddStoryboard] as Storyboard;
            anim.Begin(this.myEllipse);
            this.anim1applied = true;
        }
        
        private void ApplyOverrideAnimationClick(object sender, RoutedEventArgs e)
        {
            var anim = this.Resources[Constants.DoubleOverrideStoryboard] as Storyboard;
            anim.Begin(this.myEllipse);
            this.anim1applied = false;
        }

        private void ClearAnimationsClick(object sender, RoutedEventArgs e)
        {
            this.myEllipse.BeginAnimation(Canvas.LeftProperty, null);
            this.anim1applied = false;
        }

        private void SetValueClick(object sender, RoutedEventArgs e)
        {
            var converted = Convert.ToDouble(this.valueTextBox.Text);
            Canvas.SetLeft(this.myEllipse, converted);
        }

        private void ApplyStyleClick(object sender, RoutedEventArgs e)
        {
            var style = this.Resources[Constants.StyleOneKey] as Style;
            this.myEllipse.Style = style;
        }

        private void ClearLocalValueClick(object sender, RoutedEventArgs e)
        {
            if (this.anim1applied)
            {
                MessageBox.Show(
                    "Before you can clear the local value, you have to remove the animation 1 by either clear the animation, or running animation 2.",
                    "Can not remove local vlaue",
                    MessageBoxButton.OK,
                    MessageBoxImage.Warning);

                return;
            }

            this.myEllipse.ClearValue(Canvas.LeftProperty);
        }

        private void ClearStyleClick(object sender, RoutedEventArgs e)
        {
            this.myEllipse.Style = null;
        }

        private void ClearBindingClick(object sender, RoutedEventArgs e)
        {
            BindingOperations.ClearBinding(this.myEllipse, Canvas.LeftProperty);
        }

        private void AddBindingClick(object sender, RoutedEventArgs e)
        {
            var binding = new Binding
                              {
                                  RelativeSource = new RelativeSource(RelativeSourceMode.Self),
                                  Path = new PropertyPath(PropertyContainer.MyDoubleProperty),
                                  Mode = BindingMode.OneWay
                              };
            BindingOperations.SetBinding(this.myEllipse, Canvas.LeftProperty, binding);
        }

        private void SetLocalAttachedValueClick(object sender, RoutedEventArgs e)
        {
            var converted = Convert.ToDouble(this.valueTextBox.Text);
            PropertyContainer.SetMyDouble(this.myEllipse, converted);
        }

        private void ClearLocalAttachedValueClick(object sender, RoutedEventArgs e)
        {
            this.myEllipse.ClearValue(PropertyContainer.MyDoubleProperty);
        }
    }
}
