using Newtonsoft.Json;
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
                    impot += v.Pdv /2;
                    v.Pdv = v.Pdv / 2;
                }
            }
            return impot;
        }

        public void Mourir()
        {
            Random r = new Random();
            int index = r.Next(0, Habitants.Count - 1);
            Habitants.RemoveAt(index);
        }
    }
}
