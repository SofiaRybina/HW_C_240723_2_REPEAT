// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int Prompt(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine()!;
    int result = Convert.ToInt32(value);
    return result;
}

int num = Prompt("Enter a three-digit number: ");

if (100 <= num && num <= 999 || -999 <= num && num <= -100)
{
    int lognum = num % 100;
    int secnum = lognum / 10;
    Console.WriteLine($"{num} -> {Math.Abs(secnum)}");
}
else
{
    Console.WriteLine("Wrong number! Input XXX. Example: 785");
}


