// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Программа, которая принимает на вход число и выдает сумму цифр в числе.");
Console.WriteLine("\nВведите число: ");

int number = Convert.ToInt32(Console.ReadLine());

int SumNumber(int number)  // сумма цифр в числе
{
    int count = Convert.ToString(number).Length;
    int step = 0;
    int result = 0;
    for (int i = 0; i < count; i++)
    {
        step = number - number % 10;
        result += number - step;
        number /= 10;
    }
    return result;
}

int sumNumber = SumNumber(number);

Console.WriteLine("Сумма цифр веденного числа: " + sumNumber);
