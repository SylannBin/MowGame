using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/// <summary>
/// Liste des actions possibles d'un joueur dans un tour.
/// Toutes ne sont pas toujours disponibles.
/// TODO: Revoir et Décider les actions possibles.
/// </summary>
public enum EAction : int
{
	ChangerLeSensDeJeu = 3,
	RamasserLeTroupeau = 0,
	PiocherUneCarte = 2,
	PoserUneCarte = 1,
}
