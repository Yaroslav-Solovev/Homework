// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Программа, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее");
Console.WriteLine("Введите первое число ");

string? numberString1 = Console.ReadLine();

var number1 = int.Parse(numberString1!);

Console.WriteLine("Введите второе число ");

string? numberString2 = Console.ReadLine();

var number2 = int.Parse(numberString2!);

if (number1 == number2)
{
    Console.WriteLine("Введенные числа равны, введите оба числа заново");
}
else
{
        if (number1 > number2)
    {
    Console.WriteLine("Число " + number1 + " наибольшее из введенных");
    Console.WriteLine("Число " + number2 + " наименьшее из введенных");
    }
        else
    {
    Console.WriteLine("Число " + number2 + " наибольшее из введенных");
    Console.WriteLine("Число " + number1 + " наименьшее из введенных");
    }
}





