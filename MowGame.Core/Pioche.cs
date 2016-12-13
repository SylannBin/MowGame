using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MowGame.Core
{
    /// <summary>
    /// Principal ensemble des cartes, généré et mélangé au début de chaque manche.
    /// Peut être défaussée d'une carte  à la fois.
    /// Les condtions de fin de manche nécessitent que la pioche soit vide.
    /// Lorsque la manche est terminée, toutes les cartes sont supp
    /// </summary>
    public class Pioche : EnsembleCarte
    {
        /// <summary>
        /// Indique que la pioche est vide.
        /// Condition de fin de manche, lorsqu'un joueur ne peut pas jouer de carte.
        /// Indique également que les joueurs ne peuvent plus piocher.
        /// </summary>
        public virtual bool Est_vide(List<Vache> list)
        {
            if(list.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}