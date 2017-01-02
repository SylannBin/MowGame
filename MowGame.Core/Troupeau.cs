using System;
using System.Collections.ObjectModel;

namespace MowGame.Core
{
    /// <summary>
    /// Ensemble de cartes visibles constituant la zone de jeu principale.
    /// Ne peut contenir qu'une seule carte de chaque numéro.
    /// Les cartes retardataires peuvent remplacer n'importe quel numéro de 1 à 15 et respectent la même règle.
    /// Les cartes acrobates ne peuvent être placées que si la carte standard correspondante (7 ou 9) est présente.
    /// Dans ce cas, on met la carte acrobate à la place de la standard
    /// </summary>
    public class Troupeau : EnsembleCarte
    {
        /* Propriétés */

        public ObservableCollection<Vache> troupeau;
        
        /* Méthodes */

        /// <summary>
        /// Renvoie vrai si toutes les places sont occupées (de 0 à 16).
        /// </summary>
        public bool Est_complet()
        {
            return troupeau.Count == 17;
        }

        /// <summary>
        /// Renvoie faux si une carte du troupeau a la valeur passée en paramêtre
        /// A l'inverse, si aucune carte ne correspond, renvoie true.
        /// La valeur n'a rien à voir avec l'emplacement dans le tableau !
        /// </summary>
        public bool Est_Libre(int Valeur)
        {
            foreach(Vache carte in Cartes)
            {
                if(carte.Valeur == Valeur)
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Constructor
        /// </summary>
        Troupeau()
        {
            ObservableCollection<Vache> troupeau = new ObservableCollection<Vache>();
            
        }

    }
}