using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MowGame.Core
{
    public class Vache
    {
        /// <summary>
        /// Indique le numéro de la carte, c'est à dire son identité principale.
        /// De 0 à 16
        /// </summary>
        public int Valeur { get; set; }

        /// <summary>
        /// Indique le nombre de mouches présente sur la carte.
        /// </summary>
        public int nb_mouches { get; set; }

        /// <summary>
        /// Contient le path complet vers l'image à afficher :
        /// ex : "C:\temp\vache3.jpg"
        /// </summary>
        public string ImagePath { get; set; }

        /// <summary>
        /// Indique la catégorie de vache à laquelle correspond la carte
        /// - standard
        /// - acrobate (7 et 9, elles se mettent par dessus un 7 ou un 9 respectivement), il n'y en a que 2, une de chaque
        /// - retardataire (<> elle se met à la place de n'importe quel valeur entre deux valeurs ex: 2 entre 1 et 3), il n'y en a que 2
        /// - serre-file (0 et 16) il n'y en qu'une de chaque
        /// </summary>
        public ECategorieVache Categorie { get; set; }

    }
}