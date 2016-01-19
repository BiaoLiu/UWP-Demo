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

// “空白页”项模板在 http://go.microsoft.com/fwlink/?LinkId=234238 上提供

namespace LBI.ApplicationBar
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class ControlTest : Page
    {
        public ControlTest()
        {
            this.InitializeComponent();
        }

        private void TextBox1_SelectionChanged(object sender, RoutedEventArgs e)
        {
          var text=  this.textBox1.SelectedText;

            label1.Text = "Selection length is " + textBox1.SelectionLength.ToString();
            label2.Text = "Selection starts at " + textBox1.SelectionStart.ToString();
        }

        private void passwordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (passwordBox.Password == "Password")
            {
                statusText.Text = "'Password' is not allowed as a password.";
            }
            else
            {
                statusText.Text = string.Empty;
            }
        }

        private void CheckBox_Changed(object sender, RoutedEventArgs e)
        {
            if (revealModeCheckBox.IsChecked == true)
            {
                passwordBox1.PasswordRevealMode = PasswordRevealMode.Visible;
            }
            else
            {
                passwordBox1.PasswordRevealMode = PasswordRevealMode.Hidden;
            }
        }
    }
}
