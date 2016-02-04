using System;
using System.Collections.Generic;
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

namespace Airline
{
    public partial class MainWindow : Window
    {
        ViewModel vm = new ViewModel();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_f1001_Click(object sender, RoutedEventArgs e)
        {
            textBoxf1000.Text = vm.SPsw();
        }

        private void button_f1001_sell_Click(object sender, RoutedEventArgs e)
        {
            textBoxf1000.Text = vm.SPswInfo();
        }

        private void button_f1002_Click(object sender, RoutedEventArgs e)
        {

            textBoxf1000.Text = vm.SPne();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            textBoxf1000.Text = vm.SPneInfo();
        }

        private void button_f101_Click(object sender, RoutedEventArgs e)
        {
            textBoxf100.Text = vm.MPsw();
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            textBoxf100.Text = vm.MPswInfo();
        }

        private void button_f102_Click(object sender, RoutedEventArgs e)
        {
            textBoxf100.Text = vm.MPne();
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            textBoxf100.Text = vm.MPneInfo();
        }

        private void button_f11_Click(object sender, RoutedEventArgs e)
        {
            textBoxf10.Text = vm.BPsw();
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            textBoxf10.Text = vm.BPswInfo();
        }

        private void button_f12_Click(object sender, RoutedEventArgs e)
        {
            textBoxf10.Text = vm.BPne();
        }

        private void button11_Click(object sender, RoutedEventArgs e)
        {
            textBoxf10.Text = vm.BPneInfo();
        }

    }
}
