using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MowGame.Core
{
    public class Statistique
    {
        public virtual object max_cartesRamassees
        {
            get;
            set;
        }

        public virtual object max_cartesTroupeau
        {
            get;
            set;
        }

        public virtual object max_mouchesRamassees
        {
            get;
            set;
        }

        public virtual object min_cartesRamassees
        {
            get;
            set;
        }

        public virtual object min_mouchesRamassees
        {
            get;
            set;
        }

        public virtual object nb_cartesJouees
        {
            get;
            set;
        }

        public virtual object nb_cartesPiochees
        {
            get;
            set;
        }

        public virtual object nb_cartesRamassees
        {
            get;
            set;
        }

        public virtual object nb_changerSens
        {
            get;
            set;
        }

        public virtual object nb_troupeauComplet
        {
            get;
            set;
        }

    }
}