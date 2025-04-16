var random = new Random();
var capitals = new SortedList<string, string>();
string contry;
string city;
int randomnumber;
capitals["Australia"] = "Canberra";
capitals["USA"] = "Washington DC";
capitals["Greece"] = "Athens";
capitals["Italy"] = "Rome";
capitals["China"] = "Beijing";
capitals["Canada"] = "Ottawa";
capitals["United Kingdom"] = "London";
capitals["Russia"] = "Moscow";
capitals["Brazil"] = "Brasília";
capitals["South Korea"] = "Seoul";
capitals["Japan"] = "Tokyo";
capitals["France"] = "Paris";

for(int a = 0; a < 3; a++)
{
    randomnumber = random.Next(capitals.Count);
    contry = capitals.GetKeyAtIndex(randomnumber);
    city = capitals.GetValueAtIndex(randomnumber);
    Console.WriteLine($"What is the capital of {contry}?");
    string userinput = Console.ReadLine().ToLower();
    if(userinput == city.ToLower())
    {
        Console.WriteLine("Correct!");
    }
    else
    {
        Console.WriteLine($"Incorrect! right awnser was {city}.");
    }
}