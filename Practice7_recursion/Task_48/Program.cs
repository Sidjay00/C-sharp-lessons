/* **Задача 48:** Задайте двумерный массив размером mxn, каждый элемент в массиве находится по формуле: А(i,j) = i + j.
Выведите полученный массив на экран

 m = 3, n = 4.

 0 1 2 3
 1 2 3 4
 2 3 4 5  */

 int[,] array = new int[3, 4];

 for (int i = 0; i < array.GetLength(0); i++) //Строки
    for (int j = 0; j < array.GetLength(1); j++) // Столбцы
        array[i, j] = i + j;

PrintArray(array);

 void PrintArray(Array arr) //Задаем функцию для печати массивов: одномерного, двухмерного и трехмерного. В скобочках обозначается, что на ввод берется массив Array <имя переменной>
 {
    switch (arr.Rank)   // Новый метод switch, не помню, когда нам его давали, но похоже он просто переключает внутри себя, когда определяет, по какому case надо работать. .Rank - определяет размер массива, как я понял.
    {
        case 1:
            for (int i = 0; i < arr.GetLength(0); i++) // Строка одномерного массива
                Console.Write($"{arr.GetValue(i)} ");
            break;
        case 2:
            for (int i = 0; i < arr.GetLength(0); i++) // Строки
            {
                for (int j = 0; j < arr.GetLength(1); j++) // Столбцы
                    Console.Write($"{arr.GetValue(i, j)} ");
                Console.WriteLine();
            }
            break;
        case 3:
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    for (int k = 0; k < arr.GetLength(2); k++)
                        Console.Write($"{arr.GetValue(i, j, k)} ");
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            break;
    }
 }