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
using System.Drawing;

namespace mowProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


            /*
            class toto
            {
                string joueurName = "jean";
                int age = 10;
            }


            DataContext = maClass();
            InitializeComponent();

            // xaml
            <textbox text = { Binding path = JoueurName}
            
            */


            //DataContext = maClass();


            var uriSource = new Uri(@"C:\Users\Admin\Desktop\EPSI\C#\mow\Vaches\Vache_4.png");
            main1.Source = new BitmapImage(uriSource);
            var uriSource2 = new Uri(@"C:\Users\Admin\Desktop\EPSI\C#\mow\Vaches\Vache_9.png");
            main2.Source = new BitmapImage(uriSource2);
            var uriSource3 = new Uri(@"C:\Users\Admin\Desktop\EPSI\C#\mow\Vaches\Vache_3.png");
            main3.Source = new BitmapImage(uriSource3);
            var uriSource4 = new Uri(@"C:\Users\Admin\Desktop\EPSI\C#\mow\Vaches\Vache_13.png");
            main4.Source = new BitmapImage(uriSource4);
            var uriSource5 = new Uri(@"C:\Users\Admin\Desktop\EPSI\C#\mow\Vaches\Vache_5.png");
            main5.Source = new BitmapImage(uriSource5);
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hi team !");
        }

        private void button_Click_1(object sender, RoutedEventArgs e)
        {
            if (Place3.Source == null)
            {
                var uriSource = new Uri(@"C:\Users\Admin\Desktop\EPSI\C#\mow\Vaches\Vache_9.png");
                Place3.Source = new BitmapImage(uriSource);

            }
            else
            {
                var uriSource2 = new Uri(@"C:\Users\Admin\Desktop\EPSI\C#\mow\Vaches\Vache_4.png");
                Place1.Source = new BitmapImage(uriSource2);
            }

        }

    } // Fin class MainWindow : Window
} // Fin namespace mowProject
