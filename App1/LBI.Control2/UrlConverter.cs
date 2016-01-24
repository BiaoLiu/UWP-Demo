using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace LBI.Control2
{
    public class UrlConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            return $"http://www.baidu.com/list.aspx?item={value}";
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            return 1;
        }
    }
}
