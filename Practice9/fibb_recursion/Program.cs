using System;

int m, n;
Console.Write($"Введите число M: ");
int.TryParse(Console.ReadLine(), out m);
// Console.Write($"Введите число N: ");
// int.TryParse(Console.ReadLine(), out n);

// Console.WriteLine($"M = {m}; N = {n} -> {PrintNumbers(m, n)}");

//  это прямая рекурсия
// string PrintNumbers(int m, int n)
// {
//     if (m >= n)
//         return m.ToString();
//     return $"{m}, {PrintNumbers(m + 1, n)}";
// }

Console.WriteLine(Fibb(m));

//  а вот это обратная рекурсия
int Fibb(int item)
{
    if (item < 0)
        return -1;
    if (item <= 1)
        return item;
    return Fibb(item - 1) + Fibb(item - 2); // Нельзя вызывать рекурсию без изменения переменной Fibb(item), иначе будет зацикливание - stack overflow
}