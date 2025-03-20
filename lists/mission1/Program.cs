using System.Collections.Generic;
var random = new Random();

List<int> dices = [random.Next(1,7), random.Next(1,7), random.Next(1,7), random.Next(1,7)];
List<int> ablityScore = [];
for(int a=0; a < 6; a++)
{
    Console.Write($"You rolled {dices[0]} {dices[1]} {dices[2]} {dices[3]} ");
    dices.Sort();
    ablityScore.Add(dices[1] + dices[2] + dices[3]);
    Console.WriteLine($"The ability score is {dices[1] + dices[2] + dices[3]}");
    dices = [random.Next(1,7), random.Next(1,7), random.Next(1,7), random.Next(1,7)];
}
ablityScore.Sort();
Console.WriteLine($"Your available ability scores are {ablityScore[0]} {ablityScore[1]} {ablityScore[2]} {ablityScore[3]} {ablityScore[4]} {ablityScore[5]}");