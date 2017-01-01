using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MowGame.Core
{
    public class Humain : Joueur
    {
        /// <summary>
        /// Nom du joueur, saisit manuellement au début de la partie dans un "formulaire d'inscription"
        /// </summary>
        public override string Pseudo
        {
            get { return Pseudo; }
            set { Pseudo = value; } //TODO: Faire un Bind entre Pseudo.value et le champ que l'on utilisera dans le formulaire d'inscription
        }

    }
}