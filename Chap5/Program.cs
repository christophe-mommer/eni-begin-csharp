using System;
using System.Linq;

var entiers = Enumerable.Range(1, 100);
var divisibleParSept = entiers.Where(e => e % 7 == 0);
var divisibleParSeptInline = from e in entiers where e % 7 == 0 select e;

foreach (var item in divisibleParSept)
{
    Console.Write("\t" + item);
}
Console.WriteLine();
foreach (var item in divisibleParSeptInline)
{
    Console.Write("\t" + item);
}
Console.WriteLine();

var groups = divisibleParSept.GroupBy(e => e % 2).Select(g => new { Nom = g.Key == 0 ? "Pair" : "Impair", Nombres = g.ToList() });

foreach (var item in groups)
{
    Console.WriteLine(item.Nom);
    foreach (var value in item.Nombres)
    {
        Console.WriteLine("\t" + value);
    }
    Console.WriteLine();
}