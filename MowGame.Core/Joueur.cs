using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MowGame.Core
{
    public abstract class Joueur
    {
        /// <summary>
        /// Etable du joueur. Contient les cartes ramassées au cours d'un tour.
        /// Doit être remis à zéro à chaque fin de tour après avoir :
        /// 1 - ajouté les cartes de la main (MainDuJoueur.Retirer -> Etable.Ajouter) (pour chaque carte de MainDuJoueur)
        /// 2 - compté le nombre de mouche (Etable.CompterMouches)
        /// </summary>
        public EnsembleCarte Etable { get; set; }


        /// <summary>
        /// Main du joueur. Contient jusqu'à 5 cartes (Vache)
        /// Doit être vidée puis ajoutée à l'étable à chaque fin de tour
        /// </summary>
        public EnsembleCarte MainDuJoueur { get; set; }


        /// <summary>
        /// Score total du joueur au cours d'une partie (init à 0). Ajoute le total nb_mouche à chaque fin de tour
        /// </summary>
        public int score { get; set; }


        /// <summary>
        /// Identifiant unique du joueur (numéro de 0 à 4)
        /// </summary>
        public int id { get; set; }


        /// <summary>
        /// Nom du joueur, entré au début de la partie pour un humain et choisit alétoirement dans une liste pour un joueur IA
        /// </summary>
        public virtual string Pseudo { get; set; }


        /// <summary>
        /// Un joueur peut utiliser cette compétence s'il vient de placer une carte spéciale.
        /// Change l'ordre selon lequel les joueurs enchainent le jeu.
        /// Horaire: respecte le sens des aiguilles d'une montre.
        /// Anti-horaire: dans le sens inverse.
        /// Renvoie le sens après changement effectif.
        /// </summary>
        public virtual ESensDeJeu changerSens()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Récupère une carte depuis la pioche.
        /// La carte est supprimée de la pioche et ajoutée à la main du joueur.
        /// Renvoie la carte piochée.
        /// </summary>
        public virtual Vache piocher()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Dépose une carte depuis la main du joueur dans le troupeau.
        /// Appelle la méthode de sélection de la position dans le troupeau.
        /// Si celle-ci ne renvoie pas false:
        /// La carte jouée est supprimée de la main du joueur
        /// Puis elle est ajoutée au troupeau à la position renvoyée par la méthode de placement de carte.
        /// Renvoie la carte posée.
        /// </summary>
        public virtual Vache poser()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Ramasser les cartes du troupeau.
        /// Supprime les cartes du troupeau et les ajoute à l'étable du joueur.
        /// Appelle la fonction de comptage du nombre de mouches.
        /// Renvoie le nombre de mouches récupérées lors du ramassage.
        /// </summary>
        public virtual int ramasser()
        {
            throw new System.NotImplementedException();
        }

    }
}