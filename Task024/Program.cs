// Напишите программу, которая принимает на вход число (А) и выдает сумму чисел от 1 до А
int Sum(int a)
{
    int result = 0;
    for (int number = 0; number <= a; number++)
    {
        result += number;
    }
    return result;
}

void PrintSum(int a)
{
    Console.WriteLine($"Сумма чисел от 1 до {a} равна {Sum(a)}");
}

PrintSum(55);