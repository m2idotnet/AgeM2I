using System;
using System.Collections.Generic;
using System.Text;

namespace AgeM2I.Classes
{
    public class Fabrique
    {
        public Village FabriqueVillage()
        {
            Village v = new Village();
            return v;
        }
        public Villageois FabriqueVillageois(string type)
        {
            Villageois v = null;
            if(type == "roturier")
            {
                v = new Roturier();
            }
            else if(type == "paysan")
            {
                v = new Paysan();
            }
            return v;
        }

    }
}
