using System;
using System.Collections.Generic;
using System.Text;

namespace AgeM2I.Classes
{
    public class Villageois : IVillageois
    {
        private int vie;
        protected decimal pdv;
        protected int capaciteMax;
        private string nom;

        public int Vie { get => vie; set => vie = value; }
        public decimal Pdv { get => pdv; set => pdv = value; }
        public string Nom { get => nom; set => nom = value; }

        public Villageois()
        {
            vie = 0;
        }

        public virtual void Gain()
        {
            
        }
    }
}
