using System;
using System.Collections.Generic;
using System.Text;

namespace AgeM2I.Classes
{
    public class Roturier : Villageois
    {
        
        public Roturier()
        {
            capaciteMax = 1000;
            Pdv = 50;
            Nom = "R";
        }

        public override void Gain()
        {
            Pdv += Pdv * 1.5M;
        }
    }
}
