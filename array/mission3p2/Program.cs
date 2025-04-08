var random = new Random();
int width = 100;
int height = 100;
int numberOfRoads = 0;
int numberOIntersection = 10;
var roads = new bool[width, height];

static void GenerateRoad(bool[,] roads, int startX, int startY, int direction)
{
    int x = startX;
    int y = startY;
switch (direction)
{
    case 0:
    while(x < roads.GetLength(0))
    {
        roads[x,y] = true;
        x=x + 1;
    }  
    break;
    case 1:
    while(y < roads.GetLength(1))
    {
        roads[x,y] = true;
        y = y+1;
    }
    break;
    case 2:
    while(x > 0)
    {
        roads[x,y] = true;
        x= x-1;
    }
    break;
    case 3:
    while(y > 0)
    {
        roads[x,y] = true;
        y = y-1;
    }
    break;
}
}

static void GenerateIntersection(bool[,] roads, int x, int y)
{
    var random = new Random();
    for(int d = 0; d < 3; d++)
    {
        int rate = random.Next(1,11);
        if(rate > 3)
        {
            GenerateRoad(roads,x,y,d);
        }

    }
}

for(int c = 0; c < numberOIntersection; c++)
{
    GenerateIntersection(roads,random.Next(0,width),random.Next(0,height));
}


for(int c = 0; c < numberOfRoads; c++)
{
    GenerateRoad(roads,random.Next(0,width),random.Next(0,height),random.Next(0,4));
}

for(int a = 0; a <height; a++)
{
    for(int b = 0; b <width; b++)
    {
    if(roads[b,a] == true)
    {
        Console.Write("#");
    }
    else
    {
        Console.Write("⠀");
    }
    }
    Console.Write("\n");
}