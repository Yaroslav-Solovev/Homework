// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] CreateArray()
{
    int[] array = new int[4];
    var random = new Random();

    for (int i = 0; i < 4; i++)
        array[i] = random.Next(100, 1001);
    return array;
}
// Функция поиска количества четных чисел
int SearchNumbers(int[] arr)
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            result += 1;
        }
    }
    return result;
}
// Функция вывода массива
void viewArr(int[] arr)
{
    string result = "[";
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length -1)
        {
            result += arr[i] + ", ";
        }
        if (i == arr.Length - 1)
        {
            result += arr [i] + "]";
        }
    }
    Console.WriteLine("\nЗаданный массив: " + result + ".");
}

int[] array = CreateArray();
viewArr(array);

int result = SearchNumbers(array);
Console.WriteLine("Количество четных чисел в заданном масиве: " + result + ".");
