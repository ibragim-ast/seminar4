// //Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.WriteLine("Введите число");
int digit = Convert.ToInt32(Console.ReadLine());

int Sum(int a)
{
    int rem = 0;
    while (a > 0)
    {
        rem = rem + a % 10;
        a = a / 10;
    }
    return rem;
}

void PrintSum(int a)
{
    Console.WriteLine($"Сумма цифр в числе {a} = {Sum(a)}");
}

PrintSum(digit);




