/* **Задача 55: **  Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
В случае, если это невозможно, программа должны вывести сообщение для пользователя.
Например, задан массив:
1 4 7 2 
5 9 2 3
8 4 2 4
5 2 6 7

1 5 8 5
4 9 4 2
7 2 2 6
2 3 4 7 */

/*  Списки обращаются к динамической памяти. Есть тэг и что-то второе они хранятся в разных частях памяти.

Как создается список. Далее по тексту была длинная часть семинара про списки.
List<int> arr = new List<int>();    // Так как используем динамический список, размер мы задать не может, поэтому пишем List интов. Такой строкой задаем список. Разница: прежде чем обращаться, 
//например к пятому элементу, то выскочит ошибка. Выделяем с помощью .Add
arr.Add(5);
arr.Insert(0, 3);
arr.Insert(1, 8);    // .Add добавляет элемент в конец списка. Добавляя элемент, мы увеличиваем размер списка.
arr.Add(10);
int[] array2 = new int[] { 1, 2, 3, 4, 5 };
arr.AddRange(array2);   // Добавляем в список несколько элементов через массив.

// bool flag = arr.Remove(5);
int flag = arr.RemoveAll(i => i == 5);  //Удаление нескольких одинаковых элементов с использованием предикатов

foreach (int item in arr)
    System.Console.Write($"{item} ");

if (flag > 0)
    System.Console.WriteLine($"\nУдалили {flag} элементов");
else
    System.Console.WriteLine($"\nНе удалили");
    //Почему любят листы: Могут менять размер, увеличиваться или уменьшаться. И для них прописано куча методов.

    // Когда лучше использовать List? С листа мы тратим больше памяти.
    */

/* Про сортировку

List<int> array = new List<int>();

for (int i = 0; i < 5; i++)
    array.Add(new Random().Next(10));
foreach (int item in array)
    System.Console.Write($"{item} ");

array.Sort((x,y) => y.CompareTo(x));    //обратная сортировка (по убыванию) через тернарный оператор
System.Console.WriteLine();
// array.Sort();   //  Сортировка по возрастанию
foreach (int item in array)
    System.Console.Write($"{item} ");
*/
/* Решение Ильи через листы, но оно, почему-то падает с ошибкой Unhandled exception. System.ArgumentOutOfRangeException: Index was out of range. Must be non-negative and less than the size of the collection. (Parameter 'index')
   at System.Collections.Generic.List`1.get_Item(Int32 index)
   at Program.<Main>$(String[] args) in /home/sysadmin/Dev/GeekBrains/C-sharp-lessons/Practice8_2D_arrays_continued/Task_55/Program.cs:line 76


List<List<int>> array = new List<List<int>>();

for (int i = 0; i < array.Count; i++)
{
    array.Add(new List<int>());
    for (int j = 0; j < array[i].Count; j++)
    {
        array[i].Add(new Random().Next(10));
        Console.Write($"{array[i][j]} ");
    }
    System.Console.WriteLine();
}

int LastRow = array.Count - 1;

// for (int i = 0; i < array[0].Count; i++)    // Размер нужно брать внутреннего массива, поэтому мы обращаемся к нулю, а потом к каунт.
//     (array[0][i], array[LastRow][i]) = (array[LastRow][i], array[0][i]);    // пишем не через запятую, а в разных скобках
// так как это списки, мы можем обратиться ко всему массиву в строке, вместо того, чтобы брать каждый элемент, мы сразу можем взять всю строку

(array[0], array[LastRow]) = (array[LastRow], array[0]);


System.Console.WriteLine();
for (int i = 0; i < array.Count; i++)
{
    for (int j = 0; j < array[i].Count; j++)
        System.Console.Write($"{array[i][j]} ");
    System.Console.WriteLine();
} */

int[,] array = new int[4, 4];
int[,] array2 = new int[4, 4];

if (array.GetLength(0) != array.GetLength(1))
{
    System.Console.WriteLine("Поменять строки и столбцы невозможно");
    return;
}

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(10);
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}

//  Первое решение
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = i + 1; j < array.GetLength(1); j++)
//     {
//         (array[i, j], array[j, i]) = (array[j, i], array[i, j]);
//     }
// }


//  Альтернативное решение
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array2[i, j] = array[j, i];
    }
}

System.Console.WriteLine();
for (int i = 0; i < array2.GetLength(0); i++)
{
    for (int j = 0; j < array2.GetLength(1); j++)
        Console.Write($"{array2[i, j]} ");
    Console.WriteLine();
}