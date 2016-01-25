using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
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

namespace LBI.DataBinding
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class ListBoxPage : Page
    {
        public ObservableCollection<DateTime> Data { get; set; }
        public ListBoxPage()
        {
            Data = new ObservableCollection<DateTime>();

            for (int i = 0; i < 30; i++)
            {
                Data.Add(DateTime.Now);
            }

            this.InitializeComponent();
        }

        private void BtnLoadMore_OnClick(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 30; i++)
            {
                Data.Add(DateTime.Now);
            }
        }
    }
}
