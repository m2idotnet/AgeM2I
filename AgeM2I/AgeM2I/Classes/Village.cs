using System;
using System.Collections.Generic;
using System.Text;

namespace AgeM2I.Classes
{
    public class Village
    {
        private List<Villageois> habitants;


        public List<Villageois> Habitants { get => habitants; set => habitants = value; }

        public Village()
        {
            Habitants = new List<Villageois>();
        }

        public void Vieillir()
        {
            foreach(Villageois v in Habitants)
            {
                v.Vie++;
            }
        }

        public decimal Production()
        {
            decimal production = 0;
            foreach(Villageois v in Habitants)
            {
                v.Gain();
                production += v.Pdv;
            }
            return production;
        }

        public decimal Impot()
        {
            decimal impot = 0;
            foreach (Villageois v in Habitants)
            {
                if(v.GetType() == typeof(Paysan))
                {
                    impot += v.Pdv;
                    v.Pdv = 0;
                }
                else if(v.GetType() == typeof(Roturier))
                {
                    impot += v.Pdv * 0.5M;
                    v.Pdv = v.Pdv / 2;
                }
            }
            return impot;
        }

        public void Mourir(Villageois v)
        {

        }
    }
}
