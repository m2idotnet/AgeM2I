using System;
using System.Collections.Generic;
using System.Text;

namespace AgeM2I.Classes
{
    public class Royaume
    {
        private List<Village> villages;
        private decimal caisse;

        public List<Village> Villages { get => villages; set => villages = value; }
        public decimal Caisse { get => caisse; set => caisse = value; }

        public Royaume()
        {
            Villages = new List<Village>();
        }

        public void AjouterHabitant(Villageois v)
        {
            Random r = new Random();
            int index = r.Next(0, Villages.Count - 1);
            Villages[index].Habitants.Add(v);
        }
    }
}
