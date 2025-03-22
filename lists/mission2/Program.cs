using System.Collections.Generic;
var random = new Random();
int basiliskHp = 16;
int warriorTurn = 0;
int pickHero;
List<string> warriors = ["Garry", "Rin", "Hougen", "Selander"];//yes the names based on my cats
Console.WriteLine(warriors.Count);
for(int a = 0; a < 8; a++ )
{
    basiliskHp = basiliskHp + random.Next(1,9);
}

Console.WriteLine($"Fighters {warriors[0]} {warriors[1]} {warriors[2]} {warriors[3]} enters the dungon.\nA basilisk with {basiliskHp}HP appears!");
while(basiliskHp > 0 && warriors.Count > 0)
{
    if(warriorTurn == warriors.Count)
    {
        pickHero = random.Next(0,warriors.Count);
        Console.WriteLine($"The basilisk uses petrifying gaze on {warriors[pickHero]}");
        int conthrow = random.Next(1,21);
        if(conthrow + 3 < 12)
        {
            Console.WriteLine($"{warriors[pickHero]} rolled {conthrow} and failed be saved. {warriors[pickHero]} got turn into stone.");
            warriors.RemoveAt(pickHero);
        }
        else
        {
            Console.WriteLine($"{warriors[pickHero]} rolled {conthrow} and is saved from the atrack.");
        }
        if(warriors.Count > 0)
        {
            warriorTurn = 0;
        }
    }
    int atack = random.Next(1,5);
    basiliskHp = basiliskHp - atack;
    if(basiliskHp <= 0)
    {
        Console.WriteLine($"{warriors[warriorTurn]} hits the baslisk for {atack}. Baslisk has 0 HP left!\nThe basslisk Falls and dies The warriors has a feast!");
    }
    else
    {
        if(warriors.Count > 0)
        {
            Console.WriteLine($"{warriors[warriorTurn]} hits the baslisk for {atack}. Baslisk has {basiliskHp}HP left!");
            warriorTurn = warriorTurn + 1;
        }
        else
        {
            Console.WriteLine($"The party has failed and the basilisk continues to turn unsuspecting adventurers to stone.");
        }
    }
}
