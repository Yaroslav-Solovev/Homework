// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Программа, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.");

Console.WriteLine("Введите число ");

string? numberString = Console.ReadLine();

var number = int.Parse(numberString!);

if ((number > 100 && number < 1000) || (number > -1000 && number < -100))
{
    number /= 10;
    long result = number % 10;
    if (result < 0)
        result *= (-1);
    Console.WriteLine("Вторая цифра введенного трехзначного числа: " + result);
}
else
{
    Console.WriteLine("Error: Вы ввели не трехзначное число. Пожалуйста заново введите число.");
}
