/* Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D плоскости
A (3,6); B (2,1) -> 5,09
A (7,-5); B (1,-1) -> 7,21 */

// Что такое массив, и как он работает? Это упорядоченный набор элементов, который каждый у нас пронумерован.

double[] A = new double[2]; // создали новый массив с двумя элементами.
double[] B = new double[2];

Console.Write($"Введите координату x точки А: ");
double.TryParse(Console.ReadLine(), out A[0]);
Console.Write($"Введите координату y точки А: ");
double.TryParse(Console.ReadLine(), out A[1]);
Console.Write($"Введите координату x точки B: ");
double.TryParse(Console.ReadLine(), out B[0]);
Console.Write($"Введите координату y точки B: ");
double.TryParse(Console.ReadLine(), out B[1]);

double ans = Math.Round(Math.Sqrt(Math.Pow(A[0] - B[0], 2) + Math.Pow(A[1] - B[1], 2)), 3);

System.Console.WriteLine($"A({A[0]};{A[1]}) B({B[0]};{B[1]}) -> {ans}");