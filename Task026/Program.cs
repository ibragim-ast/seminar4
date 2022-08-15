// Console.WriteLine("Введите число");
// int a = Convert.ToInt32(Console.ReadLine());

int Quantity(int a)
{
    int result = 0;
    for (int number = a; number > 0; number /= 10)
    {
        result++;
    }
    return result;
}

void PrintQuantity(int a)
{
    Console.WriteLine($"Количество чисел в числе {a} равна {Quantity(a)}");
}

PrintQuantity(328889);