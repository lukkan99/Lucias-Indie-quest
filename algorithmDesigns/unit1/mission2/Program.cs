static string JoinWithAnd(List<string> items, bool useSerialComma = true)
{
    int count = items.Count;
    switch(count)
    {
        case 0:
        return "";
        case 1:
        return items[0];
        case 2:
        return($"{items[0]} and {items[1]}");
        default:
        var itemsCopy = new List<string>(items);
        if(useSerialComma)
        {
            itemsCopy[count -1] =($"and {itemsCopy[count -1]}");
            return String.Join(", ", itemsCopy);        
        }else
        {
            itemsCopy[count -2] = ($"{itemsCopy[count -2]} and {itemsCopy[count -1]}");
            itemsCopy.RemoveAt(count-1);
            return String.Join(", ", itemsCopy);
        }

        
    }
}

List<string> heros = ["Jazlyn", "Theron", "Dayana","Rolando"];
List<string> heros2 = ["Jazlyn", "Theron", "Dayana"];
List<string> heros3 = ["Jazlyn", "Theron"];
List<string> heros4 = ["Jazlyn"];

Console.WriteLine(JoinWithAnd(heros));
Console.WriteLine(JoinWithAnd(heros2));
Console.WriteLine(JoinWithAnd(heros3));
Console.WriteLine(JoinWithAnd(heros4));
Console.WriteLine(JoinWithAnd(heros,false));
Console.WriteLine(JoinWithAnd(heros2,false));
Console.WriteLine(JoinWithAnd(heros3,false));
Console.WriteLine(JoinWithAnd(heros4,false));

