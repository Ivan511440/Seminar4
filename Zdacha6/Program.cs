// Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементами массива.

// [3,7,22,2,78] → 76

using static System.Console;
Console.Clear();
Console.Write("Введите размер массива: ");
int length = int.Parse(ReadLine()!);
Console.Write("Введите минимальное значение массива: ");
int min = int.Parse(ReadLine()!);
Console.Write("Введите максимальное значение массива: ");
int max = int.Parse(ReadLine()!);
int[] Array = GetArray(length, min, max);
Console.WriteLine($"[{string.Join(", ", Array)}]");
FindDifference(Array, max, min);

int[] GetArray(int size, int minValue, int maxValue)

{
    Random rnd = new Random();
    int[] result = new int[size];
    for(int i = 0; i <result.Length; i++)
    {
        result[i] = rnd.Next(minValue, maxValue + 1);
    }
    return result;
}

void FindDifference(int[] MyArray, int minValue,int maxValue)
{
   for (int i = 0; i < MyArray.Length; i++)
   {
    if (MyArray[i] < minValue)
    {
       minValue=MyArray[i];   
    }
    if (MyArray[i] > maxValue)
    {
        maxValue=MyArray[i];
    }

   }
   Console.WriteLine($"Разница {maxValue-minValue}");
}


