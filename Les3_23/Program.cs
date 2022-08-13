//Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N");
Console.WriteLine("\nВведите число");

string numberString = Console.ReadLine()!;

int number = int.Parse(numberString);

int index = 1;

Console.WriteLine("\nТаблица кубов введенного числа выглядит следующим образом: ");

if (number <= 0)
    Console.WriteLine("\nError: Программа не выдаст таблицу кубов чисел от 1 до N. Введите положительное число от 1.");

while (index <= number) 
{
    Console.WriteLine(index*index*index);
    index += 1;
}