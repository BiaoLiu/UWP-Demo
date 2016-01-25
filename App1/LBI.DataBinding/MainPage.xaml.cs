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

namespace LBI.DataBinding
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public Person Person { get; set; }
        public MainPage()
        {
            Person = new Person() { Id = 1, Age = 20, Gender = "man", Name = "LBI" };

            this.InitializeComponent();

            // this.DataContext = Data;
            //this.txt1.Text = Data;
        }
    }

    public class Person
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public string Gender { get; set; }
    }
}
