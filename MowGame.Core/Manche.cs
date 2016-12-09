using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MowGame.Core
{
    /// <summary>
    /// Une manche se termine lorsque la pioche et le troupeau sont vides.
    /// Le nombre de tour est illimité.
    /// Chaque fois qu'une manche commence, on génère une pioche à partir du Deck de jeu.
    /// Puis on distribue 5 cartes depuis la pioche vers la main de chacun des joueurs.
    /// Les statistique de la manche sont conservées.
    /// </summary>
    public class Manche : Statistique, IGame
    {
        /// <summary>
        /// La manche se termine lorsque la pioche et le troupeau sont vides.
        /// Cas possibles (la pioche étant vide):
        /// Un joueur ne peut pas jouer une carte, et ramasse obligatoirement le troupeau.
        /// Ou alors un joueur décide de ramasser le troupeau même s'il pouvait jouer.
        /// Les joueurs peuvent continuer jouer sans piocher, mais ils devraient être incapable de joueur assez rapidement.
        ///
        /// </summary>
        public virtual void est_finie()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Constitue la pioche à partir de la liste des cartes du jeu.
        /// Les cartes sont séléctionnées aléatoirement parmi les cartes non encore utilisées et sont ajoutées à la pioche.
        /// Il n'y a plus d'aléatoire une fois la pioche constituée car les cartes ont été ajoutées dans un ordre définitif.
        /// </summary>
        public virtual void GenererPioche()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Effectue 5 fois, pour chaque joueur da la partie:
        /// Enlève la dernière carte de la pioche et l'ajoute à la main d'un joueur.
        /// </summary>
        public virtual void Distribuer()
        {
            throw new System.NotImplementedException();
        }

    }
}