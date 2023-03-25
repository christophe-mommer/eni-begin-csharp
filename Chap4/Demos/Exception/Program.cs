Calculer(); 

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
    decimal result =  Diviser(one, two);
    Console.WriteLine("Résultat = " + result); 
} 
decimal Diviser (decimal a, decimal b) 
{ 
    if(b == 0) 
    { 
           throw new InvalidOperationException("Il est impossible de diviser par 0"); 
    } 
    return a / b; 
}
