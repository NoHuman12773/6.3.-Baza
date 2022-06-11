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

namespace _6._3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int count;
        private List<int> list;
        public MainWindow()
        {
            InitializeComponent();
            list = new List<int>();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (InputChisla.Text.Length != 0)
            {
                list.Add(int.Parse(InputChisla.Text));
                Spisok.Items.Add(InputChisla.Text);
                InputChisla.Clear();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int a = 0;
            int b = 0;
            foreach (int s in list)
            {
                if (s % 4 ==0)
                {
                    a += s;
                    b++;
                }
            }
            count = a / b;
            Result.Text = Convert.ToString(count);
        }
    }
}
