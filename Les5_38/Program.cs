// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// Функция, которая задает массив везщественных чисел (рандомно).
double[] CreateArray(int length)
{
    var random = new Random();

    double[] array = new Double [length];

    for (int i = 0; i < array.Length; i++)
        array[i] = 5 - random.Next(-20,20) + random.NextDouble();
    return array;
}

// Функция поиска разницы между максимальным и минимальным элементами массива.
double difMaxMinNumbers(double[] arr) //difference - разница
{
    var min = arr[0];
    var max = arr[0];
       
    for (long i = 0; i < arr.Length; i++)
    {
        if (min > arr[i])
            min = arr[i];
        if (max < arr[i])
            max = arr[i];
    }
    return max - min;
}

// Функция вывода массива
void viewArr(double[] arr)
{
    string result = "[";
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length -1)
        {
            arr[i] = Math.Round(arr[i]); // данная строка добавлена для округления каждого эелемента масива до целого числа.
            result += arr[i] + "  ";
        }
        if (i == arr.Length - 1)
        {
            arr[i] = Math.Round(arr[i]); // данная строка добавлена для округления каждого эелемента масива до целого числа.
            result += arr [i] + "]";
        }
    }
    Console.WriteLine("\nЗаданный массив: " + result + ".");
}

Console.Write("Введите размер массива: ");
int length = int.Parse(Console.ReadLine()!);

double[] array = CreateArray(length);
viewArr(array);

double result = difMaxMinNumbers(array);
Console.WriteLine("Разница между максимальным и минимальным элементами заданного массива: " + result + ".");