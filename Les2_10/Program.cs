// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("\nПрограмма, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.");

Console.WriteLine("\nВведите число ");

string? numberString = Console.ReadLine();

var number = int.Parse(numberString!);

if (number < 0)
    number *= (-1);

if (number > 99 && number < 1000)
{
    number /= 10;
    long result = number % 10;
    Console.WriteLine("\nВторая цифра введенного трехзначного числа: " + result);
}
else
{
    Console.WriteLine("\nError: Вы ввели не трехзначное число. Пожалуйста заново введите число.");
}
