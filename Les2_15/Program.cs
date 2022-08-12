// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Программа, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным");
//Console.WriteLine("Понедельник - 1, Вторник - 2, Среда - 3, Четверг - 4, Пятница - 5, Суббота - 6, Воскресенье - 7");

Console.WriteLine("Введите цифру ");

string? numberString = Console.ReadLine();

var number = int.Parse(numberString!);

if (number == 1)
Console.WriteLine("Понедельник");
if (number == 2)
Console.WriteLine("Вторник");
if (number == 3)
Console.WriteLine("Среда");
if (number == 4)
Console.WriteLine("Четверг");
if (number == 5)
Console.WriteLine("Пятница");
if (number == 6)
Console.WriteLine("Суббота");
if (number == 7)
Console.WriteLine("Воскресенье");

if (number == 6 || number == 7)
    Console.WriteLine(number + " - является выходным днем");
else
    if (number > 0 && number < 6) 
    Console.WriteLine(number + " - не является выходным днем");
    else
    Console.WriteLine("Число " + number + " не обозначает день недели");