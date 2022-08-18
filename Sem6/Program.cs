/*
Console.WriteLine("Введите числа ");
int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int count = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)

    {
        count++;
    }

}
 
Console.WriteLine($"Колличество положительных чисел {count}");
*/






    
        int[] array = { 7, 2, 6, 0, 1, 4 };
 
        int[] copyarr = new int[array.Length];

        for (int i = 0; i < array.Length; i++)
       {
            copyarr[i] = array[i];
        }
 
        Console.WriteLine(String.Join(", ", copyarr));     
    
