using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MowProject.core
{
    public class AI : Joueur
    {
        /// <summary>
        /// Doit déterminer l'action que va choisir l'IA.
        /// TODO: Décider le fonctionnement de cette classe.
        /// Lister les possibilités à chaque tour
        /// Effectuer un choix stratégique, ou déterministe
        /// Ex: Toujours essayer de jouer la carte avec le plus grand nombre de mouche ...
        /// --- Ramasser si nombre carte > 2 et moins de 2 mouches
        /// </summary>
        public virtual EAction deciderAction()
        {
            throw new System.NotImplementedException();
        }

    }
}
