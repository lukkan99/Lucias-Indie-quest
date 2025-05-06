//int random
var random = new Random();
//set how big area map suld be
int width = 35;
int height = 16;

//declear 2d arrys for all calc
var forrest = new bool[width, height];
var roads = new bool[width, height];
var river = new bool[width, height];
var bidge = new bool[width, height];
var usedspace = new bool[width, height];

//data perpering stage
for (int y = 0; y < height; y++)
{
    for (int x = 0; x < width; x++)
    {   //gen river
        if(y==1&&x==width-5)
        {
            for(int a = x; a > x-3; a--)
            {
                for(int b = y; b < height-1; b++)
                {
                    river[a,b] = true;
                    usedspace[a,b] = true;
                }
            }
        }

        //gen roads
        if(y==height/2 && x == 2)
        {
            roads[x,y] = true;
            usedspace[x,y]= true;
        }
    }
}



//drawing rutine
for (int y = 0; y < height; y++)
{
    for (int x = 0; x < width; x++)
    {   //boder coners
        if((x==0 && y ==0) || (x == width-1 && y== height-1) || (x==0 && y==height-1) || (y==0 && x==width-1))
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("+");
            usedspace[x,y] = true;
        }
        if(x == width/2-5 && y==1)
        {   Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("ADVENTURE MAP");
            for(int a =x ; a < x+13; a++)
            {   Console.ForegroundColor = ConsoleColor.Yellow;
                usedspace[a,y] = true;
            }
        }
        // top and bottom border
        if((x!=0 && y==0 && x!= width-1) || (x!=0 && y==height-1 && x!= width-1))
        {   Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("-");
            usedspace[x,y] = true;        
        }//side borders
        if((y!=0 && x==0 && y!=height-1) || (y!=0 && x==width-1 && y!=height-1))
        {   Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("|");
            usedspace[x,y] = true;
        }   
            //Draw roads
        if(roads[x,y]==true)
        {
            Console.ForegroundColor = ConsoleColor.White;
             Console.Write("#");
        }   //draw rivers
        if(river[x,y]==true)
        {   Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("|");
        }

        //write blank spaceses
        Console.ForegroundColor = ConsoleColor.White;
        if(usedspace[x,y] == false) Console.Write(" ");

    }
    Console.WriteLine();
}
