using System.Collections.Generic;

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
        /// Calcul le nombre total de mouches en ajoutant les mouches de chaque carte présente dans 'list'
        /// </summary>
        public int CompterMouches(List<Vache> list)
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