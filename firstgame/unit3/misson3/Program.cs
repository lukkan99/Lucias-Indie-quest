var random = new Random();
int dice = random.Next(1,7);
int totalscore = dice;
Console.WriteLine($"The player rolls: {dice}");
while(dice != 6)
{
    dice = random.Next(1,7);
    Console.WriteLine($"The player rolls: {dice}");
    totalscore = totalscore + dice;
    
}
Console.WriteLine($"Total score: {totalscore}");