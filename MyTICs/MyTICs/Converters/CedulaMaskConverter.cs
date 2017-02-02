using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MyTICs.Converters
{
    public class CedulaMaskConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null)
            {
                bool hasZero = false;
                if (value.ToString().Substring(0, 1).Equals("0"))
                    hasZero = true;

                    var cedula = string.Format("{0:###-#######-#}", Int64.Parse(value.ToString()));

                if (value.ToString().Substring(0, 1).Equals("0"))
                    cedula = "0" + cedula;

                return cedula;
            }
            else
                return "- -";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
    }
}
