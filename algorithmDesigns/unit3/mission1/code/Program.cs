﻿//int random
var random = new Random();
//set how big area map suld be
int width = 40;
int height = 18;

//declear 2d arrys for all calc
var forrest = new bool[width, height];
var roads = new bool[width, height];
var river = new bool[width, height];
var riverright = new bool[width, height];
var riverleft = new bool[width, height];
var bidge = new bool[width, height];


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
                    }
                break;
                case 1:
                    riverx--;
                    for(int a = riverx; a > riverx-3; a--)
                    {
                    riverleft[a,b] = true;
                    }
                break;
                case 2:
                    if(riverx==width-2)
                {
                    for(int a = riverx; a > riverx-3; a--)
                    {
                        river[a,b] = true;
                    }
                }
                else
                {
                    riverx++;
                    for(int a = riverx; a > riverx-3; a--)
                    {
                    riverright[a,b] = true;
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
                {   //second road and bridg
                    if(pastfirstwatetile == false)
                    {
                        pastfirstwatetile= true;
                        int bridgex = a-1;
                        for(int bridgea = bridgex; bridgea<a+4&&bridgex!=width-2; bridgea++)
                        {
                            if(river[bridgea,roadY+1]==true ||river[bridgea,roadY-1]==true||riverleft[bridgea,roadY+1]==true ||riverleft[bridgea,roadY-1]==true||riverright[bridgea,roadY+1]==true ||riverright[bridgea,roadY-1]==true)
                            {
                                river[bridgea,roadY+1]=false;
                                river[bridgea,roadY-1]=false;
                                riverleft[bridgea,roadY+1]=false;
                                riverleft[bridgea,roadY-1]=false;
                                riverright[bridgea,roadY+1]=false;
                                riverright[bridgea,roadY-1]=false;
                            }
                            if(roadY+1!=height-1)
                            {
                            bidge[bridgea,roadY+1]=true;
                            }
                            if(roadY-1!=0)
                            {
                            bidge[bridgea,roadY-1]=true;
                            }
                        
                        }
                        
                        int newroadx = a-2;
                        int newroady= roadY;
                        for(int NewA = newroady; NewA < height-1; NewA++)
                        {   if(river[newroadx,NewA]||riverleft[newroadx,NewA]||river[newroadx,NewA]||bidge[newroadx,NewA])
                            {newroadx--;}
                            else
                            {
                                switch(random.Next(1,6))
                                {
                                case 2:
                                newroadx++;
                                break;
                                case 3:
                                case 4:
                                case 5:
                                newroadx--;
                                break;
                                }
                            }
                            if(river[newroadx,NewA]==true){river[newroadx,NewA]=false;}
                            if(riverleft[newroadx,NewA]==true){riverleft[newroadx,NewA]=false;}
                            if(riverright[newroadx,NewA]==true){riverright[newroadx,NewA]=false;}
                            roads[newroadx,NewA] = true;
                            forrest[newroadx,NewA] = false;
                        }
                    }
                    riverleft[a,roadY]=false;
                    //riverleft[a,roadY-1]=false; riverleft[a-1,roadY-1]=false; riverleft[a+1,roadY-1]=false;
                   // riverleft[a,roadY+1]=false; riverleft[a-1,roadY+1]=false; riverleft[a+1,roadY+1]=false;
                    //riverright[a,roadY+1]=false; riverright[a-1,roadY+1]=false; riverright[a+1,roadY+1]=false;
                    //riverright[a,roadY-1]=false; riverright[a-1,roadY-1]=false; riverright[a+1,roadY-1]=false;
                    riverright[a,roadY]=false;
                    river[a,roadY]=false;
                    //river[a,roadY-1]=false; river[a-1,roadY-1]=false; river[a+1,roadY-1]=false;
                    //river[a,roadY+1]=false; river[a-1,roadY+1]=false; river[a+1,roadY+1]=false;
                    //bidge[a,roadY-1]=true;
                    //bidge[a,roadY+1]=true; 
                    roads[a,roadY] =true;
                    forrest[a,roadY] = false;
                    //usedspace[a,roadY-1]=true;
                    //usedspace[a,roadY+1]=true;


                }
                else if(bidge[a,roadY-1])
                {
                    roads[a,roadY] = true;
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
                        break;
                        case 1:
                        if(roadY!<height-2)roadY++;
                        
                        //if(river[a,roadY]==true){river[a,roadY]=false;}
                        //if(riverleft[a,roadY]==true){riverleft[a,roadY]=false;}
                        //if(riverright[a,roadY]==true){riverright[a,roadY]=false;}
                        roads[a,roadY] = true;
                        forrest[a,roadY] = false;
                        break;
                        case 2:
                        if(roadY!> 2)roadY--;
                        //if(river[a,roadY]==true){river[a,roadY]=false;}
                        //if(riverleft[a,roadY]==true){riverleft[a,roadY]=false;}
                        //if(riverright[a,roadY]==true){riverright[a,roadY]=false;}
                        roads[a,roadY] = true;
                        forrest[a,roadY] = false;
                        break;
                    }
                }
            }
        } //gen forrest
        if((x<width/5) && roads[x,y] == false && y!=0 && y!=height-1)
        {   
            
            if(random.Next(0,x)< 1)
            {
            forrest[x,y] = true;
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
            continue;
        }
        if(x == width/2-5 && y==1)
        {   Console.ForegroundColor = ConsoleColor.Yellow;
            string title = "ADVENTURE MAP";
            Console.Write(title);
            x += title.Length - 1;
            continue;
        }
        // top and bottom border
        if((x!=0 && y==0 && x!= width-1) || (x!=0 && y==height-1 && x!= width-1))
        {   Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("-"); 
            continue;      
        }//side borders
        if((y!=0 && x==0 && y!=height-1) || (y!=0 && x==width-1 && y!=height-1))
        {   Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("|");
            continue;
        }   
           //draw rivers
        if(river[x,y]==true)
        {   Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("|");
            continue;
        }
        if(riverleft[x,y]==true)
        {   Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("/");
            continue;
        }
        if(riverright[x,y]==true)
        {   Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("\\");
            continue;
        }   //drawing roads
        if(roads[x,y]==true)
        {
            Console.ForegroundColor = ConsoleColor.White;
             Console.Write("#");
             continue;
        } //draw forrest
        if(forrest[x,y]==true)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("A");
            continue;
        }
        if(bidge[x,y]==true)
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("=");
            continue;
        }

        //write blank spaceses
        Console.ForegroundColor = ConsoleColor.White;
        //if(usedspace[x,y] == false) Console.Write(" ");
        Console.Write(" ");

    }
    Console.WriteLine();
}
