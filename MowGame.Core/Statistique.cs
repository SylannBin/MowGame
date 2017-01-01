using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MowGame.Core
{
    public class Statistique
    {
        public object max_cartesRamassees  { get; set; }
        public object max_cartesTroupeau   { get; set; }
        public object max_mouchesRamassees { get; set; }
        public object min_cartesRamassees  { get; set; }
        public object min_mouchesRamassees { get; set; }
        public object nb_cartesJouees      { get; set; }
        public object nb_cartesPiochees    { get; set; }
        public object nb_cartesRamassees   { get; set; }
        public object nb_changerSens       { get; set; }
        public object nb_troupeauComplet   { get; set; }
    }
}