var random = new Random();
var hostCountries = new Dictionary<int, string>();
hostCountries[2000] = "Australia";
hostCountries[2002] = "USA";
hostCountries[2004] = "Greece";
hostCountries[2006] = "Italy";
hostCountries[2008] = "China";
hostCountries[2010] = "Canada";
hostCountries[2012] = "United Kingdom";
hostCountries[2014] = "Russia";
hostCountries[2016] = "Brazil";
hostCountries[2018] = "South Korea";
hostCountries[2020] = "Japan";
hostCountries[2022] = "China";
hostCountries[2024] = "France";
List<int> summerGames = [2004,2008,2012,2016,2020,2024];


for(int a = 0; a < 3; a++)
{
    int year = 2000 + random.Next(hostCountries.Count) * 2;
    if(summerGames.IndexOf(year) == -1)
    {
        Console.WriteLine($"which country hosted the Winter Olympic Games in {year}?");
        string userInput = Console.ReadLine().ToLower();
        if(userInput == hostCountries[year].ToLower())
        {
            Console.WriteLine("Correct!");
        }else
        {
            Console.WriteLine($"Inorrect! The correct answser is {hostCountries[year]}");
        }
    }
    else
    {
        Console.WriteLine($"which country hosted the Summer Olympic Games in {year}?");
        string userInput = Console.ReadLine().ToLower();
        if(userInput == hostCountries[year].ToLower())
        {
            Console.WriteLine("Correct!");
        }else
        {
            Console.WriteLine($"Inorrect! The correct answser is {hostCountries[year]}");
        }

    }
}