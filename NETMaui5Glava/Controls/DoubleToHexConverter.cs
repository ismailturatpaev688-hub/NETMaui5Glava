using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace NETMaui5Glava.Controls
{
    public class DoubleToHexConverter : IValueConverter
    {
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            if (value == null) return null;
            var data = System.Convert.ToInt32(value);
            return data.ToString("X");
        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture) 
        {
            if (value == null) return null;
            return (double)int.Parse((string)value, NumberStyles.HexNumber);
        }
    }
}
