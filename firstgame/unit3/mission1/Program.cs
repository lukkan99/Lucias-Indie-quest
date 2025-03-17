var random = new Random();
int ball1 = random.Next(0,11);

if(ball1 == 10)
{
    Console.WriteLine($"First roll: X\nKnocked pins: 10");
}
else
{
    int ball2 = random.Next(0,(10 - ball1) + 1);
    int totalscore = (ball1 + ball2);
    if(totalscore == 10)
    {
        Console.WriteLine($"First roll: {ball1}\nSecond roll: / \nKnocked pins: 10");
    }
    else
    {
        Console.WriteLine($"First roll: {ball1}\nSecond roll: {ball2}\nKnocked pins: {totalscore}");
    }
}