List<string> participants = ["Allie", "Ben", "Claire", "Dan", "Eleanor"];
static List<string> ShuffleList(List<string> items)
{
    
    var random = new Random();
    for(int i = items.Count - 1; i >= 1; i--)
    {
        int j = random.Next(0,i);
        string itemj = items[j];
        string itemi = items[i];
        items[j] = itemi;
        items[i] = itemj;
    }
    return items;
}

Console.WriteLine($"Signed-up participants: {String.Join(", ", participants)}");
Console.WriteLine("Generating starting order ...");
List<string> shuffledParticipants = ShuffleList(participants);
Console.WriteLine($"Starting order: {String.Join(", ", shuffledParticipants)}");