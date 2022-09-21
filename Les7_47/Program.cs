// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// Функция вывода массива
void PrintArray(double[,] array)
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Math.Round(array[i, j], 1, MidpointRounding.ToEven);
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

// Функция рандомного формирования массива вещественными числами
double[,] CreateArrayWithRandomNumbers(int m, int n)
{
    double[,] result = new double[m, n];

    var random = new Random();

    for (var i = 0; i < result.GetLength(0); i++)
    {
        for (var j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = random.Next(-10, 10) + random.NextDouble();
        }
    }
    return result;
}

Console.WriteLine("Введите число строк (m)");
if (!int.TryParse(Console.ReadLine()!, out var m))
{
    Console.WriteLine("Error");
}

Console.WriteLine("Введите число столбцов (n)");
if (!int.TryParse(Console.ReadLine()!, out var n))
{
    Console.WriteLine("Error");
}

PrintArray(CreateArrayWithRandomNumbers(m, n));


// 1. Считывание из консоли с обработкой трайпарсов стоит вынести в отдельный метод, иначе код повторяется
// 2. Тут аналогично. Не забывайте использовать авто форматирование на Shift + Alt + F для виндоус и Shift + Command + F для мака, потому что формат кода сейчас не единообразный
// 3. Всё то же, что и выше. Поиск ср. ариф. — в отдельный метод
