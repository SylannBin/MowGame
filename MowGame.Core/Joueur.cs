using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MowGame.Core
{
    public abstract class Joueur
    {
        /// <summary>
        /// Etable du joueur
        /// Contient toutes les cartes ramassées par le joueur
        /// Le nombre de mouches contenue indique les points du joueur
        /// </summary>
        public virtual EnsembleCarte Etable
        {
            get;
            set;
        }

        /// <summary>
        /// Main du joueur, liste de cartes (type Vache)
        /// Peut contenir jusqu'à 5 cartes
        /// </summary>
        public virtual EnsembleCarte Main
        {
            get;
            set;
        }

        /// <summary>
        /// Score total du joueur au cours d'une partie.
        /// Initialisé à 0.
        /// On y ajoute le nombre total de mouche dans l'étable à chaque fin de manche.
        /// </summary>
        public virtual int score
        {
            get;
            set;
        }

        /// <summary>
        /// Identifiant unique du joueur
        /// numéro de 0 à 4
        /// détermine la position sur le plan du jeu
        /// </summary>
        public virtual int id
        {
            get;
            set;
        }

        /// <summary>
        /// Nom du joueur, entré au début de la partie
        /// Généré alétoirement pour un joueur IA
        /// </summary>
        public virtual string Pseudo
        {
            get;
            set;
        }

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