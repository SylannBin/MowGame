using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MowGame.Core
{
    /// <summary>
    /// Chaque joueur dispose de sa propre étable.
    /// Vide en début de manche, elle peut se remplir de 2 manières.
    /// A chaque fois que le joueur ramasse les cartes du troupeau.
    /// En fin de manche lorsque la main est vidée.
    /// Le nombre de mouches présentes dans l'étable constitue le score du joueur.
    /// </summary>
    public class Etable : EnsembleCarte
    {
        /// <summary>
        /// Calcul le nombre total de mouches présentes dans cette List<vache>.
        /// Effectue la somme de la propriété nb_mouche de chaque Vache présente dans la liste.
        /// </summary>
        public virtual int CompterMouches(List<Vache> list)
        {
            int total = 0;
            foreach (Vache element in list)
            {
                total += element.nb_mouches;
            }
            return total;
        }

    }
}