using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MowGame.Core
{
    /// <summary>
    /// Contient une méthode décrivant la manière de se terminer d'une partie ou d'une manche
    /// </summary>
    public interface IGame
    {
        void est_finie();
    }
}