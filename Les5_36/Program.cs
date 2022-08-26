// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] CreateArray()
{
    int[] array = new int[4];
    var random = new Random();
    for (int i = 0; i < array.Length; i ++)
    {
        array[i] = random.Next(-10,10);
    }
    return array;
}

// Функция поиска суммы элементов, стоящих на нечётных позициях
int SumOddNumbers(int[] arr) 
{
    var result = 0;

    for (long i = 0; i < arr.Length; i++)
    {
        if (i % 2 == 1)
            result += arr[i];
    }
    return result;
}

// Функция вывода массива
void ViewArr(int[] arr)
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
ViewArr(array);

int result = SumOddNumbers(array);
Console.WriteLine("Cумма элементов заданного массива, стоящих на нечетных позициях: " + result + ".");