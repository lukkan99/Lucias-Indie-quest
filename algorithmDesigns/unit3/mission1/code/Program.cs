//int random
var random = new Random();
//set how big area map suld be
int width = 45;
int height = 18;

//declear 2d arrys for all calc
var forrest = new bool[width, height];
var roads = new bool[width, height];
var river = new bool[width, height];
var riverright = new bool[width, height];
var riverleft = new bool[width, height];
var bidge = new bool[width, height];
var usedspace = new bool[width, height];

//data perpering stage
for (int y = 0; y < height; y++)
{
    for (int x = 0; x < width; x++)
    {  //gen river
    
        if(y==1&&x==width-6)
        {
            int riverx = x;
            for(int b = y; b < height-1; b++)
            {   //pick if go leftdown or rightdown or only down
                int riverdirection = random.Next(0,3);
                //seting data for how river following
                switch(riverdirection)
                {
                case 0:
                    for(int a = riverx; a > riverx-3; a--)
                    {
                    river[a,b] = true;
                    usedspace[a,b] = true;
                    }
                break;
                case 1:
                    riverx--;
                    for(int a = riverx; a > riverx-3; a--)
                    {
                    riverleft[a,b] = true;
                    usedspace[a,b] = true;
                    }
                break;
                case 2:
                    if(riverx==width-2)
                {
                    for(int a = riverx; a > riverx-3; a--)
                    {
                        river[a,b] = true;
                        usedspace[a,b] = true;
                    }
                }
                else
                {
                    riverx++;
                    for(int a = riverx; a > riverx-3; a--)
                    {
                    riverright[a,b] = true;
                    usedspace[a,b] = true;
                    }
                }
                break;
                    
                }
            }
            
        }

        //gen roads
        bool pastfirstwatetile = false;
        if(y==height/2 && x == 0)
        {   
            int roadY = y;
            
            for(int a=x; a<width-1; a++)
            {
                if(river[a,roadY]==true||riverleft[a,roadY]||riverright[a,roadY])
                {   //second road
                    if(pastfirstwatetile == false)
                    {
                        pastfirstwatetile= true;
                        int newroadx = a-2;
                        int newroady= roadY;
                        for(int NewA = newroady; NewA < height-1; NewA++)
                        {   if(river[newroadx,NewA]||riverleft[newroadx,NewA]||river[newroadx,NewA])
                            {newroadx--;}
                            else
                            {
                                switch(random.Next(1,4))
                                {
                                case 1:
                                break;
                                case 2:
                                newroadx++;
                                break;
                                case 3:
                                newroadx--;
                                break;
                                }
                            }
                            if(river[newroadx,NewA]==true){river[newroadx,NewA]=false;}
                            if(riverleft[newroadx,NewA]==true){riverleft[newroadx,NewA]=false;}
                            if(riverright[newroadx,NewA]==true){riverright[newroadx,NewA]=false;}
                            roads[newroadx,NewA] = true;
                            forrest[newroadx,NewA] = false;
                            usedspace[newroadx,NewA] = true;
                        }
                    }
                    riverleft[a,roadY]=false;
                    riverleft[a,roadY-1]=false; riverleft[a-1,roadY-1]=false; riverleft[a+1,roadY-1]=false;
                    riverleft[a,roadY+1]=false; riverleft[a-1,roadY+1]=false; riverleft[a+1,roadY+1]=false;
                    riverright[a,roadY+1]=false; riverright[a-1,roadY+1]=false; riverright[a+1,roadY+1]=false;
                    riverright[a,roadY-1]=false; riverright[a-1,roadY-1]=false; riverright[a+1,roadY-1]=false;
                    riverright[a,roadY]=false;
                    river[a,roadY]=false;
                    river[a,roadY-1]=false; river[a-1,roadY-1]=false; river[a+1,roadY-1]=false;
                    river[a,roadY+1]=false; river[a-1,roadY+1]=false; river[a+1,roadY+1]=false;
                    bidge[a,roadY-1]=true;
                    bidge[a,roadY+1]=true; 
                    roads[a,roadY] =true;
                    forrest[a,roadY] = false;
                    usedspace[a,roadY] =true;


                }
                else
                {
                    int roaddirection = random.Next(0,3);
                    switch(roaddirection)
                    {
                        case 0:
                        //if(river[a,roadY]==true){river[a,roadY]=false;}
                        //if(riverleft[a,roadY]==true){riverleft[a,roadY]=false;}
                        //if(riverright[a,roadY]==true){riverright[a,roadY]=false;}
                        roads[a,roadY] = true;
                        forrest[a,roadY] = false;
                        usedspace[a,roadY]= true;
                        break;
                        case 1:
                        roadY++;
                        //if(river[a,roadY]==true){river[a,roadY]=false;}
                        //if(riverleft[a,roadY]==true){riverleft[a,roadY]=false;}
                        //if(riverright[a,roadY]==true){riverright[a,roadY]=false;}
                        roads[a,roadY] = true;
                        forrest[a,roadY] = false;
                        usedspace[a,roadY]= true;
                        break;
                        case 2:
                        roadY--;
                        //if(river[a,roadY]==true){river[a,roadY]=false;}
                        //if(riverleft[a,roadY]==true){riverleft[a,roadY]=false;}
                        //if(riverright[a,roadY]==true){riverright[a,roadY]=false;}
                        roads[a,roadY] = true;
                        forrest[a,roadY] = false;
                        usedspace[a,roadY]= true;
                        break;
                    }
                }
            }
        } //gen forrest
        if((x<width/5) && roads[x,y] == false && y!=0 && y!=height-1 && usedspace[x,y]==false)
        {   
            
            if(random.Next(0,x)< 1)
            {
            forrest[x,y] = true;
            usedspace[x,y] = true;
            }
            
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
           //draw rivers
        if(river[x,y]==true)
        {   Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("|");
        }
        if(riverleft[x,y]==true)
        {   Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("/");
        }
        if(riverright[x,y]==true)
        {   Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("\\");
        }   //drawing roads
        if(roads[x,y]==true)
        {
            Console.ForegroundColor = ConsoleColor.White;
             Console.Write("#");
        } //draw forrest
        if(forrest[x,y]==true)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("A");
        }
        if(bidge[x,y]==true)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("=");
        }

        //write blank spaceses
        Console.ForegroundColor = ConsoleColor.White;
        if(usedspace[x,y] == false) Console.Write(" ");

    }
    Console.WriteLine();
}
