int[] numberOfMonster = new int[100];
var random = new Random();

for(int a = 0; a < 100; a++)
{
    numberOfMonster[a] = random.Next(1,51);
}
Array.Sort(numberOfMonster);
Console.Write("Number of monsters in levels:");
for(int a = 0; a < 99; a++)
{
    Console.Write($" {numberOfMonster[a]},");
}
Console.Write($" {numberOfMonster[99]}\n");