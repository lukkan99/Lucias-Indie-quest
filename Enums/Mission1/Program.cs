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
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        static void DrawCard(Suit suit, int rank)
        {
            string cardSymbol = "";
            if(suit == Suit.Heart)
            {
                cardSymbol = "♥";
            }
            if(suit == Suit.Spade)
            {
                cardSymbol = "♠";
            }
            if(suit == Suit.Diamond)
            {
                cardSymbol = "♦";
            }
            if(suit == Suit.Club)
            {
                cardSymbol = "♣";
            }


            if(rank == 1)
            {
                Console.WriteLine($"╭─────────╮\n│A        │\n│{cardSymbol}        │\n│         │\n│    {cardSymbol}    │\n│         │\n│        {cardSymbol}│\n│        A│\n╰─────────╯");
            }

            if(rank == 2)
            {
                Console.WriteLine($"╭─────────╮\n│2   {cardSymbol}    │\n│{cardSymbol}        │\n│         │\n│         │\n│         │\n│        {cardSymbol}│\n│    {cardSymbol}   2│\n╰─────────╯");   
            }

            if(rank == 3)
            {
                Console.WriteLine($"╭─────────╮\n│3   {cardSymbol}    │\n│{cardSymbol}        │\n│         │\n│    {cardSymbol}    │\n│         │\n│        {cardSymbol}│\n│    {cardSymbol}   3│\n╰─────────╯");
            }

            if(rank == 4)
            {
                Console.WriteLine($"╭─────────╮\n│4 {cardSymbol}   {cardSymbol}  │\n│{cardSymbol}        │\n│         │\n│         │\n│         │\n│        {cardSymbol}│\n│  {cardSymbol}   {cardSymbol} 4│\n╰─────────╯");
            }
            
            if(rank == 5)
            {
                Console.WriteLine($"╭─────────╮\n│5 {cardSymbol}   {cardSymbol}  │\n│{cardSymbol}        │\n│         │\n│    {cardSymbol}    │\n│         │\n│        {cardSymbol}│\n│  {cardSymbol}   {cardSymbol} 5│\n╰─────────╯");
            }
            if(rank == 6)
            {
                Console.WriteLine($"╭─────────╮\n│5 {cardSymbol}   {cardSymbol}  │\n│{cardSymbol}        │\n│         │\n│    {cardSymbol}    │\n│         │\n│        {cardSymbol}│\n│  {cardSymbol}   {cardSymbol} 5│\n╰─────────╯");
            }
            if(rank == 7)
            {
                Console.WriteLine($"╭─────────╮\n│7 {cardSymbol}   {cardSymbol}  │\n│{cardSymbol}        │\n│    {cardSymbol}    │\n│  {cardSymbol}   {cardSymbol}  │\n│         │\n│        {cardSymbol}│\n│  {cardSymbol}   {cardSymbol} 7│\n╰─────────╯");
            }
            if(rank == 8)
            {
                Console.WriteLine($"╭─────────╮\n│8 {cardSymbol}   {cardSymbol}  │\n│{cardSymbol}        │\n│    {cardSymbol}    │\n│  {cardSymbol}   {cardSymbol}  │\n│    {cardSymbol}    │\n│        {cardSymbol}│\n│  {cardSymbol}   {cardSymbol} 8│\n╰─────────╯");
            }
            if(rank == 9)
            {
                Console.WriteLine($"╭─────────╮\n│9 {cardSymbol}   {cardSymbol}  │\n│{cardSymbol}        │\n│  {cardSymbol}   {cardSymbol}  │\n│    {cardSymbol}    │\n│  {cardSymbol}   {cardSymbol}  │\n│        {cardSymbol}│\n│  {cardSymbol}   {cardSymbol} 9│\n╰─────────╯");
            }
            if(rank == 10)
            {
                Console.WriteLine($"╭─────────╮\n│10{cardSymbol}   {cardSymbol}  │\n│{cardSymbol}   {cardSymbol}    │\n│  {cardSymbol}   {cardSymbol}  │\n│         │\n│  {cardSymbol}   {cardSymbol}  │\n│    {cardSymbol}   {cardSymbol}│\n│  {cardSymbol}   {cardSymbol}10│\n╰─────────╯");
            }
            if(rank == 11)
            {
                Console.WriteLine($"╭─────────╮\n│J┌─────┐ │\n│{cardSymbol}│{cardSymbol}\\__/│ │\n│ │|(_/|│ │\n│ │}} / {{│ │\n│ │|/_)|│ │\n│ │/  \\{cardSymbol}│{cardSymbol}│\n│ └─────┘J│\n╰─────────╯");
            }
            if(rank == 12)
            {
                Console.WriteLine($"╭─────────╮\n│Q┌─────┐ │\n│{cardSymbol}│{cardSymbol}(_(/│ │\n│ │  )/❀│ │\n│ │{{ / }}│ │\n│ │❀/(  │ │\n│ │/) ){cardSymbol}│{cardSymbol}│\n│ └─────┘Q│\n╰─────────╯");
            }
            if(rank == 13)
            {
                Console.WriteLine($"╭─────────╮\n│K┌─────┐ │\n│{cardSymbol}│{cardSymbol}\\__/│ │\n│ │ (_/|│ │\n│ │+ / +│ │\n│ │|/_) │ │\n│ │/  \\{cardSymbol}│{cardSymbol}│\n│ └─────┘K│\n╰─────────╯");
            }
            
        }
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
        Console.WriteLine("mission 1 output:");
        DrawAce(Suit.Heart);
        DrawAce(Suit.Diamond);
        DrawAce(Suit.Spade);
        DrawAce(Suit.Spade);
        Console.WriteLine("\n\nmission bonsus output:");
        int numberOfCards = 13;
        for(int a = 1; a <= numberOfCards; a++)
        {
            DrawCard(Suit.Heart,a);
        }
        for(int a = 1; a <= numberOfCards; a++)
        {
            DrawCard(Suit.Diamond,a);
        }
        for(int a = 1; a <= numberOfCards; a++)
        {
            DrawCard(Suit.Spade,a);
        }
        for(int a = 1; a <= numberOfCards; a++)
        {
            DrawCard(Suit.Spade,a);
        }
        
    }
}