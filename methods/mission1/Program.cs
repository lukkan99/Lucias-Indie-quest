using System.Collections.Generic;
var random = new Random();
//int basiliskHp = 16;
List<string> characterNames = ["Garry", "Rin", "Hougen", "Selander"];//yes the names based on my cats
Console.WriteLine(characterNames.Count);
/*for(int a = 0; a < 8; a++ )
{
    basiliskHp = basiliskHp + random.Next(1,9);
}
*/
Console.WriteLine($"The heros {characterNames[0]} {characterNames[1]} {characterNames[2]} {characterNames[3]} enters the dungon.");
static void SimulateCombat(List<string> characterNames, string monsterName, int monsterHP, int savingThrowDC)
{
    int warriorTurn = 0;
    int pickHero;
    var random = new Random();
    
    Console.WriteLine($"A {monsterName} with {monsterHP}HP appears!");
    while(monsterHP > 0 && characterNames.Count > 0)
    {
        if(warriorTurn == characterNames.Count)
        {
            pickHero = random.Next(0,characterNames.Count);
            Console.WriteLine($"The {monsterName} attacks {characterNames[pickHero]}");
            int conthrow = random.Next(1,21);
            if(conthrow + 3 < savingThrowDC)
            {
                Console.WriteLine($"{characterNames[pickHero]} rolled {conthrow} and failed be saved. {characterNames[pickHero]} has been killed.");
                characterNames.RemoveAt(pickHero);
            }
            else
            {
                Console.WriteLine($"{characterNames[pickHero]} rolled {conthrow} and is saved from the atrack.");
            }
            if(characterNames.Count > 0)
            {
                warriorTurn = 0;
            }
        }
        int atack = random.Next(1,7) + random.Next(1,7);
        monsterHP = monsterHP - atack;
        if(monsterHP <= 0)
        {
            Console.WriteLine($"{characterNames[warriorTurn]} hits the {monsterName} for {atack}. {monsterName} has 0 HP left!\nThe {monsterName} Falls and dies");
        }
        else
        {
            if(characterNames.Count > 0)
            {
                Console.WriteLine($"{characterNames[warriorTurn]} hits the {monsterName} for {atack}. {monsterName} has {monsterHP}HP left!");
                warriorTurn = warriorTurn + 1;
            }
            else
            {
                //Console.WriteLine($"The party has failed and the basilisk continues to turn unsuspecting adventurers to stone.");
            }
        }
    }
}
SimulateCombat(characterNames, "orc", 15, 10);
if(characterNames.Count > 0)
{
    SimulateCombat(characterNames, "azer", 39, 18);
    if(characterNames.Count > 0)
    {
        SimulateCombat(characterNames, "troll", 84, 16);
        if(characterNames.Count > 0)
        {
            Console.Write($"After three grueling battles, the heroes ");
            foreach(string hero in characterNames)
            {
                Console.Write($"{hero} ");
            }
            Console.WriteLine("return from the dungeons to live another day.");
        }else
        {
           Console.WriteLine("all heros are dead"); 
        }
    }else
    {
        Console.WriteLine("all heros are dead");
    }
}else
{
    Console.WriteLine("all heros are dead");
}