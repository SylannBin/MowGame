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
        /// TODO
        /// </summary>
        /// <param name="min inclue"></param>
        /// <param name="max exclue"></param>
        /// <returns></returns>
        public RNGCryptoServiceProvider _RNG = new RNGCryptoServiceProvider();
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

