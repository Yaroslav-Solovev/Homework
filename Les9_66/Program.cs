// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов 
// в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Функция нахождения суммы натуральных элементов от M до N.

int RecursMetod(int numberM, int numberN, int sum)
{
    if (numberM <= numberN)
    {
        sum += numberM;
        numberM++;
        return RecursMetod(numberM, numberN, sum);
    }
    return sum;
}

Console.Write("Введдите значение M = ");
int numberM = Convert.ToInt16(Console.ReadLine());

Console.Write("Введите значение N = ");
int numberN = Convert.ToInt16(Console.ReadLine());

int sum = 0;

Console.Write("Cумма натуральных элементов в промежутке от " + numberM + " до " + numberN + ": " + $"{RecursMetod(numberM, numberN, sum)} ");
