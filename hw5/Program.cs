// 7. Напишите программу, которая на вход принимает трехзначное число
// и на выходе показывает **последнюю** цифру этого числа.
Console.Clear();
Console.WriteLine("Введите трехзначное число");
int a = int.Parse(Console.ReadLine());
Console.WriteLine(a%10);