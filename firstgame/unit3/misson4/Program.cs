var random = new Random();
int dices;
int strength = 0;
int cubehp = 40;
int armyhp = 0;
for (int throws = 1; throws <= 3; throws++) // strengh gen
{
    dices = random.Next(1,7);
    strength = strength + dices;
}

Console.WriteLine($"A character with strength {strength} was created.");

for (int throws = 1; throws <= 10; throws++) //cube hp gen
{
    dices = random.Next(1,9);
    cubehp = cubehp + dices;
}
Console.WriteLine($"A gelatinous cube with {cubehp} HP appears!");

for (int spawns = 1; spawns <= 100; spawns++)//army gen
{
    cubehp = 40;
    for (int throws = 1; throws <= 10; throws++) //cube hp gen
        {
            dices = random.Next(1,9);
            cubehp = cubehp + dices;
        }
    armyhp = armyhp + cubehp;
}
Console.WriteLine($"Dear gods, an army of 100 cubes descends upon us with a total of {armyhp} HP. We are doomed!");