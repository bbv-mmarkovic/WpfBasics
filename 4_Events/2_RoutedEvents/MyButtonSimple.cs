namespace RoutedEvents
{
    using System.Windows;
    using System.Windows.Controls;

    public class MyButtonSimple : Button
    {
        public delegate void MyButtonSimpleEventHandler(object sender, MyButtonSimpleEventArgs e);

        // Create a custom routed event by first registering a RoutedEventID 
        // This event uses the bubbling routing strategy 
        public static readonly RoutedEvent TapEvent = EventManager.RegisterRoutedEvent(
            "Tap", RoutingStrategy.Bubble, typeof(MyButtonSimpleEventHandler), typeof(MyButtonSimple));

        // Provide CLR accessors for the event 
        public event MyButtonSimpleEventHandler Tap
        {
            add { AddHandler(TapEvent, value); }
            remove { RemoveHandler(TapEvent, value); }
        }

        // This method raises the Tap event 
        public void RaiseTapEvent()
        {
            RaiseEvent(new MyButtonSimpleEventArgs());
        }

        // For demonstration purposes we raise the event when the MyButtonSimple is clicked 
        protected override void OnClick()
        {
            RaiseTapEvent();
            base.OnClick();
        }
    }

    public class MyButtonSimpleEventArgs : RoutedEventArgs
    {
        public MyButtonSimpleEventArgs() : base(MyButtonSimple.TapEvent)
        {
        }
    }
}