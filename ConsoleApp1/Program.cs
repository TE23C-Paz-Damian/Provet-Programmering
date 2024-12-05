using System;
using System.Transactions;
class Program
{
    static void Main()
}
    // Fråga användaren om Max-hp
    int maxHP;
    do{
        Console.WriteLine("Ange karaktärens max-HP (1-20): ");

        (int.TryParse(Console.ReadLine(), out max HP) && maxHP >= 1 && maxHP <= 20)
        {
            break;
        }
        else
        {
            
        }

        Console.WriteLine("Felaktig inmatning. Ange ett tal mellan 1 och 20.");
    }
    {while (true);

    int currentHP = maxHP;

    }
    // Loop för att minska
    while (currentHP > 0)
    {

    }
    //Skriver ut
    
    Console.Write("[");
    for (int i = 0; i < currentHP; i++)
    {
        Console.Write("=");
    }
    for (int i = currentHP; i < maxHP; i++)
    {
        Console.Write("");
    }

    Console.WriteLine("]");

    //Dela ut skada
    currentHP--;

    //Vänta på att användaren trycker på en tangnent

    Console.WriteLine("Tryck på valfri tangnent för att ta skada...");
    Console.ReadKey();
    {
        Console.WriteLine("Karaktären har dött! Game Over.");
    }

    