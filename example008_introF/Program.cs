/* ищем максимум из 9 чисел */

int Max(int arg1, int arg2, int arg3)
{
   int result=arg1;
   if(arg2>result) {result=arg2;}
   if(arg3>result) {result=arg3;}
   return result;

}

int a1=10;
int b1=1001;
int c1=11111;
int a2=34;
int b2=4545;
int c2=10;
int a3=12;
int b3=202;
int c3=1212;

int max1=Max(a1,b1,c1);
int max2=Max(a2,b2,c2);
int max3=Max(a3,b3,c3);

Console.WriteLine($"Maximum of all values is {Max(max1,max2,max3)}");
