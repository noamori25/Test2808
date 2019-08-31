using Prism.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Threading;

namespace Test2808Part2
{
    public class ViewModel : DependencyObject
    {
        public Exercise ex { get; set; }
        public static readonly DependencyProperty TimerLeftProperty =
            DependencyProperty.Register("TimerLeft", typeof(int), typeof(ViewModel), new PropertyMetadata(30));
        public DispatcherTimer timer;
        public ViewModel()
        {
            ex = new Exercise() { CorrectAnswer = 50,Optional1 = 55, Optional2 = 65, Optional3 = 10 };
            timer = new DispatcherTimer(TimeSpan.FromSeconds(1), 
                DispatcherPriority.Normal,
                new EventHandler(Callback), Application.Current.Dispatcher);
            timer.Start();
        }

        private void Callback(object ignore, EventArgs ex)
        {
            TimerLeft = TimerLeft - 1;
            if (TimerLeft == 0)
            {
                timer.Stop();
            }
        }

        public int TimerLeft
        {
            get { return (int)GetValue(TimerLeftProperty); }
            set { SetValue(TimerLeftProperty, value); }
        }



    }
}
