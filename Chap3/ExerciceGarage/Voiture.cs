using System;

namespace ExerciceGarage;

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
    public required string Marque { get; set; }
    public required Couleur Couleur { get; set; }
    public DateOnly? DateEntretien { get; set; }
}
public class Camion : Vehicule
{
}