// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите натуральное число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите натуральное число: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"A({a}, {b}) = {funcAkkerman(a, b)}");

int funcAkkerman(int a, int b)
{
    if (a == 0)
        return b + 1;
    if (a > 0 && b == 0)
        return funcAkkerman(a - 1, 1);
    else
        return funcAkkerman(a - 1, funcAkkerman(a, b - 1));
}