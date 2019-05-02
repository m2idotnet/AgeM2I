using System;
using System.Collections.Generic;
using System.Text;

namespace AgeM2I.Classes
{
    public class AchatVillage : Action
    {
        public AchatVillage()
        {
            Cout = 500;
            Nom = "Achat village";
        }

        public override bool action(Royaume r, Fabrique f)
        {
            bool res = false;
            if(r.Caisse >= Cout)
            {
                Village v = f.FabriqueVillage();
                v.Habitants.Add(f.FabriqueVillageois("roturier"));
                r.Villages.Add(v);
                res = true;
                r.Caisse -= Cout;
            }
            return res;
        }
    }
}
