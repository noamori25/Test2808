﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Test2808
{
    public class ValueConverterWidth : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Double number = System.Convert.ToDouble(value);
            if (number < 25 * 500 / 100)
            {
                return $"Small";
            }
           else if (number < 50 * 500 / 100)
            {
                return $"Meduim";
            }
            else if (number < 75 * 500 / 100)
            {
                return $"Large";
            }
            else if (number > 75 * 500 / 100)
            {
                return $"Extra Large";
            }
            return string.Empty;
        }      

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
