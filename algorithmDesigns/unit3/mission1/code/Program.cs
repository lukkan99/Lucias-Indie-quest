var random = new Random();
int width = 25;
int height = 10;

//2d arrys for all calc
var forrest = new bool[width, height];
var roads = new bool[width, height];
var river = new bool[width, height];
var bidge = new bool[width, height];
var usedspace = new bool[width, height];




//drawing rutine
for (int y = 0; y < height; y++)
{
    for (int x = 0; x < width; x++)
    {   //boder coners
        if((x==0 && y ==0) || (x == width-1 && y== height-1) || (x==0 && y==height-1) || (y==0 && x==width-1))
        {
            Console.Write("+");
            usedspace[x,y] = true;
        }
        if(x == width/2-5 && y==1)
        {
            Console.Write("ADVENTURE MAP");
            for(int a =x ; a < x+13; a++)
            {
                usedspace[a,y] = true;
            }
        }
        // top and bottom border
        if((x!=0 && y==0 && x!= width-1) || (x!=0 && y==height-1 && x!= width-1))
        {
            Console.Write("-");
            usedspace[x,y] = true;        
        }//side borders
        if((y!=0 && x==0 && y!=height-1) || (y!=0 && x==width-1 && y!=height-1))
        {
            Console.Write("|");
            usedspace[x,y] = true;
        }

        //write blank spaceses
        if(usedspace[x,y] == false) Console.Write(" ");

    }
    Console.WriteLine();
}
