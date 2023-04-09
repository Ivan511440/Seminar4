// Задайте массив заполненный случайными, положительными, трехзначными числами.
// Напищите программу, которая покажет количество четных чисел в масстве.

// [345, 897, 568, 234] → 2

Console.Write("Введите количество элементов массива: ");
int a = Convert.ToInt32(Console.ReadLine());
int[] RandomArray = new int[a];

void mas(int a)
{
    for (int i = 0; i < a; i++ )
    {
        RandomArray[i] = new Random().Next(99,999);
        Console.Write(RandomArray[i] + "");
    }
}
int kol(int[] RandomArray)
{
    int kol = 0;
    for (int i = 0; i < RandomArray.Length; i++)
    {
       if(RandomArray[i] % 2 == 0)
       kol = kol + 1;
    }
       return kol;
}
mas(a);
Console.Write("");
Console.WriteLine($"\nКоличество четных чисел в массиве: {kol(RandomArray)}" );







