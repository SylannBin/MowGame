using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MowProject.core
{
    /// <summary>
    /// Chaque état du déroulement du jeu a sa propre manière de finir.
    /// </summary>
    public interface IGame
    {
        void est_finie();

    }
}