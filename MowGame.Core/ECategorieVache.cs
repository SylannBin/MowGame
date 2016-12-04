using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MowProject.core
{
    /// <summary>
    /// Enumération des types spéciaux de vache.
    /// Permet de tester si une carte a une spécialité précise ou n'importe laquelle.
    /// Facilite la lecture du code
    /// </summary>
    public enum ECategorieVache : int
    {
        Acrobate = 2,
        Retardataire = 3,
        SerreFile = 1,
        Standard = 0,
    }
}