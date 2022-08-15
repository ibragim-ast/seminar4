//Напишите программу, которая принимает на вход число N и выдает произведение чисел от 1 до N

int Sum(int a)
{
    int result = 1;
    for (int number = 1; number <= a; number++)
    {
        result *= number;
    }
    return result;
}
void PrintSum(int a)
{
    Console.WriteLine($"Произведение чисел от 1 до {a} равна {Sum(a)}");
}
PrintSum(6);
