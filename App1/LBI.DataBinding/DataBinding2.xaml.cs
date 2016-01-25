using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
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
    public sealed partial class DataBinding2 : Page
    {
        public MainData MainDataViewModel { get; set; }
        public DataBinding2()
        {
            MainDataViewModel = new MainData();

            this.InitializeComponent();
        }

        private void BtnAdd_OnClick(object sender, RoutedEventArgs e)
        {
            MainDataViewModel.Result = MainDataViewModel.Num1 + MainDataViewModel.Num2;
        }
    }

    public class MainData : NotifyPropertyChanged
    {
        private double num1;
        public double Num1
        {
            get { return num1; }
            set
            {
                num1 = value;
                OnPropertyChanged();
            }
        }

        private double num2;
        public double Num2
        {
            get { return num2; }
            set
            {
                num2 = value;
                OnPropertyChanged();
            }
        }

        private double result;
        public double Result
        {
            get { return result; }
            set
            {
                result = value;
                OnPropertyChanged();
            }
        }
    }
}
