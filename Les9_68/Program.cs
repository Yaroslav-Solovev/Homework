// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9

// Метод вычисления функции Аккурмана

int Akkerman(int numberM, int numberN)
{
    if (numberM == 0)
    {
        return numberN + 1;
    }
    else
    {
        if ((numberM != 0) && (numberN == 0))
        {
            return Akkerman(numberM - 1, 1);
        }
        else
        {
            return Akkerman(numberM - 1, Akkerman(numberM, numberN - 1));
        }
    }
}

Console.Write("Введдите значение M = ");
int numberM = Convert.ToInt16(Console.ReadLine());

Console.Write("Введите значение N = ");
int numberN = Convert.ToInt16(Console.ReadLine());

Console.Write("Результат: " + Akkerman(numberM, numberN));

