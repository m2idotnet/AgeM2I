using System;
using System.Collections.Generic;
using System.Text;

namespace AgeM2I.Classes
{
    public abstract class Villageois
    {
        private int vie;
        protected decimal pdv;
        protected int capaciteMax;

        public int Vie { get => vie; set => vie = value; }
        public decimal Pdv { get => pdv; set => pdv = value; }

        public Villageois()
        {
            vie = 0;
        }

        public virtual void Gain()
        {
            
        }
    }
}
