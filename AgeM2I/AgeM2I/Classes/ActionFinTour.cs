using System;
using System.Collections.Generic;
using System.Text;

namespace AgeM2I.Classes
{
    class ActionFinTour : Action
    {
        public ActionFinTour()
        {
            Cout = 0;
            Nom = "Fin tour";
        }
        public override bool action(Royaume r, Fabrique f)
        {
            r.Age++;
            r.Produire();
            r.Vieillir();
            r.PossibleImpot = true;
            return true;
        }
    }
}
