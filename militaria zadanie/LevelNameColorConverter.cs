using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;

namespace militaria_zadanie
{
    public class LevelNameColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is string levelName)
            {
                switch (levelName)
                {
                    case "Temat":
                        return Brushes.Green;
                    case "Zakres informacyjny":
                        return Brushes.Red;
                    case "Dziedzina":
                        return Brushes.Yellow;
                    default:
                        return Brushes.Black;
                }
            }

            return Brushes.Black;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
