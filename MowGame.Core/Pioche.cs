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
        /// Indique que la pioche est vide lorsque la liste ne contient plus une seule vache
        /// </summary>
        public virtual bool Est_vide(List<Vache> list)
        {
            return (list.Count == 0);
        }


        /// <summary>
        /// Retourne la vache qui est à la dernière position de la pioche
        /// Permet de piocher une carte en fournissant le résultat à la méthode RetirerCarte
        /// </summary>
        /// <returns></returns>
        public Vache DessusDePioche()
        {
            return Cartes.Last();
        }


    }
}