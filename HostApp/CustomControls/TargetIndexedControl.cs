using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace HostApp.CustomControls
{
    public class TargetIndexedControl : UserControl
    {
        public static readonly DependencyProperty TargetIndexProperty = DependencyProperty.Register(
            "TargetIndex", typeof(int), typeof(TargetIndexedControl), null);
        //"TargetIndex", typeof(int), typeof(TargetIndexedControl), new PropertyMetadata(0));

        public static void SetTargetIndex(UIElement element, int value)
        {
            element.SetValue(TargetIndexProperty, value);
        }
        public static int GetTargetIndex(UIElement element)
        {
            return (int)element.GetValue(TargetIndexProperty);
        }
        public int TargetedIndex
        {
            get { return (int)GetValue(TargetIndexProperty); }
            set { SetValue(TargetIndexProperty, value); }
        }
    }
}
