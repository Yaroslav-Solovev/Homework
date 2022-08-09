// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет
Console.WriteLine("Программа, которая принимает на вход число и выдаёт, является ли число чётным (делится ли оно на два без остатка)");
Console.WriteLine("Введите число ");

string? numberString = Console.ReadLine();

var number = int.Parse(numberString!);

if (number%2 == 0)
{
    Console.WriteLine("Число " + number + " является четным");
}
else
{
    Console.WriteLine("Число " + number + " является нечетным");
}
