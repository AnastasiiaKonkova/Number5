// Создание рандомного массива.
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
         array[i] = new Random().Next(minValue, maxValue + 1);
    return array;
}

// Вывод массива в терминал.
void ShowArray(int[] array)
{
    for( int i = 0; i < array.Length; i++)
    {
        Console.Write(array [i] + " ");
    }
    Console.WriteLine();
}

// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

/*
int CountArray(int[]array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if( array [i] % 2 == 0 )
            count++;
    return count;
}

Console.Write("Введите колличество элементов в массиве: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите минимальное трехзначное значение массива: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите максимальное трехзначное значение массива: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, min, max);
ShowArray(myArray);

int countNum = CountArray(myArray);
Console.WriteLine($"Четных чисел в массиве - {countNum} шт.");
*/

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

/* int sumArray(int[]array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
        if( i % 2 == 1 )
            sum+=array[i];
    return sum;
}

Console.Write("Введите колличество элементов в массиве: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите минимальное трехзначное значение массива: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите максимальное трехзначное значение массива: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, min, max);
ShowArray(myArray);

int sumNum = sumArray(myArray);
Console.WriteLine($"Сумма элементов на нечетных позициях: {sumNum}");
*/

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.