using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MowGame.Core
{
    /// <summary>
    /// Ensemble de cartes visibles constituant la zone de jeu principale.
    /// Ne peut contenir qu'une seule carte de chaque numéro.
    /// Les cartes retardataires peuvent remplacer n'importe quel numéro de 1 à 15 et respectent la même règle.
    /// Parcontre les cartes acrobates ne peuvent être placées que si leur numéro respectif est déjà présent (7 ou 9).
    ///
    /// </summary>
    public class Troupeau : EnsembleCarte
    {
        /// <summary>
        /// Renvoie vrai si toutes les places sont occupées.
        /// Dans la List, les positions de 0 à 16 correspondent aux numéros identiques.
        /// Les positions 17 et 18 correspondent aux cartes acrobates 7 et 9
        /// Est utilisé dans les statistiques de jeu comme achievement exceptionnel.
        /// TODO: A voir -> compter ou non avec les cartes "acrobates".
        /// </summary>
        public virtual bool Est_complet(List<Vache> list)
        {
            if(list.Count == 17)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Renseigne l'appeleur de la méthode sur la disponibilité de l'emplacement pour la carte qu'on essaie de jouer.
        /// S'il s'agit d'une carte acrobate, renvoie vrai si le numéro est Présent dans le troupeau et faux à l'inverse.
        /// Sinon, renvoie vrai si le numéro est Absent, et faux à l'inverse.
        /// </summary>
        public virtual bool Est_Libre(int Valeur)
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
            List<Vache> troupeau = new List<Vache>();
        }

    }
}