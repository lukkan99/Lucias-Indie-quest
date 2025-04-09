class Location
{
    public string Name;
    public string Discription;
    public List<Location> Neighbors = new List<Location>();
}
class Program
{
    static void Main(string[] args)
    {
        int currentNumber;
        static void ConnectLocations(Location a, Location b)
        {
            a.Neighbors.Add(b);
            b.Neighbors.Add(a);
        }

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
        ConnectLocations(locations[2],locations[1]);
        ConnectLocations(locations[2],locations[3]);
        ConnectLocations(locations[2],locations[4]);
        ConnectLocations(locations[2],locations[5]);
        ConnectLocations(locations[0],locations[1]);
        ConnectLocations(locations[0],locations[3]);
        ConnectLocations(locations[5],locations[1]);
        ConnectLocations(locations[5],locations[4]);
        ConnectLocations(locations[4],locations[3]);
        Location currentLocation = locations[0];
        int pickedTraval;
        while(true)
        {
            currentNumber = 1;
            Console.WriteLine($"Welcome to {currentLocation.Name}, {currentLocation.Discription}\nPossible destinations are:");
            foreach(Location Neighbor in currentLocation.Neighbors)
            {
                Console.WriteLine($"{currentNumber}. {Neighbor.Name}");
                currentNumber ++;
            }
            Console.WriteLine("Where do you want to travel?");
            pickedTraval = Convert.ToInt32(Console.ReadLine());
            currentLocation = currentLocation.Neighbors[(pickedTraval-1)];
            
        }

        
        
        
    }
}