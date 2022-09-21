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

namespace Teglalap
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

        private void szamolj_Click(object sender, RoutedEventArgs e)
        {
            double a = double.Parse(a_oldal.Text), b = double.Parse(b_oldal.Text);
            double K = (a + b) * 2, T = a * b;

            Kerulet.Text = K.ToString() + " cm";
            Terulet.Text = T.ToString() + " cm2";
        }
    }
}
