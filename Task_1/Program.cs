//  Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Input natural number: ");
int n = int.Parse(Console.ReadLine());
int a = 1;

int Natural (int n, int a)
{
    if (n == a)
    {
        return n;
    }
    else
    {
    Console.Write(Natural(n, a+1) + ", ");
    }
    return a;
}
Console.WriteLine(Natural(n, a));