class Location
{
    public string Name;
    public string Discription;
}
class Program
{
    static void Main(string[] args)
    {
        var locations = new List<Location>();
        locations.Add(new Location{
            Name = "Winterfell",
            Discription = "the capital of the Kingdom of the North"
        });
        locations.Add(new Location{
            Name = "Pyke",
            Discription = "the stronghold and seat of House Greyjoy"
        });
        locations.Add(new Location{
            Name = "Riverrun",
            Discription = "a large castle located in the central-western part of the Riverlands"
        });
        locations.Add(new Location{
            Name = "The Trident",
            Discription = "one of the largest and most well-known rivers on the continent of Westeros"
        });
        locations.Add(new Location{
            Name = "King's Landing",
            Discription = "the capital, and largest city, of the Seven Kingdoms"
        });
        locations.Add(new Location{
            Name = "Highgarden",
            Discription = "the seat of House Tyrell and the regional capital of the Reach"
        });
        Location currentLocation;
        for(int a = 0; a<6; a++)
        {
            currentLocation = locations[a];
            Console.WriteLine($"Welcome to {currentLocation.Name}, {currentLocation.Discription}");

        }
        
        
    }
}