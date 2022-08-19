// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("\nЦикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.");

int Exponentiation(int numberA, int numberB) // возведение в степень
{
    int result = 1;
    for(int i = 1; i <= numberB; i++)
    {
        result *= numberA;
    }
    return result;
}

Console.Write("\nВведите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("\nВведите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberB < 0)
{
    Console.WriteLine("Error: Число В должно быть натуральным. Пожалуйста введите число B заново.");
}
else
{
    int exponentiation = Exponentiation(numberA, numberB);
    Console.WriteLine("Результат возведения числа A в натуральную степень B: " + exponentiation);
}
