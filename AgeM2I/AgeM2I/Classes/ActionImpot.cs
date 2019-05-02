using System;
using System.Collections.Generic;
using System.Text;

namespace AgeM2I.Classes
{
    public class ActionImpot : Action
    {
        public ActionImpot()
        {
            Nom = "Action Impot";
            Cout = 100;
        }
        public override bool action(Royaume r, Fabrique f)
        {
            bool res = false;
            if(r.Caisse >= Cout)
            {
                r.Impot();
                res = true;
            }
            return res;
        }

    }
}
