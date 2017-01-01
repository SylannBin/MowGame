using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MowGame.Core
{
    public class AI : Joueur
    {
        // Liste des noms des joueurs IA
        private string[] bots = { "Jeremy", "Sarah", "Jack", "George", "Marie", "Hasan", "Sung Li", "Nikolaï", "R209" };
        // Générateur de nombre aléatoire
        private static Random random = new Random();

        public override string Pseudo
        {
            get { return Pseudo; }
            set { Pseudo = bots[random.Next(bots.Length)]; } // Prend au hasard dans bots[]
        }
    }
}
