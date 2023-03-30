/*  **Задача 63:** Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6" */

using System;   // Выяснить что это значит

int m, n;
Console.Write($"Введите число: ");
int.TryParse(Console.ReadLine(), out n);

Console.WriteLine($"N = {n} -> {PrintNumbers(n)}");

string PrintNumbers(int n, int i = 1)
{
    if (i >= n)
        return i.ToString();
    return $"{i}, {PrintNumbers(n, i + 1)}";
}