/* первый вариант решения


Console.WriteLine("Введите пятизначное число");
int num=Convert.ToInt32(Console.ReadLine());
if(num>=1000 && num<=99999)
{ int n1, gap2, n2, gap4, n4, n5;

n1=num/10000;
gap2=num/1000;
n2=gap2%10;
gap4=num%100;
n4=gap4/10;
n5=num%10;

if(n1==n5 && n2==n4)
{
Console.WriteLine("Число является палиндромом");
}
else
{
Console.WriteLine("Число не является палиндромом");
}
}
else
{
Console.WriteLine("Число не является пятизначным");
}
*/


/* второй вариант решения


int Palindrome(int num)
{
if(num>=1000 && num<=99999)
{ int n1, gap2, n2, gap4, n4, n5;

n1=num/10000;
gap2=num/1000;
n2=gap2%10;
gap4=num%100;
n4=gap4/10;
n5=num%10;

if(n1==n5 && n2==n4)
{
return 0;
}
else
{
return 1;
}
}
else
{
return -1;
}
}

Console.WriteLine("Введите пятизначное число");
int a=Convert.ToInt32(Console.ReadLine());

int result=Palindrome(a);

if(result == -1)
{
Console.WriteLine("Число не пятизначное");
}

if(result == 1)
{
Console.WriteLine("Число не является палиндромом");
}

if(result == 0)
{
Console.WriteLine("Число является палиндромом");
}
*/






/*
Console.WriteLine("Введите координату x первой точки");
double x1=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату y первой точки");
double y1=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату z первой точки");
double z1=Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Введите координату x второй точки");
double x2=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату y второй точки");
double y2=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату z второй точки");
double z2=Convert.ToInt32(Console.ReadLine());

double FindLenght(double x1, double y1, double z1, double x2, double y2, double z2)
{
return Math.Sqrt(Math.Pow((x2-x1),2)+Math.Pow((y2-y1),2)+Math.Pow((z2-z1),2));
}

double result=FindLenght( x1, y1, z1, x2, y2, z2);

Console.WriteLine($"Расстояние между точками {result}");
*/



/*
Console.WriteLine("Введите число");
int num=Convert.ToInt32(Console.ReadLine());

int current=1;

while (current<=num)
{
Console.Write((current*current*current) + " ");
current++;
}
*/

