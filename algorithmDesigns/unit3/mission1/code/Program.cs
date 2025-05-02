var random = new Random();
int width = 15;
int height = 10;

//2d arrys for all calc
var forrest = new bool[width, height];
var roads = new bool[width, height];
var river = new bool[width, height];
var bidge = new bool[width, height];
var usedspace = new bool[width, height];





for (int y = 0; y < height; y++)
{
    for (int x = 0; x < width; x++)
    {
        if((x==0 && y ==0) || (x == width-1 && y== height-1) || (x==0 && y==height-1) || (y==0 && x==width-1))
        {
            Console.Write("+");
        }
        Console.Write(" ");

    }
    Console.WriteLine();
}
