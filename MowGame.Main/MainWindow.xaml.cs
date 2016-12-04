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
using System.IO.Packaging;

namespace MowGame.Main
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


            // Déclaration path Cartes spéciales
            var srcSensDuJeu = new Uri(@"/Images/sensDuJeu.jpg", UriKind.Relative);

            var srcRetardataire = new Uri(@"/Images/retardataire.jpg", UriKind.Relative);

            var srcSerreFile0 = new Uri(@"/Images/serreFile0.jpg",UriKind.Relative);
            var srcSerreFile16 = new Uri(@"/Images/serreFile16.jpg", UriKind.Relative);
            var srcAcrobate7 = new Uri(@"/Images/acrobate7.jpg", UriKind.Relative);
            var srcAcrobate9 = new Uri(@"/Images/acrobate9.jpg", UriKind.Relative);


            // Initialisation
            Place0.Source = new BitmapImage(srcSerreFile0);
            Place16.Source = new BitmapImage(srcSerreFile16);

            Place7B.Source = new BitmapImage(srcAcrobate7);
            Place9B.Source = new BitmapImage(srcAcrobate9);

            SensDuJeu.Source = new BitmapImage(srcSensDuJeu);


            



            var uriSource = new Uri(@"C:\Users\Admin\Desktop\EPSI\C#\mow\Vaches\Vache_4.png");
            JoueurCourantCarte1.Source = new BitmapImage(uriSource);

            var uriSource2 = new Uri(@"C:\Users\Admin\Desktop\EPSI\C#\mow\Vaches\Vache_9.png");
            JoueurCourantCarte2.Source = new BitmapImage(uriSource2);

            var uriSource3 = new Uri(@"C:\Users\Admin\Desktop\EPSI\C#\mow\Vaches\Vache_3.png");
            JoueurCourantCarte3.Source = new BitmapImage(uriSource3);

            var uriSource4 = new Uri(@"C:\Users\Admin\Desktop\EPSI\C#\mow\Vaches\Vache_13.png");
            JoueurCourantCarte4.Source = new BitmapImage(uriSource4);

            var uriSource5 = new Uri(@"C:\Users\Admin\Desktop\EPSI\C#\mow\Vaches\Vache_5.png");
            JoueurCourantCarte5.Source = new BitmapImage(uriSource5);
        }

        private void BtnRamasserClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Je ramasse le troupeau !");
        }

        private void BtnJouerCarteClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Je Joue une carte");

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


        private void BtnPiocherCarteClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Je Pioche");
        }
    } // Fin class MainWindow : Window
} // Fin namespace mowProject
