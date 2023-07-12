// Напишите программу, которая принимает на вход трехзначное число и на выходе показывает вторую цифру числа.

// Например:
// 456 -> 5

int GetRandomNumber()
{
int number = new Random().Next(100, 1000);
Console.WriteLine(number);
return number;
}

int GetFirstDigit(int number1)
{
    return number1/10;
}

int GetSecondDigit(int number2)
{
    return number2%10;
}

int num = GetRandomNumber();
int firstDigit = GetFirstDigit(num);
int secondDigit = GetSecondDigit(firstDigit);
Console.WriteLine(secondDigit);

