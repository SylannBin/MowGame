using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MowGame.Core
{
    /// <summary>
    /// Le jeu se termine lorsqu'un joueur atteint les 100 points.
    /// </summary>
    public class Partie : Statistique, IGame
    {
        // Conteneur pour les joueurs de la partie
        public List<Joueur> joueurs = new List<Joueur>();

        /// <summary>
        /// La partie se termine lorsqu'un joueur atteint les 100 points.
        /// </summary>
        public bool est_finie()
        {
            // Si au moins un joueur a atteint la limite de score, la partie est finie
            foreach (Joueur joueur in joueurs)
            {
                if (joueur.score >= 100)
                    { return true; }
            }
            // Sinon le jeu continue !
            return false;
        }

        /// <summary>
        /// Nombre de joueur dans la partie (défini au départ)
        /// </summary>
        public int nb_joueurs { get; set; } = 0;


        /// <summary>
        /// Nombre de manches terminées à un moment donné (init à 0, ++ à chaque fin de manche)
        /// </summary>
        public int nb_manches { get; set; } = 0;


        /// <summary>
        /// Indique comment déterminer le numéro du joueur suivant
        /// AntiHoraire (0): JoueurEnCours = "joueurs[--joueurEnCours] (ou joueurs.Last() si joueur N°0)
        /// Horaire (1):     JoueurEnCours = "joueurs[++joueurEnCours] (ou joueurs.First() si dernier joueur)
        /// </summary>
        public ESensDeJeu SensDeJeu { get; set; } = ESensDeJeu.Horaire;


        /// <summary>
        /// Indique quel joueur est en train de jouer. Change à chaque fin de tour
        /// </summary>
        public Joueur JoueurEnCours { get; set; }


        /// <summary>
        /// Nombre de joueurs contrôlés par des humains, incrémenté à chaque inscription
        /// </summary>
        public int nb_humains { get; set; } = 0;

        
        /// <summary>
        /// Nombre de joueur contrôlés par les IA. Dépend du nombre de joueur humains inscrit
        /// </summary>
        public int nb_ia
        {
            get { return nb_ia; }
            set { nb_ia = nb_joueurs - nb_humains; }
        }
    }
}
