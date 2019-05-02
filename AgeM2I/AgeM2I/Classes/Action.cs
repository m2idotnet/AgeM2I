using System;
using System.Collections.Generic;
using System.Text;

namespace AgeM2I.Classes
{
    public abstract class Action
    {
        private string nom;
        private decimal cout;

        public string Nom { get => nom; set => nom = value; }
        public decimal Cout { get => cout; set => cout = value; }

        public virtual bool action(Royaume r, Fabrique f)
        {
            return false;
        }
    }
}
