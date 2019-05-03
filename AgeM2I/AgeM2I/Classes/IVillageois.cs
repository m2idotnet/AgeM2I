using System;
using System.Collections.Generic;
using System.Text;

namespace AgeM2I.Classes
{
    public interface IVillageois
    {
        int Vie { get; set; }
        decimal Pdv { get; set; }
        void Gain();
    }
}
