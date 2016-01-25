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
    public sealed partial class DataTemplatePage : Page
    {
        public ObservableCollection<Person2> ViewModel { get; set; }

        public DataTemplatePage()
        {
            ViewModel=new ObservableCollection<Person2>();

            for (int i = 0; i < 10; i++)
            {
                ViewModel.Add(new Person2() { Id = i, Gender = "man", Name = "LBI" + i });
            }

            this.InitializeComponent();
        }
    }

    public class Person2
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Gender { get; set; }
    }
}
