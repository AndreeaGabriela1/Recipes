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

namespace Recipes_Application
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        { 
            Window1 w = new Window1();
            this.Close();
            w.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
            Window2 m = new Window2();
            this.Close();
            m.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Window3 m = new Window3();
            this.Close();
            m.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Window4 m = new Window4();
            this.Close();
            m.Show();
        }
    }
}
