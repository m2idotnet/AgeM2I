using System;
using System.Collections.Generic;
using System.Text;

namespace AgeM2I.Classes
{
    public class Paysan : Roturier
    {
        
        public Paysan()
        {
            capaciteMax = 400;
            Nom = "P";
        }

        public override void Gain()
        {
            pdv += 20;
        }
    }
}
