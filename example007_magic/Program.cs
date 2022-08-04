Console.Clear();
//Console.SetCursorPosition(10,4);
//Console.WriteLine("+");

int xa=50;
int ya=1;
int xb=1;
int yb=10;
int xc=100;
int yc=10;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");


int x=xa, y=xb;
int count=0;
while(count<10000)
{
   int What=new Random().Next(0,3);//выбираем одну из 3 точек
   if(What==0) {x=(x+xa)/2;y=(y+ya)/2;}
   if(What==1) {x=(x+xb)/2;y=(y+yb)/2;}
   if(What==2) {x=(x+xc)/2;y=(y+yc)/2;}

/*Console.Write(x);
Console.Write("+");
Console.Write(y);
Console.Write("Random=");
Console.Write(What);
Console.WriteLine();*/
Console.SetCursorPosition(x, y);
Console.WriteLine("+");
count++;

}
