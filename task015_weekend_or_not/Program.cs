// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

int Prompt(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine()!;
    int result = Convert.ToInt32(value);
    return result;
}

int num = Prompt("Enter the number of the day of the week: ");

bool ValidateWeekday(int number)
{
    if(number > 0 && number <= 7)
    {
        return true;
    }
    Console.WriteLine("It`s not a day of the week!");
    return false;
}

bool Weekend(int number)
{
    if(number > 5)
    {
        return true;
    }
    return false;
}

if(ValidateWeekday(num))
{
    if(Weekend(num))
    {
        Console.WriteLine($"{num} -> yes");
    }
    else
    {
        Console.WriteLine($"{num} -> no");
    }
}