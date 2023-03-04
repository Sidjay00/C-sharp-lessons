/* Напишите программу, которая принимает на вход число (N) и выдает таблицу квадратов чисел от 1 до N.
5 -> 1, 4, 9, 16, 25.
2 -> 1, 4. */

int N;
Console.Write($"Введите число: ");
int.TryParse(Console.ReadLine(), out N);

Console.Write($"{N} -> ");
for (int i = 1; i <= N; i++)
{
    Console.Write($"{i * i}, ");
}