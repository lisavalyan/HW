// Задайте двумерный массив. 
//Напишите программу, которая упорядочит по возрастанию элементы каждой строки двумерного массива.
/*
int[,] RandomeArray(int m, int n, int min, int max)
{
    int[,] Matrix = new int[m,n];

    for (int i = 0; i < m; i++)
    {
       for (int j = 0; j < n; j++)
       {
        Matrix[i,j] = new Random().Next(min,max+1);
        Console.Write(Matrix[i,j] + " ");
       }
       Console.WriteLine();
    }
    return Matrix;
}

void ShowTwoDimArray(int[,] array)
{ 
    for (int i = 0; i < array.GetLength(0); i++)
    {
       for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
       Console.WriteLine();
    }
}    

int[,] IncreasingArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    for (int j = 0; j < array.GetLength(1); j++)
    for (int k = 0; k < array.GetLength(1); k++)
         {
            if (array[i, j] >= array[i, k]) continue;
                int temp = array[i, j];
                array[i, j] = array[i, k];
                array[i, k] = temp;
         }
       return array;
}
    
int[,] myArray=RandomeArray(4,4,1,100);
Console.WriteLine();
myArray=IncreasingArray(myArray);
ShowTwoDimArray(myArray);
*/




/*
//Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] RandomeArray(int m, int n, int min, int max)
{
    int[,] Matrix = new int[m,n];

    for (int i = 0; i < m; i++)
    {
       for (int j = 0; j < n; j++)
       {
        Matrix[i,j] = new Random().Next(min,max+1);
        Console.Write(Matrix[i,j] + " ");
       }
       Console.WriteLine();
    }
    return Matrix;
}

void SumArray(int[,] Matrix) 
{int minsum=0;
int sum=0;
int index=0;
        for (int i = 0; i < Matrix.GetLength(0); i++)
        {
        for (int j = 0; j < Matrix.GetLength(1); j++)
            while(j < Matrix.GetLength(1))
        {
            sum += Matrix[i, j];
        
        }
        if (i == 0)
        {
            minsum = sum;
        }
        else if (sum < minsum)
        {
            minsum = sum;
            index = i;
        }
        }
    Console.WriteLine($"Строка с минимальной суммой элементов равна {index}. ");
}

int[,] myArray=RandomeArray(7,4,1,99);
Console.WriteLine();
SumArray(myArray);
*/



