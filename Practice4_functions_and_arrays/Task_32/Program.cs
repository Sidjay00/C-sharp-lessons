﻿/* **Задача 32:** Напишите программу замена элементов массива:
положительные элементы замените на соответствующие отрицательные, и наоборот.

[-4.-8.8.2] -> [4.8.-8.-2] */

int[] array = FillArray(12, -9, 10);

Console.WriteLine($"{String.Join(", ", array)}");
InverseElements(array);
// Console.WriteLine($"{String.Join(", ", InverseElements(array))}"); - специальная ошибка, допущенная на практике, функция вызывается второй раз
Console.WriteLine($"{String.Join(", ", array)}");

// int[] InverseElements(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//         arr[i] *= -1;
//     return arr;
// }

// Данный метод для ссылочных типов данных можно записать через void

void InverseElements(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        arr[i] *= -1;
}

int[] FillArray(int size, int min = 0, int max = 10)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
        arr[i] = new Random().Next(min, max);
    return arr;
}