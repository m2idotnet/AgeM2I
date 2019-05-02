using System;
using System.Collections.Generic;
using System.Text;

namespace AgeM2I.Classes
{
    public class Jeu
    {
        public Royaume r;
        public Fabrique fabrique;
        public FabriqueAction fabriqueAction;

        public void Init()
        {
            r = new Royaume();
            fabrique = new Fabrique();
            fabriqueAction = new FabriqueAction();
            Village v = fabrique.FabriqueVillage();
            v.Habitants.Add(fabrique.FabriqueVillageois("roturier"));
            r.Villages.Add(v);
            int choix;
            do
            {
                Menu();
                choix = Convert.ToInt32(Console.ReadLine());
                switch(choix)
                {
                    case 1:
                        AfficherInfoRoyaume();
                        break;
                    case 2:
                        fabriqueAction.Creer(r, fabrique, "Fin tour");
                        fabriqueAction.Creer(r, fabrique, "Achat paysan");
                        AfficherInfoRoyaume();
                        break;
                    case 3:
                        fabriqueAction.Creer(r, fabrique, "Fin tour");
                        fabriqueAction.Creer(r, fabrique, "Achat village");
                        AfficherInfoRoyaume();
                        break;
                    case 4:
                        if(r.PossibleImpot)
                            fabriqueAction.Creer(r, fabrique, "Action Impot");
                        r.PossibleImpot = false;
                        AfficherInfoRoyaume();
                        break;
                    case 5:
                        fabriqueAction.Creer(r, fabrique, "Fin tour");
                        AfficherInfoRoyaume();
                        break;
                }

            } while (choix != 0);
        }

        public void tour(string nom)
        {
            fabriqueAction.Creer(r, fabrique, nom);
        }

        public void Menu()
        {
            Console.WriteLine("-----------------------Menu--------------");
            Console.WriteLine("1- Afficher info royaume");
            Console.WriteLine("2- Achat paysan");
            Console.WriteLine("3- Achat village");
            Console.WriteLine("4- impot");
            Console.WriteLine("5- fin tour");
            Console.WriteLine("0- quitter");
        }

        public void AfficherInfoRoyaume()
        {
            Console.Clear();
            Console.WriteLine("----------------Info royaume--------------");
            Console.WriteLine(r);
        }
    }
}
