/*  **Задача 65:** Задайте значение M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 5, 6, 7, 8" */

using System;   // Выяснить что это значит

int m, n;
Console.Write($"Введите число M: ");
int.TryParse(Console.ReadLine(), out m);
Console.Write($"Введите число N: ");
int.TryParse(Console.ReadLine(), out n);

Console.WriteLine($"M = {m}; N = {n} -> {PrintNumbers(m, n)}");

//  это прямая рекурсия
string PrintNumbers(int m, int n)
{
    if (m >= n)
        return m.ToString();
    return $"{m}, {PrintNumbers(m + 1, n)}";
}