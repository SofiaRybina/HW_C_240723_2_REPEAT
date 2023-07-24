// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Enter a three-digit number: ");
int num = int.Parse(Console.ReadLine()!);
int lognum = 0;
int secnum = 0;

if(100 <= num && num <= 999 || -999 <= num && num <= -100)
{
    lognum = num % 100;
    secnum = lognum / 10;
    Console.WriteLine($"{num} -> {Math.Abs(secnum)}");
}
else
{
    Console.WriteLine("Wrong number! Input XXX. Example: 785");
}