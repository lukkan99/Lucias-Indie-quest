var scores = new Dictionary<string, int>();
bool hasinput = true; 

while(hasinput)
{
    Console.Write("Who won this round?");
    string userInput = Console.ReadLine();
    Console.WriteLine();
    if(userInput == "")
    {
        hasinput = false;
    }
    else
    {
        if(scores.ContainsKey(userInput))
        {
            scores[userInput] = scores[userInput] + 1;

        }
        else
        {
            scores.Add(userInput,1);
        }
    }
var sortedPlayers = scores.Keys.OrderBy((player) => scores[player]).Reverse();

if(hasinput)
{
    Console.WriteLine("RANKINGS");
}
else
{
    Console.WriteLine("FINAL RANKINGS");
}
foreach(string player in sortedPlayers)
{
    Console.WriteLine($"{player} {scores[player]}");
}

}