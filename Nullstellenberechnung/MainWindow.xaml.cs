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

namespace Nullstellenberechnung
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double a = Convert.ToDouble(TxtBx_a.Text);
            double b = Convert.ToDouble(TxtBx_b.Text);
            double c = Convert.ToDouble(TxtBx_c.Text);
            if (a == 0.0) 
            {
                MessageBox.Show(" a muss verschieden von Null sein");
            }
            else
            {
                double p, q, D;
                double x1, x2;
                p = b / a;
                q = c / a;
                D = Math.Pow(p / 2, 2) - q;
                if (D >0)
                {
                    x1 = -p / 2 + Math.Sqrt(D);
                    x2 = -p / 2 - Math.Sqrt(D);
                    TxtBx_Ausgabe.Text = "Es gibt zwei einfache reelle Nullstellen: x_1=" + x1 + "und x_2=" + x2 + ".";
                }
                else if (D==0.0)
                {
                    x1 = -p / 2;
                    TxtBx_Ausgabe.Text = "Es gibt zwei einfache doppelte Nullstellen: x_1=" + x1 ;

                }
                else
                {
                    TxtBx_Ausgabe.Text = "Es gibt keine reelle Nulstelle";
                }
            }
        }

        private void TxtBx_g_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
