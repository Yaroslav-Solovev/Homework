// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""

// Функция вывода натуральных чисел от M до N.
void PrintNaturalNumbers(int numberM, int numberN)
{
    if (numberM == numberN) Console.Write($"{numberN}");
    else
    {
        Console.Write($"{numberM}, ");
        PrintNaturalNumbers(numberM + 1, numberN);
    }
}

Console.Write("Введдите значение M = ");
int numberM = Convert.ToInt16(Console.ReadLine());

Console.Write("Введите значение N = ");
int numberN = Convert.ToInt16(Console.ReadLine());

Console.Write("Натуральные числа в промежутке от M до N: ");
PrintNaturalNumbers(numberM, numberN);

