/* **Задача 31:** Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
Найдите сумму отрицательных и положительных элементов массива.

Например, в массиве [3,9-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20. */



int[] array = FillArray(12, -9, 10);

Console.WriteLine($"{String.Join(", ", array)}");    // Join объединяет все эллементы коллекции использую указанный разделитель. Он берет все элементы массива разбивает его на строку и ставит тот символ, который мы укажем.

Print(array);

int pos = 0;
int neg = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
        pos += array[i];
    else
        neg += array[i];
}

System.Console.WriteLine($"pos sum = {pos}\nneg sum = {neg}");

double[] array2 = new double[12];
Print(array2);

// void Print(int[] arr)
// Переделываем метод Print() через системный класс Array
void Print(Array arr)   // Это у нас класс Array в C#, системный класс, на котором работают массивы. Грубо говоря это и есть массив. Только от этого массива строятся другие массивы. Не важно, какого размера, типа данных и пр.
{
    for (int i = 0; i < arr.Length; i++)
//        System.Console.Write($"{arr[i]} "); - заменяем эту строку на правильную, т.к. в системном классе значение массива задается методом .GetValue()
        System.Console.Write($"{arr.GetValue(i)} ");
    System.Console.WriteLine();
}

int[] FillArray(int size, int min = 0, int max = 10)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
        arr[i] = new Random().Next(min, max);
    return arr;
}