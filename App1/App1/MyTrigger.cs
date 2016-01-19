using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;

namespace App1
{
    public  class MyTrigger:StateTriggerBase
    {
        public MyTrigger()
        {
            Window.Current.SizeChanged += (sender, e) =>
            {
                if (e.Size.Width >= 700 || e.Size.Height <= 450)
                {
                    this.SetActive(true);
                }
                else
                {
                    this.SetActive(false);
                }
            };
        }
    }
}
