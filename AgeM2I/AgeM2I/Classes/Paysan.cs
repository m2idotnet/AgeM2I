using System;
using System.Collections.Generic;
using System.Text;

namespace AgeM2I.Classes
{
    class Paysan : Villageois
    {
        public Paysan()
        {
            capaciteMax = 400;
        }

        public override void Gain()
        {
            pdv += 20;
        }
    }
}
