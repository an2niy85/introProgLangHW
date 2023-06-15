// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
Console.Clear();
Console.WriteLine("Введите три числа");
Console.Write("Первое число a: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Второе число b: ");
int b = int.Parse(Console.ReadLine());
Console.Write("Третье число c: ");
int c = int.Parse(Console.ReadLine());
if (a > b && a > c) Console.WriteLine($"max = {a}");
else if (b > a && b > c) Console.WriteLine($"max = {b}");
else Console.WriteLine($"max = {c}");