using System;

namespace ExerciceGarage
{
    public class Garage
    {
        public void FaireEntretien(Voiture voiture)
        {
            Console.WriteLine("Réalisation de l'entretien de la voiture de marque" + voiture.Marque);
            voiture.DateEntretien = DateTime.Now;
        }
        public void Repeindre(Voiture voiture, Couleur nouvelleCouleur)
        {
            Console.WriteLine("Changement de la couleur de la voiture. Couleur originale = " + voiture.Couleur + ". Nouvelle couleur = " + nouvelleCouleur);
            voiture.Couleur = nouvelleCouleur;
        }
        public void Reparer(Vehicule vehicule)
        {
            Console.WriteLine("Réparation d'un véhicule");
            vehicule.Repare = true;
        }
    }

}