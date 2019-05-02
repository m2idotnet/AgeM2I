using System;
using System.Collections.Generic;
using System.Text;

namespace AgeM2I.Classes
{
    class AchatPaysan : Action
    {
        public AchatPaysan()
        {
            Nom = "Achat paysan";
            Cout = 50;
        }

        public override bool action(Royaume r, Fabrique f)
        {
            bool res = false;
            if(r.Caisse >= Cout)
            {
                Villageois v = f.FabriqueVillageois("paysan");
                if (v != null)
                {
                    r.AjouterHabitant(v);
                    r.Caisse -= Cout;
                    res = true;
                }
            }
            return res;
        }
    }
}
