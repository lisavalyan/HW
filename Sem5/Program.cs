/*
int[] RandomeArray(int size)
{
int[] newArray = new int[size];
for(int i=0 ; i<size ; i++)
{

    newArray[i]= new Random().Next(100,999);
    Console.Write(newArray[i] + " ");

}

    Console.WriteLine();

return newArray;
}

int PositiveNum(int[] array)
{
   int num=0;
   
   for(int i=0 ; i<array.Length ; i++)
   {
    int ost=array[i]%2;
    if(ost<1) num += 1;
   }

   return num;

}


Console.WriteLine("Введите размер массива");
int mysize=Convert.ToInt32(Console.ReadLine());

int[] myArray= RandomeArray(mysize);
Console.WriteLine("Колличеством четных чисел массива является " + PositiveNum(myArray));

*/





/*
int[] RandomeArray(int size)
{
int[] newArray = new int[size];
for(int i=0 ; i<size ; i++)
{

    newArray[i]= new Random().Next(1,99);
    Console.Write(newArray[i] + " ");

}

    Console.WriteLine();

return newArray;
}

int NegativeNum(int[] array)
{
   int sum=0;
   
   for(int i=0 ; i<array.Length ; i++)
   {
    int ost=i%2;
    if(ost>0) sum += array[i];
   }

   return sum;

}


Console.WriteLine("Введите размер массива");
int mysize=Convert.ToInt32(Console.ReadLine());

int[] myArray= RandomeArray(mysize);
Console.WriteLine("Сумма отрицательных чисел равна " + NegativeNum(myArray));

*/





int[] RandomeArray(int size)
{
int[] newArray = new int[size];
for(int i=0 ; i<size ; i++)

{
    newArray[i]= new Random().Next(1,99);
    //double r = Convert.ToDouble(i.Next(-100, 100)/10.0);
    //Convert.ToDouble(new Random().Next(1,100)/10.0);
    //newArray[i]=new Random().Next();
    Console.Write(newArray[i] + " ");

}

    Console.WriteLine();

return newArray;
}

int MaxNum(int[] array)
{
   int max=0;
   
   for(int i=0 ; i<array.Length ; i++)
   {
    if(array[i]>max) max = array[i];
   }

   return max;

}

int MinNum(int[] array)
{
   int min=array[0];
   
   for(int i=0 ; i<array.Length ; i++)
   {
    if(array[i]<min) min = array[i];
   }

   return min;

}




Console.WriteLine("Введите размер массива");
int mysize=Convert.ToInt32(Console.ReadLine());

int[] myArray= RandomeArray(mysize);
Console.WriteLine("Разница между максимальным и минимальным элементом массива равна " + (MaxNum(myArray) - MinNum(myArray)));