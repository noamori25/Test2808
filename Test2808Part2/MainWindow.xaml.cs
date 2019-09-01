using Prism.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Test2808Part2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ViewModel vm;
        
        public MainWindow()
        {
            InitializeComponent();
            vm = new ViewModel();
           this.DataContext = vm;
        }

        private void BCorrect_Click(object sender, RoutedEventArgs e)
        {
            MyWindow.Background = new SolidColorBrush(Colors.LightGreen);
            bCorrect.IsEnabled = false;
            b1.IsEnabled = false;
            b2.IsEnabled = false;
            b3.IsEnabled = false;
            vm.timer.Stop();
        }
        private void B1_Click(object sender, RoutedEventArgs e)
        {
            MyWindow.Background = new SolidColorBrush(Colors.LightPink);
            bCorrect.IsEnabled = false;
            b1.IsEnabled = false;
            b2.IsEnabled = false;
            b3.IsEnabled = false;
            vm.timer.Stop();
        }

        private void B2_Click(object sender, RoutedEventArgs e)
        {
            MyWindow.Background = new SolidColorBrush(Colors.LightPink);
            bCorrect.IsEnabled = false;
            b1.IsEnabled = false;
            b2.IsEnabled = false;
            b3.IsEnabled = false;
            vm.timer.Stop();
        }

        private void B3_Click(object sender, RoutedEventArgs e)
        {
            MyWindow.Background = new SolidColorBrush(Colors.LightPink);
            bCorrect.IsEnabled = false;
            b1.IsEnabled = false;
            b2.IsEnabled = false;
            b3.IsEnabled = false;
            vm.timer.Stop();
        }
    }
}
