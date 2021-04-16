using System;

namespace ExerciceGarage
{
    public enum Couleur
    {
        Vert,
        Bleu,
        Rouge
    }
    public abstract class Vehicule
    {
        public bool Repare { get; set; }
    }
    public class Voiture : Vehicule
    {
        public string Marque { get; set; }
        public Couleur Couleur { get; set; }
        public DateTime DateEntretien { get; set; }
    }
    public class Camion : Vehicule
    {
    }

}