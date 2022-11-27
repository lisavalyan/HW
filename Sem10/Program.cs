// Задайте массив строк. Напишите программу, считает кол-во слов в массиве, начинающихся на гласную букву
 
 /*
string[] CreateStringArray(int size)
{
    string[] words = new string[size];

    for(int i=0; i < size; i++)
    {
        Console.Write($"Input {i +1} word: ");
        words[i] = Console.ReadLine();
    }

    return words;
}

void ShowArray(string[] array)
{
    for(int i=0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}


int NumbersOfVowels(string[] array,char A,char E,char I,char O,char U,char Y)
{
    int count = 0;

    for(int i=0; i < array.Length; i++)
       if(array[i][0] == A || array[i][0] == E || array[i][0] == I || array[i][0] == O || array[i][0] == U || array[i][0] == Y )
        count++;

    return count;     
}

Console.Write("Input number of words: ");
int size = Convert.ToInt32(Console.ReadLine());
char A = 'A'; 
char E = 'E';
char I = 'I';
char O = 'O';
char U = 'U';
char Y = 'Y'; 

string[] names = CreateStringArray(size);
Console.WriteLine("Words beginning with a vowel is " + NumbersOfVowels(names,A,E,I,O,U,Y));
*/




//Задайте массив строк. 
//Напишите программу, которая генерирует новый массив, объединяя элементы исходного массива попарно.

string[] CreateStringArray(int size)
{
    string[] words = new string[size];

    for(int i=0; i < size; i++)
    {
        Console.Write($"Input {i +1} word: ");
        words[i] = Console.ReadLine();
    }

    return words;
}

void ShowArray(string[] array)
{
    for(int i=0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

string[] Unification(string [] names, string [] words)
{ 
        for(int i=0; i < names.Length;i=i+2)
        for(int k=0; k < words.Length; k++)
        {
        words[k] = names[i] += names[i+1];
        }
    return words;
}


Console.Write("Input number of words: ");
int size = Convert.ToInt32(Console.ReadLine());

string[] names = CreateStringArray(size);

string[] words = {" "};

ShowArray(Unification(names,words));
//Пробовала по разному,но не пойму,где ошибка,почему не выводит весь массив,а только последние 2 пары.
//Очень интересно узнать все-таки конечное решение.