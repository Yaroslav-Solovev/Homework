// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// Функция вывода массива
int[,] CreateArrayWithRandomNumbers(int m, int n)
{
    int[,] result = new int[m, n];
    var random = new Random();
    for (var i = 0; i < result.GetLength(0); i++)
        for (var j = 0; j < result.GetLength(1); j++)
            result[i, j] = random.Next(1, 10);
    return result;
}

// Функция рандомного формирования массива из целых чисел
void PrintArray(int[,] array)
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++) Console.Write($"{array[i, j]} ");
        Console.WriteLine();
    }
}

Console.WriteLine("Введите число строк (m)");
if(!int.TryParse(Console.ReadLine()!, out var m)) {
    Console.WriteLine("Error");
}

Console.WriteLine("Введите число столбцов (n)");
if(!int.TryParse(Console.ReadLine()!, out var n)) {
    Console.WriteLine("Error");
}

int[,] array = CreateArrayWithRandomNumbers(m, n);

Console.Write($"\nЗаданный массив: \n");
PrintArray(array);

// Программа поиска элемента по заданным координатам
Console.WriteLine("Введите координаты (позицию) элемента в заданном массиве: ");
Console.WriteLine("Позиция x (строка):");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Позиция y (столбец):");
int y = Convert.ToInt32(Console.ReadLine());
if (x > m && y > n){
  Console.WriteLine("Такого элемента в массиве нет.");
}
else{
  object? z = array.GetValue(x,y);
  Console.WriteLine("Значение искомого элемента: " + z + ".");
}