//Задайте значения M и N. 
//Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N

/*
Console.Write("M = ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("N = ");
int N = Convert.ToInt32(Console.ReadLine());

static int SumNumbers(int M, int N)
{
   if (M == 0) return (N * (N + 1)) / 2;            
   else if (N == 0) return (M * (M + 1)) / 2;       
   else if (M == N) return M;                       
    if (M < N) return N + SumNumbers(M, N - 1);     
   else  return N + SumNumbers(M, N + 1);           
}

Console.WriteLine($"Сумма натуральных чисел = {SumNumbers(M, N)}");
*/




//Напишите программу, которая будет принимать на вход число и возвращать кол-во его цифр.

/*
Console.Write("M = ");
int M = Convert.ToInt32(Console.ReadLine());


int num=0;
while(M/10>0 )
{
num=num+1;
M=M/10;
}
Console.Write($"Колличество цифр равно {num+1}");
*/