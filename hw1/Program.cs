Console.Clear();
Console.WriteLine("Введите два числа");
Console.Write("Первое число a: ");
int a = int.Parse(Console.ReadLine());
//Console.WriteLine();
Console.Write("Второе число b: ");
int b = int.Parse(Console.ReadLine());
if (a > b) Console.WriteLine($"max = {a}");
else Console.WriteLine($"max = {b}");