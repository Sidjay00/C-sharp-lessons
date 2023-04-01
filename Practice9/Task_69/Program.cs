/*  **Задача 69:** Напишите программу, которая на вход принимает два числа A и B, и возводит числа A в степень B с помощью рекурсии.

А = 3; В = 5 -> 243 (3^5)
А = 2; В = 3 -> 8 (3^5) */

using System;   // Выяснить что это значит

int m, n;
Console.Write($"Введите число M: ");
int.TryParse(Console.ReadLine(), out m);
Console.Write($"Введите число N: ");
int.TryParse(Console.ReadLine(), out n);

Console.WriteLine($"{Pow(m, n)}");

double Pow(double a, int b) => b < 0 ? PowN(a, b) : PowP(a, b); //  Запись через тернарную операцию и лямбдой.
    // if (b < 0)
    //     return PowN(a, b);
    // else
    //     return PowP(a, b);

double PowP(double a, int b)
{
    if (b == 0)
        return 1;
    if (b == 1)
        return a;
    return a * PowP(a, b - 1);
}

double PowN(double a, int b)
{
    if (b == -1)
        return 1 / a;
    return (double)1 / a * (double)Pow(a, b + 1);
}