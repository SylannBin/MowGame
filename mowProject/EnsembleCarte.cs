using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/// <summary>
/// Classe pour un objet correspondant à un ensemble de carte.
/// La main est un ensemble de carte.
/// Il existe des classes Troupeau, Pioche et Etable qui héritent de EnsembleCarte.
/// </summary>
public class EnsembleCarte
{
	/// <summary>
	/// Collection générique contenant le type Vache.
	/// La contenance maximale est précisée par la propriété max_cartes.
	/// </summary>
	public virtual List<Vache> Cartes
	{
		get;
		set;
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

