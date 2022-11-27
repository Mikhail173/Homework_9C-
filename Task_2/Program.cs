//  Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
Console.WriteLine("Input numbers in ascending order");
Console.WriteLine("Input m: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Input n: ");
int n = int.Parse(Console.ReadLine());

int Sum(int m, int n)
{
    if (m==n)
    {
        return n;
    } 
    return n + Sum(m,n-1);
}
Console.WriteLine("Sum of elements from "+ m +" to " + n + " is " + Sum(m, n));