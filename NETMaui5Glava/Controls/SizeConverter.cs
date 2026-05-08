using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace NETMaui5Glava.Controls
{
    class SizeConverter : IValueConverter
    {
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            return (double)value - 20;
        }
        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
