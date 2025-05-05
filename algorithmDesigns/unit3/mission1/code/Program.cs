var random = new Random();
int width = 35;
int height = 16;

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

        if(roads[x,y]==true) Console.Write("#");

        //write blank spaceses
        if(usedspace[x,y] == false) Console.Write(" ");

    }
    Console.WriteLine();
}
