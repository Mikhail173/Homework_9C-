//  Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Input m : ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Input n : ");
int n = int.Parse(Console.ReadLine());

int Akk(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    } 
    if (m != 0 & n == 0)
    {
        return Akk(m - 1, 1);
    }    
    if (m > 0 & n > 0)
    {
        return Akk(m - 1, Akk(m, n - 1));
    } 
    return Akk(m,n);
}
Console.WriteLine("Ackermann's function : " + Akk(m, n));