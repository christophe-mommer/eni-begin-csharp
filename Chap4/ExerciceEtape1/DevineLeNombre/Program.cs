Console.WriteLine("Saisissez la borne maximum du chiffre à deviner");
var borneMaximum = int.Parse(Console.ReadLine());
if (borneMaximum <= 0)
{
    Console.WriteLine("La borne maximum ne peut pas être inférieure ou égale à 0. Relancer le jeu pour recommencer");
}
else
{
    var nombre = Random.Shared.Next(0, borneMaximum + 1);
    Console.WriteLine("Tentez de deviner le nombre caché");

    var devine = int.Parse(Console.ReadLine());
    if (devine == nombre)
    {
        Console.WriteLine("Gagné !");
    }
    else
    {
        Console.WriteLine("Perdu !");
    }
}
