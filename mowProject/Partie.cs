using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/// <summary>
/// Le jeu se termine lorsqu'un joueur atteint les 100 points.
/// Il peut contenir un nombre de manches limité mais indéterminé.
/// On peut traquer les statistiques de l'ensemble d'une partie.
/// </summary>
public class Partie : Statistique, IGame
{
	/// <summary>
	/// Nombre de joueur dans la partie.
	/// Choisit au début de la partie.
	/// Affecte l'affichage de la table de jeu (sa disposition).
	/// </summary>
	public virtual object nb_joueurs
	{
		get;
		set;
	}

	/// <summary>
	/// Indique le nombre de manches terminées à un moment de la partie.
	/// Initialisé à 0.
	/// Incrémenté de 1 à chaque fin de manche.
	/// Bonus: Peut servir de motif de fin de partie.
	/// </summary>
	public virtual object nb_manches
	{
		get;
		set;
	}

	/// <summary>
	/// Indique le sens dans lequel la partie se déroule, donc le numéro du joueur suivant.
	/// Par défaut, le sens est horaire, autrement dit, on ajoute 1 au numéro de joueur actuel.
	/// On passe au joueur 0 si le joueur en cours est "nb_joueurs-1".
	/// Si le sens est antihoraire, on soustrait 1 au numéro du joueur actuel.
	/// On passe au joueur "nb_joueurs-1" si le joueur en cours est 0.
	/// </summary>
	public virtual object SensDeJeu
	{
		get;
		set;
	}

    /// <summary>
    /// Joueur qui est en train de jouer.
    /// Lorsqu'un joueur a fini son tour, on détermine le joueur suivant à partir de l'id du joueur courant
    /// Et en tenant compte du sens de jeu.
    /// </summary>
	public virtual Joueur JoueurEnCours
	{
		get;
		set;
	}

	/// <summary>
	/// Nombre de joueurs contrôlés par des humains.
	/// (nb_joueurs - nb_humains) indique le nombre d'IA.
	/// Choisit au début de la partie.
	/// </summary>
	public virtual object nb_humains
	{
		get;
		set;
	}

	/// <summary>
	/// La partie se termine lorsqu'un joueur atteint les 100 points.
	/// </summary>
	public virtual void est_finie()
	{
		throw new System.NotImplementedException();
	}

}
