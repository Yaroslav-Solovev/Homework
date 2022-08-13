// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


Console.WriteLine("\nПрограмма, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.");

Console.WriteLine("\nВведите число ");

string? numberString = Console.ReadLine();

var number = int.Parse(numberString!);

if (number < 0)
    number *= (-1);

if (number > 99)
{
    Console.WriteLine("\nТретья цифра введенного числа: " + number.ToString()[2]);
}
else
{
    Console.WriteLine("\nТретьей цифры нет");
}
