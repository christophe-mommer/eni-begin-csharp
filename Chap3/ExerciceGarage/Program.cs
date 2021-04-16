using System;

namespace ExerciceGarage
{
    class Program
    {
        static void Main(string[] args)
        {
            var garage = new Garage();
            var peugeot = new Voiture { Marque = "Peugeot", Couleur = Couleur.Bleu };
            var ferrari = new Voiture { Marque = "Ferrari", Couleur = Couleur.Rouge };
            var camion = new Camion();
            garage.Reparer(camion);
            garage.Reparer(peugeot);
            garage.FaireEntretien(ferrari);
            garage.Repeindre(peugeot, Couleur.Vert);
        }
    }
}
