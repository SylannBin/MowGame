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
        /// Creation des :
        /// - 15 cartes vaches (numérotées de 1 à 15), avec 0 mouche
        /// - 13 cartes vaches (numérotées de 2 à 14), avec 1 mouche
        /// - 11 cartes vaches (numérotées de 3 à 13), avec 2 mouches
        /// - 3 cartes vaches (numérotées 7, 8, 9), avec 3 mouches
        /// Creation des 6 cartes vaches spéciales, avec 5 mouches :
        /// - 2 serre-files
        /// - 2 vaches acrobates
        /// - 2 vaches retardataires
        /// Return la liste des 46 Vaches
        /// </summary>
        public List<Vache> createDeck()
        {
            List<Vache> deck = new List<Vache>();

            for (int i = 1; i < 16; i++)
            {
                deck.Add(new Vache()
                {
                    Valeur = i,
                    nb_mouches = 0,
                    Categorie = ECategorieVache.standard,
                    ImagePath = "standard_" + i.ToString() + "_0.jpeg"
                });
            }

            for (int i = 2; i < 15; i++)
            {
                deck.Add(new Vache()
                {
                    Valeur = i,
                    nb_mouches = 1,
                    Categorie = ECategorieVache.standard,
                    ImagePath = "standard_" + i.ToString() + "_1.jpeg"
                });
            }

            for (int i = 3; i < 14; i++)
            {
                deck.Add(new Vache()
                {
                    Valeur = i,
                    nb_mouches = 2,
                    Categorie = ECategorieVache.standard,
                    ImagePath = "standard_" + i.ToString() + "_2.jpeg"
                });
            }

            for (int i = 7; i < 10; i++)
            {
                deck.Add(new Vache()
                {
                    Valeur = i,
                    nb_mouches = 3,
                    Categorie = ECategorieVache.standard,
                    ImagePath = "standard_" + i.ToString() + "_3.jpeg"
                });
            }

            deck.Add(new Vache() { Valeur = 0, nb_mouches = 5, Categorie = ECategorieVache.serreFile, ImagePath = "serreFile_0_5.jpeg" });
            deck.Add(new Vache() { Valeur = 16, nb_mouches = 5, Categorie = ECategorieVache.serreFile, ImagePath = "serreFile_16_5.jpeg" });

            deck.Add(new Vache() { Valeur = 7, nb_mouches = 5, Categorie = ECategorieVache.acrobate, ImagePath = "acrobate_7_5.jpeg" });
            deck.Add(new Vache() { Valeur = 9, nb_mouches = 5, Categorie = ECategorieVache.acrobate, ImagePath = "acrobate_9_5.jpeg" });

            deck.Add(new Vache() { Valeur = 0, nb_mouches = 5, Categorie = ECategorieVache.retardataire, ImagePath = "retardataire.jpeg" });
            deck.Add(new Vache() { Valeur = 0, nb_mouches = 5, Categorie = ECategorieVache.retardataire, ImagePath = "retardaataire.jpeg" });

            return deck;
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