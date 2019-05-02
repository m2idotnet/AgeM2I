﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AgeM2I.Classes
{
    public class Roturier : Villageois
    {
        public Roturier()
        {
            capaciteMax = 1000;
            pdv = 50;
        }

        public override void Gain()
        {
            pdv += pdv * 1.5M;
        }
    }
}
