using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace MowGame.Core
{
    /// <summary>
    /// Classe pour un objet correspondant à un ensemble de carte.
    /// La main est un ensemble de carte.
    /// Il existe des classes Troupeau, Pioche et Etable qui héritent de EnsembleCarte.
    /// </summary>
    public class EnsembleCarte
    {
	    /// <summary>
	    /// Liste des cartes de EnsemleCarte.
	    /// </summary>
	    public virtual List<Vache> Cartes { get; set; }

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
        public List<Vache> creerdeck()
        {
            List<Vache> deck = new List<Vache>();

            for (int i = 1; i < 16; i++)
            {
                deck.Add(new Vache() {
                    Valeur = i,
                    nb_mouches = 0,
                    Categorie = ECategorieVache.Standard,
                    ImagePath = "fourmi.jpeg"
                });
            }

            for (int i = 2; i < 15; i++)
            {
                deck.Add(new Vache() {
                    Valeur = i,
                    nb_mouches = 1,
                    Categorie = ECategorieVache.Standard,
                    ImagePath = "fourmi.jpeg"
                });
            }

            for (int i = 3; i < 14; i++)
            {
                deck.Add(new Vache() {
                    Valeur = i,
                    nb_mouches = 2,
                    Categorie = ECategorieVache.Standard,
                    ImagePath = "fourmi.jpeg"
                });
            }

            for (int i = 7; i < 10; i++)
            {
                deck.Add(new Vache() {
                    Valeur = i,
                    nb_mouches = 3,
                    Categorie = ECategorieVache.Standard,
                    ImagePath = "fourmi.jpeg"
                });
            }

            deck.Add(new Vache() { Valeur = 0, nb_mouches = 5, Categorie = ECategorieVache.SerreFile, ImagePath = "fourmi.jpeg" });
            deck.Add(new Vache() { Valeur = 16, nb_mouches = 5, Categorie = ECategorieVache.SerreFile, ImagePath = "fourmi.jpeg" });

            deck.Add(new Vache() { Valeur = 7, nb_mouches = 5, Categorie = ECategorieVache.Acrobate, ImagePath = "fourmi.jpeg" });
            deck.Add(new Vache() { Valeur = 9, nb_mouches = 5, Categorie = ECategorieVache.Acrobate, ImagePath = "fourmi.jpeg" });

            deck.Add(new Vache() { Valeur = 0, nb_mouches = 5, Categorie = ECategorieVache.Retardataire, ImagePath = "fourmi.jpeg" });
            deck.Add(new Vache() { Valeur = 0, nb_mouches = 5, Categorie = ECategorieVache.Retardataire, ImagePath = "fourmi.jpeg" });

            return deck;
        }

        /// <summary>
        /// Methode Shuffle : mélange une liste aléatoirement
        /// </summary>
        /// <typeparam name="T">Objet de type "Vache" avec trois propriétés ( Valeur - nb_mouches - Categorie )</typeparam>
        /// <param name="list">Liste (deck, pioche, paquet ...) à mélanger</param>
        public void Shuffle<T>(IList<T> list)
        {
            RNGCryptoServiceProvider provider = new RNGCryptoServiceProvider();
            int n = list.Count;
            while (n > 1)
            {
                byte[] box = new byte[1];
                do provider.GetBytes(box);
                while (!(box[0] < n * (Byte.MaxValue / n)));
                int k = (box[0] % n);
                n--;
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }

        /// <summary>
        /// Create a random number in a range
        /// </summary>
        /// <param name="min">Minimal value</param>
        /// <param name="max">Maximal value</param>
        /// <returns></returns>
        public RNGCryptoServiceProvider _RNG = new RNGCryptoServiceProvider();

        /// <summary>
        /// TODO
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public int GetRnd(int min, int max)
        {
            byte[] rndBytes = new byte[4];
            _RNG.GetBytes(rndBytes);
            int rand = BitConverter.ToInt32(rndBytes, 0);
            const Decimal OldRange = (Decimal)int.MaxValue - (Decimal)int.MinValue;
            Decimal NewRange = max - min;
            Decimal NewValue = ((Decimal)rand - (Decimal)int.MinValue) / OldRange * NewRange + (Decimal)min;
            return (int)NewValue;
        }


        /// <summary>
        /// Ajoute la carte en parametre, à l'ensemble de carte.
        /// Intervient dans tous les déplacements de carte (avec la méthode RetirerCarte).
        /// Peut être appelé en boucle pour remplir un ensemble de carte (ex: ajout du troupeau dans l'etable)
        /// Ou encore en début de manche, lors de la génération de la pioche.
        /// </summary>
        public virtual void AjouterCarte(Vache carte)
	    {
		    throw new System.NotImplementedException();
	    }

	    /// <summary>
	    /// Retire la carte en parametre de l'ensemble de carte.
	    /// Intervient dans tous les déplacements de carte (avec la méthode AjouterCarte).
	    /// Peut être appelé en boucle pour vider un ensemble de carte (ex: vider le troupeau)
	    /// Ne détruit pas l'objet Vache dans la mémoire, seulement la référence.
	    /// </summary>
	    public virtual void RetirerCarte(Vache carte)
	    {
		    throw new System.NotImplementedException();
	    }
    }
}

