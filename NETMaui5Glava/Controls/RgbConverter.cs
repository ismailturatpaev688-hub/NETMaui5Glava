using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace NETMaui5Glava.Controls
{
    // Берет три отдельных числа (красный, зеленый, синий) и превращает их в один готовый цвет
    public class RgbConverter : IMultiValueConverter
    {
        // Получает три значения и отдат цвет
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            // Приводим их к байтам
            var r = System.Convert.ToByte(values[0]);
            var g = System.Convert.ToByte(values[1]);
            var b = System.Convert.ToByte(values[2]);
            // Создаем и возвращаем готовый цвет на три числа
            return Color.FromRgb(r, g, b);
        }

        // Обратная операция: разложить на три числа
        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
