/*  **Задача 67:** Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
453 -> 12
45 -> 9 */

using System;   // Выяснить что это значит

int m;
Console.Write($"Введите число M: ");
int.TryParse(Console.ReadLine(), out m);

Console.WriteLine(DigitsSum(m));

int DigitsSum(int item)
{
    if (item < 10)
        return item;
    return item % 10 + DigitsSum(item / 10);
}