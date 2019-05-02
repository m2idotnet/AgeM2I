using System;
using System.Collections.Generic;
using System.Text;

namespace AgeM2I.Classes
{
    public class FabriqueAction
    {
        private List<Action> listeAction;

        public List<Action> ListeAction { get => listeAction; set => listeAction = value; }

        public FabriqueAction()
        {
            ListeAction = new List<Action>();
            ListeAction.Add(new AchatPaysan());
            ListeAction.Add(new AchatVillage());
            ListeAction.Add(new ActionFinTour());
            ListeAction.Add(new ActionImpot());
        }

        public bool ActionCorrect(string nom)
        {
            bool res = false;
            foreach(Action a in ListeAction)
            {
                if(a.Nom == nom)
                {
                    res = true;
                    break;
                }
            }
            return res;
        }

        public bool Creer(Royaume r, Fabrique f, string nom)
        {
            bool res = false;
            foreach (Action a in ListeAction)
            {
                if (a.Nom == nom)
                {
                    res = a.action(r,f);
                    break;
                }
            }
            return res;
        }

    }
}
