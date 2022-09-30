//  Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int height = EnterInt("Введите число строк массива: ");
int width = EnterInt("Введите число столбцов массива: ");

int[,] numbers = new int[height, width];
Fill2DArray(numbers);
Print2DArray(numbers);

int[] arrayOfSumInRowsFrom2DArray = SumInRowsIn2DArray(numbers);

int indexMinSumRow = FindIndexMinRow(arrayOfSumInRowsFrom2DArray);
Console.WriteLine($"Наименьшая сумму элементов находится в {indexMinSumRow + 1} строке");


int EnterInt(string hint)
{
    Console.Write(hint);
    return int.Parse(Console.ReadLine()!);
}

void Fill2DArray(int[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            numbers[i, j] = new Random().Next(0, 10);
        }
    }
}

void Print2DArray(int[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            Console.Write($"{numbers[i, j],2} ");
        }
        Console.WriteLine();
    }
}

int[] SumInRowsIn2DArray(int[,] numbers)
{
    int[] SumArray = new int[numbers.GetLength(0)];

    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            sum += numbers[i, j];
        }
        SumArray[i] = sum;
    }

    return SumArray;
}

int FindIndexMinRow(int[] numbers)
{
    int indexMinRow = 0;
    int min = numbers[0];
    for (int i = 1; i < numbers.Length; i++)
    {
        if (numbers[i] < min)
        {
            min = numbers[i];
            indexMinRow = i;
        }
    }
    return indexMinRow;

}
