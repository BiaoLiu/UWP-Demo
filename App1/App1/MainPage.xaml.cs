using System;
using System.Collections.Generic;
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

//“空白页”项模板在 http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409 上有介绍

namespace App1
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        //private void BtnPlay_OnClick(object sender, RoutedEventArgs e)
        //{
        //    //this.storyboard.Begin();
        //}

        private void chkSelect_Checked(object sender, RoutedEventArgs e)
        {
            VisualStateManager.GoToState(this, "vsSelect", true);
        }

        private void chkSelect_Unchecked(object sender, RoutedEventArgs e)
        {
            VisualStateManager.GoToState(this, "vsUnSelect", true);
        }
    }
}
