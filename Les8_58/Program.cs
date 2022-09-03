// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4  | 3 4
// 3 2  | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// Примечание: Умножение матриц — есть операция вычисления матрицы X, каждый элемент которой равен сумме произведений элементов в
// соответствующей строке первого множителя и столбце второго. 

Console.Clear();
Console.WriteLine($"\nВведите размеры матриц и диапазон случайных значений элементов матриц:");
int m = InputNumbers("Введите число строк 1-й матрицы: ");
int n = InputNumbers("Введите число столбцов 1-й матрицы (и строк 2-й): ");
int p = InputNumbers("Введите число столбцов 2-й матрицы: ");
int range = InputNumbers("Введите диапазон случайных значений элементов матриц: от 1 до ");

int[,] firstMartrix = new int[m, n];
CreateArray(firstMartrix);
Console.WriteLine($"\nПервая матрица: ");
WriteArray(firstMartrix);

int[,] secondMartrix = new int[n, p];
CreateArray(secondMartrix);
Console.WriteLine($"\nВторая матрица: ");
WriteArray(secondMartrix);

int[,] resultMatrix = new int[m, p];

MultiplyMatrix(firstMartrix, secondMartrix, resultMatrix);
Console.WriteLine($"\nРезультат произведения двух матриц: ");
WriteArray(resultMatrix);

// Функция вычисления произведения двух матриц

void MultiplyMatrix(int[,] firstMartrix, int[,] secondMartrix, int[,] resultMatrix)
{
    if (firstMartrix.GetLength(0) != secondMartrix.GetLength(1))
    {
        Console.WriteLine("Error: Умножение не возможно, поскольку количество столбцов первой матрицы не равно количеству строк второй матрицы.");
    }
    else
    {
        for (int i = 0; i < firstMartrix.GetLength(0); i++)
        {
            for (int j = 0; j < secondMartrix.GetLength(1); j++)
            {
                resultMatrix[i, j] = 0;
                for (int k = 0; k < firstMartrix.GetLength(1); k++)
                {
                    resultMatrix[i, j] += firstMartrix[i, k] * secondMartrix[k, j];
                }
            }
        }
    }
}

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

// Функция создания массива (матрицы) и заполнения случайными числами
void CreateArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1,range);
        }
    }
}

// Функция вывода массива (матрицы)
void WriteArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}