using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Markup;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

//“空白页”项模板在 http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409 上有介绍

namespace LBI.Control
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            //this.scrollViewer1.ChangeView(null, 100, null);
        }

        private void Btn_OnClick(object sender, RoutedEventArgs e)
        {
            var xaml = "<Button   xmlns=\"http://schemas.microsoft.com/winfx/2006/xaml/presentation\" Content=\"the hide button\"></Button>";

            var btn = XamlReader.Load(xaml);
        }

         private void TextBox_OnSelectionChanged(object sender, RoutedEventArgs e)
        {
            var txtBox = sender as TextBox;

             var txt= txtBox.SelectedText;

             //  await new MessageDialog(txtBox?.SelectedText ?? "").ShowAsync();
        }

        private void BtnValue_OnClick(object sender, RoutedEventArgs e)
        {
            

        }
    }
}
