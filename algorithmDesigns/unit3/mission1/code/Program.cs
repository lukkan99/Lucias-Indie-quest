//int random
var random = new Random();
//set how big area map suld be
int width = 40;
int height = 18;

//declear 2d arrys for all calc
var tiles = new string[width, height]; //ri1(river) ri2(riverleft) ri3(riverright) fo(forrest) ro(roads) bi(brige)
//var forrest = new bool[width, height];
//var roads = new bool[width, height];
//var river = new int[width, height];//down 1 left 2 right 3
//var bidge = new bool[width, height];


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
                    tiles[a,b] = "ri1";
                    }
                break;
                case 1:
                    riverx--;
                    for(int a = riverx; a > riverx-3; a--)
                    {
                    tiles[a,b] = "ri2";
                    }
                break;
                case 2:
                    if(riverx==width-2)
                {
                    for(int a = riverx; a > riverx-3; a--)
                    {
                        tiles[a,b] = "ri1";
                    }
                }
                else
                {
                    riverx++;
                    for(int a = riverx; a > riverx-3; a--)
                    {
                    tiles[a,b] = "ri3";
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
                if(tiles[a,roadY]=="ri1"||tiles[a,roadY]=="ri2"||tiles[a,roadY]=="ri3")
                {   //second road and bridg
                    if(pastfirstwatetile == false)
                    {
                        pastfirstwatetile= true;
                        int bridgex = a-1;
                        for(int bridgea = bridgex; bridgea<a+4&&bridgex!=width-2; bridgea++)
                        {
                            if(tiles[bridgea,roadY+1]=="ri1" ||tiles[bridgea,roadY-1]=="ri1"||tiles[bridgea,roadY+1]=="ri2" ||tiles[bridgea,roadY-1]=="ri2"||tiles[bridgea,roadY+1]=="ri3" ||tiles[bridgea,roadY-1]=="ri3")
                            {
                                //river[bridgea,roadY+1]=0;
                                //river[bridgea,roadY-1]=0;
                            }
                            if(roadY+1!=height-1)
                            {
                            tiles[bridgea,roadY+1]="bi";
                            }
                            if(roadY-1!=0)
                            {
                            tiles[bridgea,roadY-1]="bi";
                            }
                        
                        }
                        
                        int newroadx = a-2;
                        int newroady= roadY;
                        for(int NewA = newroady; NewA < height-1; NewA++)
                        {   if(tiles[newroadx,NewA]=="ri1"||tiles[newroadx,NewA]=="ri2"||tiles[newroadx,NewA]=="ri1"||tiles[newroadx,NewA]=="bi")
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
                            //if(river[newroadx,NewA]==1){river[newroadx,NewA]=0;}
                            //if(river[newroadx,NewA]==2){river[newroadx,NewA]=0;}
                            //if(river[newroadx,NewA]==3){river[newroadx,NewA]=0;}
                            tiles[newroadx,NewA] = "ro";
                            //forrest[newroadx,NewA] = false;
                        }
                    }
                
                    //riverleft[a,roadY-1]=false; riverleft[a-1,roadY-1]=false; riverleft[a+1,roadY-1]=false;
                   // riverleft[a,roadY+1]=false; riverleft[a-1,roadY+1]=false; riverleft[a+1,roadY+1]=false;
                    //riverright[a,roadY+1]=false; riverright[a-1,roadY+1]=false; riverright[a+1,roadY+1]=false;
                    //riverright[a,roadY-1]=false; riverright[a-1,roadY-1]=false; riverright[a+1,roadY-1]=false;
                    
                    //river[a,roadY]=0;
                    //river[a,roadY-1]=false; river[a-1,roadY-1]=false; river[a+1,roadY-1]=false;
                    //river[a,roadY+1]=false; river[a-1,roadY+1]=false; river[a+1,roadY+1]=false;
                    //bidge[a,roadY-1]=true;
                    //bidge[a,roadY+1]=true; 
                    tiles[a,roadY] ="ro";
                    //forrest[a,roadY] = false;
                    //usedspace[a,roadY-1]=true;
                    //usedspace[a,roadY+1]=true;


                }
                else if(tiles[a,roadY-1]=="bi")
                {
                    tiles[a,roadY] = "ro";
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
                        tiles[a,roadY] = "ro";
                        //forrest[a,roadY] = false;
                        break;
                        case 1:
                        if(roadY!<height-2)roadY++;
                        
                        //if(river[a,roadY]==true){river[a,roadY]=false;}
                        //if(riverleft[a,roadY]==true){riverleft[a,roadY]=false;}
                        //if(riverright[a,roadY]==true){riverright[a,roadY]=false;}
                        tiles[a,roadY] = "ro";
                        //forrest[a,roadY] = false;
                        break;
                        case 2:
                        if(roadY!> 2)roadY--;
                        //if(river[a,roadY]==true){river[a,roadY]=false;}
                        //if(riverleft[a,roadY]==true){riverleft[a,roadY]=false;}
                        //if(riverright[a,roadY]==true){riverright[a,roadY]=false;}
                        tiles[a,roadY] = "ro";
                        //forrest[a,roadY] = false;
                        break;
                    }
                }
            }
        } //gen forrest
        if((x<width/5) && tiles[x,y] != "ro" && y!=0 && y!=height-1)
        {   
            
            if(random.Next(0,x)< 1)
            {
            tiles[x,y] = "fo";
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
        if(tiles[x,y]=="ri1")
        {   Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("|");
            continue;
        }
        if(tiles[x,y]=="ri2")
        {   Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("/");
            continue;
        }
        if(tiles[x,y]=="ri3")
        {   Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("\\");
            continue;
        }   //drawing roads
        if(tiles[x,y]=="ro")
        {
            Console.ForegroundColor = ConsoleColor.White;
             Console.Write("#");
             continue;
        } //draw forrest
        if(tiles[x,y]=="fo")
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("A");
            continue;
        }
        if(tiles[x,y]=="bi")
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
