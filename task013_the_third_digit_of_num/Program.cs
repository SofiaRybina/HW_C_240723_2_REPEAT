// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int Prompt(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine()!;
    int result = Convert.ToInt32(value);
    return result;
}

int number = Prompt("Enter the number: ");

int GetThirdRank(int number)
{
    while(number > 999 || number < -999)
    {
        number /= 10;
    }
    return Math.Abs(number % 10);
}

bool ValidateNumber(int number)
{
    if(number < 100 && number > -100)
    {
        Console.WriteLine("No third digit");
        return false;
    }
    return true;
}

if(ValidateNumber(number))
{
    Console.WriteLine(GetThirdRank(number));
}