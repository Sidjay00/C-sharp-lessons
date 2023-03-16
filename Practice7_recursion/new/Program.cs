
using System.Diagnostics;

int n;
Console.Write($"Введите число: ");
int.TryParse(Console.ReadLine()!, out n);


Stopwatch loop = new Stopwatch();
Stopwatch recurs = new Stopwatch();

loop.Start();
ulong left = 0;
ulong right = 1;
for (int i = 0; i < n; i++)
{
    Console.Write($"{left} ");
    right = left + right;
    left = right - left;
}
loop.Stop();

Console.WriteLine();

recurs.Start();
Console.Write(FibbRec(n));
recurs.Stop(); 

string FibbRec(int N, ulong left = 0, ulong right = 1)
{
    if (N <= 1)
        return left.ToString();
    return $"{left.ToString()} {FibbRec(N - 1, right, left + right)}";
}


Console.WriteLine($"\n\nloop = {loop.ElapsedMilliseconds} recurs = {recurs.ElapsedMilliseconds}");