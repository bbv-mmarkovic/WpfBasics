namespace WhichValueWins
{
    using System.Windows;

    public class PropertyContainer : FrameworkElement
    {
        public static double GetMyDouble(DependencyObject obj)
        {
            return (double)obj.GetValue(MyDoubleProperty);
        }

        public static void SetMyDouble(DependencyObject obj, double value)
        {
            obj.SetValue(MyDoubleProperty, value);
        }
        
        // Using a DependencyProperty as the backing store for MyDouble.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MyDoubleProperty = 
            DependencyProperty.RegisterAttached(
                                "MyDouble", 
                                typeof(double), 
                                typeof(PropertyContainer), 
                                new FrameworkPropertyMetadata(0.0, FrameworkPropertyMetadataOptions.Inherits));

    }
}