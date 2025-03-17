var random = new Random();
int tankDistance = random.Next(40,71);

Console.WriteLine("Commander a tank is getting closer ready the fild attrilery!\n");
Console.Write("So what your name commander: ");


string commander = Console.ReadLine();//set commanders name

Console.Clear();
void drawBattlefiled()
{
    Console.WriteLine("Current map of the battlefiled:\n\n");
    Console.Write("_/");//atterily

    for(int a = 3; a <= (tankDistance - 1); a++)//gen rest of battlefiled
    {
        Console.Write("_");
    }
    Console.Write("T");
    for(int a = 1; a <= (80 - tankDistance); a++)
    {
        Console.Write("_");
    }
}

bool aimAndShoot()
{
    drawBattlefiled();
    Console.WriteLine($"\nAim your shot, {commander}!");
    Console.Write("Enter Distance: ");
    int target = Convert.ToInt32(Console.ReadLine());

    for(int a = 0; a < (target - 1); a++)//gen visulation of the shot
    {
        Console.Write(" ");
    }
    Console.Write("*");
    for(int a = 1; a <= (80 - target); a++)
    {
        Console.Write(" ");
    }
    Console.Write("\n");

    if(target == tankDistance)
    {
        bool hit = true;
        Console.Clear();
        return (hit);
    }
    else if(target < tankDistance)
    {
        Console.WriteLine($"Miss to short");
        bool hit = false;
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        return (hit);
    }
    else
    {
        Console.WriteLine($"Miss to far");
        bool hit = false;
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        return (hit);
    }
}
bool aimHit = aimAndShoot();
while(aimHit==false && tankDistance > 2)
{   
    tankDistance = tankDistance - random.Next(1,16);
    aimHit = aimAndShoot();    
}

if(aimHit == true)
{
    Console.WriteLine($"Hit!, nice shoot commander {commander}!");
}
else
{
    Console.WriteLine($"Tank is too close {commander}! Game Over");
}
