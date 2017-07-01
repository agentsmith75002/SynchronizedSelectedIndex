using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;

namespace HostApp.Converters
{
    public class VisibilityIndexedConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            var index = System.Convert.ToInt32(value);
            var givenIndexList = parameter as string;

            var givenIndexes = givenIndexList.Split(',').Select(i => System.Convert.ToInt32(i));
            return givenIndexes.Any(givenIndex => givenIndex == index) ? Visibility.Collapsed : Visibility.Visible;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            return System.Convert.ToInt32(value);
        }
    }
}
