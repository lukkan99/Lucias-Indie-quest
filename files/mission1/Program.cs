using System.IO;
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