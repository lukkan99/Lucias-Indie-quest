using System.IO;
string[]backers = File.ReadAllLines("backers.txt");
string playername = "";
if(File.Exists("player.txt"))
{
    playername = File.ReadAllText("player.txt");
    Console.WriteLine($"Welcome back, {playername}, let's continue!");
}
else
{
    Console.WriteLine("Welcome to your biggest adventure yet!\n\n What your name?");
    playername = Console.ReadLine();

    File.WriteAllText("player.txt", playername);
}
if(Array.IndexOf(backers,playername) == -1)
{
    Console.WriteLine($"Unfortunately I cannot let you into Dr. Fred's secret laboratory.");
}
else
{
    Console.WriteLine($"You successfully enter Dr. Fred's secret laboratory and are greeted with a warm welcome for backing the game's Kickstarter!");
}