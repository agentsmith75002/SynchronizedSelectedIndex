using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace HostApp.CustomControls
{
    public class ContentUserControl : ContentControl
    {
        public static readonly DependencyProperty ContentTagProperty = DependencyProperty.Register(
            "ContentTag", typeof(string), typeof(ContentUserControl), new PropertyMetadata(null, OnPropertyChanged));

        public static void SetContentTag(UIElement element, string value)
        {
            element.SetValue(ContentTagProperty, value);
        }
        public static string GetContentTag(UIElement element)
        {
            return (string)element.GetValue(ContentTagProperty);
        }

        private static void OnPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var tag = e.NewValue as string;
            if (tag == null)
                return;

            var cc = d as ContentUserControl;
            if (cc.Resources.ContainsKey(tag))
                cc.ContentTemplate = cc.Resources[tag] as DataTemplate;
        }
    }
}
