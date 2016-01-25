using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// “空白页”项模板在 http://go.microsoft.com/fwlink/?LinkId=234238 上提供

namespace LBI.Control2
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class PageNavigate2 : Page
    {
        public PageNavigate2()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            var parameter = e.Parameter;

            var type = e.Parameter?.GetType();
            if (type == null)
            {
                return;
            }

            var id = type.GetProperty("id").GetValue(parameter);
            var name = type.GetProperty("name").GetValue(parameter);

            Debug.WriteLine($"id:{id} name:{name}");
        }

        private void Button1_OnClick(object sender, RoutedEventArgs e)
        {

        }

        private void Button2_OnClick(object sender, RoutedEventArgs e)
        {
            //this.Frame.Navigate(typeof(PageNavigate));

            if (this.Frame.CanGoBack)
            {
                this.Frame.GoBack();
            }
        }
    }
}
