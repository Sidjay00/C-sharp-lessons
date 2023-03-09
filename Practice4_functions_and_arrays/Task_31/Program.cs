/* **Задача 31:** Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
Найдите сумму отрицательных и положительных элементов массива.

Например, в массиве [3,9-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20. */



int[] array = FillArray(12, -9, 10);
Print(array);







void Print(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        System.Console.Write($"{arr[i]} ");
    System.Console.WriteLine();
}

int[] FillArray(int size, int min = 0, int max = 10)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
        arr[i] = new Random().Next(min, max);
    return arr;
}