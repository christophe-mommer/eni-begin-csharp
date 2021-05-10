using System;
using System.Collections.Generic;

namespace DevineLeNombre
{
    class Program
    {
        static void Main(string[] args)
        {
            int borneMaximum = 0;
            string saisie = string.Empty;
            do
            {
                Console.WriteLine("Saisir la borne maximum du chiffre à deviner");
                saisie = Console.ReadLine();
                if (saisie == "q")
                {
                    Environment.Exit(0);
                }
            } while (!int.TryParse(saisie, out borneMaximum) && borneMaximum <= 0);
            System.Console.WriteLine("Choisir le niveau de difficulté (1 = facile, 2 = moyen, 3 = difficile)");
            int nbEssais = 5;
            if (int.TryParse(Console.ReadLine(), out int difficulte))
            {
                nbEssais = difficulte switch
                {
                    1 => 10,
                    2 => 5,
                    3 => 3,
                    _ => 5
                };
            }

            var random = new Random();
            var nombre = random.Next(0, borneMaximum + 1);
            bool? etatJeu = null;
            List<int> tentatives = new List<int>();
            while (!etatJeu.HasValue)
            {
                Console.Clear();
                Console.WriteLine("Chiffres déjà joués : " + string.Join(", ", tentatives));
                Console.WriteLine("Tentez de deviner le nombre caché");
                saisie = Console.ReadLine();
                if (saisie == "q")
                {
                    Environment.Exit(0);
                }
                if (int.TryParse(saisie, out int devine))
                {
                    tentatives.Add(devine);
                    if (devine == nombre)
                    {
                        etatJeu = true;
                        break;
                    }
                    else if (devine > nombre)
                    {
                        Console.WriteLine("Le nombre à deviner est plus petit");
                    }
                    else
                    {
                        Console.WriteLine("Le nombre à deviner est plus grand");
                    }
                    if (tentatives.Count >= nbEssais)
                    {
                        etatJeu = false;
                        break;
                    }
                }
                System.Console.WriteLine("Appuyer sur Entrée pour continuer");
                Console.ReadLine();
            }
            if (etatJeu.HasValue)
            {
                if (etatJeu.Value)
                {
                    System.Console.WriteLine("Gagné !");
                }
                else
                {
                    System.Console.WriteLine("Perdu ! Le nombre à deviner était " + nombre);
                }
            }
        }
    }
}
