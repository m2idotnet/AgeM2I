using System;
using System.Collections.Generic;
using System.Text;

namespace AgeM2I.Classes
{
    public class Royaume
    {
        private List<Village> villages;
        private decimal caisse;
        private int age;
        private decimal production;
        private bool possibleImpot;

        public List<Village> Villages { get => villages; set => villages = value; }
        public decimal Caisse { get => caisse; set => caisse = value; }
        public int Age { get => age; set => age = value; }
        public decimal Production { get => production; set => production = value; }
        public bool PossibleImpot { get => possibleImpot; set => possibleImpot = value; }

        public Royaume()
        {
            Villages = new List<Village>();
            Age = 0;
            Caisse = 100;
            PossibleImpot = true;
        }

        public void AjouterHabitant(Villageois v)
        {
            Random r = new Random();
            int index = r.Next(0, Villages.Count - 1);
            Villages[index].Habitants.Add(v);
        }

        public void Impot()
        {
            decimal tmp = 0;
            foreach(Village v in Villages)
            {
                decimal impot = v.Impot();
                Caisse += impot;
                tmp = impot;
            }
            Production = Production - tmp;
            
        }

        public void Vieillir()
        {
            foreach (Village v in Villages)
            {
                v.Vieillir();
            }
        }

        public void Produire()
        {
            Production = 0;
            foreach(Village v in Villages)
            {
                Production += v.Production();
            }
        }

        public override string ToString()
        {
            string res = "";
            res += "Age royaume : " + Age;
            res += "\nProductivité du royaume : " + Production;
            res += "\nNombre de village : " + Villages.Count;
            res += "\nCaisse : " + Caisse;
            return res;
        }
    }
}
