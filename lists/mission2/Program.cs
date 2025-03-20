using System.Collections.Generic;
var random = new Random();
int basiliskHp = 16;
List<string> warriors = ["Garry", "Rin", "Hougen", "Selander"];//yes the names based on my cats
for(int a = 0; a < 8; a++ )
{
    basiliskHp = basiliskHp + random.Next(1,9);
}

Console.WriteLine($"Fighters {warriors[0]} {warriors[1]} {warriors[2]} {warriors[3]} enters the dungon.\nA basilisk with {basiliskHp}HP appears!");
foreach(string warrior in warriors)
{
    int atack = random.Next(1,7) + random.Next(1,7);
    basiliskHp = basiliskHp - atack;
    Console.WriteLine($"{warrior} hits the baslisk for {atack}. Baslisk has {basiliskHp}HP left!");
}
