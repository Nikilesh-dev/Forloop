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

namespace For_loop
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
            StringBuilder Print = new StringBuilder();

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 4; k++)
                    {
                        for (int l = 0; l < 5; l++)
                        {
                            Print.Append(i.ToString());
                            Print.Append(j.ToString());
                            Print.Append(k.ToString());
                            Print.Append(l.ToString());
                            Print.AppendLine(",");
                            lbltxt.Content = Print.ToString();
                        }
                    }
                }
            }
            
            
        }
    }
}
