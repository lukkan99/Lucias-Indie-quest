var random = new Random();
int width = 50;
int height = 50;
int numberOfRoads = 10;
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


for(int c = 0; c <= numberOfRoads; c++)
{
    GenerateRoad(roads,random.Next(0,width),random.Next(0,height),random.Next(0,4));
}

for(int a = 0; a <height; a++)
{
    int displayY = a;
    for(int b = 0; b <width; b++)
    {
    if(roads[b,displayY] == true)
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