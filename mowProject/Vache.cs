using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Vache
{
	/// <summary>
	/// Indique le numéro de la carte, c'est à dire son identité principale.
	/// </summary>
	public virtual int Numero
	{
		get;
		set;
	}

	/// <summary>
	/// Indique le nombre de mouches présente sur la carte.
	/// </summary>
	public virtual int nb_mouches
	{
		get;
		set;
	}

	/// <summary>
	/// Indique la catégorie de vache à laquelle correspond la carte
	/// </summary>
	public virtual ECategorieVache Categorie
	{
		get;
		set;
	}

}
