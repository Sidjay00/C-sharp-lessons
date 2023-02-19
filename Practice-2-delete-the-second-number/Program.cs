// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру числа.

int number;

number = new Random().Next(100, 1000);

int a = number % 10;
int b = number / 100;

// int number2 = b * 10 + a;

// Console.WriteLine($"{number} -> {number2}");

// решение через строку
string text = b.ToString() + a.ToString();

Console.WriteLine($"{number} -> {text}"); //этот пример я решил самостоятельно
