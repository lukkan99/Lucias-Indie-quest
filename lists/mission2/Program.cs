using System.Collections.Generic;
var random = new Random();
int basiliskHp = 16;
int warriorTurn = 0;
List<string> warriors = ["Garry", "Rin", "Hougen", "Selander"];//yes the names based on my cats
for(int a = 0; a < 8; a++ )
{
    basiliskHp = basiliskHp + random.Next(1,9);
}

Console.WriteLine($"Fighters {warriors[0]} {warriors[1]} {warriors[2]} {warriors[3]} enters the dungon.\nA basilisk with {basiliskHp}HP appears!");
while(basiliskHp > 0)
{
    if(warriorTurn == 4)
    {
        warriorTurn = 0;
    }
    int atack = random.Next(1,7) + random.Next(1,7);
    basiliskHp = basiliskHp - atack;
    if(basiliskHp <= 0)
    {
        Console.WriteLine($"{warriors[warriorTurn]} hits the baslisk for {atack}. Baslisk has 0 HP left!\nThe basslisk Falls and dies The warriors has a feast!");
    }
    else
    {
        Console.WriteLine($"{warriors[warriorTurn]} hits the baslisk for {atack}. Baslisk has {basiliskHp}HP left!");
        warriorTurn = warriorTurn + 1;
    }
}
