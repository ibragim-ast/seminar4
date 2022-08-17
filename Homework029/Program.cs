// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.


void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(0, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(col[position]);
        Console.Write(" ");
        position++;
    }
}

int[] array = new int[8];

FillArray(array);
PrintArray(array);
Console.WriteLine(" ");

