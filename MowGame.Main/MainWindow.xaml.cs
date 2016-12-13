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
        public bool evenement = false; // Booléen qui va instencier si on peut cliqué sur les carte ou non

        public MainWindow()
        {
            InitializeComponent();

            // Déclaration path Cartes spéciales
            var srcBackGr = new Uri(@"/Images/GameBackGround.png", UriKind.Relative);

            var srcSensDuJeu = new Uri(@"/Images/sensDuJeu.jpg", UriKind.Relative);

            var srcRetardataire = new Uri(@"/Images/retardataire.jpg", UriKind.Relative);

            var srcSerreFile0 = new Uri(@"/Images/serreFile0.jpg",UriKind.Relative);
            var srcSerreFile16 = new Uri(@"/Images/serreFile16.jpg", UriKind.Relative);
            var srcAcrobate7 = new Uri(@"/Images/acrobate7.jpg", UriKind.Relative);
            var srcAcrobate9 = new Uri(@"/Images/acrobate9.jpg", UriKind.Relative);


            // Initialisation
            //Game.Background = new BitmapImage(srcBackGr);

            

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

        private void BtnRamasserClick(object sender, RoutedEventArgs e) // Rammase le troupeau et le remet à 0
        {
            Place1.Source = null;
            Place2.Source = null;
            Place3.Source = null;
            Place4.Source = null;
            Place5.Source = null;
            MessageBox.Show("Vous avez rammassé le troupeau !");
        }

        public void BtnJouerCarteClick(object sender, RoutedEventArgs e) // Rends les cartes cliquable et prévient l'utilisateur  
        {
            evenement = true;
            MessageBox.Show("Vous pouvez jouer une carte !");

        }
        /*Image monImage = (Image)sender;
            string chemin = (string)monImage.DataContext;
            MessageBox.Show(chemin);
            */


        public void BtnPoserCarte(object sender, MouseButtonEventArgs e) // Place la carte lorsqu'elle est cliqué
        {
            if (evenement)
            {
                if (Place3.Source == null)
                {
                    var uriSource = new Uri(@"C:\Users\Admin\Desktop\EPSI\C#\mow\Vaches\Vache_9.png");
                    Place3.Source = new BitmapImage(uriSource);
                    Place3.DataContext = @"C:\Users\Admin\Desktop\EPSI\C#\mow\Vaches\Vache_9.png";
                }
                else
                {
                    var uriSource2 = new Uri(@"C:\Users\Admin\Desktop\EPSI\C#\mow\Vaches\Vache_4.png");
                    Place1.Source = new BitmapImage(uriSource2);
                    Place1.DataContext = @"C:\Users\Admin\Desktop\EPSI\C#\mow\Vaches\Vache_9.png";
                }
                evenement = false;
            }

        }


        private void BtnPiocherCarteClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Je Pioche");
        }

    } // Fin class MainWindow : Window
} // Fin namespace mowProject
