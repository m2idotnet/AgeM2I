using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AgeM2I.Classes
{
    public class Jeu
    {
        public Royaume r;
        public Fabrique fabrique;
        public FabriqueAction fabriqueAction;
        public string fileRoyaume;

        public void Init()
        {
            int choixInitial;
            
            do
            {
                Console.WriteLine("1-Nouveau royaume");
                Console.WriteLine("2-Charger un royaume");
                Console.WriteLine("0-Quitter");
                choixInitial = Convert.ToInt32(Console.ReadLine());
                switch(choixInitial)
                {
                    case 1:
                        Console.Write("Nom du royaume : ");
                        fileRoyaume = Console.ReadLine();
                        r = new Royaume();
                        Jouer("village");
                        break;
                    case 2:
                        Console.Write("Nom du royaume : ");
                        fileRoyaume = Console.ReadLine();
                        r = new Royaume();
                        if (File.Exists(fileRoyaume + ".txt"))
                        {
                            StreamReader reader = new StreamReader(fileRoyaume + ".txt");
                            string contenuRoyaume = reader.ReadToEnd();
                            reader.Close();
                            JsonConvert.PopulateObject(contenuRoyaume,r);
                            Jouer("");
                            
                        }
                        break;
                }
            } while (choixInitial != 0);
            
        }

        private void Jouer(string type)
        {
            fabrique = new Fabrique();
            fabriqueAction = new FabriqueAction();
            if (type == "village")
            {
                Village v = fabrique.FabriqueVillage();
                v.Habitants.Add(fabrique.FabriqueVillageois("roturier"));
                r.Villages.Add(v);
            }
            
            int choix;
            do
            {
                Menu();
                choix = Convert.ToInt32(Console.ReadLine());
                switch (choix)
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
                        if (r.PossibleImpot)
                            fabriqueAction.Creer(r, fabrique, "Action Impot");
                        r.PossibleImpot = false;
                        AfficherInfoRoyaume();
                        break;
                    case 5:
                        fabriqueAction.Creer(r, fabrique, "Fin tour");
                        AfficherInfoRoyaume();
                        break;
                    case 0:
                        StreamWriter writer = new StreamWriter(fileRoyaume + ".txt");
                        writer.Write(JsonConvert.SerializeObject(r));
                        writer.Close();
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
