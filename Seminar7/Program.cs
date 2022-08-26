//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами
/*
int[,] RandomeArray(int a, int b, int min, int max)
{
    int[,] Matrix = new int[a,b];

    for (int i = 0; i < a; i++)
    {
       for (int j = 0; j < b; j++)
       {
        Matrix[i,j] = new Random().Next(min,max+1);
        Console.Write(Matrix[i,j] + " ");
       }
       Console.WriteLine();
    }
    return Matrix;
}

int[,] array = RandomeArray(3, 4, -100, 100);
*/


//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//и возвращает значение этого элемента или же указание, что такого элемента нет.
/*
int[,] RandomeArray(int a, int b, int min, int max)
{
    int[,] Matrix = new int[a,b];

    for (int i = 0; i < a; i++)
    {
       for (int j = 0; j < b; j++)
       {
        Matrix[i,j] = new Random().Next(min,max+1);
        Console.Write(Matrix[i,j] + " ");
       }
       Console.WriteLine();
    }
    return Matrix;
    
}

Console.WriteLine("Введите индекс строки");
int line=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите индекс столбца");
int post=Convert.ToInt32(Console.ReadLine());

int[,] array = RandomeArray(6, 7, -100, 100);

if (line < 0 && line > array.GetLength(0) - 1 && post < 0 && post > array.GetLength(1) - 1)
    {
        Console.WriteLine("Элемент не существует");
    }
else
    {
        Console.WriteLine(array[line-1,post-1]);
    }

*/




//Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.

int[,] RandomeArray(int a, int b, int min, int max)
{
    int[,] Matrix = new int[a,b];

    for (int i = 0; i < a; i++)
    {
       for (int j = 0; j < b; j++)
       {
        Matrix[i,j] = new Random().Next(min,max+1);
        Console.Write(Matrix[i,j] + " ");
       }
       Console.WriteLine();
    }
    return Matrix;
}

int[,] array = RandomeArray(3, 4, 0, 100);

for (int j = 0; j < array.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum += array[i, j];
    }
    Console.Write(sum / array.GetLength(0) + " " );
}
Console.ReadLine();
