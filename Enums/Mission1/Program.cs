enum Suit 
{
    Heart,
    Spade,
    Diamond,
    Club
}
class Program
{
    static void Main(string[] args)
    {
        static void DrawAce(Suit suit)
        {
            
            if(suit == Suit.Heart)
            {
                Console.WriteLine("╭───────╮\n│A      │\n│ ♥     │\n│    ♥  │\n│      ♥│\n│      A│\n╰───────╯");
            }
            if(suit == Suit.Spade)
            {
                Console.WriteLine("╭───────╮\n│A      │\n│ ♠     │\n│    ♠  │\n│      ♠│\n│      A│\n╰───────╯");
            }
            if(suit == Suit.Diamond)
            {
                Console.WriteLine("╭───────╮\n│A      │\n│ ♦     │\n│    ♦  │\n│      ♦│\n│      A│\n╰───────╯");
            }
            if(suit == Suit.Club)
            {
                Console.WriteLine("╭───────╮\n│A      │\n│ ♣     │\n│    ♣  │\n│      ♣│\n│      A│\n╰───────╯");
            }
        }
        DrawAce(Suit.Heart);
        DrawAce(Suit.Diamond);
        DrawAce(Suit.Club);
        DrawAce(Suit.Spade);
        
    }
}