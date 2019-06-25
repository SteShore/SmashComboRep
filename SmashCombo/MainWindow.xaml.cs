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
using SmashCombo.ViewModel;

namespace SmashCombo
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

        private void Home_Clicked(object sender, RoutedEventArgs e)
        {
            DataContext = new HomeVM();
        }

        private void MarioBtn_Clicked(object sender, RoutedEventArgs e)
        {
            DataContext = new MarioVM();
        }
    }
}
