// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("\nВведите цифру ");

string? numberString = Console.ReadLine();

var number = int.Parse(numberString!);

if (number < 0)
    number *= (-1);

if (number > 9999 && number < 100000)
{
    var number1 = number;
    var number2 = 0;
    
    while(number > 0)
    {
        var x = number % 10;
        number2 = number2 * 10 + x;
        number = number / 10;
    }
    
    if(number1 == number2)
    Console.WriteLine("\nЧисло " + number1 + " является палидромом.");
    else
    Console.WriteLine("\nЧисло " + number1 + " не является палидромом.");
}
else
{
    Console.WriteLine("\nError: Вы ввели не пятизначное число. Пожалуйста заново введите число.");
}
