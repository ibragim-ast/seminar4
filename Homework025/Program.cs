//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.WriteLine("Введите число А");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число В");
int b = Convert.ToInt32(Console.ReadLine());
int result = 1;

void Exponentiation(int digit1, int digit2)
{
    for (int index = 0; index < digit2; index++)
    {
        result *= digit1;
    }
   
}

void PrintExponentiation(int col, int tol)
{
int final = result;
{
         Console.WriteLine($"{a} в {b} степени = {final}");
}
}
Exponentiation(a, b);
PrintExponentiation(a, b);



