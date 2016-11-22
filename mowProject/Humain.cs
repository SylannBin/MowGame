using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Humain : Joueur
{
	/// <summary>
	/// Le joueur humain voit les choix d'action dans un menu en bas de l'écran.
	/// Les actions indisponibles au moment du jeu sont grisées.
	/// Lorsqu'une seule action est possible, le joueur n'a pas le choix, l'action s'effectue automatiquement.
    /// Toute action effectuée est ajoutée au log de la partie, et un message flottant apparaît sur la table de jeu.
	/// </summary>
	public virtual EAction attendreChoix()
	{
		throw new System.NotImplementedException();
	}

}
