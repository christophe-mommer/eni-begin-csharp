try  
{ 
    Calculer();  
}  
catch  
{ 
    var color = Console.ForegroundColor; 
    Console.ForegroundColor = ConsoleColor.Red; 
    Console.WriteLine("Une erreur a été rencontrée"); 
    Console.ForegroundColor = color;  
}  
finally  
{ 
    Console.WriteLine("Fin du programme");  
} 
void Calculer() 
{ 
    Console.WriteLine("C'est parti pour la division"); 
    RecupererSaisie(); 
} 
void RecupererSaisie() 
{ 
    Console.WriteLine("Saisir le premier chiffre"); 
    decimal one = decimal.Parse(Console.ReadLine()); 
    Console.WriteLine("Saisir le second chiffre"); 
    decimal two = decimal.Parse(Console.ReadLine()); 
    Console.WriteLine("Résultat = " + Diviser(one, two)); 
} 
decimal Diviser(decimal a, decimal b) 
{ 
    if (b == 0) 
    { 
        throw new InvalidOperationException("Il est impossible de diviser par 0"); 
    } 
    return a / b; 
}
