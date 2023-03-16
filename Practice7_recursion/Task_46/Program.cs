/* **Задача 46:** Задайте двумерный массив размером mxn, заполненный целыми числами.

 m = 3, n = 4.
 1 4 8 19
 5 -2 33 -2
 77 3 8 1 */

 int[,] array = new int[3, 4];
 for (int i = 0; i < array.GetLength(0); i++) //Строки
 {
    for (int j = 0; j < array.GetLength(1); j++) // Столбцы
    {
        array[i, j] = new Random().Next(10);
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
 }