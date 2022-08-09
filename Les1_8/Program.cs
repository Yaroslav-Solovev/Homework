//Console.WriteLine("Программа, которая на вход принимает одно число (N), а на выходе показывает все четные числа в промежутке от 1 до N");
//Console.WriteLine("Введите число ");
Console.WriteLine("Введите положительное число ");

string numberString = Console.ReadLine()!;

int number = int.Parse(numberString);

if (number <= 0)
{
    Console.WriteLine("Вы ввели отрицательное число (или ноль). Заново ведите число");
}
else
{
    for (int i = 2; i < number; i++)
    if (i%2 == 0)
    Console.WriteLine(i);  
}

