var random = new Random();

int hp = random.Next(1,101);
Console.WriteLine($"Warrior hp: {hp}\nThe Regenerate spell is cast!");
while(hp<50)
{
    hp = hp +10;
    Console.WriteLine($"Warrior hp: {hp}");
}
Console.WriteLine($"The Regenerate spell is complete.\nWarrior hp: {hp}");