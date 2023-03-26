// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine($" Введите число m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($" Введите число n");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($" A(m,n) = {Foo(m,n)}");

int Foo(int m, int n)
{
    int result = n;
    if (m == 0) return n + 1;
    else if (n==0) return Foo(m-1,1);
    else
        result = Foo(m - 1, Foo(m,n-1));
    return result;
}